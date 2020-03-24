
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SF365.Plugins
{
    [DataContract]
    internal class ExchangeRateResult
    {
        [DataMember]
        public string @base { get; set; }
        [DataMember]
        public string date { get; set; }

        [DataMember]
        public JsonDictionary<double> rates { get; set; }

    }
    [Serializable]
    public class JsonDictionary<V> : ISerializable
        {
        Dictionary<string, V> dict = new Dictionary<string, V>();


        public JsonDictionary()
        {

        }
        protected JsonDictionary(SerializationInfo info, StreamingContext context)
        {
            dict = new Dictionary<string, V>();
            foreach(var entry in info)
            {
                dict.Add(entry.Name, (V)Convert.ChangeType(entry.Value, typeof(V)));
            }
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            foreach(var key in dict.Keys)
            {
                info.AddValue(key, dict[key]);
            }
        }
        public void Add(string key, V value)
        {
            dict.Add(key, value);
        }

        public string[] Keys
        {
            get { return dict.Keys.ToArray(); }
        }

        public V this[string index]
        {
            set { dict[index] = value; }
            get { return dict[index]; }
        }
    }
}