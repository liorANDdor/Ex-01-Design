using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
	class FacebookManager
	{
		public User LoggedInUser { set; get; }
		public LoginResult LoginResult { set; get; }
		public AppSettings AppSettingsInstance { set; get; }

		public FacebookManager()
		{
			AppSettingsInstance = AppSettings.LoadFromFile();
		}
		public void Login()
		{
			LoginResult = FacebookService.Login("1450160541956417", /// (desig patter's "Design Patterns Course App 2.4" app)

			   "public_profile",
			   "email",
			   "publish_to_groups",
			   "user_birthday",
			   "user_age_range",
			   "user_gender",
			   "user_link",
			   "user_tagged_places",
			   "user_videos",
			   "publish_to_groups",
			   "groups_access_member_info",
			   "user_friends",
			   "user_events",
			   "user_likes",
			   "user_location",
			   "user_photos",
			   "user_posts",
			   "user_hometown"
			   );
				LoggedInUser = LoginResult.LoggedInUser;
		}

		public void Connect()
		{
			LoginResult = FacebookService.Connect(this.AppSettingsInstance.AccessToken);
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
			FacebookService.Logout(null);
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
					theMostLikerFriend = likesOfFriend;
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

		internal List<string> FetchUserGroups()
		{

			List<string> groupList = new List<string>();
			foreach (Group group in LoggedInUser.Groups)
			{
				groupList.Add(group.Name);
			}
			return groupList;
		}

		public string FindYourMatchFriends(string io_FriendMail)
		{
			int mutualFriends;
			int maxMutualFriends = 0;
			Random rnd = new Random();
			int num = rnd.Next(1, 20);
			User myMatchFriend = LoggedInUser.Friends[num];// in case that Api doesnt work
			foreach (User friend in LoggedInUser.Friends)
			{
				mutualFriends = 0;
				foreach (User hisfriend in friend.Friends)
				{
					foreach (User myFriend in LoggedInUser.Friends)
					{
						if (hisfriend == myFriend)
							mutualFriends++;
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
			User myMatch = LoggedInUser.Friends[num];//in case that Facebook Api does'nt work
			foreach (User friend in LoggedInUser.Friends)
			{
				MutualGroups = 0;
				foreach (Group group in LoggedInUser.Groups)
				{
					foreach (Group friendgroup in friend.Groups)
					{
						if (friendgroup.Id == group.Id)
							MutualGroups++;
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
