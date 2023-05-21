namespace imgResize
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
            txt_log = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btn_folder = new Button();
            txt_folder = new TextBox();
            btn_change = new Button();
            lbl_x = new Label();
            txt_x = new TextBox();
            txt_y = new TextBox();
            lbl_y = new Label();
            label1 = new Label();
            label2 = new Label();
            btn_make17 = new Button();
            lbl_17 = new Label();
            btn_chgSize = new Button();
            label3 = new Label();
            label4 = new Label();
            txt_y2 = new TextBox();
            label5 = new Label();
            txt_x2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            txt_newFileName = new TextBox();
            btn_NameChange = new Button();
            label10 = new Label();
            label11 = new Label();
            btn_make26 = new Button();
            label8 = new Label();
            btn_NameChangeP1 = new Button();
            SuspendLayout();
            // 
            // txt_log
            // 
            txt_log.Location = new Point(12, 226);
            txt_log.Multiline = true;
            txt_log.Name = "txt_log";
            txt_log.ScrollBars = ScrollBars.Vertical;
            txt_log.Size = new Size(776, 267);
            txt_log.TabIndex = 0;
            // 
            // btn_folder
            // 
            btn_folder.Location = new Point(713, 18);
            btn_folder.Name = "btn_folder";
            btn_folder.Size = new Size(75, 23);
            btn_folder.TabIndex = 1;
            btn_folder.Text = "폴더선택";
            btn_folder.UseVisualStyleBackColor = true;
            btn_folder.Click += btn_folder_Click;
            // 
            // txt_folder
            // 
            txt_folder.Location = new Point(12, 18);
            txt_folder.Name = "txt_folder";
            txt_folder.Size = new Size(695, 23);
            txt_folder.TabIndex = 2;
            txt_folder.Text = "D:\\unity\\design\\shootC4EI\\new\\player";
            // 
            // btn_change
            // 
            btn_change.Location = new Point(713, 57);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(75, 23);
            btn_change.TabIndex = 3;
            btn_change.Text = "변경";
            btn_change.UseVisualStyleBackColor = true;
            btn_change.Click += btn_change_Click;
            // 
            // lbl_x
            // 
            lbl_x.AutoSize = true;
            lbl_x.Location = new Point(323, 59);
            lbl_x.Name = "lbl_x";
            lbl_x.Size = new Size(55, 15);
            lbl_x.TabIndex = 4;
            lbl_x.Text = "변경너비";
            // 
            // txt_x
            // 
            txt_x.Location = new Point(384, 56);
            txt_x.Name = "txt_x";
            txt_x.Size = new Size(48, 23);
            txt_x.TabIndex = 5;
            txt_x.Text = "212";
            // 
            // txt_y
            // 
            txt_y.Location = new Point(574, 56);
            txt_y.Name = "txt_y";
            txt_y.Size = new Size(42, 23);
            txt_y.TabIndex = 7;
            txt_y.Text = "237";
            // 
            // lbl_y
            // 
            lbl_y.AutoSize = true;
            lbl_y.Location = new Point(513, 59);
            lbl_y.Name = "lbl_y";
            lbl_y.Size = new Size(55, 15);
            lbl_y.TabIndex = 6;
            lbl_y.Text = "변경높이";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 61);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 8;
            label1.Text = "pixel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(622, 61);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 9;
            label2.Text = "pixel";
            // 
            // btn_make17
            // 
            btn_make17.Location = new Point(427, 95);
            btn_make17.Name = "btn_make17";
            btn_make17.Size = new Size(141, 23);
            btn_make17.TabIndex = 10;
            btn_make17.Text = "18장만들기(루프)";
            btn_make17.UseVisualStyleBackColor = true;
            btn_make17.Click += btn_make17_Click;
            // 
            // lbl_17
            // 
            lbl_17.AutoSize = true;
            lbl_17.Location = new Point(198, 99);
            lbl_17.Name = "lbl_17";
            lbl_17.Size = new Size(229, 15);
            lbl_17.TabIndex = 11;
            lbl_17.Text = "skeleton-Walk_0.png~3 까지 폴더에 준비";
            // 
            // btn_chgSize
            // 
            btn_chgSize.Location = new Point(674, 132);
            btn_chgSize.Name = "btn_chgSize";
            btn_chgSize.Size = new Size(114, 23);
            btn_chgSize.TabIndex = 12;
            btn_chgSize.Text = "이미지사이즈변경";
            btn_chgSize.UseVisualStyleBackColor = true;
            btn_chgSize.Click += btn_chgSize_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(622, 138);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 18;
            label3.Text = "pixel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 138);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 17;
            label4.Text = "pixel";
            // 
            // txt_y2
            // 
            txt_y2.Location = new Point(574, 133);
            txt_y2.Name = "txt_y2";
            txt_y2.Size = new Size(42, 23);
            txt_y2.TabIndex = 16;
            txt_y2.Text = "237";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(513, 136);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 15;
            label5.Text = "변경높이";
            // 
            // txt_x2
            // 
            txt_x2.Location = new Point(384, 133);
            txt_x2.Name = "txt_x2";
            txt_x2.Size = new Size(48, 23);
            txt_x2.TabIndex = 14;
            txt_x2.Text = "212";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(323, 136);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 13;
            label6.Text = "변경너비";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 181);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 19;
            label7.Text = "파일명일괄변경";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(321, 181);
            label9.Name = "label9";
            label9.Size = new Size(123, 15);
            label9.TabIndex = 23;
            label9.Text = "변경될 파일명 앞부분";
            // 
            // txt_newFileName
            // 
            txt_newFileName.Location = new Point(450, 178);
            txt_newFileName.Name = "txt_newFileName";
            txt_newFileName.Size = new Size(149, 23);
            txt_newFileName.TabIndex = 22;
            txt_newFileName.Text = "skeleton-Idle_";
            // 
            // btn_NameChange
            // 
            btn_NameChange.Location = new Point(605, 173);
            btn_NameChange.Name = "btn_NameChange";
            btn_NameChange.Size = new Size(174, 23);
            btn_NameChange.TabIndex = 24;
            btn_NameChange.Text = "파일명 번호빼고 일괄변경";
            btn_NameChange.UseVisualStyleBackColor = true;
            btn_NameChange.Click += btn_NameChange_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 140);
            label10.Name = "label10";
            label10.Size = new Size(131, 15);
            label10.TabIndex = 25;
            label10.Text = "이미지사이즈 일괄변경";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 99);
            label11.Name = "label11";
            label11.Size = new Size(180, 15);
            label11.TabIndex = 26;
            label11.Text = "이미지4장을 17장으로 순차복사";
            // 
            // btn_make26
            // 
            btn_make26.Location = new Point(580, 95);
            btn_make26.Name = "btn_make26";
            btn_make26.Size = new Size(208, 23);
            btn_make26.TabIndex = 27;
            btn_make26.Text = "26장만들기(death0~3까지준비)";
            btn_make26.UseVisualStyleBackColor = true;
            btn_make26.Click += btn_make26_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 59);
            label8.Name = "label8";
            label8.Size = new Size(159, 15);
            label8.TabIndex = 28;
            label8.Text = "뻥튀기(캐릭터를배경크기로)";
            // 
            // btn_NameChangeP1
            // 
            btn_NameChangeP1.Location = new Point(605, 197);
            btn_NameChangeP1.Name = "btn_NameChangeP1";
            btn_NameChangeP1.Size = new Size(174, 23);
            btn_NameChangeP1.TabIndex = 29;
            btn_NameChangeP1.Text = "파일명 번호빼고-1일괄변경";
            btn_NameChangeP1.UseVisualStyleBackColor = true;
            btn_NameChangeP1.Click += btn_NameChangeP1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(btn_NameChangeP1);
            Controls.Add(label8);
            Controls.Add(btn_make26);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btn_NameChange);
            Controls.Add(label9);
            Controls.Add(txt_newFileName);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txt_y2);
            Controls.Add(label5);
            Controls.Add(txt_x2);
            Controls.Add(label6);
            Controls.Add(btn_chgSize);
            Controls.Add(lbl_17);
            Controls.Add(btn_make17);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_y);
            Controls.Add(lbl_y);
            Controls.Add(txt_x);
            Controls.Add(lbl_x);
            Controls.Add(btn_change);
            Controls.Add(txt_folder);
            Controls.Add(btn_folder);
            Controls.Add(txt_log);
            Name = "Form1";
            Text = "이미지일괄변경";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_log;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btn_folder;
        private TextBox txt_folder;
        private Button btn_change;
        private Label lbl_x;
        private TextBox txt_x;
        private TextBox txt_y;
        private Label lbl_y;
        private Label label1;
        private Label label2;
        private Button btn_make17;
        private Label lbl_17;
        private Button btn_chgSize;
        private Label label3;
        private Label label4;
        private TextBox txt_y2;
        private Label label5;
        private TextBox txt_x2;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox txt_newFileName;
        private Button btn_NameChange;
        private Label label10;
        private Label label11;
        private Button btn_make26;
        private Label label8;
        private Button btn_NameChangeP1;
    }
}