namespace FBShare.Control
{
    partial class AddUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserControl));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAddToken = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddAccount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddAccountCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(78, 117);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 23);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Token";
            // 
            // txtAddToken
            // 
            this.txtAddToken.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAddToken.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAddToken.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddToken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddToken.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddToken.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddToken.HintText = "";
            this.txtAddToken.isPassword = false;
            this.txtAddToken.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAddToken.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAddToken.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAddToken.LineThickness = 3;
            this.txtAddToken.Location = new System.Drawing.Point(82, 144);
            this.txtAddToken.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddToken.MaxLength = 32767;
            this.txtAddToken.Name = "txtAddToken";
            this.txtAddToken.Size = new System.Drawing.Size(379, 33);
            this.txtAddToken.TabIndex = 1;
            this.txtAddToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(215, 22);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(113, 92);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Active = false;
            this.btnAddAccount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAccount.BorderRadius = 0;
            this.btnAddAccount.ButtonText = "Save";
            this.btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccount.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddAccount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddAccount.Iconimage = null;
            this.btnAddAccount.Iconimage_right = null;
            this.btnAddAccount.Iconimage_right_Selected = null;
            this.btnAddAccount.Iconimage_Selected = null;
            this.btnAddAccount.IconMarginLeft = 0;
            this.btnAddAccount.IconMarginRight = 0;
            this.btnAddAccount.IconRightVisible = true;
            this.btnAddAccount.IconRightZoom = 0D;
            this.btnAddAccount.IconVisible = true;
            this.btnAddAccount.IconZoom = 90D;
            this.btnAddAccount.IsTab = false;
            this.btnAddAccount.Location = new System.Drawing.Point(252, 206);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddAccount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnAddAccount.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddAccount.selected = false;
            this.btnAddAccount.Size = new System.Drawing.Size(105, 48);
            this.btnAddAccount.TabIndex = 4;
            this.btnAddAccount.Text = "Save";
            this.btnAddAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAccount.Textcolor = System.Drawing.Color.White;
            this.btnAddAccount.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnAddAccountCancel
            // 
            this.btnAddAccountCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAccountCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccountCancel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddAccountCancel.Location = new System.Drawing.Point(363, 206);
            this.btnAddAccountCancel.Name = "btnAddAccountCancel";
            this.btnAddAccountCancel.Size = new System.Drawing.Size(98, 48);
            this.btnAddAccountCancel.TabIndex = 5;
            this.btnAddAccountCancel.Text = "Cancel";
            this.btnAddAccountCancel.UseVisualStyleBackColor = false;
            this.btnAddAccountCancel.Click += new System.EventHandler(this.btnAddAccountCancel_Click);
            // 
            // AddUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddAccountCancel);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.txtAddToken);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "AddUserControl";
            this.Size = new System.Drawing.Size(539, 345);
            this.Load += new System.EventHandler(this.AddUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddToken;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddAccount;
        private System.Windows.Forms.Button btnAddAccountCancel;
    }
}
