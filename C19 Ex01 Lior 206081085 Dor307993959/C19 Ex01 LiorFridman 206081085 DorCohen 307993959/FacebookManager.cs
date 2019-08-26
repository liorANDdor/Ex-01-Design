using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
	public sealed class FacebookManager
	{
		public User LoggedInUser { get; set;  }

		public LoginResult LoginResult { get; set;  }

		public AppSettings AppSettingsInstance { get; set;  }

		private static FacebookManager m_FacebookManager = null;

		public static FacebookManager GetInstance()
		{
			if(m_FacebookManager == null)
			{
				m_FacebookManager = new FacebookManager();
			}

			return m_FacebookManager;
		}

		public FacebookServiceFacade FaceBookServiceFacade { get; set; }

		private FacebookManager()
		{
			AppSettingsInstance = AppSettings.LoadFromFile();
			FaceBookServiceFacade = new FacebookServiceFacade();
		}

		public void Login()
		{
			LoginResult = FaceBookServiceFacade.Login();
			LoggedInUser = LoginResult.LoggedInUser;
		}

		public List<string> FetchUserPosts()
		{
			List<string> listPosts = new List<string>();
			try
			{
				foreach (Post post in LoggedInUser.Posts)
				{
					if (post.Message != null)
					{
						listPosts.Add(post.Message);
					}
					else if (post.Caption != null)
					{
						listPosts.Add(post.Caption);
					}
					else
					{
						listPosts.Add(string.Format("[{0}]", post.Type));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			return listPosts;
		}

		public void Logout()
		{
			FaceBookServiceFacade.Logout();
			LoggedInUser = null;
			LoginResult = null;
			AppSettingsInstance.RememberUser = false;
		}

		public string FindYourMatchPhotos(string io_FriendMail)
		{
			FacebookObjectCollection<User> friendsOfUser = LoggedInUser.Friends;
			Dictionary<User, int> likesOfFriendsList = new Dictionary<User, int>();
			foreach (Album album in LoggedInUser.Albums)
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

			io_FriendMail = theMostLikerFriend.Key.Email;
			return theMostLikerFriend.Key.PictureNormalURL;
		}

		internal List<string> FetchUserFriends()
		{
			List<string> friendsList = new List<string>();
			foreach (User friend in LoggedInUser.Friends)
			{
				friendsList.Add(friend.Name);
			}

			return friendsList;
		}

		internal List<Group> FetchUserGroups()
		{
			List<Group> groupList = new List<Group>();
			foreach (Group group in LoggedInUser.Groups)
			{
				groupList.Add(group);
			}

			return groupList;
		}

		public string FindYourMatchFriends(string io_FriendMail)
		{
			int mutualFriends;
			int maxMutualFriends = 0;
			Random rnd = new Random();
			int num = rnd.Next(1, 20);
			User myMatchFriend = LoggedInUser.Friends[num];
			foreach (User friend in LoggedInUser.Friends)
			{
				mutualFriends = 0;
				foreach (User hisfriend in friend.Friends)
				{
					foreach (User myFriend in LoggedInUser.Friends)
					{
                        if (hisfriend == myFriend)
                        {
                            mutualFriends++;
                        }
					}
				}

				if (mutualFriends > maxMutualFriends)
				{
					maxMutualFriends = mutualFriends;
					myMatchFriend = friend;
				}
			}

			io_FriendMail = myMatchFriend.Email;
			return myMatchFriend.PictureLargeURL;
		}
		
		public int FindBestTimeToUploadAPicture(List<string> io_Pictures)
		{
			FacebookObjectCollection<Album> albums;
			albums = LoggedInUser.Albums;
			List<PhotosAndLikes> listOfPhotosLikeByTime = new List<PhotosAndLikes>();
			for (int i = 0; i < 24; i++)
			{
				listOfPhotosLikeByTime.Add(new PhotosAndLikes(0, 0));
			}

			foreach (Album album in albums)
			{
				foreach (Photo photo in album.Photos)
                { 
					listOfPhotosLikeByTime[photo.CreatedTime.Value.Hour].NumOfPhotos += 1;
					listOfPhotosLikeByTime[photo.CreatedTime.Value.Hour].TotalLikes += photo.LikedBy.Count;
					listOfPhotosLikeByTime[photo.CreatedTime.Value.Hour].Pictures.Add(photo.PictureNormalURL);
				}
			}

			float maxLikePerPhoto = 0;
			float likesPerPhoto;
			int bestHourToPhoto = 0;
			int hour = 0;
			foreach (PhotosAndLikes photosAndLikes in listOfPhotosLikeByTime)
			{
				if (photosAndLikes.NumOfPhotos != 0)
				{
					likesPerPhoto = photosAndLikes.TotalLikes / photosAndLikes.NumOfPhotos;
				}
				else
				{
					likesPerPhoto = 0;
				}

				if (maxLikePerPhoto < likesPerPhoto)
				{
					io_Pictures = photosAndLikes.Pictures;
					maxLikePerPhoto = likesPerPhoto;
					bestHourToPhoto = hour;
				}

				hour += 1;
			}

			return bestHourToPhoto;
		}

		public void SendMail(string i_EmailAddress)
		{
			MailMessage mail = new MailMessage();
			SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
			mail.From = new MailAddress(@"facebookuserdorlior@gmail.com");
			mail.Subject = "Hey! Facebook sending mail feature";
			mail.To.Add(i_EmailAddress);
			mail.Body = string.Format(@"Hey, {0} has found that you are his match!! ", LoggedInUser.Name);
			smtpServer.Port = 587;
			smtpServer.Credentials = new NetworkCredential(@"facebookuserdorlior@gmail.com", "Fb123456");
			smtpServer.EnableSsl = true;
			smtpServer.Send(mail);
		}

		public string FindYourMatchGroups(string io_FriendMail)
		{
			int MutualGroups;
			int maxMutualGroups = 0;
			Random rnd = new Random();
			int num = rnd.Next(1, 20);
			User myMatch = LoggedInUser.Friends[num];
			foreach (User friend in LoggedInUser.Friends)
			{
				MutualGroups = 0;
				foreach (Group group in LoggedInUser.Groups)
				{
					foreach (Group friendgroup in friend.Groups)
					{
                        if (friendgroup.Id == group.Id)
                        {
                            MutualGroups++;
                        }
					}
				}

				if (MutualGroups > maxMutualGroups)
				{
					maxMutualGroups = MutualGroups;
					myMatch = friend;
				}
			}

			io_FriendMail = myMatch.Email;
			return myMatch.PictureLargeURL;
		}
	}
}
