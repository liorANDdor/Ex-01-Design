using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
	public class MatchFinderFeature
	{
		public MatchType MatchType { get; set; }

		public IMatcher Matcher { get; set; }

		public MatchFinderFeature()
		{
			MatchType = MatchType.Groups;
		}

		public void SetMatcherAndFindMatch(User i_LoggedInUser)
		{
			setMatcherByType();
			Matcher.FindMatch(i_LoggedInUser);
		}

		private void setMatcherByType()
		{
			Matcher = FactoryMatcher.getMatcher(MatchType);
		}
	}
}
