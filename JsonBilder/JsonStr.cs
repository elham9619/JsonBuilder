using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonBuilder
{
    class JsonString
    {
        
        string jsonstr;

        public JsonString SetInt(string key, int value)
        {
            jsonstr += string.Format(", \"{0}\"  : {1}", key, value);
            return this;
        }

        public JsonString  SetString(string key, string value)
        {
            jsonstr += string.Format(", \"{0}\" : \"{1}\"", key , value);
            return this;
        }
        public JsonString SetDouble(string key, double value)
        {
            jsonstr += string.Format(",\"{0}\"  : {1}", key , value);
            return this;
        }
        public JsonString SetBolean(string key, bool value)
        {
            jsonstr += string.Format(",\"{0}\"  : {1}", key, value ? "true" : "false");
            return this;
        }

        public string Build()
        {
            return ("{"+ jsonstr.Substring(1) +"}");
        }

    }
}
