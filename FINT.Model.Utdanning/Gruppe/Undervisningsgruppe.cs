using System;


using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Gruppe
{
	public class Undervisningsgruppe : Kodegruppe {
		public enum Relasjonsnavn
        {
			FAG
        }
        
	
		public Kontaktinformasjon kontaktinformasjon { get; set; }
		
	}
}
