namespace FMSearch
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
            this.ClubsComboBox = new System.Windows.Forms.ComboBox();
            this.LeetPlayers = new System.Windows.Forms.Button();
            this.MakeCAButton = new System.Windows.Forms.Button();
            this.ActivePlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClubsComboBox
            // 
            this.ClubsComboBox.DisplayMember = "Name";
            this.ClubsComboBox.FormattingEnabled = true;
            this.ClubsComboBox.Location = new System.Drawing.Point(12, 12);
            this.ClubsComboBox.Name = "ClubsComboBox";
            this.ClubsComboBox.Size = new System.Drawing.Size(251, 21);
            this.ClubsComboBox.TabIndex = 0;
            // 
            // LeetPlayers
            // 
            this.LeetPlayers.Location = new System.Drawing.Point(142, 39);
            this.LeetPlayers.Name = "LeetPlayers";
            this.LeetPlayers.Size = new System.Drawing.Size(121, 23);
            this.LeetPlayers.TabIndex = 1;
            this.LeetPlayers.Text = "Create 1337 players";
            this.LeetPlayers.UseVisualStyleBackColor = true;
            this.LeetPlayers.Click += new System.EventHandler(this.LeetPlayers_Click);
            // 
            // MakeCAButton
            // 
            this.MakeCAButton.Location = new System.Drawing.Point(12, 123);
            this.MakeCAButton.Name = "MakeCAButton";
            this.MakeCAButton.Size = new System.Drawing.Size(148, 23);
            this.MakeCAButton.TabIndex = 2;
            this.MakeCAButton.Text = "Make all CA 170+ Dutch";
            this.MakeCAButton.UseVisualStyleBackColor = true;
            this.MakeCAButton.Click += new System.EventHandler(this.MakeCAButton_Click);
            // 
            // ActivePlayerButton
            // 
            this.ActivePlayerButton.Location = new System.Drawing.Point(142, 184);
            this.ActivePlayerButton.Name = "ActivePlayerButton";
            this.ActivePlayerButton.Size = new System.Drawing.Size(121, 23);
            this.ActivePlayerButton.TabIndex = 4;
            this.ActivePlayerButton.Text = "Get active player";
            this.ActivePlayerButton.UseVisualStyleBackColor = true;
            this.ActivePlayerButton.Click += new System.EventHandler(this.ActivePlayerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 221);
            this.Controls.Add(this.ActivePlayerButton);
            this.Controls.Add(this.MakeCAButton);
            this.Controls.Add(this.LeetPlayers);
            this.Controls.Add(this.ClubsComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ClubsComboBox;
        private System.Windows.Forms.Button LeetPlayers;
        private System.Windows.Forms.Button MakeCAButton;
        private System.Windows.Forms.Button ActivePlayerButton;



    }
}

