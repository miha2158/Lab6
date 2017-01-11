using System.Windows.Forms;

namespace Lab6
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
        
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ArrayBox1 = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.SortedArrayBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.WordsBox2 = new System.Windows.Forms.TextBox();
            this.WordsBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArrayBox1
            // 
            this.ArrayBox1.Font = new System.Drawing.Font("Arial", 13F);
            this.ArrayBox1.Location = new System.Drawing.Point(5, 75);
            this.ArrayBox1.Multiline = true;
            this.ArrayBox1.Name = "ArrayBox1";
            this.ArrayBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ArrayBox1.Size = new System.Drawing.Size(465, 460);
            this.ArrayBox1.TabIndex = 1;
            this.ArrayBox1.WordWrap = false;
            this.ArrayBox1.TextChanged += new System.EventHandler(this.ArrayBox1_TextChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(5, 40);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(465, 30);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Отсортировать введённый массив";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(6, 6);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(465, 30);
            this.RandomButton.TabIndex = 2;
            this.RandomButton.Text = "Создать массив";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // SortedArrayBox
            // 
            this.SortedArrayBox.Font = new System.Drawing.Font("Arial", 13F);
            this.SortedArrayBox.Location = new System.Drawing.Point(475, 5);
            this.SortedArrayBox.Multiline = true;
            this.SortedArrayBox.Name = "SortedArrayBox";
            this.SortedArrayBox.ReadOnly = true;
            this.SortedArrayBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SortedArrayBox.Size = new System.Drawing.Size(465, 530);
            this.SortedArrayBox.TabIndex = 2;
            this.SortedArrayBox.WordWrap = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 570);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RandomButton);
            this.tabPage1.Controls.Add(this.CreateButton);
            this.tabPage1.Controls.Add(this.ArrayBox1);
            this.tabPage1.Controls.Add(this.SortedArrayBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(942, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Символы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ModifyButton);
            this.tabPage2.Controls.Add(this.WordsBox2);
            this.tabPage2.Controls.Add(this.WordsBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(942, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Строки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(5, 255);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(935, 30);
            this.ModifyButton.TabIndex = 2;
            this.ModifyButton.Text = "Преобразовать";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // WordsBox2
            // 
            this.WordsBox2.Font = new System.Drawing.Font("Arial", 13F);
            this.WordsBox2.Location = new System.Drawing.Point(5, 290);
            this.WordsBox2.Multiline = true;
            this.WordsBox2.Name = "WordsBox2";
            this.WordsBox2.ReadOnly = true;
            this.WordsBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.WordsBox2.Size = new System.Drawing.Size(935, 240);
            this.WordsBox2.TabIndex = 1;
            this.WordsBox2.WordWrap = false;
            // 
            // WordsBox
            // 
            this.WordsBox.Font = new System.Drawing.Font("Arial", 13F);
            this.WordsBox.Location = new System.Drawing.Point(5,5);
            this.WordsBox.Multiline = true;
            this.WordsBox.Name = "WordsBox";
            this.WordsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.WordsBox.Size = new System.Drawing.Size(935, 245);
            this.WordsBox.TabIndex = 0;
            this.WordsBox.WordWrap = false;
            this.WordsBox.TextChanged += new System.EventHandler(this.WordsBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(950, 570);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Cambria", 12F);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }
        
        private Button CreateButton;
        private TextBox ArrayBox1;
        private TextBox SortedArrayBox;
        private Button RandomButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox WordsBox;
        private Button ModifyButton;
        private TextBox WordsBox2;
    }
}

