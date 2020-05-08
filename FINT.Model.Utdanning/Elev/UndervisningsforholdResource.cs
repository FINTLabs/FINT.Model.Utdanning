// Built from tag v3.5.0

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Elev
{

    public class UndervisningsforholdResource : Utdanningsforhold 
    {

    
        public UndervisningsforholdResource()
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
     
            

        public void AddArbeidsforhold(Link link)
        {
            AddLink("arbeidsforhold", link);
        }

        public void AddBasisgruppe(Link link)
        {
            AddLink("basisgruppe", link);
        }

        public void AddKontaktlarergruppe(Link link)
        {
            AddLink("kontaktlarergruppe", link);
        }

        public void AddUndervisningsgruppe(Link link)
        {
            AddLink("undervisningsgruppe", link);
        }

        public void AddEksamensgruppe(Link link)
        {
            AddLink("eksamensgruppe", link);
        }

        public void AddTime(Link link)
        {
            AddLink("time", link);
        }

        public void AddSkole(Link link)
        {
            AddLink("skole", link);
        }

        public void AddSkoleressurs(Link link)
        {
            AddLink("skoleressurs", link);
        }

        public void AddMedlemskap(Link link)
        {
            AddLink("medlemskap", link);
        }
    }
}
