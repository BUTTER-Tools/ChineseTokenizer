namespace ChineseTokenizerCoreNLP
{
    partial class SettingsForm_ChineseTokenizer_CoreNLP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm_ChineseTokenizer_CoreNLP));
            this.OKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CTBRadioButton = new System.Windows.Forms.RadioButton();
            this.PKURadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(106, 210);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(118, 40);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Segmentation Model:";
            // 
            // CTBRadioButton
            // 
            this.CTBRadioButton.AutoSize = true;
            this.CTBRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTBRadioButton.Location = new System.Drawing.Point(28, 86);
            this.CTBRadioButton.Name = "CTBRadioButton";
            this.CTBRadioButton.Size = new System.Drawing.Size(229, 20);
            this.CTBRadioButton.TabIndex = 8;
            this.CTBRadioButton.TabStop = true;
            this.CTBRadioButton.Text = "Chinese Penn Treebank Standard";
            this.CTBRadioButton.UseVisualStyleBackColor = true;
            // 
            // PKURadioButton
            // 
            this.PKURadioButton.AutoSize = true;
            this.PKURadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PKURadioButton.Location = new System.Drawing.Point(28, 132);
            this.PKURadioButton.Name = "PKURadioButton";
            this.PKURadioButton.Size = new System.Drawing.Size(188, 20);
            this.PKURadioButton.TabIndex = 9;
            this.PKURadioButton.TabStop = true;
            this.PKURadioButton.Text = "Peking University Standard";
            this.PKURadioButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm_ChineseTokenizer_CoreNLP
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 262);
            this.Controls.Add(this.PKURadioButton);
            this.Controls.Add(this.CTBRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm_ChineseTokenizer_CoreNLP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugin Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton CTBRadioButton;
        private System.Windows.Forms.RadioButton PKURadioButton;
    }
}