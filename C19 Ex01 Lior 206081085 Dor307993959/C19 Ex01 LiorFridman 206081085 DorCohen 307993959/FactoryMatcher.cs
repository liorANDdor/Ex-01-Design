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
			if (i_MatchType == MatchType.Groups)
			{
				matcher = new MatcherByGroups();
			}
			else if (i_MatchType == MatchType.Friends)
			{
				matcher = new MatcherByFriends();
			}
			else if (i_MatchType == MatchType.Photos)
			{
				matcher = new MatcherByPhotos();
			}

			return matcher;
		}
	}
}
