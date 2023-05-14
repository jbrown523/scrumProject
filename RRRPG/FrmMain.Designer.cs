namespace RRRPG
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            picOpponent = new PictureBox();
            picPlayer = new PictureBox();
            btnDoIt = new Button();
            lblPlayer = new Label();
            lblOpponent = new Label();
            picWeaponSelectMagicWand = new PictureBox();
            lblWeaponSelectMagicWand = new Label();
            panWeaponSelect = new Panel();
            lblWeaponSelectBow = new Label();
            picWeaponSelectBow = new PictureBox();
            lblWeaponSelectNerfRev = new Label();
            picWeaponSelectNerfRev = new PictureBox();
            label3 = new Label();
            lblWeaponSelectWaterGun = new Label();
            lblWeaponSelectCorkGun = new Label();
            picWeaponSelectWaterGun = new PictureBox();
            picWeaponSelectCorkGun = new PictureBox();
            SurvivalLabel = new Label();
            AmmoLabel = new Label();
            UpBtn = new Button();
            DownBtn = new Button();
            AmmoText = new Label();
            HealthLabel = new Label();
            SurvivalText = new Label();
            FortLabel = new Label();
            btnStart = new Button();
            lblOpponentSpeak = new Label();
            lblPlayerSpeak = new Label();
            tmrStateMachine = new System.Windows.Forms.Timer(components);
            tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picOpponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).BeginInit();
            panWeaponSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).BeginInit();
            SuspendLayout();
            // 
            // picOpponent
            // 
            picOpponent.BackgroundImageLayout = ImageLayout.Stretch;
            picOpponent.Location = new Point(600, 160);
            picOpponent.Margin = new Padding(3, 4, 3, 4);
            picOpponent.Name = "picOpponent";
            picOpponent.Size = new Size(601, 668);
            picOpponent.TabIndex = 0;
            picOpponent.TabStop = false;
            // 
            // picPlayer
            // 
            picPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayer.Image = Properties.Resources.Img_Bender_Idle;
            picPlayer.Location = new Point(14, 115);
            picPlayer.Margin = new Padding(3, 4, 3, 4);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(559, 796);
            picPlayer.TabIndex = 1;
            picPlayer.TabStop = false;
            // 
            // btnDoIt
            // 
            btnDoIt.BackColor = Color.Black;
            btnDoIt.Font = new Font("Castellar", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnDoIt.ForeColor = SystemColors.ButtonHighlight;
            btnDoIt.Location = new Point(67, 899);
            btnDoIt.Margin = new Padding(3, 4, 3, 4);
            btnDoIt.Name = "btnDoIt";
            btnDoIt.Size = new Size(257, 93);
            btnDoIt.TabIndex = 2;
            btnDoIt.Text = "Try Your Luck!";
            btnDoIt.UseVisualStyleBackColor = false;
            btnDoIt.Click += btnDoIt_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(242, 64);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(105, 41);
            lblPlayer.TabIndex = 3;
            lblPlayer.Text = "Player";
            // 
            // lblOpponent
            // 
            lblOpponent.AutoSize = true;
            lblOpponent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponent.ForeColor = Color.White;
            lblOpponent.Location = new Point(870, 67);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(161, 41);
            lblOpponent.TabIndex = 4;
            lblOpponent.Text = "Opponent";
            // 
            // picWeaponSelectMagicWand
            // 
            picWeaponSelectMagicWand.BackColor = Color.Black;
            picWeaponSelectMagicWand.BackgroundImage = Properties.Resources.Img_Magic_Wand;
            picWeaponSelectMagicWand.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectMagicWand.Location = new Point(14, 13);
            picWeaponSelectMagicWand.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectMagicWand.Name = "picWeaponSelectMagicWand";
            picWeaponSelectMagicWand.Size = new Size(146, 204);
            picWeaponSelectMagicWand.TabIndex = 5;
            picWeaponSelectMagicWand.TabStop = false;
            picWeaponSelectMagicWand.Click += picWeaponSelectMagicWand_Click;
            // 
            // lblWeaponSelectMagicWand
            // 
            lblWeaponSelectMagicWand.AutoSize = true;
            lblWeaponSelectMagicWand.BackColor = Color.Black;
            lblWeaponSelectMagicWand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectMagicWand.ForeColor = Color.White;
            lblWeaponSelectMagicWand.Location = new Point(53, 221);
            lblWeaponSelectMagicWand.Name = "lblWeaponSelectMagicWand";
            lblWeaponSelectMagicWand.Size = new Size(70, 28);
            lblWeaponSelectMagicWand.TabIndex = 6;
            lblWeaponSelectMagicWand.Text = "Magic";
            // 
            // panWeaponSelect
            // 
            panWeaponSelect.BackColor = Color.Black;
            panWeaponSelect.Controls.Add(lblWeaponSelectBow);
            panWeaponSelect.Controls.Add(picWeaponSelectBow);
            panWeaponSelect.Controls.Add(lblWeaponSelectNerfRev);
            panWeaponSelect.Controls.Add(picWeaponSelectNerfRev);
            panWeaponSelect.Controls.Add(label3);
            panWeaponSelect.Controls.Add(lblWeaponSelectWaterGun);
            panWeaponSelect.Controls.Add(lblWeaponSelectCorkGun);
            panWeaponSelect.Controls.Add(picWeaponSelectWaterGun);
            panWeaponSelect.Controls.Add(picWeaponSelectCorkGun);
            panWeaponSelect.Controls.Add(picWeaponSelectMagicWand);
            panWeaponSelect.Controls.Add(lblWeaponSelectMagicWand);
            panWeaponSelect.Location = new Point(579, 848);
            panWeaponSelect.Margin = new Padding(3, 4, 3, 4);
            panWeaponSelect.Name = "panWeaponSelect";
            panWeaponSelect.Size = new Size(647, 305);
            panWeaponSelect.TabIndex = 7;
            // 
            // lblWeaponSelectBow
            // 
            lblWeaponSelectBow.AutoSize = true;
            lblWeaponSelectBow.BackColor = Color.Black;
            lblWeaponSelectBow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectBow.ForeColor = Color.White;
            lblWeaponSelectBow.Location = new Point(571, 221);
            lblWeaponSelectBow.Name = "lblWeaponSelectBow";
            lblWeaponSelectBow.Size = new Size(53, 28);
            lblWeaponSelectBow.TabIndex = 15;
            lblWeaponSelectBow.Text = "Bow";
            // 
            // picWeaponSelectBow
            // 
            picWeaponSelectBow.BackColor = Color.Black;
            picWeaponSelectBow.BackgroundImage = Properties.Resources.Img_Bow;
            picWeaponSelectBow.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectBow.Location = new Point(533, 15);
            picWeaponSelectBow.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectBow.Name = "picWeaponSelectBow";
            picWeaponSelectBow.Size = new Size(114, 203);
            picWeaponSelectBow.TabIndex = 14;
            picWeaponSelectBow.TabStop = false;
            picWeaponSelectBow.Click += picWeaponSelectBow_Click;
            // 
            // lblWeaponSelectNerfRev
            // 
            lblWeaponSelectNerfRev.AutoSize = true;
            lblWeaponSelectNerfRev.BackColor = Color.Black;
            lblWeaponSelectNerfRev.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectNerfRev.ForeColor = Color.White;
            lblWeaponSelectNerfRev.Location = new Point(401, 221);
            lblWeaponSelectNerfRev.Name = "lblWeaponSelectNerfRev";
            lblWeaponSelectNerfRev.Size = new Size(144, 28);
            lblWeaponSelectNerfRev.TabIndex = 13;
            lblWeaponSelectNerfRev.Text = "Nerf Revolver";
            // 
            // picWeaponSelectNerfRev
            // 
            picWeaponSelectNerfRev.BackColor = Color.Black;
            picWeaponSelectNerfRev.BackgroundImage = Properties.Resources.Img_Nerf_Revolver;
            picWeaponSelectNerfRev.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectNerfRev.Location = new Point(409, 15);
            picWeaponSelectNerfRev.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectNerfRev.Name = "picWeaponSelectNerfRev";
            picWeaponSelectNerfRev.Size = new Size(114, 203);
            picWeaponSelectNerfRev.TabIndex = 12;
            picWeaponSelectNerfRev.TabStop = false;
            picWeaponSelectNerfRev.Click += picWeaponSelectNerfRev_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(235, 260);
            label3.Name = "label3";
            label3.Size = new Size(207, 37);
            label3.TabIndex = 11;
            label3.Text = "Weapon Select";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeaponSelectWaterGun
            // 
            lblWeaponSelectWaterGun.AutoSize = true;
            lblWeaponSelectWaterGun.BackColor = Color.Black;
            lblWeaponSelectWaterGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectWaterGun.ForeColor = Color.White;
            lblWeaponSelectWaterGun.Location = new Point(295, 220);
            lblWeaponSelectWaterGun.Name = "lblWeaponSelectWaterGun";
            lblWeaponSelectWaterGun.Size = new Size(113, 28);
            lblWeaponSelectWaterGun.TabIndex = 10;
            lblWeaponSelectWaterGun.Text = "Water Gun";
            // 
            // lblWeaponSelectCorkGun
            // 
            lblWeaponSelectCorkGun.AutoSize = true;
            lblWeaponSelectCorkGun.BackColor = Color.Black;
            lblWeaponSelectCorkGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectCorkGun.ForeColor = Color.White;
            lblWeaponSelectCorkGun.Location = new Point(178, 220);
            lblWeaponSelectCorkGun.Name = "lblWeaponSelectCorkGun";
            lblWeaponSelectCorkGun.Size = new Size(99, 28);
            lblWeaponSelectCorkGun.TabIndex = 9;
            lblWeaponSelectCorkGun.Text = "Cork Gun";
            // 
            // picWeaponSelectWaterGun
            // 
            picWeaponSelectWaterGun.BackColor = Color.Black;
            picWeaponSelectWaterGun.BackgroundImage = Properties.Resources.Img_Water_Gun;
            picWeaponSelectWaterGun.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectWaterGun.Location = new Point(288, 13);
            picWeaponSelectWaterGun.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectWaterGun.Name = "picWeaponSelectWaterGun";
            picWeaponSelectWaterGun.Size = new Size(114, 203);
            picWeaponSelectWaterGun.TabIndex = 8;
            picWeaponSelectWaterGun.TabStop = false;
            picWeaponSelectWaterGun.Click += picWeaponSelectWaterGun_Click;
            // 
            // picWeaponSelectCorkGun
            // 
            picWeaponSelectCorkGun.BackColor = Color.Black;
            picWeaponSelectCorkGun.BackgroundImage = Properties.Resources.Img_Cork_Gun;
            picWeaponSelectCorkGun.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectCorkGun.Location = new Point(167, 13);
            picWeaponSelectCorkGun.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectCorkGun.Name = "picWeaponSelectCorkGun";
            picWeaponSelectCorkGun.Size = new Size(114, 203);
            picWeaponSelectCorkGun.TabIndex = 7;
            picWeaponSelectCorkGun.TabStop = false;
            picWeaponSelectCorkGun.Click += picWeaponSelectCorkGun_Click;
            // 
            // SurvivalLabel
            // 
            SurvivalLabel.AutoSize = true;
            SurvivalLabel.BackColor = SystemColors.ActiveCaptionText;
            SurvivalLabel.Font = new Font("Castellar", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SurvivalLabel.ForeColor = SystemColors.ControlLightLight;
            SurvivalLabel.Location = new Point(447, 849);
            SurvivalLabel.Name = "SurvivalLabel";
            SurvivalLabel.Size = new Size(99, 27);
            SurvivalLabel.TabIndex = 16;
            SurvivalLabel.Text = " 100 %";
            SurvivalLabel.Visible = false;
            // 
            // AmmoLabel
            // 
            AmmoLabel.AutoSize = true;
            AmmoLabel.BackColor = SystemColors.ActiveCaptionText;
            AmmoLabel.Font = new Font("Castellar", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AmmoLabel.ForeColor = SystemColors.ControlLightLight;
            AmmoLabel.Location = new Point(156, 849);
            AmmoLabel.Name = "AmmoLabel";
            AmmoLabel.Size = new Size(76, 27);
            AmmoLabel.TabIndex = 14;
            AmmoLabel.Text = "0 / 0";
            AmmoLabel.Visible = false;
            AmmoLabel.Click += AmmoLabel_Click;
            // 
            // UpBtn
            // 
            UpBtn.BackColor = SystemColors.ActiveCaptionText;
            UpBtn.Font = new Font("Castellar", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            UpBtn.ForeColor = SystemColors.ControlLightLight;
            UpBtn.Location = new Point(236, 845);
            UpBtn.Name = "UpBtn";
            UpBtn.Size = new Size(60, 33);
            UpBtn.TabIndex = 12;
            UpBtn.Text = "+";
            UpBtn.UseVisualStyleBackColor = false;
            UpBtn.UseWaitCursor = true;
            UpBtn.Visible = false;
            UpBtn.Click += HUDUp;
            // 
            // DownBtn
            // 
            DownBtn.BackColor = SystemColors.ActiveCaptionText;
            DownBtn.Font = new Font("Castellar", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DownBtn.ForeColor = SystemColors.ControlLightLight;
            DownBtn.Location = new Point(88, 849);
            DownBtn.Name = "DownBtn";
            DownBtn.Size = new Size(53, 33);
            DownBtn.TabIndex = 11;
            DownBtn.Text = "-";
            DownBtn.UseVisualStyleBackColor = false;
            DownBtn.Visible = false;
            DownBtn.Click += HUDDown;
            // 
            // AmmoText
            // 
            AmmoText.AutoSize = true;
            AmmoText.BackColor = SystemColors.ActiveCaptionText;
            AmmoText.Font = new Font("Castellar", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AmmoText.ForeColor = SystemColors.ControlLightLight;
            AmmoText.Location = new Point(147, 806);
            AmmoText.Name = "AmmoText";
            AmmoText.Size = new Size(91, 25);
            AmmoText.TabIndex = 13;
            AmmoText.Text = "Ammo";
            AmmoText.Visible = false;
            AmmoText.Click += label1_Click;
            // 
            // HealthLabel
            // 
            HealthLabel.AutoSize = true;
            HealthLabel.BackColor = SystemColors.ActiveCaptionText;
            HealthLabel.Font = new Font("Castellar", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            HealthLabel.ForeColor = SystemColors.ControlLightLight;
            HealthLabel.Location = new Point(395, 938);
            HealthLabel.Name = "HealthLabel";
            HealthLabel.Size = new Size(161, 25);
            HealthLabel.TabIndex = 17;
            HealthLabel.Text = "Health: 100";
            HealthLabel.Visible = false;
            // 
            // SurvivalText
            // 
            SurvivalText.AutoSize = true;
            SurvivalText.BackColor = SystemColors.ActiveCaptionText;
            SurvivalText.Font = new Font("Castellar", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SurvivalText.ForeColor = SystemColors.ControlLightLight;
            SurvivalText.Location = new Point(330, 804);
            SurvivalText.Name = "SurvivalText";
            SurvivalText.Size = new Size(282, 25);
            SurvivalText.TabIndex = 15;
            SurvivalText.Text = "Chance of Survival:";
            SurvivalText.Visible = false;
            // 
            // FortLabel
            // 
            FortLabel.AutoSize = true;
            FortLabel.BackColor = SystemColors.ActiveCaptionText;
            FortLabel.Font = new Font("Castellar", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FortLabel.ForeColor = SystemColors.ControlLightLight;
            FortLabel.Location = new Point(344, 894);
            FortLabel.Name = "FortLabel";
            FortLabel.Size = new Size(244, 25);
            FortLabel.TabIndex = 18;
            FortLabel.Text = "Passive: BUFFENUM";
            FortLabel.Visible = false;
            FortLabel.Click += label2_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Black;
            btnStart.Font = new Font("Castellar", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnStart.ForeColor = SystemColors.ButtonHighlight;
            btnStart.Location = new Point(331, 903);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(257, 93);
            btnStart.TabIndex = 8;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblOpponentSpeak
            // 
            lblOpponentSpeak.AutoSize = true;
            lblOpponentSpeak.BackColor = Color.White;
            lblOpponentSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponentSpeak.Location = new Point(666, 133);
            lblOpponentSpeak.Name = "lblOpponentSpeak";
            lblOpponentSpeak.Size = new Size(263, 41);
            lblOpponentSpeak.TabIndex = 9;
            lblOpponentSpeak.Text = "I will outlast you!";
            // 
            // lblPlayerSpeak
            // 
            lblPlayerSpeak.AutoSize = true;
            lblPlayerSpeak.BackColor = Color.White;
            lblPlayerSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerSpeak.Location = new Point(377, 211);
            lblPlayerSpeak.Name = "lblPlayerSpeak";
            lblPlayerSpeak.Size = new Size(355, 41);
            lblPlayerSpeak.TabIndex = 10;
            lblPlayerSpeak.Text = "Bite my shiny metal ass!";
            // 
            // tmrStateMachine
            // 
            tmrStateMachine.Interval = 40;
            tmrStateMachine.Tick += tmrDialog_Tick;
            // 
            // tmrPlayMusicAfterGameOver
            // 
            tmrPlayMusicAfterGameOver.Interval = 2000;
            tmrPlayMusicAfterGameOver.Tick += tmrPlayMusicAfterGameOver_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1240, 1055);
            Controls.Add(SurvivalLabel);
            Controls.Add(lblPlayerSpeak);
            Controls.Add(AmmoLabel);
            Controls.Add(lblOpponentSpeak);
            Controls.Add(UpBtn);
            Controls.Add(btnStart);
            Controls.Add(DownBtn);
            Controls.Add(panWeaponSelect);
            Controls.Add(AmmoText);
            Controls.Add(lblOpponent);
            Controls.Add(HealthLabel);
            Controls.Add(lblPlayer);
            Controls.Add(SurvivalText);
            Controls.Add(FortLabel);
            Controls.Add(btnDoIt);
            Controls.Add(picPlayer);
            Controls.Add(picOpponent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            Text = "Russian Roulette RPG";
            FormClosed += FrmMain_FormClosed;
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)picOpponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).EndInit();
            panWeaponSelect.ResumeLayout(false);
            panWeaponSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #endregion
        private PictureBox picOpponent;
        private PictureBox picPlayer;
        private Button btnDoIt;
        private Label lblPlayer;
        private Label lblOpponent;
        private PictureBox picWeaponSelectMagicWand;
        private Label lblWeaponSelectMagicWand;
        private Panel panWeaponSelect;
        private Button btnStart;
        private Label lblOpponentSpeak;
        private Label lblPlayerSpeak;
        private System.Windows.Forms.Timer tmrStateMachine;
        private PictureBox picWeaponSelectCorkGun;
        private Label lblWeaponSelectWaterGun;
        private Label lblWeaponSelectCorkGun;
        private PictureBox picWeaponSelectWaterGun;
        private Label label3;
        private Label lblWeaponSelectBow;
        private PictureBox picWeaponSelectBow;
        private Label lblWeaponSelectNerfRev;
        private PictureBox picWeaponSelectNerfRev;
        private System.Windows.Forms.Timer tmrPlayMusicAfterGameOver;
        private Button DownBtn;
        private Button UpBtn;
        private Label AmmoText;
        private Label AmmoLabel;
        private Label SurvivalText;
        private Label SurvivalLabel;
        private Label HealthLabel;
        private Label FortLabel;
    }
}