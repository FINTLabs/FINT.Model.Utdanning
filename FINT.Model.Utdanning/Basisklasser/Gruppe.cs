// Built from tag v3.2.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Utdanning.Basisklasser
{
	public abstract class Gruppe {
	
		public string Beskrivelse { get; set; }
		public string Navn { get; set; }
		public List<Periode> Periode { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
