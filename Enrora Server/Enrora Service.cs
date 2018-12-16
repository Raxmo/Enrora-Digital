using Enrora_Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Enrora_Server
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Enrora_Service" in both code and config file together.
	[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
	public class Enrora_Service : IEnrora_Service
	{
				

		public void TEST()
		{

		}
	}
}
