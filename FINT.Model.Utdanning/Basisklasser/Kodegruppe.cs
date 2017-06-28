using System;


using FINT.Model.Utdanning.Kompleksedatatyper;
using FINT.Model.Utdanning.Basisklasser;

namespace FINT.Model.Utdanning.Basisklasser
{
	public abstract class Kodegruppe : Gruppe {
		public enum Relasjonsnavn
        {
			KODE
        }
        
	
		public Periodegruppe gyldighetsperiode { get; set; }
		
	}
}
