// Built from tag v2.4.0-rc-4

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Utdanning.Utdanningsprogram
{
	public class Skole : Enhet {
		public enum Relasjonsnavn
        {
			ORGANISASJON,
			FAG,
			SKOLEEIERTYPE,
			VIGOREFERANSE,
			UTDANNINGSPROGRAM,
			UTDANNINGSFORHOLD
        }
        
	
		public string Domenenavn { get; set; }
		public string JuridiskNavn { get; set; }
		public string Navn { get; set; }
		public Identifikator Skolenummer { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
