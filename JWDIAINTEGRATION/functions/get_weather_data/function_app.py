import logging
import azure.functions as func
import requests
import requests as r
import pandas as pd
import datetime as dt
from sqlalchemy import DateTime
import json



def get_yesterday():
    """
        Get yesterdays date as a string
    """
    months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
    
    theday = dt.date.today() - dt.timedelta(days=1)
    day =  theday.day
    month = months[theday.month-1]

    year = theday.year
    if day < 10:
        day = f"0{str(day)}"
        
    return  f"{year}-{month}-{day}"

def connection_string():
    """this needs to be moved out

    Returns:
        string
    """
    return "mssql+pyodbc://@joshwork\\MSSQLSERVER02/db1?driver=ODBC+Driver+17+for+SQL+Server&Trusted_Connection=yes&TrustServerCertificate=yes"

def get_yesterday_url():
    date_ref = get_yesterday()
    return f"https://api.weatherapi.com/v1/history.json?q=Perth&dt={date_ref}&end_dt={date_ref}&hour=8&key=96792ecea70641218aa32831252402"


def clean_string_times(timestring):
    """
        Returns hundred hour int of a time string

    Args:
        timestring (string): string in formate '00:00 AM/PM'

    Returns:
        int: 100 hour int of time string, if incorrect format will return 0, needs logging.
    """
    try:
        time = timestring.split(" ")[0]
    except:
        return 0
    if timestring.split(" ")[1][0].lower() == "p": # case sensitivity removed
        return (  ((int(time.split(":")[0])+ 12)*100)   + int(time.split(":")[1])) 
    else:
        return (  ((int(time.split(":")[0]))*100)   + int(time.split(":")[1])) 


def set_columns(df):
    df.columns = [
        'date',
        'date_epoch',
        'hour',
        'maxtemp_c',
        'maxtemp_f',
        'mintemp_c',
        'mintemp_f',
        'avgtemp_c',
        'avgtemp_f',
        'maxwind_mph',
        'maxwind_kph',
        'totalprecip_mm',
        'totalprecip_in',
        'totalsnow_cm',
        'avgvis_km',
        'avgvis_miles',
        'avghumidity',
        'daily_will_it_rain',
        'daily_chance_of_rain',
        'daily_will_it_snow',
        'daily_chance_of_snow',
        'condition_text',
        'condition_icon',
        'condition_code',
        'uv',
        'sunrise',
        'sunset',
        'moonrise',
        'moonset',
        'moon_phase',
        'moon_illumination',
        ]
    
    return df

app = func.FunctionApp()

@app.timer_trigger(schedule="0 * * * * *", arg_name="myTimer", run_on_startup=False,
              use_monitor=False) 
def timer_trigger(myTimer: func.TimerRequest) -> None:
    if myTimer.past_due:
        logging.info('The timer is past due!')

    logging.info('Python timer trigger function executed.')

@app.timer_trigger(schedule="", arg_name="myTimer", run_on_startup=False,
              use_monitor=False) 
def get_weather_data(myTimer: func.TimerRequest) -> None:
    response = r.get(url=get_yesterday_url())
    data_dict = json.loads(response.content)
    del response

    data = pd.json_normalize(data_dict['forecast']['forecastday'])
    
    data = set_columns(data)
    
    data.iloc[0, 2] = 8
    
    data.iloc[0,0] = dt.datetime.today() - dt.timedelta(days=1)

    x = 25
    for val in data.iloc[0,25:-2]:
        data.iloc[0, x] =   clean_string_times(val)
        x +=1
    
    data.to_sql( 
        name="WeatherDataModels",
        con=connection_string(), 
        if_exists="append",
        index=False,
        dtype={'date' : DateTime()}
        )
        
        
    if myTimer.past_due:
        logging.info('The timer is past due!')

    logging.info('Python timer trigger function executed.')