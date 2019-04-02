namespace TradutorCavales
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPt = new System.Windows.Forms.RichTextBox();
            this.txtCavalo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cavalar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPt
            // 
            this.txtPt.Location = new System.Drawing.Point(25, 12);
            this.txtPt.Name = "txtPt";
            this.txtPt.Size = new System.Drawing.Size(763, 172);
            this.txtPt.TabIndex = 1;
            this.txtPt.Text = "";
            this.txtPt.TextChanged += new System.EventHandler(this.txtPt_TextChanged);
            // 
            // txtCavalo
            // 
            this.txtCavalo.Location = new System.Drawing.Point(25, 243);
            this.txtCavalo.Name = "txtCavalo";
            this.txtCavalo.Size = new System.Drawing.Size(763, 195);
            this.txtCavalo.TabIndex = 2;
            this.txtCavalo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCavalo);
            this.Controls.Add(this.txtPt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtPt;
        private System.Windows.Forms.RichTextBox txtCavalo;
    }
}

