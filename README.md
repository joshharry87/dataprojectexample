# dataintegrationexample
## Example data integration


I have created this repository to provide an example of data integration.


Goal.


Ingest data from some arbitrary website and an API on a schedule, land it to blob or whatever.
Grab that data in a function or some other thing like data factory and transform it with a function or stored procedure then land it into an SQL database on an Azure server instance.
Build all the YAML to deploy this pipeline. 
Create all the relevant documentation detailing the logic for the transformations etc.
Upload to Github


```
1. Finding the 'perfect' data - lets go with Weather data from the beaureau of meteorology
 http://www.bom.gov.au/catalogue/data-feeds.shtml
Appears to be a bunch of XML files from FTP

API I found ABS has swagger making it easier to build the html needed:
https://api.gov.au/assets/APIs/abs/DataAPI.openapi.html#/Get%20Data/GetData


Include some GIS data within the integration. Source 3
https://catalogue.data.wa.gov.au/dataset/mining-tenements-dmirs-003 tenement data - email sent to department for a login to access geojson
will hunt around for other datasets, ideally i would like to work with GIS as it makes the project more interesting....
https://neo.gsfc.nasa.gov/ nasa earth observations

https://hub.arcgis.com/search - big repository of datasets


first one that returned a geojson with some geo data in it  : 
pending airports
https://hub.arcgis.com/datasets/093e181579e841f39f88df8068dae331_0/explore?location=0.001937%2C-32.318315%2C0.14
https://hub.arcgis.com/api/download/v1/items/093e181579e841f39f88df8068dae331/geojson?redirect=false&layers=0&spatialRefId=4326


I dont particularly care about the data at this point its about the INTEGRATION. Generally speaking you will need to consult with the data provider for documentation and allowances for use of the
supplied data. Dealing with things such as frequency of use, limits on access etc. If it is a paid provider or publicly available changes what we may or may not do in this scenario.
"https://data.api.abs.gov.au/rest/data/ABS%2CCPI%2C1.1.0/1.115486.10..Q?format=csvfile&detail=dataonly&dimensionAtObservation=AllDimensions"

Making the project more amazing will take something like Webscraping, and finding a website to do that legally from! Then we can build the code to scrape that and shift it into a library for potential extra use within the business, namely for analysts to apply to others. A common practice here is to abstract the logic from python libraries into very simple to use functions to allow people to directly
access data sources outside of the integration if analysis is wanted/warranted. 

```




