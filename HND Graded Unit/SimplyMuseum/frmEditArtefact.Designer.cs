namespace SimplyMuseum
{
    partial class frmEditArtefact
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_EditFurniture = new System.Windows.Forms.Button();
            this.btn_EditPottery = new System.Windows.Forms.Button();
            this.btn_EditSculpture = new System.Windows.Forms.Button();
            this.btn_EditPainting = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.pbtn_Home = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbtn_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(35, 317);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 23);
            this.btn_back.TabIndex = 89;
            this.btn_back.Text = "Previous Screen";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_EditFurniture
            // 
            this.btn_EditFurniture.Location = new System.Drawing.Point(198, 125);
            this.btn_EditFurniture.Name = "btn_EditFurniture";
            this.btn_EditFurniture.Size = new System.Drawing.Size(87, 23);
            this.btn_EditFurniture.TabIndex = 88;
            this.btn_EditFurniture.Text = "Edit Furniture";
            this.btn_EditFurniture.UseVisualStyleBackColor = true;
            this.btn_EditFurniture.Click += new System.EventHandler(this.btn_EditFurniture_Click);
            // 
            // btn_EditPottery
            // 
            this.btn_EditPottery.Location = new System.Drawing.Point(312, 183);
            this.btn_EditPottery.Name = "btn_EditPottery";
            this.btn_EditPottery.Size = new System.Drawing.Size(75, 23);
            this.btn_EditPottery.TabIndex = 87;
            this.btn_EditPottery.Text = "Edit Pottery";
            this.btn_EditPottery.UseVisualStyleBackColor = true;
            // 
            // btn_EditSculpture
            // 
            this.btn_EditSculpture.Location = new System.Drawing.Point(198, 183);
            this.btn_EditSculpture.Name = "btn_EditSculpture";
            this.btn_EditSculpture.Size = new System.Drawing.Size(87, 23);
            this.btn_EditSculpture.TabIndex = 86;
            this.btn_EditSculpture.Text = "Edit Sculpture";
            this.btn_EditSculpture.UseVisualStyleBackColor = true;
            // 
            // btn_EditPainting
            // 
            this.btn_EditPainting.Location = new System.Drawing.Point(312, 125);
            this.btn_EditPainting.Name = "btn_EditPainting";
            this.btn_EditPainting.Size = new System.Drawing.Size(75, 23);
            this.btn_EditPainting.TabIndex = 85;
            this.btn_EditPainting.Text = "Edit Painting";
            this.btn_EditPainting.UseVisualStyleBackColor = true;
            this.btn_EditPainting.Click += new System.EventHandler(this.btn_EditPainting_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.Location = new System.Drawing.Point(35, 278);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(75, 23);
            this.btn_logOut.TabIndex = 84;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // pbtn_Home
            // 
            this.pbtn_Home.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbtn_Home.Image = global::SimplyMuseum.Properties.Resources.pixel_museum;
            this.pbtn_Home.Location = new System.Drawing.Point(35, 111);
            this.pbtn_Home.Name = "pbtn_Home";
            this.pbtn_Home.Size = new System.Drawing.Size(148, 143);
            this.pbtn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbtn_Home.TabIndex = 83;
            this.pbtn_Home.TabStop = false;
            this.pbtn_Home.Click += new System.EventHandler(this.pbtn_Home_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Welcome User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, -41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 37);
            this.label1.TabIndex = 81;
            this.label1.Text = "Simply Museum";
            // 
            // frmEditArtefact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 401);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_EditFurniture);
            this.Controls.Add(this.btn_EditPottery);
            this.Controls.Add(this.btn_EditSculpture);
            this.Controls.Add(this.btn_EditPainting);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.pbtn_Home);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditArtefact";
            this.Text = "frmEditArtefact";
            ((System.ComponentModel.ISupportInitialize)(this.pbtn_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_EditFurniture;
        private System.Windows.Forms.Button btn_EditPottery;
        private System.Windows.Forms.Button btn_EditSculpture;
        private System.Windows.Forms.Button btn_EditPainting;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.PictureBox pbtn_Home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}