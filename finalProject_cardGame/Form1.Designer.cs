namespace finalProject_cardGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbGameSettings = new System.Windows.Forms.GroupBox();
            this.pnlFavoritePlayers = new System.Windows.Forms.Panel();
            this.btnUseFavPlayer = new System.Windows.Forms.Button();
            this.rbtnSavedPlayers = new System.Windows.Forms.RadioButton();
            this.nudMaxHP = new System.Windows.Forms.NumericUpDown();
            this.pnlCreatePlayers = new System.Windows.Forms.Panel();
            this.btnCreatePlayers = new System.Windows.Forms.Button();
            this.lblNumberOfPlayers = new System.Windows.Forms.Label();
            this.cboxNumberOfPlayers = new System.Windows.Forms.ComboBox();
            this.rbtnNewPlayers = new System.Windows.Forms.RadioButton();
            this.lblMaxHP = new System.Windows.Forms.Label();
            this.chbUseMagic = new System.Windows.Forms.CheckBox();
            this.chbUseJoker = new System.Windows.Forms.CheckBox();
            this.grbPlayers = new System.Windows.Forms.GroupBox();
            this.chbSaveAsFavPlayers = new System.Windows.Forms.CheckBox();
            this.lblRemainingPlayers = new System.Windows.Forms.Label();
            this.lvRemainingPlayers = new System.Windows.Forms.ListView();
            this.playerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.draws = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imglAvatars = new System.Windows.Forms.ImageList(this.components);
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.pbAvatars = new System.Windows.Forms.PictureBox();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.txtbNameOfPlayer = new System.Windows.Forms.TextBox();
            this.lblNameOfPlayer = new System.Windows.Forms.Label();
            this.grbRound = new System.Windows.Forms.GroupBox();
            this.lblP1Card = new System.Windows.Forms.Label();
            this.lblP2Card = new System.Windows.Forms.Label();
            this.pnlRemainingP2Cards = new System.Windows.Forms.Panel();
            this.pbPlayer2Deck = new System.Windows.Forms.PictureBox();
            this.pnlRemainingP1Cards = new System.Windows.Forms.Panel();
            this.pbPlayer1Deck = new System.Windows.Forms.PictureBox();
            this.lblWinLoseMsg = new System.Windows.Forms.Label();
            this.lblPlayer2HP = new System.Windows.Forms.Label();
            this.lblPlayer1HP = new System.Windows.Forms.Label();
            this.pbDrawPile = new System.Windows.Forms.PictureBox();
            this.pgbPlayer2HP = new System.Windows.Forms.ProgressBar();
            this.pgbPlayer1HP = new System.Windows.Forms.ProgressBar();
            this.pbPlayer2Avatar = new System.Windows.Forms.PictureBox();
            this.pbPlayer1Avatar = new System.Windows.Forms.PictureBox();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.btnDrawCards = new System.Windows.Forms.Button();
            this.pnlRemainingDrawCards = new System.Windows.Forms.Panel();
            this.imglCards = new System.Windows.Forms.ImageList(this.components);
            this.grbGameSettings.SuspendLayout();
            this.pnlFavoritePlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHP)).BeginInit();
            this.pnlCreatePlayers.SuspendLayout();
            this.grbPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatars)).BeginInit();
            this.grbRound.SuspendLayout();
            this.pnlRemainingP2Cards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2Deck)).BeginInit();
            this.pnlRemainingP1Cards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Deck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawPile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // grbGameSettings
            // 
            this.grbGameSettings.Controls.Add(this.pnlFavoritePlayers);
            this.grbGameSettings.Controls.Add(this.rbtnSavedPlayers);
            this.grbGameSettings.Controls.Add(this.nudMaxHP);
            this.grbGameSettings.Controls.Add(this.pnlCreatePlayers);
            this.grbGameSettings.Controls.Add(this.rbtnNewPlayers);
            this.grbGameSettings.Controls.Add(this.lblMaxHP);
            this.grbGameSettings.Controls.Add(this.chbUseMagic);
            this.grbGameSettings.Controls.Add(this.chbUseJoker);
            this.grbGameSettings.Location = new System.Drawing.Point(17, 13);
            this.grbGameSettings.Name = "grbGameSettings";
            this.grbGameSettings.Size = new System.Drawing.Size(762, 148);
            this.grbGameSettings.TabIndex = 0;
            this.grbGameSettings.TabStop = false;
            this.grbGameSettings.Text = "Game settings";
            // 
            // pnlFavoritePlayers
            // 
            this.pnlFavoritePlayers.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlFavoritePlayers.Controls.Add(this.btnUseFavPlayer);
            this.pnlFavoritePlayers.Enabled = false;
            this.pnlFavoritePlayers.Location = new System.Drawing.Point(356, 83);
            this.pnlFavoritePlayers.Name = "pnlFavoritePlayers";
            this.pnlFavoritePlayers.Size = new System.Drawing.Size(380, 43);
            this.pnlFavoritePlayers.TabIndex = 8;
            // 
            // btnUseFavPlayer
            // 
            this.btnUseFavPlayer.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnUseFavPlayer.Location = new System.Drawing.Point(212, 6);
            this.btnUseFavPlayer.Name = "btnUseFavPlayer";
            this.btnUseFavPlayer.Size = new System.Drawing.Size(158, 30);
            this.btnUseFavPlayer.TabIndex = 8;
            this.btnUseFavPlayer.Text = "Use favorite players";
            this.btnUseFavPlayer.UseVisualStyleBackColor = true;
            this.btnUseFavPlayer.Click += new System.EventHandler(this.btnUseFavPlayer_Click);
            // 
            // rbtnSavedPlayers
            // 
            this.rbtnSavedPlayers.AutoSize = true;
            this.rbtnSavedPlayers.Location = new System.Drawing.Point(216, 96);
            this.rbtnSavedPlayers.Name = "rbtnSavedPlayers";
            this.rbtnSavedPlayers.Size = new System.Drawing.Size(122, 19);
            this.rbtnSavedPlayers.TabIndex = 5;
            this.rbtnSavedPlayers.TabStop = true;
            this.rbtnSavedPlayers.Text = "Saved players";
            this.rbtnSavedPlayers.UseVisualStyleBackColor = true;
            this.rbtnSavedPlayers.CheckedChanged += new System.EventHandler(this.rbtnSavedPlayers_CheckedChanged);
            // 
            // nudMaxHP
            // 
            this.nudMaxHP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMaxHP.Location = new System.Drawing.Point(23, 102);
            this.nudMaxHP.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudMaxHP.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMaxHP.Name = "nudMaxHP";
            this.nudMaxHP.Size = new System.Drawing.Size(43, 25);
            this.nudMaxHP.TabIndex = 3;
            this.nudMaxHP.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // pnlCreatePlayers
            // 
            this.pnlCreatePlayers.BackColor = System.Drawing.Color.Aquamarine;
            this.pnlCreatePlayers.Controls.Add(this.btnCreatePlayers);
            this.pnlCreatePlayers.Controls.Add(this.lblNumberOfPlayers);
            this.pnlCreatePlayers.Controls.Add(this.cboxNumberOfPlayers);
            this.pnlCreatePlayers.Enabled = false;
            this.pnlCreatePlayers.ForeColor = System.Drawing.SystemColors.Window;
            this.pnlCreatePlayers.Location = new System.Drawing.Point(356, 28);
            this.pnlCreatePlayers.Name = "pnlCreatePlayers";
            this.pnlCreatePlayers.Size = new System.Drawing.Size(381, 43);
            this.pnlCreatePlayers.TabIndex = 5;
            // 
            // btnCreatePlayers
            // 
            this.btnCreatePlayers.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCreatePlayers.Location = new System.Drawing.Point(251, 8);
            this.btnCreatePlayers.Name = "btnCreatePlayers";
            this.btnCreatePlayers.Size = new System.Drawing.Size(119, 30);
            this.btnCreatePlayers.TabIndex = 7;
            this.btnCreatePlayers.Text = "Create players";
            this.btnCreatePlayers.UseVisualStyleBackColor = true;
            this.btnCreatePlayers.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // lblNumberOfPlayers
            // 
            this.lblNumberOfPlayers.AutoSize = true;
            this.lblNumberOfPlayers.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblNumberOfPlayers.Location = new System.Drawing.Point(10, 14);
            this.lblNumberOfPlayers.Name = "lblNumberOfPlayers";
            this.lblNumberOfPlayers.Size = new System.Drawing.Size(130, 15);
            this.lblNumberOfPlayers.TabIndex = 1;
            this.lblNumberOfPlayers.Text = "Number of players:";
            // 
            // cboxNumberOfPlayers
            // 
            this.cboxNumberOfPlayers.FormattingEnabled = true;
            this.cboxNumberOfPlayers.ItemHeight = 15;
            this.cboxNumberOfPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboxNumberOfPlayers.Location = new System.Drawing.Point(143, 10);
            this.cboxNumberOfPlayers.Name = "cboxNumberOfPlayers";
            this.cboxNumberOfPlayers.Size = new System.Drawing.Size(44, 23);
            this.cboxNumberOfPlayers.TabIndex = 0;
            // 
            // rbtnNewPlayers
            // 
            this.rbtnNewPlayers.AutoSize = true;
            this.rbtnNewPlayers.Location = new System.Drawing.Point(216, 42);
            this.rbtnNewPlayers.Name = "rbtnNewPlayers";
            this.rbtnNewPlayers.Size = new System.Drawing.Size(107, 19);
            this.rbtnNewPlayers.TabIndex = 4;
            this.rbtnNewPlayers.TabStop = true;
            this.rbtnNewPlayers.Text = "New players";
            this.rbtnNewPlayers.UseVisualStyleBackColor = true;
            this.rbtnNewPlayers.CheckedChanged += new System.EventHandler(this.rbtnNewPlayers_CheckedChanged);
            // 
            // lblMaxHP
            // 
            this.lblMaxHP.AutoSize = true;
            this.lblMaxHP.Location = new System.Drawing.Point(73, 107);
            this.lblMaxHP.Name = "lblMaxHP";
            this.lblMaxHP.Size = new System.Drawing.Size(61, 15);
            this.lblMaxHP.TabIndex = 3;
            this.lblMaxHP.Text = "Max HP";
            // 
            // chbUseMagic
            // 
            this.chbUseMagic.AutoSize = true;
            this.chbUseMagic.Location = new System.Drawing.Point(23, 68);
            this.chbUseMagic.Name = "chbUseMagic";
            this.chbUseMagic.Size = new System.Drawing.Size(98, 19);
            this.chbUseMagic.TabIndex = 2;
            this.chbUseMagic.Text = "Use magic";
            this.chbUseMagic.UseVisualStyleBackColor = true;
            // 
            // chbUseJoker
            // 
            this.chbUseJoker.AutoSize = true;
            this.chbUseJoker.Location = new System.Drawing.Point(23, 34);
            this.chbUseJoker.Name = "chbUseJoker";
            this.chbUseJoker.Size = new System.Drawing.Size(99, 19);
            this.chbUseJoker.TabIndex = 1;
            this.chbUseJoker.Text = "Use jokers";
            this.chbUseJoker.UseVisualStyleBackColor = true;
            // 
            // grbPlayers
            // 
            this.grbPlayers.Controls.Add(this.chbSaveAsFavPlayers);
            this.grbPlayers.Controls.Add(this.lblRemainingPlayers);
            this.grbPlayers.Controls.Add(this.lvRemainingPlayers);
            this.grbPlayers.Controls.Add(this.btnAddPlayer);
            this.grbPlayers.Controls.Add(this.pbAvatars);
            this.grbPlayers.Controls.Add(this.lblAvatar);
            this.grbPlayers.Controls.Add(this.txtbNameOfPlayer);
            this.grbPlayers.Controls.Add(this.lblNameOfPlayer);
            this.grbPlayers.Location = new System.Drawing.Point(17, 177);
            this.grbPlayers.Name = "grbPlayers";
            this.grbPlayers.Size = new System.Drawing.Size(761, 281);
            this.grbPlayers.TabIndex = 9;
            this.grbPlayers.TabStop = false;
            this.grbPlayers.Text = "Players";
            // 
            // chbSaveAsFavPlayers
            // 
            this.chbSaveAsFavPlayers.AutoSize = true;
            this.chbSaveAsFavPlayers.Enabled = false;
            this.chbSaveAsFavPlayers.Location = new System.Drawing.Point(542, 78);
            this.chbSaveAsFavPlayers.Name = "chbSaveAsFavPlayers";
            this.chbSaveAsFavPlayers.Size = new System.Drawing.Size(189, 19);
            this.chbSaveAsFavPlayers.TabIndex = 13;
            this.chbSaveAsFavPlayers.Text = "Save as favorite players";
            this.chbSaveAsFavPlayers.UseVisualStyleBackColor = true;
            // 
            // lblRemainingPlayers
            // 
            this.lblRemainingPlayers.AutoSize = true;
            this.lblRemainingPlayers.Location = new System.Drawing.Point(20, 102);
            this.lblRemainingPlayers.Name = "lblRemainingPlayers";
            this.lblRemainingPlayers.Size = new System.Drawing.Size(131, 15);
            this.lblRemainingPlayers.TabIndex = 6;
            this.lblRemainingPlayers.Text = "Remaining players:";
            // 
            // lvRemainingPlayers
            // 
            this.lvRemainingPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerName,
            this.HP,
            this.wins,
            this.draws,
            this.loses});
            this.lvRemainingPlayers.HideSelection = false;
            this.lvRemainingPlayers.Location = new System.Drawing.Point(23, 125);
            this.lvRemainingPlayers.Name = "lvRemainingPlayers";
            this.lvRemainingPlayers.Size = new System.Drawing.Size(714, 133);
            this.lvRemainingPlayers.SmallImageList = this.imglAvatars;
            this.lvRemainingPlayers.TabIndex = 12;
            this.lvRemainingPlayers.UseCompatibleStateImageBehavior = false;
            this.lvRemainingPlayers.View = System.Windows.Forms.View.Details;
            // 
            // playerName
            // 
            this.playerName.Text = "Player name";
            this.playerName.Width = 154;
            // 
            // HP
            // 
            this.HP.Text = "HP";
            this.HP.Width = 80;
            // 
            // wins
            // 
            this.wins.Text = "Wins";
            this.wins.Width = 87;
            // 
            // draws
            // 
            this.draws.Text = "Draws";
            this.draws.Width = 94;
            // 
            // loses
            // 
            this.loses.Text = "Loses";
            this.loses.Width = 99;
            // 
            // imglAvatars
            // 
            this.imglAvatars.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglAvatars.ImageStream")));
            this.imglAvatars.TransparentColor = System.Drawing.Color.Transparent;
            this.imglAvatars.Images.SetKeyName(0, "mk.jpg");
            this.imglAvatars.Images.SetKeyName(1, "rj.jpg");
            this.imglAvatars.Images.SetKeyName(2, "js.jpg");
            this.imglAvatars.Images.SetKeyName(3, "jn.jpg");
            this.imglAvatars.Images.SetKeyName(4, "jm.jpg");
            this.imglAvatars.Images.SetKeyName(5, "hc.jpg");
            this.imglAvatars.Images.SetKeyName(6, "cl.jpg");
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Enabled = false;
            this.btnAddPlayer.Location = new System.Drawing.Point(612, 24);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(125, 48);
            this.btnAddPlayer.TabIndex = 11;
            this.btnAddPlayer.Text = "Add player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // pbAvatars
            // 
            this.pbAvatars.Image = global::finalProject_cardGame.Properties.Resources.rj;
            this.pbAvatars.Location = new System.Drawing.Point(427, 24);
            this.pbAvatars.Name = "pbAvatars";
            this.pbAvatars.Size = new System.Drawing.Size(77, 77);
            this.pbAvatars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatars.TabIndex = 3;
            this.pbAvatars.TabStop = false;
            this.pbAvatars.Click += new System.EventHandler(this.picbAvatars_Click);
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Location = new System.Drawing.Point(365, 40);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(53, 15);
            this.lblAvatar.TabIndex = 2;
            this.lblAvatar.Text = "Avatar:";
            // 
            // txtbNameOfPlayer
            // 
            this.txtbNameOfPlayer.Enabled = false;
            this.txtbNameOfPlayer.Location = new System.Drawing.Point(160, 35);
            this.txtbNameOfPlayer.Name = "txtbNameOfPlayer";
            this.txtbNameOfPlayer.Size = new System.Drawing.Size(184, 25);
            this.txtbNameOfPlayer.TabIndex = 10;
            // 
            // lblNameOfPlayer
            // 
            this.lblNameOfPlayer.AutoSize = true;
            this.lblNameOfPlayer.Location = new System.Drawing.Point(30, 40);
            this.lblNameOfPlayer.Name = "lblNameOfPlayer";
            this.lblNameOfPlayer.Size = new System.Drawing.Size(123, 15);
            this.lblNameOfPlayer.TabIndex = 10;
            this.lblNameOfPlayer.Text = "Name of player 1:";
            // 
            // grbRound
            // 
            this.grbRound.Controls.Add(this.lblP1Card);
            this.grbRound.Controls.Add(this.lblP2Card);
            this.grbRound.Controls.Add(this.pnlRemainingP2Cards);
            this.grbRound.Controls.Add(this.pnlRemainingP1Cards);
            this.grbRound.Controls.Add(this.lblWinLoseMsg);
            this.grbRound.Controls.Add(this.lblPlayer2HP);
            this.grbRound.Controls.Add(this.lblPlayer1HP);
            this.grbRound.Controls.Add(this.pbDrawPile);
            this.grbRound.Controls.Add(this.pgbPlayer2HP);
            this.grbRound.Controls.Add(this.pgbPlayer1HP);
            this.grbRound.Controls.Add(this.pbPlayer2Avatar);
            this.grbRound.Controls.Add(this.pbPlayer1Avatar);
            this.grbRound.Controls.Add(this.lblPlayer2Name);
            this.grbRound.Controls.Add(this.lblPlayer1Name);
            this.grbRound.Controls.Add(this.btnDrawCards);
            this.grbRound.Controls.Add(this.pnlRemainingDrawCards);
            this.grbRound.Enabled = false;
            this.grbRound.Location = new System.Drawing.Point(17, 477);
            this.grbRound.Name = "grbRound";
            this.grbRound.Size = new System.Drawing.Size(760, 350);
            this.grbRound.TabIndex = 13;
            this.grbRound.TabStop = false;
            this.grbRound.Text = "Round";
            // 
            // lblP1Card
            // 
            this.lblP1Card.AutoSize = true;
            this.lblP1Card.Location = new System.Drawing.Point(167, 217);
            this.lblP1Card.Name = "lblP1Card";
            this.lblP1Card.Size = new System.Drawing.Size(22, 15);
            this.lblP1Card.TabIndex = 10;
            this.lblP1Card.Text = "...";
            // 
            // lblP2Card
            // 
            this.lblP2Card.AutoSize = true;
            this.lblP2Card.Location = new System.Drawing.Point(468, 217);
            this.lblP2Card.Name = "lblP2Card";
            this.lblP2Card.Size = new System.Drawing.Size(22, 15);
            this.lblP2Card.TabIndex = 11;
            this.lblP2Card.Text = "...";
            // 
            // pnlRemainingP2Cards
            // 
            this.pnlRemainingP2Cards.BackColor = System.Drawing.Color.DimGray;
            this.pnlRemainingP2Cards.Controls.Add(this.pbPlayer2Deck);
            this.pnlRemainingP2Cards.Location = new System.Drawing.Point(471, 46);
            this.pnlRemainingP2Cards.Name = "pnlRemainingP2Cards";
            this.pnlRemainingP2Cards.Size = new System.Drawing.Size(120, 165);
            this.pnlRemainingP2Cards.TabIndex = 4;
            // 
            // pbPlayer2Deck
            // 
            this.pbPlayer2Deck.BackColor = System.Drawing.SystemColors.Control;
            this.pbPlayer2Deck.Location = new System.Drawing.Point(0, 0);
            this.pbPlayer2Deck.Name = "pbPlayer2Deck";
            this.pbPlayer2Deck.Size = new System.Drawing.Size(120, 165);
            this.pbPlayer2Deck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer2Deck.TabIndex = 9;
            this.pbPlayer2Deck.TabStop = false;
            // 
            // pnlRemainingP1Cards
            // 
            this.pnlRemainingP1Cards.BackColor = System.Drawing.Color.DimGray;
            this.pnlRemainingP1Cards.Controls.Add(this.pbPlayer1Deck);
            this.pnlRemainingP1Cards.Location = new System.Drawing.Point(170, 46);
            this.pnlRemainingP1Cards.Name = "pnlRemainingP1Cards";
            this.pnlRemainingP1Cards.Size = new System.Drawing.Size(120, 165);
            this.pnlRemainingP1Cards.TabIndex = 4;
            // 
            // pbPlayer1Deck
            // 
            this.pbPlayer1Deck.BackColor = System.Drawing.SystemColors.Control;
            this.pbPlayer1Deck.Location = new System.Drawing.Point(0, 0);
            this.pbPlayer1Deck.Name = "pbPlayer1Deck";
            this.pbPlayer1Deck.Size = new System.Drawing.Size(120, 165);
            this.pbPlayer1Deck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer1Deck.TabIndex = 8;
            this.pbPlayer1Deck.TabStop = false;
            // 
            // lblWinLoseMsg
            // 
            this.lblWinLoseMsg.AutoSize = true;
            this.lblWinLoseMsg.Font = new System.Drawing.Font("Gulim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWinLoseMsg.Location = new System.Drawing.Point(167, 295);
            this.lblWinLoseMsg.Name = "lblWinLoseMsg";
            this.lblWinLoseMsg.Size = new System.Drawing.Size(26, 18);
            this.lblWinLoseMsg.TabIndex = 14;
            this.lblWinLoseMsg.Text = "...";
            // 
            // lblPlayer2HP
            // 
            this.lblPlayer2HP.AutoSize = true;
            this.lblPlayer2HP.Location = new System.Drawing.Point(604, 196);
            this.lblPlayer2HP.Name = "lblPlayer2HP";
            this.lblPlayer2HP.Size = new System.Drawing.Size(15, 15);
            this.lblPlayer2HP.TabIndex = 13;
            this.lblPlayer2HP.Text = "0";
            // 
            // lblPlayer1HP
            // 
            this.lblPlayer1HP.AutoSize = true;
            this.lblPlayer1HP.Location = new System.Drawing.Point(30, 196);
            this.lblPlayer1HP.Name = "lblPlayer1HP";
            this.lblPlayer1HP.Size = new System.Drawing.Size(15, 15);
            this.lblPlayer1HP.TabIndex = 12;
            this.lblPlayer1HP.Text = "0";
            // 
            // pbDrawPile
            // 
            this.pbDrawPile.Image = ((System.Drawing.Image)(resources.GetObject("pbDrawPile.Image")));
            this.pbDrawPile.Location = new System.Drawing.Point(322, 35);
            this.pbDrawPile.Name = "pbDrawPile";
            this.pbDrawPile.Size = new System.Drawing.Size(120, 165);
            this.pbDrawPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDrawPile.TabIndex = 7;
            this.pbDrawPile.TabStop = false;
            // 
            // pgbPlayer2HP
            // 
            this.pgbPlayer2HP.Location = new System.Drawing.Point(607, 186);
            this.pgbPlayer2HP.Name = "pgbPlayer2HP";
            this.pgbPlayer2HP.Size = new System.Drawing.Size(119, 25);
            this.pgbPlayer2HP.Step = 1;
            this.pgbPlayer2HP.TabIndex = 6;
            // 
            // pgbPlayer1HP
            // 
            this.pgbPlayer1HP.Location = new System.Drawing.Point(32, 186);
            this.pgbPlayer1HP.Name = "pgbPlayer1HP";
            this.pgbPlayer1HP.Size = new System.Drawing.Size(119, 25);
            this.pgbPlayer1HP.Step = 1;
            this.pgbPlayer1HP.TabIndex = 5;
            // 
            // pbPlayer2Avatar
            // 
            this.pbPlayer2Avatar.Location = new System.Drawing.Point(607, 60);
            this.pbPlayer2Avatar.Name = "pbPlayer2Avatar";
            this.pbPlayer2Avatar.Size = new System.Drawing.Size(120, 120);
            this.pbPlayer2Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer2Avatar.TabIndex = 4;
            this.pbPlayer2Avatar.TabStop = false;
            // 
            // pbPlayer1Avatar
            // 
            this.pbPlayer1Avatar.Location = new System.Drawing.Point(32, 60);
            this.pbPlayer1Avatar.Name = "pbPlayer1Avatar";
            this.pbPlayer1Avatar.Size = new System.Drawing.Size(120, 120);
            this.pbPlayer1Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer1Avatar.TabIndex = 3;
            this.pbPlayer1Avatar.TabStop = false;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(604, 35);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(54, 15);
            this.lblPlayer2Name.TabIndex = 2;
            this.lblPlayer2Name.Text = "player2";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(30, 35);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(54, 15);
            this.lblPlayer1Name.TabIndex = 1;
            this.lblPlayer1Name.Text = "player1";
            // 
            // btnDrawCards
            // 
            this.btnDrawCards.Location = new System.Drawing.Point(23, 278);
            this.btnDrawCards.Name = "btnDrawCards";
            this.btnDrawCards.Size = new System.Drawing.Size(128, 53);
            this.btnDrawCards.TabIndex = 14;
            this.btnDrawCards.Text = "Draw cards";
            this.btnDrawCards.UseVisualStyleBackColor = true;
            this.btnDrawCards.Click += new System.EventHandler(this.btnDrawCards_Click);
            // 
            // pnlRemainingDrawCards
            // 
            this.pnlRemainingDrawCards.BackColor = System.Drawing.Color.DimGray;
            this.pnlRemainingDrawCards.Location = new System.Drawing.Point(322, 35);
            this.pnlRemainingDrawCards.Name = "pnlRemainingDrawCards";
            this.pnlRemainingDrawCards.Size = new System.Drawing.Size(120, 165);
            this.pnlRemainingDrawCards.TabIndex = 3;
            // 
            // imglCards
            // 
            this.imglCards.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglCards.ImageStream")));
            this.imglCards.TransparentColor = System.Drawing.Color.Transparent;
            this.imglCards.Images.SetKeyName(0, "hA.svg.png");
            this.imglCards.Images.SetKeyName(1, "h2.svg.png");
            this.imglCards.Images.SetKeyName(2, "h3.svg.png");
            this.imglCards.Images.SetKeyName(3, "h4.svg.png");
            this.imglCards.Images.SetKeyName(4, "h5.svg.png");
            this.imglCards.Images.SetKeyName(5, "h6.svg.png");
            this.imglCards.Images.SetKeyName(6, "h7.svg.png");
            this.imglCards.Images.SetKeyName(7, "h8.svg.png");
            this.imglCards.Images.SetKeyName(8, "h9.svg.png");
            this.imglCards.Images.SetKeyName(9, "h10.svg.png");
            this.imglCards.Images.SetKeyName(10, "hJ.png");
            this.imglCards.Images.SetKeyName(11, "hQ.svg.png");
            this.imglCards.Images.SetKeyName(12, "hK.svg.png");
            this.imglCards.Images.SetKeyName(13, "dA.svg.png");
            this.imglCards.Images.SetKeyName(14, "d2.svg.png");
            this.imglCards.Images.SetKeyName(15, "d3.svg.png");
            this.imglCards.Images.SetKeyName(16, "d4.svg.png");
            this.imglCards.Images.SetKeyName(17, "d5.svg.png");
            this.imglCards.Images.SetKeyName(18, "d6.svg.png");
            this.imglCards.Images.SetKeyName(19, "d7.svg.png");
            this.imglCards.Images.SetKeyName(20, "d8.svg.png");
            this.imglCards.Images.SetKeyName(21, "d9.svg.png");
            this.imglCards.Images.SetKeyName(22, "d10_-_David_Bellot.svg.png");
            this.imglCards.Images.SetKeyName(23, "dJ.svg.png");
            this.imglCards.Images.SetKeyName(24, "dQ.svg.png");
            this.imglCards.Images.SetKeyName(25, "dK.svg.png");
            this.imglCards.Images.SetKeyName(26, "cA.svg.png");
            this.imglCards.Images.SetKeyName(27, "c2.svg.png");
            this.imglCards.Images.SetKeyName(28, "c3.svg.png");
            this.imglCards.Images.SetKeyName(29, "c4.svg.png");
            this.imglCards.Images.SetKeyName(30, "c5.svg.png");
            this.imglCards.Images.SetKeyName(31, "c6.svg.png");
            this.imglCards.Images.SetKeyName(32, "c7.svg.png");
            this.imglCards.Images.SetKeyName(33, "c8.svg.png");
            this.imglCards.Images.SetKeyName(34, "c9.svg.png");
            this.imglCards.Images.SetKeyName(35, "c10.svg.png");
            this.imglCards.Images.SetKeyName(36, "cJ.svg.png");
            this.imglCards.Images.SetKeyName(37, "cQ.svg.png");
            this.imglCards.Images.SetKeyName(38, "cK.svg.png");
            this.imglCards.Images.SetKeyName(39, "sA.svg.png");
            this.imglCards.Images.SetKeyName(40, "s2.svg.png");
            this.imglCards.Images.SetKeyName(41, "s3.svg.png");
            this.imglCards.Images.SetKeyName(42, "s4.svg.png");
            this.imglCards.Images.SetKeyName(43, "s5.svg.png");
            this.imglCards.Images.SetKeyName(44, "s6.svg.png");
            this.imglCards.Images.SetKeyName(45, "s7.svg.png");
            this.imglCards.Images.SetKeyName(46, "s8.svg.png");
            this.imglCards.Images.SetKeyName(47, "s9.svg.png");
            this.imglCards.Images.SetKeyName(48, "s10.svg.png");
            this.imglCards.Images.SetKeyName(49, "sJ.svg.png");
            this.imglCards.Images.SetKeyName(50, "sQ.svg.png");
            this.imglCards.Images.SetKeyName(51, "sK.svg.png");
            this.imglCards.Images.SetKeyName(52, "J1.jpg");
            this.imglCards.Images.SetKeyName(53, "J2.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 839);
            this.Controls.Add(this.grbRound);
            this.Controls.Add(this.grbPlayers);
            this.Controls.Add(this.grbGameSettings);
            this.Name = "Form1";
            this.Text = "Doyh\'s Fun Card Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbGameSettings.ResumeLayout(false);
            this.grbGameSettings.PerformLayout();
            this.pnlFavoritePlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHP)).EndInit();
            this.pnlCreatePlayers.ResumeLayout(false);
            this.pnlCreatePlayers.PerformLayout();
            this.grbPlayers.ResumeLayout(false);
            this.grbPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatars)).EndInit();
            this.grbRound.ResumeLayout(false);
            this.grbRound.PerformLayout();
            this.pnlRemainingP2Cards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2Deck)).EndInit();
            this.pnlRemainingP1Cards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Deck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawPile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGameSettings;
        private System.Windows.Forms.CheckBox chbUseMagic;
        private System.Windows.Forms.CheckBox chbUseJoker;
        private System.Windows.Forms.NumericUpDown nudMaxHP;
        private System.Windows.Forms.Panel pnlCreatePlayers;
        private System.Windows.Forms.RadioButton rbtnNewPlayers;
        private System.Windows.Forms.Label lblMaxHP;
        private System.Windows.Forms.ComboBox cboxNumberOfPlayers;
        private System.Windows.Forms.Label lblNumberOfPlayers;
        private System.Windows.Forms.Button btnCreatePlayers;
        private System.Windows.Forms.RadioButton rbtnSavedPlayers;
        private System.Windows.Forms.Panel pnlFavoritePlayers;
        private System.Windows.Forms.Button btnUseFavPlayer;
        private System.Windows.Forms.GroupBox grbPlayers;
        private System.Windows.Forms.Label lblNameOfPlayer;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.PictureBox pbAvatars;
        private System.Windows.Forms.ImageList imglAvatars;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Label lblRemainingPlayers;
        private System.Windows.Forms.ListView lvRemainingPlayers;
        private System.Windows.Forms.ColumnHeader playerName;
        private System.Windows.Forms.ColumnHeader HP;
        private System.Windows.Forms.ColumnHeader wins;
        private System.Windows.Forms.ColumnHeader draws;
        private System.Windows.Forms.ColumnHeader loses;
        private System.Windows.Forms.GroupBox grbRound;
        private System.Windows.Forms.PictureBox pbDrawPile;
        private System.Windows.Forms.ProgressBar pgbPlayer2HP;
        private System.Windows.Forms.ProgressBar pgbPlayer1HP;
        private System.Windows.Forms.PictureBox pbPlayer2Avatar;
        private System.Windows.Forms.PictureBox pbPlayer1Avatar;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Button btnDrawCards;
        private System.Windows.Forms.PictureBox pbPlayer2Deck;
        private System.Windows.Forms.ImageList imglCards;
        private System.Windows.Forms.Label lblP1Card;
        private System.Windows.Forms.Label lblP2Card;
        private System.Windows.Forms.Panel pnlRemainingDrawCards;
        private System.Windows.Forms.Label lblPlayer2HP;
        private System.Windows.Forms.Label lblPlayer1HP;
        private System.Windows.Forms.Label lblWinLoseMsg;
        private System.Windows.Forms.TextBox txtbNameOfPlayer;
        private System.Windows.Forms.Panel pnlRemainingP2Cards;
        private System.Windows.Forms.Panel pnlRemainingP1Cards;
        private System.Windows.Forms.PictureBox pbPlayer1Deck;
        private System.Windows.Forms.CheckBox chbSaveAsFavPlayers;
    }
}

