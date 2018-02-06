// Built from tag v2.4.0

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
