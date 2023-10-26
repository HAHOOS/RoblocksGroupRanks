namespace RobloxGroupRanks
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
            components = new System.ComponentModel.Container();
            button_check = new Button();
            groupId_box = new TextBox();
            groupId_title = new Label();
            rank = new ContextMenuStrip(components);
            name = new ToolStripMenuItem();
            rankNum = new ToolStripMenuItem();
            ranks_box = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            rank.SuspendLayout();
            SuspendLayout();
            // 
            // button_check
            // 
            button_check.Location = new Point(12, 56);
            button_check.Name = "button_check";
            button_check.Size = new Size(75, 23);
            button_check.TabIndex = 0;
            button_check.Text = "Check";
            button_check.UseVisualStyleBackColor = true;
            button_check.Click += button_check_Click;
            // 
            // groupId_box
            // 
            groupId_box.Location = new Point(12, 27);
            groupId_box.Name = "groupId_box";
            groupId_box.Size = new Size(343, 23);
            groupId_box.TabIndex = 1;
            groupId_box.KeyPress += button_check_KeyPress;
            // 
            // groupId_title
            // 
            groupId_title.AutoSize = true;
            groupId_title.Location = new Point(12, 9);
            groupId_title.Name = "groupId_title";
            groupId_title.Size = new Size(57, 15);
            groupId_title.TabIndex = 2;
            groupId_title.Text = "Group ID:";
            // 
            // rank
            // 
            rank.Items.AddRange(new ToolStripItem[] { name, rankNum });
            rank.Name = "rank";
            rank.Size = new Size(179, 48);
            // 
            // name
            // 
            name.Name = "name";
            name.Size = new Size(178, 22);
            name.Text = "Copy Name";
            // 
            // rankNum
            // 
            rankNum.Name = "rankNum";
            rankNum.Size = new Size(178, 22);
            rankNum.Text = "Copy Rank Number";
            // 
            // ranks_box
            // 
            ranks_box.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ranks_box.FormattingEnabled = true;
            ranks_box.ItemHeight = 16;
            ranks_box.Items.AddRange(new object[] { "N/A" });
            ranks_box.Location = new Point(14, 91);
            ranks_box.Name = "ranks_box";
            ranks_box.Size = new Size(341, 340);
            ranks_box.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 468);
            button1.Name = "button1";
            button1.Size = new Size(340, 23);
            button1.TabIndex = 4;
            button1.Text = "Copy All Content";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 437);
            button2.Name = "button2";
            button2.Size = new Size(179, 23);
            button2.TabIndex = 5;
            button2.Text = "Copy Rank Number";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(197, 437);
            button3.Name = "button3";
            button3.Size = new Size(155, 23);
            button3.TabIndex = 6;
            button3.Text = "Copy Rank Name";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 517);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ranks_box);
            Controls.Add(groupId_title);
            Controls.Add(groupId_box);
            Controls.Add(button_check);
            Name = "Form1";
            Text = "Roblocks Group Ranks";
            rank.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_check;
        private TextBox groupId_box;
        private Label groupId_title;
        private ContextMenuStrip rank;
        private ToolStripMenuItem name;
        private ToolStripMenuItem rankNum;
        private ListBox ranks_box;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}