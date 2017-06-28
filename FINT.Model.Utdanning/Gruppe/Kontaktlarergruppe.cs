using System;


using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Gruppe
{
	public class Kontaktlarergruppe : Basisklasser.Gruppe {
		public enum Relasjonsnavn
        {
			BASISGRUPPE
        }
        
	
		public Kontaktinformasjon kontaktinformasjon { get; set; }
		
	}
}
