﻿namespace Sudoku
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
            this.startButton = new System.Windows.Forms.Button();
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
            this.lastGameBeginner = new System.Windows.Forms.Button();
            this.lastGameModerate = new System.Windows.Forms.Button();
            this.lastGameAdvanced = new System.Windows.Forms.Button();
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
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(644, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(167, 38);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.Location = new System.Drawing.Point(841, 13);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(85, 64);
            this.newGameButton.TabIndex = 3;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(644, 60);
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
            this.button2.Location = new System.Drawing.Point(701, 60);
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
            this.button3.Location = new System.Drawing.Point(758, 60);
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
            this.button4.Location = new System.Drawing.Point(644, 114);
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
            this.button5.Location = new System.Drawing.Point(701, 114);
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
            this.button6.Location = new System.Drawing.Point(758, 114);
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
            this.button7.Location = new System.Drawing.Point(644, 170);
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
            this.button8.Location = new System.Drawing.Point(701, 170);
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
            this.button9.Location = new System.Drawing.Point(758, 170);
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
            this.solutionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionButton.Location = new System.Drawing.Point(841, 82);
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
            this.stuckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuckButton.Location = new System.Drawing.Point(841, 153);
            this.stuckButton.Name = "stuckButton";
            this.stuckButton.Size = new System.Drawing.Size(85, 64);
            this.stuckButton.TabIndex = 15;
            this.stuckButton.Text = "Am I Stuck?";
            this.stuckButton.UseVisualStyleBackColor = true;
            // 
            // playerID
            // 
            this.playerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerID.AutoSize = true;
            this.playerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerID.Location = new System.Drawing.Point(819, 249);
            this.playerID.Name = "playerID";
            this.playerID.Size = new System.Drawing.Size(108, 25);
            this.playerID.TabIndex = 16;
            this.playerID.Text = "Player ID";
            // 
            // buttonBlank
            // 
            this.buttonBlank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlank.Location = new System.Drawing.Point(689, 235);
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
            this.Beginner.Location = new System.Drawing.Point(644, 337);
            this.Beginner.Name = "Beginner";
            this.Beginner.Size = new System.Drawing.Size(102, 38);
            this.Beginner.TabIndex = 19;
            this.Beginner.Text = "Beginner";
            this.Beginner.UseVisualStyleBackColor = true;
            // 
            // moderate
            // 
            this.moderate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moderate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moderate.Location = new System.Drawing.Point(757, 337);
            this.moderate.Name = "moderate";
            this.moderate.Size = new System.Drawing.Size(102, 38);
            this.moderate.TabIndex = 20;
            this.moderate.Text = "Moderate";
            this.moderate.UseVisualStyleBackColor = true;
            // 
            // Advanced
            // 
            this.Advanced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Advanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advanced.Location = new System.Drawing.Point(869, 337);
            this.Advanced.Name = "Advanced";
            this.Advanced.Size = new System.Drawing.Size(106, 38);
            this.Advanced.TabIndex = 21;
            this.Advanced.Text = "Advanced";
            this.Advanced.UseVisualStyleBackColor = true;
            // 
            // lastGameBeginner
            // 
            this.lastGameBeginner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastGameBeginner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastGameBeginner.Location = new System.Drawing.Point(644, 381);
            this.lastGameBeginner.Name = "lastGameBeginner";
            this.lastGameBeginner.Size = new System.Drawing.Size(102, 53);
            this.lastGameBeginner.TabIndex = 22;
            this.lastGameBeginner.Text = "Last Game Beginner";
            this.lastGameBeginner.UseVisualStyleBackColor = true;
            // 
            // lastGameModerate
            // 
            this.lastGameModerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastGameModerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastGameModerate.Location = new System.Drawing.Point(757, 381);
            this.lastGameModerate.Name = "lastGameModerate";
            this.lastGameModerate.Size = new System.Drawing.Size(102, 53);
            this.lastGameModerate.TabIndex = 23;
            this.lastGameModerate.Text = "Last Game Moderate";
            this.lastGameModerate.UseVisualStyleBackColor = true;
            // 
            // lastGameAdvanced
            // 
            this.lastGameAdvanced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastGameAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastGameAdvanced.Location = new System.Drawing.Point(869, 381);
            this.lastGameAdvanced.Name = "lastGameAdvanced";
            this.lastGameAdvanced.Size = new System.Drawing.Size(102, 53);
            this.lastGameAdvanced.TabIndex = 24;
            this.lastGameAdvanced.Text = "Last Game Advanced";
            this.lastGameAdvanced.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 750);
            this.Controls.Add(this.lastGameAdvanced);
            this.Controls.Add(this.lastGameModerate);
            this.Controls.Add(this.lastGameBeginner);
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
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.board);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.Button startButton;
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
        private System.Windows.Forms.Button lastGameBeginner;
        private System.Windows.Forms.Button lastGameModerate;
        private System.Windows.Forms.Button lastGameAdvanced;
    }
}

