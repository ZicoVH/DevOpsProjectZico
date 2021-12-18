
namespace CaseStudyZico
{
    partial class PractiseElement
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDelElement = new System.Windows.Forms.Button();
            this.btnAddElement = new System.Windows.Forms.Button();
            this.InsertDatatxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(25, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 304);
            this.listBox1.TabIndex = 10;
            // 
            // btnDelElement
            // 
            this.btnDelElement.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelElement.Location = new System.Drawing.Point(558, 183);
            this.btnDelElement.Name = "btnDelElement";
            this.btnDelElement.Size = new System.Drawing.Size(179, 87);
            this.btnDelElement.TabIndex = 9;
            this.btnDelElement.Text = "Delete";
            this.btnDelElement.UseVisualStyleBackColor = true;
            this.btnDelElement.Click += new System.EventHandler(this.btnDelElement_Click);
            // 
            // btnAddElement
            // 
            this.btnAddElement.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddElement.Location = new System.Drawing.Point(375, 183);
            this.btnAddElement.Name = "btnAddElement";
            this.btnAddElement.Size = new System.Drawing.Size(177, 87);
            this.btnAddElement.TabIndex = 7;
            this.btnAddElement.Text = "Add";
            this.btnAddElement.UseVisualStyleBackColor = true;
            this.btnAddElement.Click += new System.EventHandler(this.btnAddElement_Click);
            // 
            // InsertDatatxt
            // 
            this.InsertDatatxt.Location = new System.Drawing.Point(435, 116);
            this.InsertDatatxt.Name = "InsertDatatxt";
            this.InsertDatatxt.Size = new System.Drawing.Size(248, 31);
            this.InsertDatatxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add an element:";
            // 
            // PractiseElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDelElement);
            this.Controls.Add(this.InsertDatatxt);
            this.Controls.Add(this.btnAddElement);
            this.Name = "PractiseElement";
            this.Text = "PractiseElement";
            this.Load += new System.EventHandler(this.PractiseElement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDelElement;
        private System.Windows.Forms.Button btnAddElement;
        private System.Windows.Forms.TextBox InsertDatatxt;
        private System.Windows.Forms.Label label1;
    }
}