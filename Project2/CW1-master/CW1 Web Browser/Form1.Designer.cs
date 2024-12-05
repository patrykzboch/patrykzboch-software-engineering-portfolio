namespace CW1_Web_Browser
{
    partial class WebBrowser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowser));
            pageTitleLabel = new Label();
            backButton = new Button();
            forwardButton = new Button();
            refreshButton = new Button();
            homeButton = new Button();
            searchBox = new RichTextBox();
            searchButton = new Button();
            favouriteButton = new Button();
            moreButton = new Button();
            htmlContentBox = new RichTextBox();
            statusCodeLabel = new Label();
            homePagePanel = new FlowLayoutPanel();
            homePageButton = new Button();
            setHomePageButton = new Button();
            editPanel = new FlowLayoutPanel();
            label3 = new Label();
            oldNameBox = new RichTextBox();
            label4 = new Label();
            newNameBox = new RichTextBox();
            editPanelSubmitButton = new Button();
            editPanelCancelPanel = new Button();
            removeFavouritePanel = new FlowLayoutPanel();
            label5 = new Label();
            removeNameBox = new RichTextBox();
            removePanelSubmitButton = new Button();
            removeFavouriteCancelButton = new Button();
            setHomePagePanel = new FlowLayoutPanel();
            label1 = new Label();
            setHomePagePanelBox = new RichTextBox();
            SubmitSetHomeButton = new Button();
            cancelSetHomePagePanel = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            bulkDownloadPanel = new FlowLayoutPanel();
            label6 = new Label();
            fileNameBox = new RichTextBox();
            submitBulk = new Button();
            defaultDownloadButton = new Button();
            bulkDownloadCancelButton = new Button();
            favouritesPanel = new FlowLayoutPanel();
            label2 = new Label();
            favouritesNameBox = new RichTextBox();
            addButtonFavourites = new Button();
            editFavouritesButton = new Button();
            removeFavouriteButton = new Button();
            favouritesListPanel = new FlowLayoutPanel();
            closeFavouriteList = new Button();
            historyMorePanelButton = new Button();
            morePanel = new FlowLayoutPanel();
            favouriteMorePanelButton = new Button();
            bulkDownloadMorePanelButton = new Button();
            closeHistoryButton = new Button();
            historyPanel = new FlowLayoutPanel();
            homePagePanel.SuspendLayout();
            editPanel.SuspendLayout();
            removeFavouritePanel.SuspendLayout();
            setHomePagePanel.SuspendLayout();
            bulkDownloadPanel.SuspendLayout();
            favouritesPanel.SuspendLayout();
            favouritesListPanel.SuspendLayout();
            morePanel.SuspendLayout();
            historyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pageTitleLabel
            // 
            pageTitleLabel.AutoSize = true;
            pageTitleLabel.Location = new Point(12, 9);
            pageTitleLabel.Name = "pageTitleLabel";
            pageTitleLabel.Size = new Size(58, 15);
            pageTitleLabel.TabIndex = 0;
            pageTitleLabel.Text = "Page Title";
            pageTitleLabel.Visible = false;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 32);
            backButton.Name = "backButton";
            backButton.Size = new Size(30, 30);
            backButton.TabIndex = 1;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += BackButton_Click;
            // 
            // forwardButton
            // 
            forwardButton.Location = new Point(48, 32);
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(30, 30);
            forwardButton.TabIndex = 2;
            forwardButton.Text = ">";
            forwardButton.UseVisualStyleBackColor = true;
            forwardButton.Click += ForwardButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.ForeColor = SystemColors.ButtonFace;
            refreshButton.Image = (Image)resources.GetObject("refreshButton.Image");
            refreshButton.Location = new Point(92, 32);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(30, 30);
            refreshButton.TabIndex = 3;
            refreshButton.Text = ">";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += RefreshButton_Click;
            // 
            // homeButton
            // 
            homeButton.ForeColor = SystemColors.ButtonFace;
            homeButton.Image = (Image)resources.GetObject("homeButton.Image");
            homeButton.Location = new Point(128, 32);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(30, 30);
            homeButton.TabIndex = 4;
            homeButton.Text = ">";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += HomeButton_Click;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBox.Location = new Point(164, 34);
            searchBox.Multiline = false;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(931, 28);
            searchBox.TabIndex = 5;
            searchBox.Text = "";
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.ForeColor = SystemColors.ButtonFace;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(1098, 32);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(30, 30);
            searchButton.TabIndex = 6;
            searchButton.Text = ">";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // favouriteButton
            // 
            favouriteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            favouriteButton.ForeColor = SystemColors.ButtonFace;
            favouriteButton.Image = (Image)resources.GetObject("favouriteButton.Image");
            favouriteButton.Location = new Point(1135, 32);
            favouriteButton.Name = "favouriteButton";
            favouriteButton.Size = new Size(30, 30);
            favouriteButton.TabIndex = 7;
            favouriteButton.Text = ">";
            favouriteButton.UseVisualStyleBackColor = true;
            favouriteButton.Click += FavouriteButton_Click;
            // 
            // moreButton
            // 
            moreButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            moreButton.ForeColor = SystemColors.ButtonFace;
            moreButton.Image = (Image)resources.GetObject("moreButton.Image");
            moreButton.Location = new Point(1252, 32);
            moreButton.Name = "moreButton";
            moreButton.Size = new Size(30, 30);
            moreButton.TabIndex = 8;
            moreButton.Text = ">";
            moreButton.UseVisualStyleBackColor = true;
            moreButton.Click += MoreButton_Click;
            // 
            // htmlContentBox
            // 
            htmlContentBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            htmlContentBox.BackColor = SystemColors.Control;
            htmlContentBox.Location = new Point(12, 103);
            htmlContentBox.Name = "htmlContentBox";
            htmlContentBox.ReadOnly = true;
            htmlContentBox.Size = new Size(1272, 528);
            htmlContentBox.TabIndex = 9;
            htmlContentBox.Text = "";
            // 
            // statusCodeLabel
            // 
            statusCodeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            statusCodeLabel.AutoSize = true;
            statusCodeLabel.Location = new Point(1098, 9);
            statusCodeLabel.Name = "statusCodeLabel";
            statusCodeLabel.Size = new Size(35, 15);
            statusCodeLabel.TabIndex = 11;
            statusCodeLabel.Text = "Code";
            statusCodeLabel.Visible = false;
            // 
            // homePagePanel
            // 
            homePagePanel.BackColor = SystemColors.AppWorkspace;
            homePagePanel.Controls.Add(homePageButton);
            homePagePanel.Controls.Add(setHomePageButton);
            homePagePanel.Location = new Point(12, 68);
            homePagePanel.Margin = new Padding(2);
            homePagePanel.Name = "homePagePanel";
            homePagePanel.Size = new Size(187, 30);
            homePagePanel.TabIndex = 12;
            homePagePanel.Visible = false;
            // 
            // homePageButton
            // 
            homePageButton.Location = new Point(2, 2);
            homePageButton.Margin = new Padding(2);
            homePageButton.Name = "homePageButton";
            homePageButton.Size = new Size(78, 24);
            homePageButton.TabIndex = 0;
            homePageButton.Text = "Home Page";
            homePageButton.UseVisualStyleBackColor = true;
            homePageButton.Click += HomePageButton_Click;
            // 
            // setHomePageButton
            // 
            setHomePageButton.Location = new Point(84, 2);
            setHomePageButton.Margin = new Padding(2);
            setHomePageButton.Name = "setHomePageButton";
            setHomePageButton.Size = new Size(100, 24);
            setHomePageButton.TabIndex = 13;
            setHomePageButton.Text = "Set Home Page";
            setHomePageButton.UseVisualStyleBackColor = true;
            setHomePageButton.Click += SetHomePageButton_Click;
            // 
            // editPanel
            // 
            editPanel.BackColor = SystemColors.AppWorkspace;
            editPanel.Controls.Add(label3);
            editPanel.Controls.Add(oldNameBox);
            editPanel.Controls.Add(label4);
            editPanel.Controls.Add(newNameBox);
            editPanel.Controls.Add(editPanelSubmitButton);
            editPanel.Controls.Add(editPanelCancelPanel);
            editPanel.Location = new Point(11, 69);
            editPanel.Margin = new Padding(2);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(592, 30);
            editPanel.TabIndex = 16;
            editPanel.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(2, 5);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 0;
            label3.Text = "Old Name";
            // 
            // oldNameBox
            // 
            oldNameBox.Location = new Point(67, 2);
            oldNameBox.Margin = new Padding(2);
            oldNameBox.Multiline = false;
            oldNameBox.Name = "oldNameBox";
            oldNameBox.Size = new Size(159, 22);
            oldNameBox.TabIndex = 0;
            oldNameBox.Text = "";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(230, 5);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 17;
            label4.Text = "New Name";
            // 
            // newNameBox
            // 
            newNameBox.Location = new Point(300, 2);
            newNameBox.Margin = new Padding(2);
            newNameBox.Multiline = false;
            newNameBox.Name = "newNameBox";
            newNameBox.Size = new Size(159, 22);
            newNameBox.TabIndex = 17;
            newNameBox.Text = "";
            // 
            // editPanelSubmitButton
            // 
            editPanelSubmitButton.Location = new Point(463, 2);
            editPanelSubmitButton.Margin = new Padding(2);
            editPanelSubmitButton.Name = "editPanelSubmitButton";
            editPanelSubmitButton.Size = new Size(56, 22);
            editPanelSubmitButton.TabIndex = 13;
            editPanelSubmitButton.Text = "Submit";
            editPanelSubmitButton.UseVisualStyleBackColor = true;
            editPanelSubmitButton.Click += EditPanelSubmitButton_Click;
            // 
            // editPanelCancelPanel
            // 
            editPanelCancelPanel.Location = new Point(523, 2);
            editPanelCancelPanel.Margin = new Padding(2);
            editPanelCancelPanel.Name = "editPanelCancelPanel";
            editPanelCancelPanel.Size = new Size(56, 22);
            editPanelCancelPanel.TabIndex = 0;
            editPanelCancelPanel.Text = "Cancel";
            editPanelCancelPanel.UseVisualStyleBackColor = true;
            editPanelCancelPanel.Click += EditPanelCancelPanel_Click;
            // 
            // removeFavouritePanel
            // 
            removeFavouritePanel.BackColor = SystemColors.AppWorkspace;
            removeFavouritePanel.Controls.Add(label5);
            removeFavouritePanel.Controls.Add(removeNameBox);
            removeFavouritePanel.Controls.Add(removePanelSubmitButton);
            removeFavouritePanel.Controls.Add(removeFavouriteCancelButton);
            removeFavouritePanel.Location = new Point(11, 67);
            removeFavouritePanel.Margin = new Padding(2);
            removeFavouritePanel.Name = "removeFavouritePanel";
            removeFavouritePanel.Size = new Size(420, 29);
            removeFavouritePanel.TabIndex = 17;
            removeFavouritePanel.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(2, 5);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 0;
            label5.Text = "Remove Name";
            // 
            // removeNameBox
            // 
            removeNameBox.Location = new Point(91, 2);
            removeNameBox.Margin = new Padding(2);
            removeNameBox.Multiline = false;
            removeNameBox.Name = "removeNameBox";
            removeNameBox.Size = new Size(196, 22);
            removeNameBox.TabIndex = 0;
            removeNameBox.Text = "";
            // 
            // removePanelSubmitButton
            // 
            removePanelSubmitButton.Location = new Point(291, 2);
            removePanelSubmitButton.Margin = new Padding(2);
            removePanelSubmitButton.Name = "removePanelSubmitButton";
            removePanelSubmitButton.Size = new Size(56, 22);
            removePanelSubmitButton.TabIndex = 13;
            removePanelSubmitButton.Text = "Submit";
            removePanelSubmitButton.UseVisualStyleBackColor = true;
            removePanelSubmitButton.Click += RemovePanelSubmitButton_Click;
            // 
            // removeFavouriteCancelButton
            // 
            removeFavouriteCancelButton.Location = new Point(351, 2);
            removeFavouriteCancelButton.Margin = new Padding(2);
            removeFavouriteCancelButton.Name = "removeFavouriteCancelButton";
            removeFavouriteCancelButton.Size = new Size(56, 22);
            removeFavouriteCancelButton.TabIndex = 0;
            removeFavouriteCancelButton.Text = "Cancel";
            removeFavouriteCancelButton.UseVisualStyleBackColor = true;
            removeFavouriteCancelButton.Click += RemoveFavouritePanelButton_Click;
            // 
            // setHomePagePanel
            // 
            setHomePagePanel.BackColor = SystemColors.AppWorkspace;
            setHomePagePanel.Controls.Add(label1);
            setHomePagePanel.Controls.Add(setHomePagePanelBox);
            setHomePagePanel.Controls.Add(SubmitSetHomeButton);
            setHomePagePanel.Controls.Add(cancelSetHomePagePanel);
            setHomePagePanel.Controls.Add(flowLayoutPanel1);
            setHomePagePanel.Location = new Point(10, 64);
            setHomePagePanel.Margin = new Padding(2);
            setHomePagePanel.Name = "setHomePagePanel";
            setHomePagePanel.Size = new Size(449, 30);
            setHomePagePanel.TabIndex = 13;
            setHomePagePanel.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(2, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter URL";
            // 
            // setHomePagePanelBox
            // 
            setHomePagePanelBox.Location = new Point(64, 2);
            setHomePagePanelBox.Margin = new Padding(2);
            setHomePagePanelBox.Multiline = false;
            setHomePagePanelBox.Name = "setHomePagePanelBox";
            setHomePagePanelBox.Size = new Size(260, 22);
            setHomePagePanelBox.TabIndex = 0;
            setHomePagePanelBox.Text = "";
            // 
            // SubmitSetHomeButton
            // 
            SubmitSetHomeButton.Location = new Point(328, 2);
            SubmitSetHomeButton.Margin = new Padding(2);
            SubmitSetHomeButton.Name = "SubmitSetHomeButton";
            SubmitSetHomeButton.Size = new Size(56, 22);
            SubmitSetHomeButton.TabIndex = 13;
            SubmitSetHomeButton.Text = "Submit";
            SubmitSetHomeButton.UseVisualStyleBackColor = true;
            SubmitSetHomeButton.Click += SubmitSetHomeButton_Click;
            // 
            // cancelSetHomePagePanel
            // 
            cancelSetHomePagePanel.Location = new Point(388, 2);
            cancelSetHomePagePanel.Margin = new Padding(2);
            cancelSetHomePagePanel.Name = "cancelSetHomePagePanel";
            cancelSetHomePagePanel.Size = new Size(56, 22);
            cancelSetHomePagePanel.TabIndex = 0;
            cancelSetHomePagePanel.Text = "Cancel";
            cancelSetHomePagePanel.UseVisualStyleBackColor = true;
            cancelSetHomePagePanel.Click += CancelSetHomePagePanel_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(2, 28);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(210, 90);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // bulkDownloadPanel
            // 
            bulkDownloadPanel.BackColor = SystemColors.AppWorkspace;
            bulkDownloadPanel.Controls.Add(label6);
            bulkDownloadPanel.Controls.Add(fileNameBox);
            bulkDownloadPanel.Controls.Add(submitBulk);
            bulkDownloadPanel.Controls.Add(defaultDownloadButton);
            bulkDownloadPanel.Controls.Add(bulkDownloadCancelButton);
            bulkDownloadPanel.Location = new Point(10, 64);
            bulkDownloadPanel.Margin = new Padding(2);
            bulkDownloadPanel.Name = "bulkDownloadPanel";
            bulkDownloadPanel.Size = new Size(512, 34);
            bulkDownloadPanel.TabIndex = 23;
            bulkDownloadPanel.Visible = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(2, 6);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 0;
            label6.Text = "File Name";
            // 
            // fileNameBox
            // 
            fileNameBox.Location = new Point(66, 2);
            fileNameBox.Margin = new Padding(2);
            fileNameBox.Multiline = false;
            fileNameBox.Name = "fileNameBox";
            fileNameBox.Size = new Size(196, 22);
            fileNameBox.TabIndex = 0;
            fileNameBox.Text = "";
            // 
            // submitBulk
            // 
            submitBulk.Location = new Point(266, 2);
            submitBulk.Margin = new Padding(2);
            submitBulk.Name = "submitBulk";
            submitBulk.Size = new Size(56, 23);
            submitBulk.TabIndex = 13;
            submitBulk.Text = "Submit";
            submitBulk.UseVisualStyleBackColor = true;
            submitBulk.Click += SubmitBulk_Click;
            // 
            // defaultDownloadButton
            // 
            defaultDownloadButton.Location = new Point(326, 2);
            defaultDownloadButton.Margin = new Padding(2);
            defaultDownloadButton.Name = "defaultDownloadButton";
            defaultDownloadButton.Size = new Size(116, 23);
            defaultDownloadButton.TabIndex = 24;
            defaultDownloadButton.Text = "Default Download";
            defaultDownloadButton.UseVisualStyleBackColor = true;
            defaultDownloadButton.Click += DefaultDownloadButton_Click;
            // 
            // bulkDownloadCancelButton
            // 
            bulkDownloadCancelButton.Location = new Point(446, 2);
            bulkDownloadCancelButton.Margin = new Padding(2);
            bulkDownloadCancelButton.Name = "bulkDownloadCancelButton";
            bulkDownloadCancelButton.Size = new Size(56, 22);
            bulkDownloadCancelButton.TabIndex = 0;
            bulkDownloadCancelButton.Text = "Cancel";
            bulkDownloadCancelButton.UseVisualStyleBackColor = true;
            bulkDownloadCancelButton.Click += BulkDownloadCancelButton_Click;
            // 
            // favouritesPanel
            // 
            favouritesPanel.BackColor = SystemColors.AppWorkspace;
            favouritesPanel.Controls.Add(label2);
            favouritesPanel.Controls.Add(favouritesNameBox);
            favouritesPanel.Controls.Add(addButtonFavourites);
            favouritesPanel.Controls.Add(editFavouritesButton);
            favouritesPanel.Controls.Add(removeFavouriteButton);
            favouritesPanel.Location = new Point(11, 68);
            favouritesPanel.Margin = new Padding(2);
            favouritesPanel.Name = "favouritesPanel";
            favouritesPanel.Size = new Size(494, 30);
            favouritesPanel.TabIndex = 14;
            favouritesPanel.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(2, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // favouritesNameBox
            // 
            favouritesNameBox.Location = new Point(45, 2);
            favouritesNameBox.Margin = new Padding(2);
            favouritesNameBox.Multiline = false;
            favouritesNameBox.Name = "favouritesNameBox";
            favouritesNameBox.Size = new Size(260, 22);
            favouritesNameBox.TabIndex = 0;
            favouritesNameBox.Text = "";
            // 
            // addButtonFavourites
            // 
            addButtonFavourites.Location = new Point(309, 2);
            addButtonFavourites.Margin = new Padding(2);
            addButtonFavourites.Name = "addButtonFavourites";
            addButtonFavourites.Size = new Size(56, 22);
            addButtonFavourites.TabIndex = 13;
            addButtonFavourites.Text = "Add";
            addButtonFavourites.UseVisualStyleBackColor = true;
            addButtonFavourites.Click += AddButtonFavourites_Click;
            // 
            // editFavouritesButton
            // 
            editFavouritesButton.Location = new Point(369, 2);
            editFavouritesButton.Margin = new Padding(2);
            editFavouritesButton.Name = "editFavouritesButton";
            editFavouritesButton.Size = new Size(56, 22);
            editFavouritesButton.TabIndex = 0;
            editFavouritesButton.Text = "Edit";
            editFavouritesButton.UseVisualStyleBackColor = true;
            editFavouritesButton.Click += EditFavouritesButton_Click;
            // 
            // removeFavouriteButton
            // 
            removeFavouriteButton.Location = new Point(429, 2);
            removeFavouriteButton.Margin = new Padding(2);
            removeFavouriteButton.Name = "removeFavouriteButton";
            removeFavouriteButton.Size = new Size(60, 22);
            removeFavouriteButton.TabIndex = 15;
            removeFavouriteButton.Text = "Remove";
            removeFavouriteButton.UseVisualStyleBackColor = true;
            removeFavouriteButton.Click += RemoveFavouriteButton_Click;
            // 
            // favouritesListPanel
            // 
            favouritesListPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            favouritesListPanel.AutoScroll = true;
            favouritesListPanel.BackColor = SystemColors.Control;
            favouritesListPanel.Controls.Add(closeFavouriteList);
            favouritesListPanel.Location = new Point(1071, 67);
            favouritesListPanel.Margin = new Padding(2);
            favouritesListPanel.Name = "favouritesListPanel";
            favouritesListPanel.Size = new Size(211, 127);
            favouritesListPanel.TabIndex = 15;
            favouritesListPanel.Visible = false;
            // 
            // closeFavouriteList
            // 
            closeFavouriteList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeFavouriteList.AutoSize = true;
            closeFavouriteList.BackColor = SystemColors.AppWorkspace;
            closeFavouriteList.Location = new Point(2, 2);
            closeFavouriteList.Margin = new Padding(2);
            closeFavouriteList.Name = "closeFavouriteList";
            closeFavouriteList.Size = new Size(130, 30);
            closeFavouriteList.TabIndex = 0;
            closeFavouriteList.Text = "Close";
            closeFavouriteList.UseVisualStyleBackColor = false;
            closeFavouriteList.Click += CloseFavouriteList_Click;
            // 
            // historyMorePanelButton
            // 
            historyMorePanelButton.Location = new Point(2, 2);
            historyMorePanelButton.Margin = new Padding(2);
            historyMorePanelButton.Name = "historyMorePanelButton";
            historyMorePanelButton.Size = new Size(124, 23);
            historyMorePanelButton.TabIndex = 0;
            historyMorePanelButton.Text = "History";
            historyMorePanelButton.UseVisualStyleBackColor = true;
            historyMorePanelButton.Click += HistoryMorePanelButton_Click;
            // 
            // morePanel
            // 
            morePanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            morePanel.BackColor = SystemColors.AppWorkspace;
            morePanel.Controls.Add(historyMorePanelButton);
            morePanel.Controls.Add(favouriteMorePanelButton);
            morePanel.Controls.Add(bulkDownloadMorePanelButton);
            morePanel.Location = new Point(1154, 67);
            morePanel.Margin = new Padding(2);
            morePanel.Name = "morePanel";
            morePanel.Size = new Size(128, 77);
            morePanel.TabIndex = 20;
            morePanel.Visible = false;
            // 
            // favouriteMorePanelButton
            // 
            favouriteMorePanelButton.Location = new Point(2, 29);
            favouriteMorePanelButton.Margin = new Padding(2);
            favouriteMorePanelButton.Name = "favouriteMorePanelButton";
            favouriteMorePanelButton.Size = new Size(124, 21);
            favouriteMorePanelButton.TabIndex = 0;
            favouriteMorePanelButton.Text = "Favourites List";
            favouriteMorePanelButton.UseVisualStyleBackColor = true;
            favouriteMorePanelButton.Click += FavouriteMorePanelButton_Click;
            // 
            // bulkDownloadMorePanelButton
            // 
            bulkDownloadMorePanelButton.Location = new Point(2, 54);
            bulkDownloadMorePanelButton.Margin = new Padding(2);
            bulkDownloadMorePanelButton.Name = "bulkDownloadMorePanelButton";
            bulkDownloadMorePanelButton.Size = new Size(124, 21);
            bulkDownloadMorePanelButton.TabIndex = 22;
            bulkDownloadMorePanelButton.Text = "Bulk Download";
            bulkDownloadMorePanelButton.UseVisualStyleBackColor = true;
            bulkDownloadMorePanelButton.Click += BulkDownloadMorePanelButton_Click;
            // 
            // closeHistoryButton
            // 
            closeHistoryButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeHistoryButton.AutoSize = true;
            closeHistoryButton.BackColor = SystemColors.AppWorkspace;
            closeHistoryButton.Location = new Point(2, 2);
            closeHistoryButton.Margin = new Padding(2);
            closeHistoryButton.Name = "closeHistoryButton";
            closeHistoryButton.Size = new Size(130, 30);
            closeHistoryButton.TabIndex = 0;
            closeHistoryButton.Text = "Close";
            closeHistoryButton.UseMnemonic = false;
            closeHistoryButton.UseVisualStyleBackColor = false;
            closeHistoryButton.Click += CloseHistoryButton_Click;
            // 
            // historyPanel
            // 
            historyPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            historyPanel.AutoScroll = true;
            historyPanel.BackColor = SystemColors.Control;
            historyPanel.Controls.Add(closeHistoryButton);
            historyPanel.Location = new Point(1071, 67);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(211, 127);
            historyPanel.TabIndex = 24;
            historyPanel.Visible = false;
            // 
            // WebBrowser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 638);
            Controls.Add(editPanel);
            Controls.Add(removeFavouritePanel);
            Controls.Add(bulkDownloadPanel);
            Controls.Add(historyPanel);
            Controls.Add(favouritesListPanel);
            Controls.Add(setHomePagePanel);
            Controls.Add(morePanel);
            Controls.Add(favouritesPanel);
            Controls.Add(homePagePanel);
            Controls.Add(statusCodeLabel);
            Controls.Add(htmlContentBox);
            Controls.Add(moreButton);
            Controls.Add(favouriteButton);
            Controls.Add(searchButton);
            Controls.Add(searchBox);
            Controls.Add(homeButton);
            Controls.Add(refreshButton);
            Controls.Add(forwardButton);
            Controls.Add(backButton);
            Controls.Add(pageTitleLabel);
            Name = "WebBrowser";
            Text = "Web Browser";
            homePagePanel.ResumeLayout(false);
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            removeFavouritePanel.ResumeLayout(false);
            removeFavouritePanel.PerformLayout();
            setHomePagePanel.ResumeLayout(false);
            setHomePagePanel.PerformLayout();
            bulkDownloadPanel.ResumeLayout(false);
            bulkDownloadPanel.PerformLayout();
            favouritesPanel.ResumeLayout(false);
            favouritesPanel.PerformLayout();
            favouritesListPanel.ResumeLayout(false);
            favouritesListPanel.PerformLayout();
            morePanel.ResumeLayout(false);
            historyPanel.ResumeLayout(false);
            historyPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageTitleLabel;
        private Button backButton;
        private Button forwardButton;
        private Button refreshButton;
        private Button homeButton;
        private RichTextBox searchBox;
        private Button searchButton;
        private Button favouriteButton;
        private Button moreButton;
        private RichTextBox htmlContentBox;
        private Label statusCodeLabel;
        private FlowLayoutPanel homePagePanel;
        private Button homePageButton;
        private Button setHomePageButton;
        private FlowLayoutPanel setHomePagePanel;
        private Label label1;
        private Button cancelSetHomePagePanel;
        private Button SubmitSetHomeButton;
        private RichTextBox setHomePagePanelBox;
        private FlowLayoutPanel favouritesPanel;
        private Label label2;
        private RichTextBox favouritesNameBox;
        private Button addButtonFavourites;
        private Button editFavouritesButton;
        private Button removeFavouriteButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel editPanel;
        private Label label3;
        private RichTextBox oldNameBox;
        private Button editPanelSubmitButton;
        private Button editPanelCancelPanel;
        private Label label4;
        private RichTextBox newNameBox;
        private FlowLayoutPanel removeFavouritePanel;
        private Label label5;
        private RichTextBox removeNameBox;
        private Button removePanelSubmitButton;
        private Button removeFavouriteCancelButton;

        private FlowLayoutPanel favouritesListPanel;
        private Button historyMorePanelButton;
        private FlowLayoutPanel morePanel;
        private Button favouriteMorePanelButton;
        private Button bulkDownloadMorePanelButton;
        private Button closeFavouriteList;
        private Button closeHistoryButton;
        private FlowLayoutPanel bulkDownloadPanel;
        private Label label6;
        private RichTextBox fileNameBox;
        private Button submitBulk;
        private Button bulkDownloadCancelButton;
        private Button defaultDownloadButton;
        private FlowLayoutPanel historyPanel;
    }
}
