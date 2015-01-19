namespace SimplyMuseum
{
    partial class UserScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addArtefact = new System.Windows.Forms.Button();
            this.btn_listPainting = new System.Windows.Forms.Button();
            this.btn_listFurniture = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.btn_listArtefact = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.pbtn_Home = new System.Windows.Forms.PictureBox();
            this.btn_EditArtefacts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbtn_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simply Museum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome User";
            // 
            // btn_addArtefact
            // 
            this.btn_addArtefact.Location = new System.Drawing.Point(297, 173);
            this.btn_addArtefact.Name = "btn_addArtefact";
            this.btn_addArtefact.Size = new System.Drawing.Size(75, 23);
            this.btn_addArtefact.TabIndex = 4;
            this.btn_addArtefact.Text = "Add Artefact";
            this.btn_addArtefact.UseVisualStyleBackColor = true;
            this.btn_addArtefact.Click += new System.EventHandler(this.btn_addArtefact_Click);
            // 
            // btn_listPainting
            // 
            this.btn_listPainting.Location = new System.Drawing.Point(297, 236);
            this.btn_listPainting.Name = "btn_listPainting";
            this.btn_listPainting.Size = new System.Drawing.Size(75, 23);
            this.btn_listPainting.TabIndex = 5;
            this.btn_listPainting.Text = "List Painting";
            this.btn_listPainting.UseVisualStyleBackColor = true;
            this.btn_listPainting.Click += new System.EventHandler(this.btn_listPainting_Click);
            // 
            // btn_listFurniture
            // 
            this.btn_listFurniture.Location = new System.Drawing.Point(406, 236);
            this.btn_listFurniture.Name = "btn_listFurniture";
            this.btn_listFurniture.Size = new System.Drawing.Size(75, 23);
            this.btn_listFurniture.TabIndex = 6;
            this.btn_listFurniture.Text = "List Furniture";
            this.btn_listFurniture.UseVisualStyleBackColor = true;
            this.btn_listFurniture.Click += new System.EventHandler(this.btn_listFurniture_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.Location = new System.Drawing.Point(30, 358);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(75, 23);
            this.btn_logOut.TabIndex = 7;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // btn_listArtefact
            // 
            this.btn_listArtefact.Location = new System.Drawing.Point(406, 173);
            this.btn_listArtefact.Name = "btn_listArtefact";
            this.btn_listArtefact.Size = new System.Drawing.Size(75, 23);
            this.btn_listArtefact.TabIndex = 8;
            this.btn_listArtefact.Text = "List Artefact";
            this.btn_listArtefact.UseVisualStyleBackColor = true;
            this.btn_listArtefact.Click += new System.EventHandler(this.btn_listArtefact_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(394, 303);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(87, 23);
            this.btn_Print.TabIndex = 9;
            this.btn_Print.Text = "Print Artefacts";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // pbtn_Home
            // 
            this.pbtn_Home.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbtn_Home.Image = global::SimplyMuseum.Properties.Resources.pixel_museum;
            this.pbtn_Home.Location = new System.Drawing.Point(30, 162);
            this.pbtn_Home.Name = "pbtn_Home";
            this.pbtn_Home.Size = new System.Drawing.Size(174, 149);
            this.pbtn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbtn_Home.TabIndex = 2;
            this.pbtn_Home.TabStop = false;
            this.pbtn_Home.Click += new System.EventHandler(this.pbtn_Home_Click);
            // 
            // btn_EditArtefacts
            // 
            this.btn_EditArtefacts.Location = new System.Drawing.Point(291, 303);
            this.btn_EditArtefacts.Name = "btn_EditArtefacts";
            this.btn_EditArtefacts.Size = new System.Drawing.Size(81, 23);
            this.btn_EditArtefacts.TabIndex = 10;
            this.btn_EditArtefacts.Text = "Edit Artefacts";
            this.btn_EditArtefacts.UseVisualStyleBackColor = true;
            this.btn_EditArtefacts.Click += new System.EventHandler(this.btn_EditArtefact_Click);
            // 
            // UserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 458);
            this.Controls.Add(this.btn_EditArtefacts);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_listArtefact);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_listFurniture);
            this.Controls.Add(this.btn_listPainting);
            this.Controls.Add(this.btn_addArtefact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbtn_Home);
            this.Controls.Add(this.label1);
            this.Name = "UserScreen";
            this.Text = "UserScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pbtn_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbtn_Home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addArtefact;
        private System.Windows.Forms.Button btn_listPainting;
        private System.Windows.Forms.Button btn_listFurniture;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Button btn_listArtefact;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_EditArtefacts;
    }
}