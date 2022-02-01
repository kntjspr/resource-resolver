using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResourceResolver
{
	public interface ICustomService
	{
		#region Methods
		void Register();
		void DeRegister();
		#endregion
	}
}
