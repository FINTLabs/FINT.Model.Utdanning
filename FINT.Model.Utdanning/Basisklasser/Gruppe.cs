using System;


using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Basisklasser
{
	public abstract class Gruppe {
		public enum Relasjonsnavn
        {
			MEDLEMSKAP
        }
        
	
		public string beskrivelse { get; set; }
		public Identifikator systemId { get; set; }
		public string navn { get; set; }
		
	}
}
