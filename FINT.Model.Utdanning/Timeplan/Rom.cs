// Built from tag v2.6.0-beta-1

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Timeplan
{
	public class Rom {
		public enum Relasjonsnavn
        {
			TIME
        }
        
	
		public string Navn { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
