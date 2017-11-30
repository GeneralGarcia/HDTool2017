namespace HDTool2017
{
    partial class HelpdeskTool
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
            this.SNumber = new System.Windows.Forms.TextBox();
            this.labelSNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SNumber
            // 
            this.SNumber.Location = new System.Drawing.Point(32, 56);
            this.SNumber.Name = "SNumber";
            this.SNumber.Size = new System.Drawing.Size(155, 20);
            this.SNumber.TabIndex = 1;
            // 
            // labelSNumber
            // 
            this.labelSNumber.AutoSize = true;
            this.labelSNumber.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSNumber.ForeColor = System.Drawing.Color.Red;
            this.labelSNumber.Location = new System.Drawing.Point(32, 37);
            this.labelSNumber.Name = "labelSNumber";
            this.labelSNumber.Size = new System.Drawing.Size(103, 13);
            this.labelSNumber.TabIndex = 2;
            this.labelSNumber.Text = "Enter S Number:";
            // 
            // HelpdeskTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 650);
            this.Controls.Add(this.labelSNumber);
            this.Controls.Add(this.SNumber);
            this.Controls.Add(this.button1);
            this.Name = "HelpdeskTool";
            this.Text = "Helpdesk Tool V1.0 - MB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SNumber;
        private System.Windows.Forms.Label labelSNumber;
    }
}

