using System;


using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Gruppe
{
	public class Basisgruppe : Basisklasser.Gruppe
    {
		public enum Relasjonsnavn
        {
			TRINN,
			KONTAKTLARERGRUPPE
        }
        
	
		public Kontaktinformasjon kontaktinformasjon { get; set; }
		
	}
}
