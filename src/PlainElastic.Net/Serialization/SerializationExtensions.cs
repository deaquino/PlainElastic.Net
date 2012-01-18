﻿namespace PlainElastic.Net.Serialization
{
    public static class SerializationExtensions
    {
        public static string ToJson(this IJsonSerializer serializer, object value)
        {
            return serializer.Serialize(value);
        }

        public static T Deserialize<T>(this IJsonSerializer serializer, string value)
        {
            if (value.IsNullOrEmpty())
                return default(T);

            return (T) serializer.Deserialize(value, typeof (T));
        }


        public static GetResult<T> ToGetResult<T>(this IJsonSerializer serializer, OperationResult operationResult)
        {           
            return serializer.Deserialize<GetResult<T>>(operationResult);
        }

        public static IndexResult ToIndexResult(this IJsonSerializer serializer, OperationResult operationResult)
        {
            return serializer.Deserialize<IndexResult>(operationResult);
        }

        public static DeleteResult ToDeleteResult(this IJsonSerializer serializer, OperationResult operationResult)
        {
            return serializer.Deserialize<DeleteResult>(operationResult);
        }

        public static SearchResult<T> ToSearchResult<T>(this IJsonSerializer serializer, OperationResult operationResult)
        {
            return serializer.Deserialize<SearchResult<T>>(operationResult);
        } 
    }

}
