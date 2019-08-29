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

		private IMatcher m_Matcher;

		public MatchFinderFeature()
		{
			MatchType = MatchType.Groups;
		}

		public void SetMatcherAndFindMatch(User i_LoggedInUser)
		{
			setMatcherByType();
			m_Matcher.FindMatch(i_LoggedInUser);
		}

		private void setMatcherByType()
		{
			m_Matcher = FactoryMatcher.getMatcher(MatchType);
		}

		public string getPic()
		{
			return m_Matcher.Picture;
		}

		public string getName()
		{
			return m_Matcher.Name;
		}

		public string getMail()
		{
			return m_Matcher.Mail;
		}
	}
}
