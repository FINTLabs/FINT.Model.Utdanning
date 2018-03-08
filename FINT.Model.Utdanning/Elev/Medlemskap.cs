// Built from tag v0.99.9

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Elev
{
	public class Medlemskap {
		public enum Relasjonsnavn
        {
			MEDLEM,
			FORTLOPENDEKARATER,
			GRUPPE,
			ENDELIGKARAKTER,
			FRAVAR
        }
        
	
		public Identifikator SystemId { get; set; }
		
	}
}
