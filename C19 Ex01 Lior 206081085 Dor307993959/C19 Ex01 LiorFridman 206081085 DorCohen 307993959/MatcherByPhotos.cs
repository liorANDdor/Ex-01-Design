using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
	public class MatcherByPhotos : IMatcher
	{
		public string Mail { get; set; }

		public string Name { get; set; }

		public string Picture { get; set; }

		public void FindMatch(User i_LoggedInUser)
		{
			FacebookObjectCollection<User> friendsOfUser = i_LoggedInUser.Friends;
			Dictionary<User, int> likesOfFriendsList = new Dictionary<User, int>();
			foreach (Album album in i_LoggedInUser.Albums)
			{
				foreach (Photo photo in album.Photos)
				{
					foreach (User user in photo.LikedBy)
					{
						if (likesOfFriendsList.ContainsKey(user))
						{
							likesOfFriendsList[user]++;
						}
						else
						{
							likesOfFriendsList.Add(user, 1);
						}
					}
				}
			}

			KeyValuePair<User, int> theMostLikerFriend = new KeyValuePair<User, int>(null, 0);
			foreach (KeyValuePair<User, int> likesOfFriend in likesOfFriendsList)
			{
				if (likesOfFriend.Value > theMostLikerFriend.Value)
				{
					theMostLikerFriend = likesOfFriend;
				}
			}

			Mail = theMostLikerFriend.Key.Email;
			Picture = theMostLikerFriend.Key.PictureNormalURL;
		}
	}
}
