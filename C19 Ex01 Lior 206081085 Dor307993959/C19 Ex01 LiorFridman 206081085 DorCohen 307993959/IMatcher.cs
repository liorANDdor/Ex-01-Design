using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
	public interface IMatcher
	{
		string Name { get; set; }

		string Picture { get; set; }

		string Mail { get; set; }

		void FindMatch(User i_LoggedInUser);
	}
}
