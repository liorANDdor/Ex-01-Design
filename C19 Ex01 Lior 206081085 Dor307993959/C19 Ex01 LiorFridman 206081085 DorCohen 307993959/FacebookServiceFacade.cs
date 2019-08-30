using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
	public class FacebookServiceFacade
	{
		public LoginResult Login()
		{
			LoginResult result = null;
			AppSettings instance = AppSettings.GetInstance();
			if (!string.IsNullOrEmpty(instance.AccessToken))
			{
				try
				{
					result = FacebookService.Connect(instance.AccessToken);
				}
				catch
				{
					result = FacebookService.Login("1450160541956417", "public_profile", "email", "publish_to_groups", "user_birthday", "user_age_range", "user_gender", "user_link", "user_tagged_places", "user_videos", "publish_to_groups", "groups_access_member_info", "user_friends", "user_events", "user_likes", "user_location", "user_photos", "user_posts", "user_hometown");
				}
			}
			else
			{
				result = FacebookService.Login("1450160541956417", "public_profile", "email", "publish_to_groups", "user_birthday", "user_age_range", "user_gender", "user_link", "user_tagged_places", "user_videos", "publish_to_groups", "groups_access_member_info", "user_friends", "user_events", "user_likes", "user_location", "user_photos", "user_posts", "user_hometown");
			}

			return result;
		}

		public void Logout()
		{
			FacebookService.Logout(null);
		}
	}
}
