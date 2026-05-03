namespace ModNote
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
            ModListBox = new ListBox();
            ModeNameBox = new TextBox();
            ModContextBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            UserModContextBox = new TextBox();
            groupBox1 = new GroupBox();
            AddButton = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ItemDelectButton = new Button();
            label3 = new Label();
            SearchBox = new TextBox();
            groupBox4 = new GroupBox();
            ExitButton = new Button();
            OutputJsonButton = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // ModListBox
            // 
            ModListBox.FormattingEnabled = true;
            ModListBox.Location = new Point(12, 12);
            ModListBox.Name = "ModListBox";
            ModListBox.Size = new Size(196, 424);
            ModListBox.TabIndex = 0;
            ModListBox.SelectedIndexChanged += ModListBox_SelectedIndexChanged;
            // 
            // ModeNameBox
            // 
            ModeNameBox.Location = new Point(96, 20);
            ModeNameBox.Name = "ModeNameBox";
            ModeNameBox.Size = new Size(141, 27);
            ModeNameBox.TabIndex = 1;
            // 
            // ModContextBox
            // 
            ModContextBox.Location = new Point(6, 26);
            ModContextBox.Name = "ModContextBox";
            ModContextBox.Size = new Size(562, 217);
            ModContextBox.TabIndex = 2;
            ModContextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 3;
            label1.Text = "模组名字：";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 5;
            label2.Text = "模组描述：";
            // 
            // UserModContextBox
            // 
            UserModContextBox.Location = new Point(95, 53);
            UserModContextBox.Name = "UserModContextBox";
            UserModContextBox.Size = new Size(141, 27);
            UserModContextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ModeNameBox);
            groupBox1.Controls.Add(UserModContextBox);
            groupBox1.Location = new Point(214, 267);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 118);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "添加";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(6, 79);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(84, 34);
            AddButton.TabIndex = 6;
            AddButton.Text = "添加";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ModContextBox);
            groupBox2.Location = new Point(214, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(574, 249);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "描述";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ItemDelectButton);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(SearchBox);
            groupBox3.Location = new Point(214, 386);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(258, 52);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "删除";
            // 
            // ItemDelectButton
            // 
            ItemDelectButton.Location = new Point(182, 21);
            ItemDelectButton.Name = "ItemDelectButton";
            ItemDelectButton.Size = new Size(70, 25);
            ItemDelectButton.TabIndex = 6;
            ItemDelectButton.Text = "删除";
            ItemDelectButton.UseVisualStyleBackColor = true;
            ItemDelectButton.Click += ItemDelectButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "搜索：";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(61, 19);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(115, 27);
            SearchBox.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(ExitButton);
            groupBox4.Controls.Add(OutputJsonButton);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(478, 267);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(310, 171);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "关于和工具箱";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(218, 135);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(86, 30);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "关闭";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // OutputJsonButton
            // 
            OutputJsonButton.Location = new Point(6, 135);
            OutputJsonButton.Name = "OutputJsonButton";
            OutputJsonButton.Size = new Size(91, 27);
            OutputJsonButton.TabIndex = 1;
            OutputJsonButton.Text = "导出JSON";
            OutputJsonButton.UseVisualStyleBackColor = true;
            OutputJsonButton.Click += OutputJsonButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 27);
            label4.Name = "label4";
            label4.Size = new Size(181, 20);
            label4.TabIndex = 0;
            label4.Text = "制作者：OFFMN-SHARP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ModListBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Note";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ModListBox;
        private TextBox ModeNameBox;
        private RichTextBox ModContextBox;
        private Label label1;
        private Label label2;
        private TextBox UserModContextBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button AddButton;
        private GroupBox groupBox3;
        private Button ItemDelectButton;
        private Label label3;
        private TextBox SearchBox;
        private GroupBox groupBox4;
        private Label label4;
        private Button ExitButton;
        private Button OutputJsonButton;
    }
}
