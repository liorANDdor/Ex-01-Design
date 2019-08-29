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

		public MatchFinderFeature MatchFinder { get; set; }

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
			MatchFinder = new MatchFinderFeature();
			AppSettingsInstance = AppSettings.LoadFromFile();
			FaceBookServiceFacade = new FacebookServiceFacade();
		}

		public void FindYourMatch()
		{
			MatchFinder.FindMatch(LoggedInUser);
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
	}
}
