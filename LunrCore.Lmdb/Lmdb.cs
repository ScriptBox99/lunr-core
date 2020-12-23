﻿using Lunr;

namespace LunrCore.Lmdb
{
    public static class Lmdb
    {
        public static DelegatedIndex Open(string path, Pipeline pipeline)
        {
            var index = new LmdbIndex(path);

            return new DelegatedIndex(
                index.GetInvertedIndexByKey, 
                index.GetFieldVectorKeys, 
                index.GetFieldVectorByKey,
                index.IntersectTokenSets, 
                index.GetFields, 
                pipeline);
        }
    }
}