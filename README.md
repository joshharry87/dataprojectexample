# dataintegrationexample
Example data integration


I have created this repository to provide an example of data integration.


Goal.


Ingest data from some arbitrary website and an API on a schedule, land it to blob or whatever.
Grab that data in a function or some other thing like data factory and transform it with a function or stored procedure then land it into an SQL database on an Azure server instance.
Build all the YAML to deploy this magical pipeline of wonder. 
Create all the relevant documentation detailing the logic for the transformations etc.
Upload to Github
Get employment
Win

```
1. Finding the 'perfect' data - lets go with Weather data from the beaureau of meteorology
 http://www.bom.gov.au/catalogue/data-feeds.shtml
Appears to be a bunch of XML files from FTP

API I found ABS has swagger making it easier to build the html needed:
https://api.gov.au/assets/APIs/abs/DataAPI.openapi.html#/Get%20Data/GetData

I dont particularly care about the data at this point its about the INTEGRATION. Generally speaking you will need to consult with the data provider for documentation and allowances for use of the
supplied data. Dealing with things such as frequency of use, limits on access etc. If it is a paid provider or publicly available changes what we may or may not do in this scenario.
"https://data.api.abs.gov.au/rest/data/ABS%2CCPI%2C1.1.0/1.115486.10..Q?format=csvfile&detail=dataonly&dimensionAtObservation=AllDimensions"

Making the project more amazing will take something like Webscraping, finding a website to do that legally from!




