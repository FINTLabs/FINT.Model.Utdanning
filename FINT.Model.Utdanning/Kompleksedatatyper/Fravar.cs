using System;


using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Kompleksedatatyper
{
	public class Fravar {
	
		public bool erFravaretGyldig { get; set; }
		public string kommentar { get; set; }
		public Periode gjelderPeriode { get; set; }
		
	}
}
