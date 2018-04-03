// Built from tag v2.6.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Kompleksedatatyper
{
	public class Fravar {
		public enum Relasjonsnavn
        {
			FRAVARSTYPE
        }
        
	
		public bool Dokumentert { get; set; }
		public bool ForesPaVitnemal { get; set; }
		public Periode GjelderPeriode { get; set; }
		public string Kommentar { get; set; }
		
	}
}
