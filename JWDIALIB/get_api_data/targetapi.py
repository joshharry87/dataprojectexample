"""Specific functions for target data
"""
import get_api_data


def get_cpi_data():
    """Returns CPI Data as a dataframe

    Returns:
        Dataframe: Dataframe of the ABS CPI data
    """
    data = get_api_data.get_dataframe_from_url("")
    return data
    
