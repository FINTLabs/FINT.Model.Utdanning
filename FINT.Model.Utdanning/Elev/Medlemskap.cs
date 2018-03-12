// Built from tag v2.6.0-beta-3

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
