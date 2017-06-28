using System;


using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Ressurser
{
	public class Elevressurs {
		public enum Relasjonsnavn
        {
			FORESATT,
			PERSON,
			ELEVFORHOLD
        }
        
	
		public Kontaktinformasjon kontaktinformasjon { get; set; }
		public Identifikator elevnummer { get; set; }
		public Identifikator brukernavn { get; set; }
		public Identifikator systemId { get; set; }
		
	}
}
