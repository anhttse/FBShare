using FBShare.Control;

namespace FBShare
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.activeSlide = new System.Windows.Forms.Panel();
            this.btnMenuProcess = new System.Windows.Forms.Button();
            this.btnMenuCaption = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.shareControl1 = new FBShare.Control.ShareControl();
            this.facebookAccountControl1 = new FBShare.Control.FacebookAccountControl();
            this.captionControl1 = new FBShare.Control.CaptionControl();
            this.processControl1 = new FBShare.Control.ProcessControl();
            this.btnMenuReaction = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.activeSlide);
            this.panel1.Controls.Add(this.btnMenuReaction);
            this.panel1.Controls.Add(this.btnMenuProcess);
            this.panel1.Controls.Add(this.btnMenuCaption);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 391);
            this.panel1.TabIndex = 0;
            // 
            // activeSlide
            // 
            this.activeSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.activeSlide.Location = new System.Drawing.Point(0, 46);
            this.activeSlide.Name = "activeSlide";
            this.activeSlide.Size = new System.Drawing.Size(10, 57);
            this.activeSlide.TabIndex = 2;
            // 
            // btnMenuProcess
            // 
            this.btnMenuProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnMenuProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenuProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuProcess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuProcess.FlatAppearance.BorderSize = 0;
            this.btnMenuProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuProcess.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuProcess.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuProcess.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuProcess.Image")));
            this.btnMenuProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuProcess.Location = new System.Drawing.Point(12, 298);
            this.btnMenuProcess.Name = "btnMenuProcess";
            this.btnMenuProcess.Size = new System.Drawing.Size(134, 57);
            this.btnMenuProcess.TabIndex = 0;
            this.btnMenuProcess.Text = "       Process";
            this.btnMenuProcess.UseVisualStyleBackColor = false;
            this.btnMenuProcess.Click += new System.EventHandler(this.btnMenuProcess_Click);
            // 
            // btnMenuCaption
            // 
            this.btnMenuCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnMenuCaption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenuCaption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuCaption.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuCaption.FlatAppearance.BorderSize = 0;
            this.btnMenuCaption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCaption.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCaption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuCaption.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuCaption.Image")));
            this.btnMenuCaption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCaption.Location = new System.Drawing.Point(12, 172);
            this.btnMenuCaption.Name = "btnMenuCaption";
            this.btnMenuCaption.Size = new System.Drawing.Size(134, 57);
            this.btnMenuCaption.TabIndex = 0;
            this.btnMenuCaption.Text = "       Caption";
            this.btnMenuCaption.UseVisualStyleBackColor = false;
            this.btnMenuCaption.Click += new System.EventHandler(this.btnMenuCaption_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(12, 109);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(134, 57);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "     Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "     Share";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(152, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 40);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(456, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Developed by AnhTT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Facebook tool";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(589, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 34);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(630, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Facebook tool still running";
            this.notifyIcon.BalloonTipTitle = "Facebook tool";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Tag = "Facebook tool still running";
            this.notifyIcon.Text = "Facebook tool";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // shareControl1
            // 
            this.shareControl1.BackColor = System.Drawing.Color.White;
            this.shareControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shareControl1.Location = new System.Drawing.Point(152, 40);
            this.shareControl1.Name = "shareControl1";
            this.shareControl1.Size = new System.Drawing.Size(668, 349);
            this.shareControl1.TabIndex = 2;
            // 
            // facebookAccountControl1
            // 
            this.facebookAccountControl1.Location = new System.Drawing.Point(152, 40);
            this.facebookAccountControl1.Name = "facebookAccountControl1";
            this.facebookAccountControl1.Size = new System.Drawing.Size(668, 351);
            this.facebookAccountControl1.TabIndex = 3;
            // 
            // captionControl1
            // 
            this.captionControl1.Location = new System.Drawing.Point(152, 40);
            this.captionControl1.Name = "captionControl1";
            this.captionControl1.Size = new System.Drawing.Size(668, 351);
            this.captionControl1.TabIndex = 4;
            // 
            // processControl1
            // 
            this.processControl1.Location = new System.Drawing.Point(152, 40);
            this.processControl1.Name = "processControl1";
            this.processControl1.Size = new System.Drawing.Size(668, 351);
            this.processControl1.TabIndex = 5;
            // 
            // btnMenuReaction
            // 
            this.btnMenuReaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnMenuReaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenuReaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuReaction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuReaction.FlatAppearance.BorderSize = 0;
            this.btnMenuReaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuReaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuReaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuReaction.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuReaction.Image")));
            this.btnMenuReaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReaction.Location = new System.Drawing.Point(12, 235);
            this.btnMenuReaction.Name = "btnMenuReaction";
            this.btnMenuReaction.Size = new System.Drawing.Size(134, 57);
            this.btnMenuReaction.TabIndex = 0;
            this.btnMenuReaction.Text = "       Reaction";
            this.btnMenuReaction.UseVisualStyleBackColor = false;
            this.btnMenuReaction.Click += new System.EventHandler(this.btnMenuReaction_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(820, 391);
            this.Controls.Add(this.processControl1);
            this.Controls.Add(this.captionControl1);
            this.Controls.Add(this.facebookAccountControl1);
            this.Controls.Add(this.shareControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMenuProcess;
        private System.Windows.Forms.Button btnMenuCaption;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel activeSlide;
        private ShareControl shareControl1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private FacebookAccountControl facebookAccountControl1;
        private CaptionControl captionControl1;
        private ProcessControl processControl1;
        private System.Windows.Forms.Button btnMenuReaction;
    }
}