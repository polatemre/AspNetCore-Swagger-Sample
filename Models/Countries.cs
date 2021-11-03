using System;
using System.Collections.Generic;

namespace AspNetCore.Swagger.Sample
{
    public class Countries
    {
        public string name { get; set; }
        public string capital { get; set; }
        public string region { get; set; }
        public Flags flags { get; set; }
    }

}