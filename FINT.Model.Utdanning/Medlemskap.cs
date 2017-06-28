using System;


using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning
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
        
	
		public Identifikator systemId { get; set; }
		
	}
}
