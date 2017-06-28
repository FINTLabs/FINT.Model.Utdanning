using System;


using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Basisklasser
{
	public abstract class Utdanningsforhold {
		public enum Relasjonsnavn
        {
			MEDLEMSKAP
        }
        
	
		public Identifikator systemId { get; set; }
		public string kommentar { get; set; }
		
	}
}
