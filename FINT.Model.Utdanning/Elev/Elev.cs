// Built from tag v2.6.0-beta-1

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Elev
{
	public class Elev {
		public enum Relasjonsnavn
        {
			PERSON,
			ELEVFORHOLD
        }
        
	
		public Identifikator Brukernavn { get; set; }
		public Identifikator Elevnummer { get; set; }
		public Kontaktinformasjon Kontaktinformasjon { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
