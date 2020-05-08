// Built from tag v3.5.0

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Elev
{

    public class SkoleressursResource 
    {

    
        public Identifikator Feidenavn { get; set; }
        public Identifikator SystemId { get; set; }
        
        public SkoleressursResource()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        [JsonProperty(PropertyName = "_links")]
        public Dictionary<string, List<Link>> Links { get; private set; }

        protected void AddLink(string key, Link link)
        {
            if (!Links.ContainsKey(key))
            {
                Links.Add(key, new List<Link>());
            }
            Links[key].Add(link);
        }
     
            

        public void AddPersonalressurs(Link link)
        {
            AddLink("personalressurs", link);
        }

        public void AddUndervisningsforhold(Link link)
        {
            AddLink("undervisningsforhold", link);
        }

        public void AddSkole(Link link)
        {
            AddLink("skole", link);
        }
    }
}
