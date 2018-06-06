// Built from tag v3.0.0-rc-1

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Vurdering
{
	public class Vurdering {
		public enum Relasjonsnavn
        {
			KARAKTER
        }
        
	
		public string Kommentar { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
