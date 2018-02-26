// Built from tag v0.99.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Elev
{
	public class Medlemskap {
		public enum Relasjonsnavn
        {
			FRAVAR,
			FORTLOPENDEVURDERING,
			ENDELIGVURDERING,
			DELTAKER,
			GRUPPE
        }
        
	
		public Identifikator SystemId { get; set; }
		
	}
}
