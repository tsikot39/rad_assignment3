namespace rad_assignment3
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
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.comboBoxTeams = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPhotoPath = new System.Windows.Forms.TextBox();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.pictureBoxPlayerPhoto = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numSteals = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numRebounds = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numAssists = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSteals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRebounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAssists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 16;
            this.listBoxPlayers.Location = new System.Drawing.Point(6, 21);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(304, 452);
            this.listBoxPlayers.TabIndex = 0;
            this.listBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayers_SelectedIndexChanged);
            // 
            // comboBoxTeams
            // 
            this.comboBoxTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeams.FormattingEnabled = true;
            this.comboBoxTeams.Items.AddRange(new object[] {
            "Lakers",
            "Warriors",
            "Bulls"});
            this.comboBoxTeams.Location = new System.Drawing.Point(119, 21);
            this.comboBoxTeams.Name = "comboBoxTeams";
            this.comboBoxTeams.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTeams.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(325, 17);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(125, 30);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter by Team";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose a team";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxPlayers);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 479);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Players";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPhotoPath);
            this.groupBox2.Controls.Add(this.btnSelectPhoto);
            this.groupBox2.Controls.Add(this.pictureBoxPlayerPhoto);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numSteals);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numRebounds);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numAssists);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numPoints);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPosition);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTeam);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(334, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 479);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player details";
            // 
            // txtPhotoPath
            // 
            this.txtPhotoPath.Location = new System.Drawing.Point(298, 202);
            this.txtPhotoPath.Name = "txtPhotoPath";
            this.txtPhotoPath.Size = new System.Drawing.Size(132, 22);
            this.txtPhotoPath.TabIndex = 19;
            this.txtPhotoPath.Visible = false;
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Location = new System.Drawing.Point(298, 165);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(132, 30);
            this.btnSelectPhoto.TabIndex = 18;
            this.btnSelectPhoto.Text = "Select Photo";
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // pictureBoxPlayerPhoto
            // 
            this.pictureBoxPlayerPhoto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBoxPlayerPhoto.Location = new System.Drawing.Point(298, 25);
            this.pictureBoxPlayerPhoto.Name = "pictureBoxPlayerPhoto";
            this.pictureBoxPlayerPhoto.Size = new System.Drawing.Size(132, 133);
            this.pictureBoxPlayerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayerPhoto.TabIndex = 17;
            this.pictureBoxPlayerPhoto.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(279, 419);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(198, 419);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Save";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(67, 419);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add New Player";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Steals";
            // 
            // numSteals
            // 
            this.numSteals.Location = new System.Drawing.Point(82, 194);
            this.numSteals.Name = "numSteals";
            this.numSteals.Size = new System.Drawing.Size(120, 22);
            this.numSteals.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rebounds";
            // 
            // numRebounds
            // 
            this.numRebounds.Location = new System.Drawing.Point(82, 165);
            this.numRebounds.Name = "numRebounds";
            this.numRebounds.Size = new System.Drawing.Size(120, 22);
            this.numRebounds.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Assists";
            // 
            // numAssists
            // 
            this.numAssists.Location = new System.Drawing.Point(82, 137);
            this.numAssists.Name = "numAssists";
            this.numAssists.Size = new System.Drawing.Size(120, 22);
            this.numAssists.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Points";
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(82, 109);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(120, 22);
            this.numPoints.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(82, 81);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(200, 22);
            this.txtPosition.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Team";
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(82, 53);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(200, 22);
            this.txtTeam.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(82, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.comboBoxTeams);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Players";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSteals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRebounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAssists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.ComboBox comboBoxTeams;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numAssists;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numSteals;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numRebounds;
        private System.Windows.Forms.PictureBox pictureBoxPlayerPhoto;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.TextBox txtPhotoPath;
    }
}

