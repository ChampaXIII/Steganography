namespace Steganografia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBottoni = new System.Windows.Forms.Panel();
            this.panelWriteRead = new System.Windows.Forms.Panel();
            this.radioRead = new System.Windows.Forms.RadioButton();
            this.radioWrite = new System.Windows.Forms.RadioButton();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonChoseImmage = new System.Windows.Forms.Button();
            this.panelBit = new System.Windows.Forms.Panel();
            this.radioBitLeastSignificant = new System.Windows.Forms.RadioButton();
            this.radioBitMostSignificant = new System.Windows.Forms.RadioButton();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelText = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.panelBottoni.SuspendLayout();
            this.panelWriteRead.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelBit.SuspendLayout();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottoni
            // 
            this.panelBottoni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBottoni.Controls.Add(this.panelWriteRead);
            this.panelBottoni.Controls.Add(this.panelButtons);
            this.panelBottoni.Controls.Add(this.panelBit);
            this.panelBottoni.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottoni.Location = new System.Drawing.Point(0, 553);
            this.panelBottoni.Name = "panelBottoni";
            this.panelBottoni.Size = new System.Drawing.Size(1020, 75);
            this.panelBottoni.TabIndex = 0;
            // 
            // panelWriteRead
            // 
            this.panelWriteRead.Controls.Add(this.radioRead);
            this.panelWriteRead.Controls.Add(this.radioWrite);
            this.panelWriteRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWriteRead.Location = new System.Drawing.Point(156, 0);
            this.panelWriteRead.Name = "panelWriteRead";
            this.panelWriteRead.Size = new System.Drawing.Size(145, 71);
            this.panelWriteRead.TabIndex = 2;
            this.panelWriteRead.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // radioRead
            // 
            this.radioRead.AutoSize = true;
            this.radioRead.Location = new System.Drawing.Point(6, 34);
            this.radioRead.Name = "radioRead";
            this.radioRead.Size = new System.Drawing.Size(133, 19);
            this.radioRead.TabIndex = 3;
            this.radioRead.Text = "Leggi dall\'immagine";
            this.radioRead.UseVisualStyleBackColor = true;
            // 
            // radioWrite
            // 
            this.radioWrite.AutoSize = true;
            this.radioWrite.Checked = true;
            this.radioWrite.Location = new System.Drawing.Point(6, 9);
            this.radioWrite.Name = "radioWrite";
            this.radioWrite.Size = new System.Drawing.Size(132, 19);
            this.radioWrite.TabIndex = 2;
            this.radioWrite.TabStop = true;
            this.radioWrite.Text = "Scrivi nell\'immagine";
            this.radioWrite.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonStart);
            this.panelButtons.Controls.Add(this.buttonDownload);
            this.panelButtons.Controls.Add(this.buttonChoseImmage);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(301, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(715, 71);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(126, 7);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(579, 52);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "AVVIA";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(9, 36);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 1;
            this.buttonDownload.Text = "Esporta";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonChoseImmage
            // 
            this.buttonChoseImmage.Location = new System.Drawing.Point(9, 7);
            this.buttonChoseImmage.Name = "buttonChoseImmage";
            this.buttonChoseImmage.Size = new System.Drawing.Size(75, 23);
            this.buttonChoseImmage.TabIndex = 0;
            this.buttonChoseImmage.Text = "Importa";
            this.buttonChoseImmage.UseVisualStyleBackColor = true;
            this.buttonChoseImmage.Click += new System.EventHandler(this.buttonChoseImmage_Click);
            // 
            // panelBit
            // 
            this.panelBit.Controls.Add(this.radioBitLeastSignificant);
            this.panelBit.Controls.Add(this.radioBitMostSignificant);
            this.panelBit.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBit.Location = new System.Drawing.Point(0, 0);
            this.panelBit.Name = "panelBit";
            this.panelBit.Size = new System.Drawing.Size(156, 71);
            this.panelBit.TabIndex = 0;
            // 
            // radioBitLeastSignificant
            // 
            this.radioBitLeastSignificant.AutoSize = true;
            this.radioBitLeastSignificant.Checked = true;
            this.radioBitLeastSignificant.Location = new System.Drawing.Point(6, 34);
            this.radioBitLeastSignificant.Name = "radioBitLeastSignificant";
            this.radioBitLeastSignificant.Size = new System.Drawing.Size(140, 19);
            this.radioBitLeastSignificant.TabIndex = 1;
            this.radioBitLeastSignificant.TabStop = true;
            this.radioBitLeastSignificant.Text = "Bit meno significativo";
            this.radioBitLeastSignificant.UseVisualStyleBackColor = true;
            this.radioBitLeastSignificant.CheckedChanged += new System.EventHandler(this.radioBitLeastSignificant_CheckedChanged);
            // 
            // radioBitMostSignificant
            // 
            this.radioBitMostSignificant.AutoSize = true;
            this.radioBitMostSignificant.Location = new System.Drawing.Point(6, 9);
            this.radioBitMostSignificant.Name = "radioBitMostSignificant";
            this.radioBitMostSignificant.Size = new System.Drawing.Size(126, 19);
            this.radioBitMostSignificant.TabIndex = 0;
            this.radioBitMostSignificant.Text = "Bit più significativo";
            this.radioBitMostSignificant.UseVisualStyleBackColor = true;
            this.radioBitMostSignificant.CheckedChanged += new System.EventHandler(this.radioBitMostSignificant_CheckedChanged);
            // 
            // panelPicture
            // 
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPicture.Controls.Add(this.pictureBox);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPicture.Location = new System.Drawing.Point(0, 0);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(773, 553);
            this.panelPicture.TabIndex = 1;
            this.panelPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(3, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(762, 535);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // panelText
            // 
            this.panelText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelText.Controls.Add(this.textBox);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelText.Location = new System.Drawing.Point(773, 0);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(247, 553);
            this.panelText.TabIndex = 2;
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Location = new System.Drawing.Point(4, 7);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(236, 539);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 628);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.panelBottoni);
            this.Name = "Form1";
            this.panelBottoni.ResumeLayout(false);
            this.panelWriteRead.ResumeLayout(false);
            this.panelWriteRead.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelBit.ResumeLayout(false);
            this.panelBit.PerformLayout();
            this.panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelBottoni;
        private Panel panelWriteRead;
        private Panel panelButtons;
        private Panel panelBit;
        private RadioButton radioBitLeastSignificant;
        private RadioButton radioBitMostSignificant;
        private Panel panelPicture;
        private Panel panelText;
        private RadioButton radioRead;
        private RadioButton radioWrite;
        private Button buttonChoseImmage;
        private Button buttonStart;
        private Button buttonDownload;
        private RichTextBox textBox;
        private PictureBox pictureBox;
    }
}