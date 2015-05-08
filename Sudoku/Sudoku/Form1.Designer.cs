namespace Sudoku
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
            this.board = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.solutionButton = new System.Windows.Forms.Button();
            this.stuckButton = new System.Windows.Forms.Button();
            this.playerID = new System.Windows.Forms.Label();
            this.buttonBlank = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.Beginner = new System.Windows.Forms.Button();
            this.moderate = new System.Windows.Forms.Button();
            this.Advanced = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastGame = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.resetNameButton = new System.Windows.Forms.Button();
            this.currentLevel = new System.Windows.Forms.Label();
            this.prevGames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.board.Location = new System.Drawing.Point(13, 13);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(600, 600);
            this.board.TabIndex = 0;
            this.board.Click += new System.EventHandler(this.board_Click);
            this.board.Paint += new System.Windows.Forms.PaintEventHandler(this.board_Paint);
            this.board.MouseClick += new System.Windows.Forms.MouseEventHandler(this.board_MouseClick);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.resetButton.Location = new System.Drawing.Point(952, 13);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(83, 53);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newGameButton.Location = new System.Drawing.Point(644, 12);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(167, 64);
            this.newGameButton.TabIndex = 3;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(644, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(701, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(758, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 52);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Location = new System.Drawing.Point(644, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 52);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button5.Location = new System.Drawing.Point(701, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 52);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button6.Location = new System.Drawing.Point(758, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 52);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button7.Location = new System.Drawing.Point(644, 198);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 52);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button8.Location = new System.Drawing.Point(701, 198);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 52);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button9.Location = new System.Drawing.Point(758, 198);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(53, 52);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // undoButton
            // 
            this.undoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.undoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.undoButton.Location = new System.Drawing.Point(952, 82);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(83, 53);
            this.undoButton.TabIndex = 13;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // solutionButton
            // 
            this.solutionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.solutionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.solutionButton.Location = new System.Drawing.Point(842, 13);
            this.solutionButton.Name = "solutionButton";
            this.solutionButton.Size = new System.Drawing.Size(85, 64);
            this.solutionButton.TabIndex = 14;
            this.solutionButton.Text = "Show Solution";
            this.solutionButton.UseVisualStyleBackColor = true;
            this.solutionButton.Click += new System.EventHandler(this.solutionButton_Click);
            // 
            // stuckButton
            // 
            this.stuckButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stuckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuckButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.stuckButton.Location = new System.Drawing.Point(842, 84);
            this.stuckButton.Name = "stuckButton";
            this.stuckButton.Size = new System.Drawing.Size(85, 64);
            this.stuckButton.TabIndex = 15;
            this.stuckButton.Text = "Am I Stuck?";
            this.stuckButton.UseVisualStyleBackColor = true;
            this.stuckButton.Click += new System.EventHandler(this.stuckButton_Click);
            // 
            // playerID
            // 
            this.playerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerID.AutoSize = true;
            this.playerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.playerID.Location = new System.Drawing.Point(844, 249);
            this.playerID.Name = "playerID";
            this.playerID.Size = new System.Drawing.Size(108, 25);
            this.playerID.TabIndex = 16;
            this.playerID.Text = "Player ID";
            // 
            // buttonBlank
            // 
            this.buttonBlank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlank.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBlank.Location = new System.Drawing.Point(689, 263);
            this.buttonBlank.Name = "buttonBlank";
            this.buttonBlank.Size = new System.Drawing.Size(83, 52);
            this.buttonBlank.TabIndex = 17;
            this.buttonBlank.Text = "erase";
            this.buttonBlank.UseVisualStyleBackColor = true;
            this.buttonBlank.Click += new System.EventHandler(this.buttonBlank_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(952, 153);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 53);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Beginner
            // 
            this.Beginner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Beginner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beginner.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Beginner.Location = new System.Drawing.Point(644, 380);
            this.Beginner.Name = "Beginner";
            this.Beginner.Size = new System.Drawing.Size(102, 38);
            this.Beginner.TabIndex = 19;
            this.Beginner.Text = "Beginner";
            this.Beginner.UseVisualStyleBackColor = true;
            this.Beginner.Click += new System.EventHandler(this.Beginner_Click);
            // 
            // moderate
            // 
            this.moderate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moderate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moderate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.moderate.Location = new System.Drawing.Point(757, 380);
            this.moderate.Name = "moderate";
            this.moderate.Size = new System.Drawing.Size(102, 38);
            this.moderate.TabIndex = 20;
            this.moderate.Text = "Moderate";
            this.moderate.UseVisualStyleBackColor = true;
            this.moderate.Click += new System.EventHandler(this.moderate_Click);
            // 
            // Advanced
            // 
            this.Advanced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Advanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advanced.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Advanced.Location = new System.Drawing.Point(869, 380);
            this.Advanced.Name = "Advanced";
            this.Advanced.Size = new System.Drawing.Size(106, 38);
            this.Advanced.TabIndex = 21;
            this.Advanced.Text = "Advanced";
            this.Advanced.UseVisualStyleBackColor = true;
            this.Advanced.Click += new System.EventHandler(this.Advanced_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(824, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 29);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastGame
            // 
            this.lastGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastGame.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lastGame.Location = new System.Drawing.Point(736, 435);
            this.lastGame.Name = "lastGame";
            this.lastGame.Size = new System.Drawing.Size(145, 38);
            this.lastGame.TabIndex = 26;
            this.lastGame.Text = "Last Game";
            this.lastGame.UseVisualStyleBackColor = true;
            this.lastGame.Click += new System.EventHandler(this.lastGame_Click);
            // 
            // setButton
            // 
            this.setButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.setButton.Location = new System.Drawing.Point(824, 313);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(84, 29);
            this.setButton.TabIndex = 27;
            this.setButton.Text = "SET";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // resetNameButton
            // 
            this.resetNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetNameButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.resetNameButton.Location = new System.Drawing.Point(914, 313);
            this.resetNameButton.Name = "resetNameButton";
            this.resetNameButton.Size = new System.Drawing.Size(75, 29);
            this.resetNameButton.TabIndex = 28;
            this.resetNameButton.Text = "Reset";
            this.resetNameButton.UseVisualStyleBackColor = true;
            this.resetNameButton.Click += new System.EventHandler(this.resetNameButton_Click);
            // 
            // currentLevel
            // 
            this.currentLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentLevel.AutoSize = true;
            this.currentLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLevel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.currentLevel.Location = new System.Drawing.Point(619, 511);
            this.currentLevel.Name = "currentLevel";
            this.currentLevel.Size = new System.Drawing.Size(168, 25);
            this.currentLevel.TabIndex = 29;
            this.currentLevel.Text = "Current Level: ";
            // 
            // prevGames
            // 
            this.prevGames.FormattingEnabled = true;
            this.prevGames.Location = new System.Drawing.Point(626, 552);
            this.prevGames.Name = "prevGames";
            this.prevGames.Size = new System.Drawing.Size(120, 95);
            this.prevGames.TabIndex = 30;
            this.prevGames.SelectedIndexChanged += new System.EventHandler(this.prevGames_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 750);
            this.Controls.Add(this.prevGames);
            this.Controls.Add(this.currentLevel);
            this.Controls.Add(this.resetNameButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.lastGame);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Advanced);
            this.Controls.Add(this.moderate);
            this.Controls.Add(this.Beginner);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.buttonBlank);
            this.Controls.Add(this.playerID);
            this.Controls.Add(this.stuckButton);
            this.Controls.Add(this.solutionButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.board);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button solutionButton;
        private System.Windows.Forms.Button stuckButton;
        private System.Windows.Forms.Label playerID;
        private System.Windows.Forms.Button buttonBlank;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button Beginner;
        private System.Windows.Forms.Button moderate;
        private System.Windows.Forms.Button Advanced;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button lastGame;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button resetNameButton;
        private System.Windows.Forms.Label currentLevel;
        private System.Windows.Forms.ListBox prevGames;
    }
}

