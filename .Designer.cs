namespace MES
{
    partial class orderform
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderNotxt;
        private System.Windows.Forms.TextBox dataIdtxt;
        private System.Windows.Forms.Button button1;

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
            this.label2 = new System.Windows.Forms.Label();
            this.orderNotxt = new System.Windows.Forms.TextBox();
            this.dataIdtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDER_NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATA_ID";
            // 
            // orderNotxt
            // 
            this.orderNotxt.Location = new System.Drawing.Point(288, 120);
            this.orderNotxt.Name = "orderNotxt";
            this.orderNotxt.Size = new System.Drawing.Size(100, 21);
            this.orderNotxt.TabIndex = 2;
            // 
            // dataIdtxt
            // 
            this.dataIdtxt.Location = new System.Drawing.Point(288, 152);
            this.dataIdtxt.Name = "dataIdtxt";
            this.dataIdtxt.Size = new System.Drawing.Size(100, 21);
            this.dataIdtxt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // orderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataIdtxt);
            this.Controls.Add(this.orderNotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "orderform";
            this.Text = "orderform";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void Form3_Load(object sender, System.EventArgs e)
        {

        }
    }
}