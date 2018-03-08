// Built from tag v0.99.9

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
