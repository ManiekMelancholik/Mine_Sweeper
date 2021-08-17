
namespace MySaper
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        
        private void InitializeComponent()
        {
            this.GenerateButton = new System.Windows.Forms.Button();
            this.updateHashes = new System.Windows.Forms.Button();
            this.b_HMinus = new System.Windows.Forms.Button();
            this.b_HPlus = new System.Windows.Forms.Button();
            this.b_WMinus = new System.Windows.Forms.Button();
            this.b_WPlus = new System.Windows.Forms.Button();
            this.label_W = new System.Windows.Forms.Label();
            this.label_H = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_Reset = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(219, 365);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(92, 35);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "CREATE";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // updateHashes
            // 
            this.updateHashes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateHashes.Location = new System.Drawing.Point(13, 406);
            this.updateHashes.Name = "updateHashes";
            this.updateHashes.Size = new System.Drawing.Size(298, 35);
            this.updateHashes.TabIndex = 1;
            this.updateHashes.Text = "UpdateHashes";
            this.updateHashes.UseVisualStyleBackColor = true;
            this.updateHashes.Click += new System.EventHandler(this.updateHashes_Click);
            // 
            // b_HMinus
            // 
            this.b_HMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_HMinus.Location = new System.Drawing.Point(339, 405);
            this.b_HMinus.Name = "b_HMinus";
            this.b_HMinus.Size = new System.Drawing.Size(37, 35);
            this.b_HMinus.TabIndex = 2;
            this.b_HMinus.Text = "-";
            this.b_HMinus.UseVisualStyleBackColor = true;
            this.b_HMinus.Click += new System.EventHandler(this.b_HMinus_Click);
            // 
            // b_HPlus
            // 
            this.b_HPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_HPlus.Location = new System.Drawing.Point(382, 406);
            this.b_HPlus.Name = "b_HPlus";
            this.b_HPlus.Size = new System.Drawing.Size(37, 35);
            this.b_HPlus.TabIndex = 3;
            this.b_HPlus.Text = "+";
            this.b_HPlus.UseVisualStyleBackColor = true;
            this.b_HPlus.Click += new System.EventHandler(this.b_HPlus_Click);
            // 
            // b_WMinus
            // 
            this.b_WMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_WMinus.Location = new System.Drawing.Point(339, 364);
            this.b_WMinus.Name = "b_WMinus";
            this.b_WMinus.Size = new System.Drawing.Size(37, 35);
            this.b_WMinus.TabIndex = 4;
            this.b_WMinus.Text = "-";
            this.b_WMinus.UseVisualStyleBackColor = true;
            this.b_WMinus.Click += new System.EventHandler(this.b_WMinus_Click);
            // 
            // b_WPlus
            // 
            this.b_WPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_WPlus.Location = new System.Drawing.Point(382, 365);
            this.b_WPlus.Name = "b_WPlus";
            this.b_WPlus.Size = new System.Drawing.Size(37, 35);
            this.b_WPlus.TabIndex = 5;
            this.b_WPlus.Text = "+";
            this.b_WPlus.UseVisualStyleBackColor = true;
            this.b_WPlus.Click += new System.EventHandler(this.b_WPlus_Click);
            // 
            // label_W
            // 
            this.label_W.AutoSize = true;
            this.label_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_W.Location = new System.Drawing.Point(425, 372);
            this.label_W.Name = "label_W";
            this.label_W.Size = new System.Drawing.Size(19, 20);
            this.label_W.TabIndex = 6;
            this.label_W.Text = "0";
            // 
            // label_H
            // 
            this.label_H.AutoSize = true;
            this.label_H.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_H.Location = new System.Drawing.Point(425, 412);
            this.label_H.Name = "label_H";
            this.label_H.Size = new System.Drawing.Size(19, 20);
            this.label_H.TabIndex = 7;
            this.label_H.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(450, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "WIDTH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(450, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "HEIGHT";
            // 
            // b_Reset
            // 
            this.b_Reset.Location = new System.Drawing.Point(13, 364);
            this.b_Reset.Name = "b_Reset";
            this.b_Reset.Size = new System.Drawing.Size(92, 35);
            this.b_Reset.TabIndex = 10;
            this.b_Reset.Text = "RESET";
            this.b_Reset.UseVisualStyleBackColor = true;
            this.b_Reset.Click += new System.EventHandler(this.b_Reset_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(397, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 316);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.b_Reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_H);
            this.Controls.Add(this.label_W);
            this.Controls.Add(this.b_WPlus);
            this.Controls.Add(this.b_WMinus);
            this.Controls.Add(this.b_HPlus);
            this.Controls.Add(this.b_HMinus);
            this.Controls.Add(this.updateHashes);
            this.Controls.Add(this.GenerateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button updateHashes;
        private System.Windows.Forms.Button b_HMinus;
        private System.Windows.Forms.Button b_HPlus;
        private System.Windows.Forms.Button b_WMinus;
        private System.Windows.Forms.Button b_WPlus;
        private System.Windows.Forms.Label label_W;
        private System.Windows.Forms.Label label_H;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_Reset;
        private System.Windows.Forms.ListBox listBox1;
    }
}

