import numbers



def find_null_columns(df):
    
    null_cols = []
    
    return null_cols



def check_type_numeric(col, df):
    if isinstance(df[col].idx[0], numbers.Number):
        return True
    else:
        return False
        


def find_null_indexes(series):
    
    idx_list = []
    
    return idx_list


def check_categories_by_threshold(df, col, threshold):
    
    if df[col].unique() <= threshold:
        return True
    else:
        return False