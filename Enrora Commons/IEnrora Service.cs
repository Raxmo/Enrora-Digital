using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Enrora_Commons
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEnrora_Service" in both code and config file together.
	[ServiceContract]
	public interface IEnrora_Service
	{
		[OperationContract]
		void TEST();
	}
}
