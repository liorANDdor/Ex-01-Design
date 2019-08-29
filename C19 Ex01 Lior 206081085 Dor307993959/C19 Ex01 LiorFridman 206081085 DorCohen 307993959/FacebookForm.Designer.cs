namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
	public partial class FacebookForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TabPage m_MainTab;
			System.Windows.Forms.Label likesCountLabel;
			System.Windows.Forms.Label createdTimeLabel;
			System.Windows.Forms.Label descriptionLabel;
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label updateTimeLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookForm));
			this.likesCountLabel1 = new System.Windows.Forms.Label();
			this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.nameLabel1 = new System.Windows.Forms.Label();
			this.updateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.m_FriendListBox = new System.Windows.Forms.ListBox();
			this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.m_GroupListBox = new System.Windows.Forms.ListBox();
			this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.m_RemberMeCheckbox = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.m_PostListBox = new System.Windows.Forms.ListBox();
			this.m_PostBtn = new System.Windows.Forms.Button();
			this.m_LoginLogoutBtn = new System.Windows.Forms.Button();
			this.m_ProfilePicMain = new System.Windows.Forms.PictureBox();
			this.m_FaceBookBarPic = new System.Windows.Forms.PictureBox();
			this.m_FindMatchTab = new System.Windows.Forms.TabPage();
			this.m_MatchPhotoRadioBtn = new C19_Ex01_LiorFridman_206081085_DorCohen_307993959.MatchTypeRadioBtn();
			this.m_MatchFriendRadioBtn = new C19_Ex01_LiorFridman_206081085_DorCohen_307993959.MatchTypeRadioBtn();
			this.m_MatchGroupRadioBtn = new C19_Ex01_LiorFridman_206081085_DorCohen_307993959.MatchTypeRadioBtn();
			this.m_ExplainOfMatchLabel = new System.Windows.Forms.Label();
			this.m_RunMatchBtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.m_PictureProfileMatch = new System.Windows.Forms.PictureBox();
			this.m_PictureProfileFeature = new System.Windows.Forms.PictureBox();
			this.m_Bar = new System.Windows.Forms.TabControl();
			this.secondfeature = new System.Windows.Forms.TabPage();
			this.m_BestTimeLabel = new System.Windows.Forms.Label();
			this.m_BestTImePic = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.m_BestPhotoBtn = new System.Windows.Forms.Button();
			m_MainTab = new System.Windows.Forms.TabPage();
			likesCountLabel = new System.Windows.Forms.Label();
			createdTimeLabel = new System.Windows.Forms.Label();
			descriptionLabel = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			updateTimeLabel = new System.Windows.Forms.Label();
			m_MainTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_FaceBookBarPic)).BeginInit();
			this.m_FindMatchTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_PictureProfileMatch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_PictureProfileFeature)).BeginInit();
			this.m_Bar.SuspendLayout();
			this.secondfeature.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_BestTImePic)).BeginInit();
			this.SuspendLayout();
			// 
			// m_MainTab
			// 
			m_MainTab.AutoScroll = true;
			m_MainTab.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			m_MainTab.Controls.Add(likesCountLabel);
			m_MainTab.Controls.Add(this.likesCountLabel1);
			m_MainTab.Controls.Add(createdTimeLabel);
			m_MainTab.Controls.Add(this.createdTimeDateTimePicker);
			m_MainTab.Controls.Add(descriptionLabel);
			m_MainTab.Controls.Add(this.descriptionTextBox);
			m_MainTab.Controls.Add(nameLabel);
			m_MainTab.Controls.Add(this.nameLabel1);
			m_MainTab.Controls.Add(updateTimeLabel);
			m_MainTab.Controls.Add(this.updateTimeDateTimePicker);
			m_MainTab.Controls.Add(this.m_FriendListBox);
			m_MainTab.Controls.Add(this.m_GroupListBox);
			m_MainTab.Controls.Add(this.label7);
			m_MainTab.Controls.Add(this.label6);
			m_MainTab.Controls.Add(this.m_RemberMeCheckbox);
			m_MainTab.Controls.Add(this.label1);
			m_MainTab.Controls.Add(this.m_PostListBox);
			m_MainTab.Controls.Add(this.m_PostBtn);
			m_MainTab.Controls.Add(this.m_LoginLogoutBtn);
			m_MainTab.Controls.Add(this.m_ProfilePicMain);
			m_MainTab.Location = new System.Drawing.Point(4, 22);
			m_MainTab.Name = "m_MainTab";
			m_MainTab.Padding = new System.Windows.Forms.Padding(3);
			m_MainTab.Size = new System.Drawing.Size(873, 364);
			m_MainTab.TabIndex = 0;
			m_MainTab.Text = "Main";
			// 
			// likesCountLabel
			// 
			likesCountLabel.AutoSize = true;
			likesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			likesCountLabel.Location = new System.Drawing.Point(484, 324);
			likesCountLabel.Name = "likesCountLabel";
			likesCountLabel.Size = new System.Drawing.Size(80, 16);
			likesCountLabel.TabIndex = 19;
			likesCountLabel.Text = "Likes Count:";
			// 
			// likesCountLabel1
			// 
			this.likesCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.commentsBindingSource, "LikesCount", true));
			this.likesCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentsBindingSource, "LikesCount", true));
			this.likesCountLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.likesCountLabel1.Location = new System.Drawing.Point(590, 324);
			this.likesCountLabel1.Name = "likesCountLabel1";
			this.likesCountLabel1.Size = new System.Drawing.Size(100, 23);
			this.likesCountLabel1.TabIndex = 20;
			this.likesCountLabel1.Text = "label8";
			// 
			// commentsBindingSource
			// 
			this.commentsBindingSource.DataMember = "Comments";
			this.commentsBindingSource.DataSource = this.postBindingSource;
			// 
			// postBindingSource
			// 
			this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
			// 
			// createdTimeLabel
			// 
			createdTimeLabel.AutoSize = true;
			createdTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			createdTimeLabel.Location = new System.Drawing.Point(484, 208);
			createdTimeLabel.Name = "createdTimeLabel";
			createdTimeLabel.Size = new System.Drawing.Size(93, 16);
			createdTimeLabel.TabIndex = 12;
			createdTimeLabel.Text = "Created Time:";
			// 
			// createdTimeDateTimePicker
			// 
			this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
			this.createdTimeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.createdTimeDateTimePicker.Location = new System.Drawing.Point(590, 206);
			this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
			this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
			this.createdTimeDateTimePicker.TabIndex = 13;
			// 
			// descriptionLabel
			// 
			descriptionLabel.AutoSize = true;
			descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			descriptionLabel.Location = new System.Drawing.Point(484, 235);
			descriptionLabel.Name = "descriptionLabel";
			descriptionLabel.Size = new System.Drawing.Size(79, 16);
			descriptionLabel.TabIndex = 14;
			descriptionLabel.Text = "Description:";
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Description", true));
			this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.descriptionTextBox.Location = new System.Drawing.Point(590, 232);
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
			this.descriptionTextBox.TabIndex = 15;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			nameLabel.Location = new System.Drawing.Point(484, 265);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(48, 16);
			nameLabel.TabIndex = 16;
			nameLabel.Text = "Name:";
			// 
			// nameLabel1
			// 
			this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Name", true));
			this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.nameLabel1.Location = new System.Drawing.Point(590, 265);
			this.nameLabel1.Name = "nameLabel1";
			this.nameLabel1.Size = new System.Drawing.Size(200, 23);
			this.nameLabel1.TabIndex = 17;
			this.nameLabel1.Text = "label8";
			// 
			// updateTimeLabel
			// 
			updateTimeLabel.AutoSize = true;
			updateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			updateTimeLabel.Location = new System.Drawing.Point(484, 298);
			updateTimeLabel.Name = "updateTimeLabel";
			updateTimeLabel.Size = new System.Drawing.Size(90, 16);
			updateTimeLabel.TabIndex = 18;
			updateTimeLabel.Text = "Update Time:";
			// 
			// updateTimeDateTimePicker
			// 
			this.updateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "UpdateTime", true));
			this.updateTimeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.updateTimeDateTimePicker.Location = new System.Drawing.Point(590, 293);
			this.updateTimeDateTimePicker.Name = "updateTimeDateTimePicker";
			this.updateTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
			this.updateTimeDateTimePicker.TabIndex = 19;
			// 
			// m_FriendListBox
			// 
			this.m_FriendListBox.DataSource = this.friendListBindingSource;
			this.m_FriendListBox.DisplayMember = "Name";
			this.m_FriendListBox.FormattingEnabled = true;
			this.m_FriendListBox.Location = new System.Drawing.Point(232, 57);
			this.m_FriendListBox.Name = "m_FriendListBox";
			this.m_FriendListBox.Size = new System.Drawing.Size(216, 121);
			this.m_FriendListBox.TabIndex = 12;
			// 
			// friendListBindingSource
			// 
			this.friendListBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.FriendList);
			// 
			// m_GroupListBox
			// 
			this.m_GroupListBox.DataSource = this.groupBindingSource;
			this.m_GroupListBox.DisplayMember = "Name";
			this.m_GroupListBox.FormattingEnabled = true;
			this.m_GroupListBox.Location = new System.Drawing.Point(232, 235);
			this.m_GroupListBox.Name = "m_GroupListBox";
			this.m_GroupListBox.Size = new System.Drawing.Size(216, 121);
			this.m_GroupListBox.TabIndex = 11;
			// 
			// groupBindingSource
			// 
			this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label7.Location = new System.Drawing.Point(227, 199);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 25);
			this.label7.TabIndex = 10;
			this.label7.Text = "Groups List";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label6.Location = new System.Drawing.Point(227, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 25);
			this.label6.TabIndex = 9;
			this.label6.Text = "Friends List";
			// 
			// m_RemberMeCheckbox
			// 
			this.m_RemberMeCheckbox.AutoSize = true;
			this.m_RemberMeCheckbox.Enabled = false;
			this.m_RemberMeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_RemberMeCheckbox.Location = new System.Drawing.Point(9, 249);
			this.m_RemberMeCheckbox.Name = "m_RemberMeCheckbox";
			this.m_RemberMeCheckbox.Size = new System.Drawing.Size(188, 24);
			this.m_RemberMeCheckbox.TabIndex = 7;
			this.m_RemberMeCheckbox.Text = "Remeber me next time";
			this.m_RemberMeCheckbox.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label1.Location = new System.Drawing.Point(469, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "Post\'s List";
			// 
			// m_PostListBox
			// 
			this.m_PostListBox.DataSource = this.postBindingSource;
			this.m_PostListBox.DisplayMember = "Message";
			this.m_PostListBox.FormattingEnabled = true;
			this.m_PostListBox.Location = new System.Drawing.Point(474, 57);
			this.m_PostListBox.Name = "m_PostListBox";
			this.m_PostListBox.Size = new System.Drawing.Size(357, 121);
			this.m_PostListBox.TabIndex = 5;
			this.m_PostListBox.ValueMember = "Description";
			// 
			// m_PostBtn
			// 
			this.m_PostBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.m_PostBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_PostBtn.Location = new System.Drawing.Point(703, 11);
			this.m_PostBtn.Name = "m_PostBtn";
			this.m_PostBtn.Size = new System.Drawing.Size(116, 35);
			this.m_PostBtn.TabIndex = 3;
			this.m_PostBtn.Text = "Post something";
			this.m_PostBtn.UseVisualStyleBackColor = false;
			this.m_PostBtn.Click += new System.EventHandler(this.postBtn_Click);
			// 
			// m_LoginLogoutBtn
			// 
			this.m_LoginLogoutBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.m_LoginLogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_LoginLogoutBtn.Location = new System.Drawing.Point(6, 6);
			this.m_LoginLogoutBtn.Name = "m_LoginLogoutBtn";
			this.m_LoginLogoutBtn.Size = new System.Drawing.Size(203, 45);
			this.m_LoginLogoutBtn.TabIndex = 1;
			this.m_LoginLogoutBtn.Text = "Login";
			this.m_LoginLogoutBtn.UseVisualStyleBackColor = false;
			this.m_LoginLogoutBtn.Click += new System.EventHandler(this.loginLogoutBtn_Click);
			// 
			// m_ProfilePicMain
			// 
			this.m_ProfilePicMain.Image = ((System.Drawing.Image)(resources.GetObject("m_ProfilePicMain.Image")));
			this.m_ProfilePicMain.Location = new System.Drawing.Point(9, 57);
			this.m_ProfilePicMain.Name = "m_ProfilePicMain";
			this.m_ProfilePicMain.Size = new System.Drawing.Size(200, 167);
			this.m_ProfilePicMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_ProfilePicMain.TabIndex = 2;
			this.m_ProfilePicMain.TabStop = false;
			// 
			// m_FaceBookBarPic
			// 
			this.m_FaceBookBarPic.Image = ((System.Drawing.Image)(resources.GetObject("m_FaceBookBarPic.Image")));
			this.m_FaceBookBarPic.Location = new System.Drawing.Point(0, 6);
			this.m_FaceBookBarPic.Name = "m_FaceBookBarPic";
			this.m_FaceBookBarPic.Size = new System.Drawing.Size(881, 92);
			this.m_FaceBookBarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_FaceBookBarPic.TabIndex = 0;
			this.m_FaceBookBarPic.TabStop = false;
			// 
			// m_FindMatchTab
			// 
			this.m_FindMatchTab.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.m_FindMatchTab.Controls.Add(this.m_MatchPhotoRadioBtn);
			this.m_FindMatchTab.Controls.Add(this.m_MatchFriendRadioBtn);
			this.m_FindMatchTab.Controls.Add(this.m_MatchGroupRadioBtn);
			this.m_FindMatchTab.Controls.Add(this.m_ExplainOfMatchLabel);
			this.m_FindMatchTab.Controls.Add(this.m_RunMatchBtn);
			this.m_FindMatchTab.Controls.Add(this.label4);
			this.m_FindMatchTab.Controls.Add(this.label3);
			this.m_FindMatchTab.Controls.Add(this.label2);
			this.m_FindMatchTab.Controls.Add(this.m_PictureProfileMatch);
			this.m_FindMatchTab.Controls.Add(this.m_PictureProfileFeature);
			this.m_FindMatchTab.Location = new System.Drawing.Point(4, 22);
			this.m_FindMatchTab.Name = "m_FindMatchTab";
			this.m_FindMatchTab.Padding = new System.Windows.Forms.Padding(3);
			this.m_FindMatchTab.Size = new System.Drawing.Size(873, 364);
			this.m_FindMatchTab.TabIndex = 1;
			this.m_FindMatchTab.Text = "Find your match";
			// 
			// m_MatchPhotoRadioBtn
			// 
			this.m_MatchPhotoRadioBtn.AutoSize = true;
			this.m_MatchPhotoRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_MatchPhotoRadioBtn.Location = new System.Drawing.Point(43, 138);
			this.m_MatchPhotoRadioBtn.MatchType = C19_Ex01_LiorFridman_206081085_DorCohen_307993959.MatchType.Photos;
			this.m_MatchPhotoRadioBtn.Name = "m_MatchPhotoRadioBtn";
			this.m_MatchPhotoRadioBtn.Size = new System.Drawing.Size(144, 24);
			this.m_MatchPhotoRadioBtn.TabIndex = 15;
			this.m_MatchPhotoRadioBtn.TabStop = true;
			this.m_MatchPhotoRadioBtn.Text = "Match by photos";
			this.m_MatchPhotoRadioBtn.UseVisualStyleBackColor = true;
			// 
			// m_MatchFriendRadioBtn
			// 
			this.m_MatchFriendRadioBtn.AutoSize = true;
			this.m_MatchFriendRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_MatchFriendRadioBtn.Location = new System.Drawing.Point(43, 108);
			this.m_MatchFriendRadioBtn.MatchType = C19_Ex01_LiorFridman_206081085_DorCohen_307993959.MatchType.Friends;
			this.m_MatchFriendRadioBtn.Name = "m_MatchFriendRadioBtn";
			this.m_MatchFriendRadioBtn.Size = new System.Drawing.Size(143, 24);
			this.m_MatchFriendRadioBtn.TabIndex = 14;
			this.m_MatchFriendRadioBtn.TabStop = true;
			this.m_MatchFriendRadioBtn.Text = "Match by friends";
			this.m_MatchFriendRadioBtn.UseVisualStyleBackColor = true;
			// 
			// m_MatchGroupRadioBtn
			// 
			this.m_MatchGroupRadioBtn.AutoSize = true;
			this.m_MatchGroupRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_MatchGroupRadioBtn.Location = new System.Drawing.Point(43, 75);
			this.m_MatchGroupRadioBtn.MatchType = C19_Ex01_LiorFridman_206081085_DorCohen_307993959.MatchType.Groups;
			this.m_MatchGroupRadioBtn.Name = "m_MatchGroupRadioBtn";
			this.m_MatchGroupRadioBtn.Size = new System.Drawing.Size(144, 24);
			this.m_MatchGroupRadioBtn.TabIndex = 13;
			this.m_MatchGroupRadioBtn.TabStop = true;
			this.m_MatchGroupRadioBtn.Text = "Match by groups";
			this.m_MatchGroupRadioBtn.UseVisualStyleBackColor = true;
			// 
			// m_ExplainOfMatchLabel
			// 
			this.m_ExplainOfMatchLabel.AutoSize = true;
			this.m_ExplainOfMatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_ExplainOfMatchLabel.Location = new System.Drawing.Point(152, 245);
			this.m_ExplainOfMatchLabel.Name = "m_ExplainOfMatchLabel";
			this.m_ExplainOfMatchLabel.Size = new System.Drawing.Size(0, 31);
			this.m_ExplainOfMatchLabel.TabIndex = 12;
			this.m_ExplainOfMatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// m_RunMatchBtn
			// 
			this.m_RunMatchBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.m_RunMatchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_RunMatchBtn.Location = new System.Drawing.Point(40, 172);
			this.m_RunMatchBtn.Name = "m_RunMatchBtn";
			this.m_RunMatchBtn.Size = new System.Drawing.Size(131, 38);
			this.m_RunMatchBtn.TabIndex = 11;
			this.m_RunMatchBtn.Text = "Run!";
			this.m_RunMatchBtn.UseVisualStyleBackColor = false;
			this.m_RunMatchBtn.Click += new System.EventHandler(this.runFindMatchBtn_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label4.Location = new System.Drawing.Point(35, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(221, 25);
			this.label4.TabIndex = 10;
			this.label4.Text = "Please choose category";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label3.Location = new System.Drawing.Point(520, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Your match";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label2.Location = new System.Drawing.Point(336, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "You are";
			// 
			// m_PictureProfileMatch
			// 
			this.m_PictureProfileMatch.Image = ((System.Drawing.Image)(resources.GetObject("m_PictureProfileMatch.Image")));
			this.m_PictureProfileMatch.Location = new System.Drawing.Point(490, 66);
			this.m_PictureProfileMatch.Name = "m_PictureProfileMatch";
			this.m_PictureProfileMatch.Size = new System.Drawing.Size(161, 146);
			this.m_PictureProfileMatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_PictureProfileMatch.TabIndex = 4;
			this.m_PictureProfileMatch.TabStop = false;
			// 
			// m_PictureProfileFeature
			// 
			this.m_PictureProfileFeature.Image = ((System.Drawing.Image)(resources.GetObject("m_PictureProfileFeature.Image")));
			this.m_PictureProfileFeature.Location = new System.Drawing.Point(285, 66);
			this.m_PictureProfileFeature.Name = "m_PictureProfileFeature";
			this.m_PictureProfileFeature.Size = new System.Drawing.Size(160, 146);
			this.m_PictureProfileFeature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_PictureProfileFeature.TabIndex = 3;
			this.m_PictureProfileFeature.TabStop = false;
			// 
			// m_Bar
			// 
			this.m_Bar.Controls.Add(m_MainTab);
			this.m_Bar.Controls.Add(this.m_FindMatchTab);
			this.m_Bar.Controls.Add(this.secondfeature);
			this.m_Bar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_Bar.Location = new System.Drawing.Point(0, 109);
			this.m_Bar.Name = "m_Bar";
			this.m_Bar.SelectedIndex = 0;
			this.m_Bar.Size = new System.Drawing.Size(881, 390);
			this.m_Bar.TabIndex = 0;
			// 
			// secondfeature
			// 
			this.secondfeature.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.secondfeature.Controls.Add(this.m_BestTimeLabel);
			this.secondfeature.Controls.Add(this.m_BestTImePic);
			this.secondfeature.Controls.Add(this.label5);
			this.secondfeature.Controls.Add(this.m_BestPhotoBtn);
			this.secondfeature.Location = new System.Drawing.Point(4, 22);
			this.secondfeature.Name = "secondfeature";
			this.secondfeature.Padding = new System.Windows.Forms.Padding(3);
			this.secondfeature.Size = new System.Drawing.Size(873, 364);
			this.secondfeature.TabIndex = 2;
			this.secondfeature.Text = "Best time for picture post";
			// 
			// m_BestTimeLabel
			// 
			this.m_BestTimeLabel.AutoSize = true;
			this.m_BestTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)), true);
			this.m_BestTimeLabel.Location = new System.Drawing.Point(49, 186);
			this.m_BestTimeLabel.Name = "m_BestTimeLabel";
			this.m_BestTimeLabel.Size = new System.Drawing.Size(124, 20);
			this.m_BestTimeLabel.TabIndex = 3;
			this.m_BestTimeLabel.Text = "The best time is:";
			// 
			// m_BestTImePic
			// 
			this.m_BestTImePic.Image = ((System.Drawing.Image)(resources.GetObject("m_BestTImePic.Image")));
			this.m_BestTImePic.Location = new System.Drawing.Point(376, 80);
			this.m_BestTImePic.Name = "m_BestTImePic";
			this.m_BestTImePic.Size = new System.Drawing.Size(398, 226);
			this.m_BestTImePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_BestTImePic.TabIndex = 2;
			this.m_BestTImePic.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label5.Location = new System.Drawing.Point(44, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(401, 25);
			this.label5.TabIndex = 1;
			this.label5.Text = "Click run to find the best hour for picture post!";
			// 
			// m_BestPhotoBtn
			// 
			this.m_BestPhotoBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.m_BestPhotoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.m_BestPhotoBtn.Location = new System.Drawing.Point(44, 67);
			this.m_BestPhotoBtn.Name = "m_BestPhotoBtn";
			this.m_BestPhotoBtn.Size = new System.Drawing.Size(165, 44);
			this.m_BestPhotoBtn.TabIndex = 0;
			this.m_BestPhotoBtn.Text = "run!";
			this.m_BestPhotoBtn.UseVisualStyleBackColor = false;
			this.m_BestPhotoBtn.Click += new System.EventHandler(this.bestPhotoBtn_Click);
			// 
			// FacebookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(881, 499);
			this.Controls.Add(this.m_FaceBookBarPic);
			this.Controls.Add(this.m_Bar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FacebookForm";
			this.Text = "Facebook Application";
			m_MainTab.ResumeLayout(false);
			m_MainTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_FaceBookBarPic)).EndInit();
			this.m_FindMatchTab.ResumeLayout(false);
			this.m_FindMatchTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_PictureProfileMatch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_PictureProfileFeature)).EndInit();
			this.m_Bar.ResumeLayout(false);
			this.secondfeature.ResumeLayout(false);
			this.secondfeature.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_BestTImePic)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox m_FaceBookBarPic;
		internal System.Windows.Forms.TabPage m_FindMatchTab;
		private System.Windows.Forms.TabControl m_Bar;
		private System.Windows.Forms.Button m_LoginLogoutBtn;
		private System.Windows.Forms.PictureBox m_ProfilePicMain;
		private System.Windows.Forms.ListBox m_PostListBox;
		private System.Windows.Forms.Button m_PostBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button m_RunMatchBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox m_PictureProfileMatch;
		private System.Windows.Forms.PictureBox m_PictureProfileFeature;
		private System.Windows.Forms.TabPage secondfeature;
		private System.Windows.Forms.CheckBox m_RemberMeCheckbox;
		private System.Windows.Forms.Button m_BestPhotoBtn;
		private System.Windows.Forms.Label m_ExplainOfMatchLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label m_BestTimeLabel;
		private System.Windows.Forms.PictureBox m_BestTImePic;
		private System.Windows.Forms.ListBox m_FriendListBox;
		private System.Windows.Forms.ListBox m_GroupListBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.BindingSource postBindingSource;
		private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.Label nameLabel1;
		private System.Windows.Forms.DateTimePicker updateTimeDateTimePicker;
		private System.Windows.Forms.BindingSource commentsBindingSource;
		private System.Windows.Forms.Label likesCountLabel1;
		private MatchTypeRadioBtn m_MatchPhotoRadioBtn;
		private MatchTypeRadioBtn m_MatchFriendRadioBtn;
		private MatchTypeRadioBtn m_MatchGroupRadioBtn;
		private System.Windows.Forms.BindingSource friendListBindingSource;
		private System.Windows.Forms.BindingSource groupBindingSource;
	}
}
