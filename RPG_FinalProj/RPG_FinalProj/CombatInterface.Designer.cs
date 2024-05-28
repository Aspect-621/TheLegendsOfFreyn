﻿namespace RPG_FinalProj
{
    partial class CombatInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombatInterface));
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Player = new PictureBox();
            EnemyPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnemyPic).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(179, 467);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(142, 31);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(358, 462);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(140, 36);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(180, 522);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(141, 36);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(358, 522);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(270, 36);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(560, 467);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 80);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(680, 467);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 80);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(514, 244);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(273, 80);
            label1.TabIndex = 6;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(514, 338);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(273, 80);
            label2.TabIndex = 7;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.Image = Properties.Resources.sword_walk_right;
            Player.Location = new Point(106, 266);
            Player.Name = "Player";
            Player.Size = new Size(165, 177);
            Player.SizeMode = PictureBoxSizeMode.Zoom;
            Player.TabIndex = 8;
            Player.TabStop = false;
            // 
            // EnemyPic
            // 
            EnemyPic.BackColor = Color.Transparent;
            EnemyPic.Image = Properties.Resources.slimeKingAttack;
            EnemyPic.Location = new Point(594, 25);
            EnemyPic.Name = "EnemyPic";
            EnemyPic.Size = new Size(165, 177);
            EnemyPic.SizeMode = PictureBoxSizeMode.Zoom;
            EnemyPic.TabIndex = 9;
            EnemyPic.TabStop = false;
            // 
            // CombatInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(880, 590);
            Controls.Add(EnemyPic);
            Controls.Add(Player);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            DoubleBuffered = true;
            Name = "CombatInterface";
            Text = "CombatInterface";
            Load += CombatInterface_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnemyPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private PictureBox Player;
        private PictureBox EnemyPic;
    }
}