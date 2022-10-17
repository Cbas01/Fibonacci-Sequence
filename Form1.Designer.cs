namespace Fibonacci
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
            this.txtqnt = new System.Windows.Forms.TextBox();
            this.lblQnt = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.lstbNums = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtqnt
            // 
            this.txtqnt.Location = new System.Drawing.Point(12, 37);
            this.txtqnt.Name = "txtqnt";
            this.txtqnt.Size = new System.Drawing.Size(141, 20);
            this.txtqnt.TabIndex = 0;
            this.txtqnt.TextChanged += new System.EventHandler(this.txtqnt_TextChanged);
            this.txtqnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqnt_KeyPress);
            // 
            // lblQnt
            // 
            this.lblQnt.AutoSize = true;
            this.lblQnt.Location = new System.Drawing.Point(9, 21);
            this.lblQnt.Name = "lblQnt";
            this.lblQnt.Size = new System.Drawing.Size(131, 13);
            this.lblQnt.TabIndex = 1;
            this.lblQnt.Text = "Quantidade de elementos:";
            // 
            // btnIn
            // 
            this.btnIn.Enabled = false;
            this.btnIn.Location = new System.Drawing.Point(209, 35);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "Inserir";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // lstbNums
            // 
            this.lstbNums.FormattingEnabled = true;
            this.lstbNums.Location = new System.Drawing.Point(12, 90);
            this.lstbNums.Name = "lstbNums";
            this.lstbNums.Size = new System.Drawing.Size(269, 173);
            this.lstbNums.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 284);
            this.Controls.Add(this.lstbNums);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblQnt);
            this.Controls.Add(this.txtqnt);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtqnt;
        private System.Windows.Forms.Label lblQnt;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ListBox lstbNums;
    }
}

