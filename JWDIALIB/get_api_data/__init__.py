"""
        Generic function logic for accessing APIs
"""
    
import requests as req
import bs4
import pandas as pd



def get_dataframe_from_url(url: str, data: str):
    """Gets dataframe from the target source.

    Args:
        url (str): API URL
    """
    
    if len(data) > 0:
        response = req.get(url, data=data)
    else:
        response = req.get(url)
    
    # will need to run this and see what changes need to be made to the response 
    #  to generalise
    df = pd.DataFrame(response.content)
    
    return df


    
