
namespace GUI_Class_0220
{
    partial class Form_TextBox
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
            this.textBox_Add1 = new System.Windows.Forms.TextBox();
            this.textBox_Add2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Add1
            // 
            this.textBox_Add1.Location = new System.Drawing.Point(52, 54);
            this.textBox_Add1.Name = "textBox_Add1";
            this.textBox_Add1.Size = new System.Drawing.Size(100, 22);
            this.textBox_Add1.TabIndex = 0;
            // 
            // textBox_Add2
            // 
            this.textBox_Add2.Location = new System.Drawing.Point(197, 54);
            this.textBox_Add2.Name = "textBox_Add2";
            this.textBox_Add2.Size = new System.Drawing.Size(100, 22);
            this.textBox_Add2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(320, 57);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(10, 12);
            this.label_result.TabIndex = 2;
            this.label_result.Text = "?";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(347, 54);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "計算";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Form_TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Add2);
            this.Controls.Add(this.textBox_Add1);
            this.Name = "Form_TextBox";
            this.Text = "Form_TextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Add1;
        private System.Windows.Forms.TextBox textBox_Add2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button btn_Add;
    }
}