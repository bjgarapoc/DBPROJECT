
namespace DBPROJECT
{
    partial class frmEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCustomer));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSMTPport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSMTPHOST = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictBoxUser = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OldLace;
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSMTPport);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSMTPHOST);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtCusName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(304, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 262);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(13, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 1006;
            this.label7.Text = "Contact Number";
            // 
            // txtSMTPport
            // 
            this.txtSMTPport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMTPport.Location = new System.Drawing.Point(135, 143);
            this.txtSMTPport.Name = "txtSMTPport";
            this.txtSMTPport.Size = new System.Drawing.Size(191, 22);
            this.txtSMTPport.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(13, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 1005;
            this.label8.Text = "Address";
            // 
            // txtSMTPHOST
            // 
            this.txtSMTPHOST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMTPHOST.Location = new System.Drawing.Point(135, 104);
            this.txtSMTPHOST.Name = "txtSMTPHOST";
            this.txtSMTPHOST.Size = new System.Drawing.Size(269, 22);
            this.txtSMTPHOST.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(135, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 22);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtCusName
            // 
            this.txtCusName.AcceptsReturn = true;
            this.txtCusName.AcceptsTab = true;
            this.txtCusName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(135, 30);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.ReadOnly = true;
            this.txtCusName.Size = new System.Drawing.Size(269, 22);
            this.txtCusName.TabIndex = 1002;
            this.txtCusName.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer Name";
            // 
            // pictBoxUser
            // 
            this.pictBoxUser.BackColor = System.Drawing.Color.OldLace;
            this.pictBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBoxUser.Location = new System.Drawing.Point(12, 12);
            this.pictBoxUser.Name = "pictBoxUser";
            this.pictBoxUser.Size = new System.Drawing.Size(274, 262);
            this.pictBoxUser.TabIndex = 31;
            this.pictBoxUser.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.ImageIndex = 3;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(12, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Load New Photo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.ImageIndex = 4;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(177, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Clear Photo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.ImageIndex = 15;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(16, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 47;
            this.button3.Text = "Send Email";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.ImageKey = "refresh-icon-png-40262-Windows.ico";
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(324, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 1007;
            this.button4.Text = "Refresh";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave.ImageIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save-icon-5402-Windows.ico");
            this.imageList1.Images.SetKeyName(1, "refresh-icon-png-40262-Windows.ico");
            this.imageList1.Images.SetKeyName(2, "edit-icon-png-3597.png");
            this.imageList1.Images.SetKeyName(3, "camera-icon-39.jpg");
            this.imageList1.Images.SetKeyName(4, "clear-icon-9196.gif");
            this.imageList1.Images.SetKeyName(5, "save-icon-5402.png");
            this.imageList1.Images.SetKeyName(6, "refresh-icon-10850.png");
            this.imageList1.Images.SetKeyName(7, "arrow-icon-1156.png");
            this.imageList1.Images.SetKeyName(8, "arrow-icon-1151.png");
            this.imageList1.Images.SetKeyName(9, "rightdouble.png");
            this.imageList1.Images.SetKeyName(10, "leftdouble-arrow.png");
            this.imageList1.Images.SetKeyName(11, "fast-forward-double-right-arrows-symbol.png");
            this.imageList1.Images.SetKeyName(12, "left-arrow.png");
            this.imageList1.Images.SetKeyName(13, "right-arrow.png");
            this.imageList1.Images.SetKeyName(14, "forgot-password-icon-18359.png");
            this.imageList1.Images.SetKeyName(15, "email-icon-122.png");
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(226, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 1007;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictBoxUser);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmEditCustomer";
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.frmEditCustomer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSMTPport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSMTPHOST;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictBoxUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSave;
    }
}