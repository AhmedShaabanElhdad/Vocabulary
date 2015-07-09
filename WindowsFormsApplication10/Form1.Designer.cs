namespace WindowsFormsApplication10
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
            this.English = new System.Windows.Forms.TextBox();
            this.Arabic = new System.Windows.Forms.TextBox();
            this.View = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.voice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.lstbEnglish = new System.Windows.Forms.ListBox();
            this.lstbArabic = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // English
            // 
            this.English.Location = new System.Drawing.Point(24, 73);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(210, 26);
            this.English.TabIndex = 0;
            this.English.TextChanged += new System.EventHandler(this.English_TextChanged);
            // 
            // Arabic
            // 
            this.Arabic.Location = new System.Drawing.Point(279, 73);
            this.Arabic.Name = "Arabic";
            this.Arabic.Size = new System.Drawing.Size(210, 26);
            this.Arabic.TabIndex = 1;
            this.Arabic.TextChanged += new System.EventHandler(this.Arabic_TextChanged);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(122, 336);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(263, 29);
            this.View.TabIndex = 5;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "English Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arabic Word";
            // 
            // voice
            // 
            this.voice.Image = global::WindowsFormsApplication10.Properties.Resources._1;
            this.voice.Location = new System.Drawing.Point(505, 69);
            this.voice.Name = "voice";
            this.voice.Size = new System.Drawing.Size(44, 35);
            this.voice.TabIndex = 2;
            this.voice.UseVisualStyleBackColor = true;
            this.voice.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(42, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            // 
            // cmbbox
            // 
            this.cmbbox.FormattingEnabled = true;
            this.cmbbox.Items.AddRange(new object[] {
            "Notset",
            "Male",
            "Female",
            "Neutral"});
            this.cmbbox.Location = new System.Drawing.Point(277, 6);
            this.cmbbox.Name = "cmbbox";
            this.cmbbox.Size = new System.Drawing.Size(210, 28);
            this.cmbbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select Voice";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(566, 73);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(65, 29);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // lstbEnglish
            // 
            this.lstbEnglish.FormattingEnabled = true;
            this.lstbEnglish.ItemHeight = 20;
            this.lstbEnglish.Location = new System.Drawing.Point(24, 131);
            this.lstbEnglish.Name = "lstbEnglish";
            this.lstbEnglish.Size = new System.Drawing.Size(210, 184);
            this.lstbEnglish.TabIndex = 12;
            this.lstbEnglish.SelectedIndexChanged += new System.EventHandler(this.lstbEnglish_SelectedIndexChanged);
            // 
            // lstbArabic
            // 
            this.lstbArabic.FormattingEnabled = true;
            this.lstbArabic.ItemHeight = 20;
            this.lstbArabic.Location = new System.Drawing.Point(279, 131);
            this.lstbArabic.Name = "lstbArabic";
            this.lstbArabic.Size = new System.Drawing.Size(210, 184);
            this.lstbArabic.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 375);
            this.Controls.Add(this.lstbArabic);
            this.Controls.Add(this.lstbEnglish);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.View);
            this.Controls.Add(this.voice);
            this.Controls.Add(this.Arabic);
            this.Controls.Add(this.English);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Note Vocubulary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox English;
        private System.Windows.Forms.TextBox Arabic;
        private System.Windows.Forms.Button voice;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ListBox lstbEnglish;
        private System.Windows.Forms.ListBox lstbArabic;
    }
}

