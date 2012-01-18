﻿using System.Collections.Generic;
using System.Linq;

namespace PlainElastic.Net.Serialization
{
    public class SearchResult<T> : BaseResult
    {
        public int took;
        public bool timed_out;
        public ShardsResult _shards;
        public Hits hits;

        public IEnumerable<T> Documents
        {
            get { return hits.hits.Select(hit => hit._source); }
        }


        public class ShardsResult
        {
            public int total;
            public int successful;
            public int failed;
        }

        public class Hits
        {
            public int total;
            public double ?max_score;
            public Hit[] hits;
        }

        public class Hit
        {
            public string _index;
            public string _type;
            public string _id;
            public double _score;
            public T _source;
        }
    }
}
