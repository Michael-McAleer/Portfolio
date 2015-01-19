namespace SimplyMuseum
{
    partial class frmAddArtefact
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
            this.btn_logOut = new System.Windows.Forms.Button();
            this.btn_addPainting = new System.Windows.Forms.Button();
            this.btn_addSculpture = new System.Windows.Forms.Button();
            this.btn_addPottery = new System.Windows.Forms.Button();
            this.btn_addFurniture = new System.Windows.Forms.Button();
            this.pbtn_Home = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbtn_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Simply Museum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome User";
            // 
            // btn_logOut
            // 
            this.btn_logOut.Location = new System.Drawing.Point(12, 317);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(75, 23);
            this.btn_logOut.TabIndex = 8;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // btn_addPainting
            // 
            this.btn_addPainting.Location = new System.Drawing.Point(289, 164);
            this.btn_addPainting.Name = "btn_addPainting";
            this.btn_addPainting.Size = new System.Drawing.Size(75, 23);
            this.btn_addPainting.TabIndex = 9;
            this.btn_addPainting.Text = "Add Painting";
            this.btn_addPainting.UseVisualStyleBackColor = true;
            this.btn_addPainting.Click += new System.EventHandler(this.btn_addPainting_Click);
            // 
            // btn_addSculpture
            // 
            this.btn_addSculpture.Location = new System.Drawing.Point(175, 222);
            this.btn_addSculpture.Name = "btn_addSculpture";
            this.btn_addSculpture.Size = new System.Drawing.Size(87, 23);
            this.btn_addSculpture.TabIndex = 10;
            this.btn_addSculpture.Text = "Add Sculpture";
            this.btn_addSculpture.UseVisualStyleBackColor = true;
            // 
            // btn_addPottery
            // 
            this.btn_addPottery.Location = new System.Drawing.Point(289, 222);
            this.btn_addPottery.Name = "btn_addPottery";
            this.btn_addPottery.Size = new System.Drawing.Size(75, 23);
            this.btn_addPottery.TabIndex = 11;
            this.btn_addPottery.Text = "Add Pottery";
            this.btn_addPottery.UseVisualStyleBackColor = true;
            // 
            // btn_addFurniture
            // 
            this.btn_addFurniture.Location = new System.Drawing.Point(175, 164);
            this.btn_addFurniture.Name = "btn_addFurniture";
            this.btn_addFurniture.Size = new System.Drawing.Size(87, 23);
            this.btn_addFurniture.TabIndex = 12;
            this.btn_addFurniture.Text = "Add Furniture";
            this.btn_addFurniture.UseVisualStyleBackColor = true;
            this.btn_addFurniture.Click += new System.EventHandler(this.btn_addFurniture_Click);
            // 
            // pbtn_Home
            // 
            this.pbtn_Home.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbtn_Home.Image = global::SimplyMuseum.Properties.Resources.pixel_museum;
            this.pbtn_Home.Location = new System.Drawing.Point(12, 150);
            this.pbtn_Home.Name = "pbtn_Home";
            this.pbtn_Home.Size = new System.Drawing.Size(148, 143);
            this.pbtn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbtn_Home.TabIndex = 5;
            this.pbtn_Home.TabStop = false;
            this.pbtn_Home.Click += new System.EventHandler(this.pbtn_Home_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 356);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 23);
            this.btn_back.TabIndex = 80;
            this.btn_back.Text = "Previous Screen";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // frmAddArtefact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 418);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_addFurniture);
            this.Controls.Add(this.btn_addPottery);
            this.Controls.Add(this.btn_addSculpture);
            this.Controls.Add(this.btn_addPainting);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.pbtn_Home);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddArtefact";
            this.Text = "frmAddArtefact";
            ((System.ComponentModel.ISupportInitialize)(this.pbtn_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbtn_Home;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Button btn_addPainting;
        private System.Windows.Forms.Button btn_addSculpture;
        private System.Windows.Forms.Button btn_addPottery;
        private System.Windows.Forms.Button btn_addFurniture;
        private System.Windows.Forms.Button btn_back;
    }
}