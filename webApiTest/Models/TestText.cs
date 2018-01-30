using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace webApiTest.Models
{
    public class TestText
    {
[JsonProperty("data")]        
        public String data { get; set;  }

    }
}