using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
	public class FactoryMatcher
	{
		public static IMatcher getMatcher(MatchType i_MatchType)
		{
			IMatcher matcher = null;
			if (i_MatchType == MatchType.Group)
			{
				matcher = new GroupMatcher();
			}
			else if (i_MatchType == MatchType.Friend)
			{
				matcher = new FriendMatcher();
			}
			else if (i_MatchType == MatchType.Photo)
			{
				matcher = new PhotoMatcher();
			}

			return matcher;
		}
	}
}
