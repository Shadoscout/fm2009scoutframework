namespace OpenSE
{
    partial class MainForm
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
            this.CALabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PALabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaleValueLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FitnessLabel = new System.Windows.Forms.Label();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CA";
            // 
            // CALabel
            // 
            this.CALabel.AutoSize = true;
            this.CALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALabel.Location = new System.Drawing.Point(39, 9);
            this.CALabel.Name = "CALabel";
            this.CALabel.Size = new System.Drawing.Size(60, 13);
            this.CALabel.TabIndex = 1;
            this.CALabel.Text = "loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PA";
            // 
            // PALabel
            // 
            this.PALabel.AutoSize = true;
            this.PALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PALabel.Location = new System.Drawing.Point(39, 31);
            this.PALabel.Name = "PALabel";
            this.PALabel.Size = new System.Drawing.Size(60, 13);
            this.PALabel.TabIndex = 3;
            this.PALabel.Text = "loading...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sale val.";
            // 
            // SaleValueLabel
            // 
            this.SaleValueLabel.AutoSize = true;
            this.SaleValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleValueLabel.Location = new System.Drawing.Point(138, 31);
            this.SaleValueLabel.Name = "SaleValueLabel";
            this.SaleValueLabel.Size = new System.Drawing.Size(60, 13);
            this.SaleValueLabel.TabIndex = 7;
            this.SaleValueLabel.Text = "loading...";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.Location = new System.Drawing.Point(138, 9);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(60, 13);
            this.ValueLabel.TabIndex = 6;
            this.ValueLabel.Text = "loading...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fitness";
            // 
            // FitnessLabel
            // 
            this.FitnessLabel.AutoSize = true;
            this.FitnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FitnessLabel.Location = new System.Drawing.Point(84, 69);
            this.FitnessLabel.Name = "FitnessLabel";
            this.FitnessLabel.Size = new System.Drawing.Size(60, 13);
            this.FitnessLabel.TabIndex = 10;
            this.FitnessLabel.Text = "loading...";
            this.FitnessLabel.Click += new System.EventHandler(this.FitnessLabel_Click);
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 99);
            this.Controls.Add(this.FitnessLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaleValueLabel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PALabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CALabel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "OpenSE";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CALabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PALabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SaleValueLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label FitnessLabel;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
    }
}

