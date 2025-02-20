"""Specific functions for target data
"""
import api


def get_cpi_data():
    """Returns CPI Data as a dataframe

    Returns:
        Dataframe: Dataframe of the ABS CPI data
    """
    data = api.get_dataframe_from_url("")
    return data
    
