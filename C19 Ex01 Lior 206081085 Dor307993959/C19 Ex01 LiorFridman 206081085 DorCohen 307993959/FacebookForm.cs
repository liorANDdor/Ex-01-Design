using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
    public partial class FacebookForm : Form
    {
        public FacebookForm()
        {
            this.InitializeComponent();
            m_FacebookManager = new FacebookManager();

            if (m_FacebookManager.AppSettingsInstance.RememberUser)
            {
                m_FacebookManager.AppSettingsInstance = AppSettings.GetInstance();
                this.Size = m_FacebookManager.AppSettingsInstance.LastWindowsSize;
                this.Location = m_FacebookManager.AppSettingsInstance.LastWindowLocation;
                this.m_RemberMeCheckbox.Checked = m_FacebookManager.AppSettingsInstance.RememberUser;
            }
        }

        private FacebookManager m_FacebookManager;

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
				login();
            }
            else
            {
                m_FacebookManager.Logout();
                m_RemberMeCheckbox.Enabled = false;
                m_RemberMeCheckbox.Checked = false;
                cleanUI();
                m_LoginLogoutBtn.Text = "Login";
            }
        }

        private void cleanUI()
        {
            m_PostListBox.Items.Clear();
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

        private void fetchUserGroups()
        {
            List<string> userFriends = m_FacebookManager.FetchUserFriends();
            foreach (string friend in userFriends)
            {
                m_FriendListBox.Items.Add(friend);
            }

            if (userFriends.Count == 0)
            {
                m_FriendListBox.Items.Add("No friends to retrieve :(");
            }
        }

        private void fetchUserFriends()
        {
            List<string> userGroups = m_FacebookManager.FetchUserGroups();
            foreach (string group in userGroups)
            {
                m_GroupListBox.Items.Add(group);
            }

            if (userGroups.Count == 0)
            {
                m_GroupListBox.Items.Add("No Groups to retrieve :(");
            }
        }

        private void fetchUserPosts()
        {
            List<string> userPosts = m_FacebookManager.FetchUserPosts();
            foreach (string post in userPosts)
            {
                m_PostListBox.Items.Add(post);
            }

            if (userPosts.Count == 0)
            {
                m_PostListBox.Items.Add("No Posts to retrieve :(");
            }
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
            string userMatchMail = null;
            try
            {
                if (m_RadioFriends.Checked)
                {
                    m_PictureProfileMatch.LoadAsync(m_FacebookManager.FindYourMatchFriends(userMatchMail));
                    m_ExplainOfMatchLabel.Text = "This is your friend with the most mutual friends!";
                }
                else if (m_RadioGroup.Checked)
                {
                    m_PictureProfileMatch.LoadAsync(m_FacebookManager.FindYourMatchGroups(userMatchMail));
                    m_ExplainOfMatchLabel.Text = "This is your friend with the most mutual groups!";
                }
                else
                {
                    m_PictureProfileMatch.LoadAsync(m_FacebookManager.FindYourMatchPhotos(userMatchMail));
                    m_ExplainOfMatchLabel.Text = "This is your friend who gave you the most likes! ";
                }

                m_PictureProfileFeature.LoadAsync(m_FacebookManager.LoggedInUser.PictureNormalURL);
                UserChoiceForm sendEmailChoice = new UserChoiceForm(string.Format(@"Would you like send your match" +
                                                                            "\n friend a message? "));
                sendEmailChoice.ShowDialog();
                if (sendEmailChoice.Choice)
                {
                    m_FacebookManager.SendMail(userMatchMail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
