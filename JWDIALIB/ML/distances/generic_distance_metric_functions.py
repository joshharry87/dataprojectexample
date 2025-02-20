import numpy as np



def find_nearest(dataset: np.ndarray) -> np.ndarray:
    '''
    Finds nearest euclidean partner withing a dataset of n rows.
    
    ----------------
    
    dataset : np.ndarray
    
    ---------------
    
    return : np.ndarray
    
    '''
    indexes = []
    
    for x in range(0, len(dataset)-1):
        index = 0
        distance = 999999999.99999
        for y in range(0, len(dataset)-1):
            if y==0:
                distance = np.linalg.norm(dataset[x, ] - dataset[y, ] )    
            if x!=y and np.linalg.norm(dataset[x, ] - dataset[y, ]) < distance:
                distance =  np.linalg.norm(dataset[x, ] - dataset[y, ] )
                index = y
        indexes.append([index, distance])

    return np.array(indexes)



def compute__distances_return_array(dataset: np.ndarray, metric="euclidean"):
    '''
    Returns a matrix of distances for row by row in a given dataset.
    Return rows = (n rows) columns = ( n rows)
    
    -------------------------------
    dataset : nd.array
        array of continuous data for measuring distances 
    metric : str

    --------------------------
    
    return : 
        array nXn of distances row index = from row. column index = to row

    '''
    indexes = []
    
    
    if metric == "euclidean":
        for x in range(0, len(dataset)-1):
            index_maps = np.zeros( len(dataset))
            for y in range(0, len(dataset)-1):      
                if x!=y:
                    index_maps[y] =  np.linalg.norm(dataset[x, ] - dataset[y, ] )
            
            indexes.append(index_maps)
    else:
            for x in range(0, len(dataset)-1):
                index_maps = np.zeros( len(dataset))
                for y in range(0, len(dataset)-1):
                    index_maps[y] =  np.dot(dataset[x, ], dataset[y, ])/ (np.inner(dataset[x, ], dataset[x, ] ) * np.inner(dataset[y, ],  dataset[y, ] ) )   
                    
            indexes.append(index_maps)

    return np.array(indexes)
