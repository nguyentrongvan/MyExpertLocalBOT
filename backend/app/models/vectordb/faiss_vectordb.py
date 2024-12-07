import faiss
import numpy as np

class FAISSVectorDB:
    def __init__(self, d=2048, index_file=None, vector_file=None, vectors_list=[]):
        if not index_file:
            self.init_for_nonexisted_index(d=d, vectors_list=vectors_list)
        else:
            self.init_for_existed_index(index_file=index_file, vector_file=vector_file)


    def init_for_nonexisted_index(self, d, vectors_list):
        self.index = faiss.IndexFlatL2(d)
        vectordb = np.array(vectors_list).astype('float32')
        self.index.add(vectordb)


    def init_for_existed_index(self, index_file, vector_file):
        self.index = faiss.read_index(index_file)
        vectordb = self.load_vectordb(vector_file)
        self.index.add(vectordb)


    def load_vectordb(self, vector_file):
        loaded_vectors = np.load(vector_file)
        return loaded_vectors