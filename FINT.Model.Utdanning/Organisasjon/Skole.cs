using System;


using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Utdanning.Organisasjon
{
	public class Skole : Enhet {
		public enum Relasjonsnavn
        {
			SKOLEEIERTYPE,
			ORGANISASJON,
			UTDANNINGSPROGRAM
        }
        
	
		public Identifikator skolenummer { get; set; }
		public string domenenavn { get; set; }
		public string juridiskNavn { get; set; }
		public string navn { get; set; }
		public Identifikator systemId { get; set; }
		
	}
}
