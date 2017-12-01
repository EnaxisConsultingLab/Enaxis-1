using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnaxisDevonApp.ViewModels.Data
{
    
    public class Point
    {
        [JsonProperty("Value")]
        public string Value { get; set; }
        [JsonProperty("Timestamp")]
        public string Timestamp { get; set; }
    }

    public class Element
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }
        [JsonProperty("DefaultUnitsName")]
        public string DefaultUnitsName { get; set; }
        [JsonProperty("CategoryName")]
        public string CategoryName { get; set; }
    }


    public class RootObject
    {
        public List<Element> Item { get; set; }
    }
}
