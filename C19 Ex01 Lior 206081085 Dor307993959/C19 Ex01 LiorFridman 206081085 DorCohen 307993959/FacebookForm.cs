using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
    public partial class FacebookForm : Form
    {
		private FacebookManager m_FacebookManager;

		private object MatchFeatureLocker = new object();

		public FacebookForm()
        {
            this.InitializeComponent();
            m_FacebookManager = FacebookManager.GetInstance();

            if (m_FacebookManager.AppSettingsInstance.RememberUser)
            {
                m_FacebookManager.AppSettingsInstance = AppSettings.GetInstance();
                this.Size = m_FacebookManager.AppSettingsInstance.LastWindowsSize;
                this.Location = m_FacebookManager.AppSettingsInstance.LastWindowLocation;
                this.m_RemberMeCheckbox.Checked = m_FacebookManager.AppSettingsInstance.RememberUser;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            try
            {
                if (m_FacebookManager.AppSettingsInstance.RememberUser &&
                    !string.IsNullOrEmpty(m_FacebookManager.AppSettingsInstance.AccessToken))
                {
					login();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

		private void login()
		{
			m_FacebookManager.Login();
			m_RemberMeCheckbox.Enabled = true;
			m_LoginLogoutBtn.Text = "Logout";
			this.fetchUserInfo();
		}

        private void loginLogoutBtn_Click(object sender, EventArgs e)
        {
            if (m_LoginLogoutBtn.Text == "Login")
            {
				try
				{
					login();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
            }
            else
			{
				logout();
			}
		}

		private void logout()
		{
			m_FacebookManager.Logout();
			m_RemberMeCheckbox.Enabled = false;
			m_RemberMeCheckbox.Checked = false;
			cleanUI();
			m_LoginLogoutBtn.Text = "Login";
		}

		private void cleanUI()
        {
            m_FriendListBox.Items.Clear();
            m_GroupListBox.Items.Clear();
            m_PictureProfileFeature.Image = null;
            m_ProfilePicMain.Image = null;
        }

        private void fetchUserInfo()
        {
            try
            {
                m_ProfilePicMain.LoadAsync(m_FacebookManager.LoggedInUser.PictureNormalURL);
                this.fetchUserPosts();
                this.fetchUserFriends();
                this.fetchUserGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchUserFriends()
        {
			friendListBindingSource.DataSource = m_FacebookManager.LoggedInUser.FriendLists;
        }

        private void fetchUserGroups()
        {
			groupBindingSource.DataSource = m_FacebookManager.LoggedInUser.Groups;
        }

        private void fetchUserPosts()
        {
			postBindingSource.DataSource = m_FacebookManager.LoggedInUser.Posts;
        }

		private void postBtn_Click(object sender, EventArgs e)
		{
			TextFillForm newPost = new TextFillForm();
			newPost.ShowDialog();
			if (!string.IsNullOrEmpty(newPost.UserInput)
				&& !newPost.IsCanceled)
			{
				try
				{
					m_FacebookManager.LoggedInUser.PostStatus(newPost.UserInput);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Nothing was happened");
			}
        }

        private void runFindMatchBtn_Click(object sender, EventArgs e)
		{
			new Thread(findMatch).Start();
		}

		private void findMatch()
		{
			lock (MatchFeatureLocker)
			{
				foreach (Control control in this.m_FindMatchTab.Controls)
				{
					if (control is MatchTypeRadioBtn)
					{
						if ((control as MatchTypeRadioBtn).Checked)
						{
							m_FacebookManager.MatchFinder.MatchType = (control as MatchTypeRadioBtn).MatchType;
						}
					}
				}

				try
				{
					m_FacebookManager.StartMatchFeature();
					m_PictureProfileMatch.Invoke(new Action(() =>
					m_PictureProfileMatch.LoadAsync(m_FacebookManager.MatchFinder.Matcher.BestMatch.PictureNormalURL)));
					m_PictureProfileFeature.Invoke(new Action(() =>
					m_PictureProfileFeature.LoadAsync(m_FacebookManager.LoggedInUser.PictureNormalURL)));
					UserChoiceForm sendEmailChoice = new UserChoiceForm(string.Format(@"Would you like send your match" +
																				"\n friend a message? "));
					sendEmailChoice.ShowDialog();
					if (sendEmailChoice.Choice)
					{
						m_FacebookManager.SendMail(m_FacebookManager.MatchFinder.Matcher.BestMatch.Email);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_FacebookManager.AppSettingsInstance.RememberUser = this.m_RemberMeCheckbox.Checked;
            m_FacebookManager.AppSettingsInstance.LastWindowLocation = this.Location;
            m_FacebookManager.AppSettingsInstance.LastWindowsSize = this.Size;
            if (m_FacebookManager.LoginResult != null)
            {
                if (!string.IsNullOrEmpty(m_FacebookManager.LoginResult.AccessToken))
                {
                    m_FacebookManager.AppSettingsInstance.AccessToken = m_FacebookManager.LoginResult.AccessToken;
                }
            }

			try
			{
				m_FacebookManager.AppSettingsInstance.SaveToFile();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
        }

        private void bestPhotoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> pictures = new List<string>();
                int T = m_FacebookManager.FindBestTimeToUploadAPicture(pictures);
                m_BestTimeLabel.Text += T.ToString();
                if (pictures.Count > 0)
                {
                    m_BestTImePic.LoadAsync(pictures[0]);
                }
                else
                {
                    m_BestTimeLabel.Text = "No photos, so there is your profile picture";
                    m_BestTImePic.LoadAsync(m_FacebookManager.LoggedInUser.PictureNormalURL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
	}
}
