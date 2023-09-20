using System;
using System.Windows.Forms;

namespace TicTacToe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Message = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.Panel();
            this.ButtonBottomRight = new System.Windows.Forms.Button();
            this.ButtonBottomCentre = new System.Windows.Forms.Button();
            this.ButtonBottomLeft = new System.Windows.Forms.Button();
            this.ButtonMiddleRight = new System.Windows.Forms.Button();
            this.ButtonMiddleCentre = new System.Windows.Forms.Button();
            this.ButtonMiddleLeft = new System.Windows.Forms.Button();
            this.ButtonTopRight = new System.Windows.Forms.Button();
            this.ButtonTopMiddle = new System.Windows.Forms.Button();
            this.ButtonTopLeft = new System.Windows.Forms.Button();
            this.Retry = new System.Windows.Forms.Button();
            this.Grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Message.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Message.Location = new System.Drawing.Point(13, 7);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(134, 20);
            this.Message.TabIndex = 4;
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grid
            // 
            this.Grid.BackgroundImage = global::TicTacToe.Properties.Resources.kisspng_css_grid_layout_mathematics_game_law_offices_of_le_tic_tac_toe_the_classic_game_5b3bda9d3dec24_3962301915306492452537;
            this.Grid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Grid.Controls.Add(this.ButtonBottomRight);
            this.Grid.Controls.Add(this.ButtonBottomCentre);
            this.Grid.Controls.Add(this.ButtonBottomLeft);
            this.Grid.Controls.Add(this.ButtonMiddleRight);
            this.Grid.Controls.Add(this.ButtonMiddleCentre);
            this.Grid.Controls.Add(this.ButtonMiddleLeft);
            this.Grid.Controls.Add(this.ButtonTopRight);
            this.Grid.Controls.Add(this.ButtonTopMiddle);
            this.Grid.Controls.Add(this.ButtonTopLeft);
            this.Grid.Location = new System.Drawing.Point(11, 33);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(228, 232);
            this.Grid.TabIndex = 1;
            // 
            // ButtonBottomRight
            // 
            this.ButtonBottomRight.FlatAppearance.BorderSize = 0;
            this.ButtonBottomRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.ButtonBottomRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.ButtonBottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.ButtonBottomRight.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonBottomRight.Location = new System.Drawing.Point(159, 163);
            this.ButtonBottomRight.Name = "ButtonBottomRight";
            this.ButtonBottomRight.Size = new System.Drawing.Size(67, 70);
            this.ButtonBottomRight.TabIndex = 8;
            this.ButtonBottomRight.UseVisualStyleBackColor = true;
            // 
            // ButtonBottomCentre
            // 
            this.ButtonBottomCentre.FlatAppearance.BorderSize = 0;
            this.ButtonBottomCentre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.ButtonBottomCentre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.ButtonBottomCentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBottomCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.ButtonBottomCentre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonBottomCentre.Location = new System.Drawing.Point(82, 163);
            this.ButtonBottomCentre.Name = "ButtonBottomCentre";
            this.ButtonBottomCentre.Size = new System.Drawing.Size(67, 70);
            this.ButtonBottomCentre.TabIndex = 7;
            this.ButtonBottomCentre.UseVisualStyleBackColor = true;
            // 
            // ButtonBottomLeft
            // 
            this.ButtonBottomLeft.FlatAppearance.BorderSize = 0;
            this.ButtonBottomLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.ButtonBottomLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.ButtonBottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.ButtonBottomLeft.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonBottomLeft.Location = new System.Drawing.Point(5, 163);
            this.ButtonBottomLeft.Name = "ButtonBottomLeft";
            this.ButtonBottomLeft.Size = new System.Drawing.Size(67, 70);
            this.ButtonBottomLeft.TabIndex = 6;
            this.ButtonBottomLeft.UseVisualStyleBackColor = true;
            // 
            // ButtonMiddleRight
            // 
            this.ButtonMiddleRight.FlatAppearance.BorderSize = 0;
            this.ButtonMiddleRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.ButtonMiddleRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.ButtonMiddleRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMiddleRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.ButtonMiddleRight.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonMiddleRight.Location = new System.Drawing.Point(158, 81);
            this.ButtonMiddleRight.Name = "ButtonMiddleRight";
            this.ButtonMiddleRight.Size = new System.Drawing.Size(67, 70);
            this.ButtonMiddleRight.TabIndex = 5;
            this.ButtonMiddleRight.UseVisualStyleBackColor = true;
            // 
            // ButtonMiddleCentre
            // 
            this.ButtonMiddleCentre.FlatAppearance.BorderSize = 0;
            this.ButtonMiddleCentre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.ButtonMiddleCentre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.ButtonMiddleCentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMiddleCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.ButtonMiddleCentre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonMiddleCentre.Location = new System.Drawing.Point(81, 81);
            this.ButtonMiddleCentre.Name = "ButtonMiddleCentre";
            this.ButtonMiddleCentre.Size = new System.Drawing.Size(67, 70);
            this.ButtonMiddleCentre.TabIndex = 4;
            this.ButtonMiddleCentre.UseVisualStyleBackColor = true;
            // 
            // ButtonMiddleLeft
            // 
            this.ButtonMiddleLeft.FlatAppearance.BorderSize = 0;
            this.ButtonMiddleLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.ButtonMiddleLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.ButtonMiddleLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMiddleLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.ButtonMiddleLeft.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonMiddleLeft.Location = new System.Drawing.Point(4, 81);
            this.ButtonMiddleLeft.Name = "ButtonMiddleLeft";
            this.ButtonMiddleLeft.Size = new System.Drawing.Size(67, 70);
            this.ButtonMiddleLeft.TabIndex = 3;
            this.ButtonMiddleLeft.UseVisualStyleBackColor = true;
            // 
            // ButtonTopRight
            // 
            this.ButtonTopRight.FlatAppearance.BorderSize = 0;
            this.ButtonTopRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.ButtonTopRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.ButtonTopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.ButtonTopRight.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonTopRight.Location = new System.Drawing.Point(159, 1);
            this.ButtonTopRight.Name = "ButtonTopRight";
            this.ButtonTopRight.Size = new System.Drawing.Size(67, 70);
            this.ButtonTopRight.TabIndex = 2;
            this.ButtonTopRight.UseVisualStyleBackColor = true;
            // 
            // ButtonTopMiddle
            // 
            this.ButtonTopMiddle.FlatAppearance.BorderSize = 0;
            this.ButtonTopMiddle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.ButtonTopMiddle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.ButtonTopMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTopMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.ButtonTopMiddle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonTopMiddle.Location = new System.Drawing.Point(82, 1);
            this.ButtonTopMiddle.Name = "ButtonTopMiddle";
            this.ButtonTopMiddle.Size = new System.Drawing.Size(67, 70);
            this.ButtonTopMiddle.TabIndex = 1;
            this.ButtonTopMiddle.UseVisualStyleBackColor = true;
            // 
            // ButtonTopLeft
            // 
            this.ButtonTopLeft.FlatAppearance.BorderSize = 0;
            this.ButtonTopLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.ButtonTopLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.ButtonTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.ButtonTopLeft.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonTopLeft.Location = new System.Drawing.Point(5, 1);
            this.ButtonTopLeft.Name = "ButtonTopLeft";
            this.ButtonTopLeft.Size = new System.Drawing.Size(67, 70);
            this.ButtonTopLeft.TabIndex = 0;
            this.ButtonTopLeft.UseVisualStyleBackColor = true;
            // 
            // Retry
            // 
            this.Retry.FlatAppearance.BorderSize = 0;
            this.Retry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retry.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Retry.Location = new System.Drawing.Point(162, 7);
            this.Retry.Name = "Retry";
            this.Retry.Size = new System.Drawing.Size(75, 21);
            this.Retry.TabIndex = 5;
            this.Retry.Text = "Retry";
            this.Retry.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(250, 277);
            this.Controls.Add(this.Retry);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Grid);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Grid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Panel Grid;
        private System.Windows.Forms.Button ButtonTopLeft;
        private System.Windows.Forms.Button ButtonTopMiddle;
        private System.Windows.Forms.Button ButtonTopRight;
        private System.Windows.Forms.Button ButtonBottomRight;
        private System.Windows.Forms.Button ButtonBottomCentre;
        private System.Windows.Forms.Button ButtonBottomLeft;
        private System.Windows.Forms.Button ButtonMiddleRight;
        private System.Windows.Forms.Button ButtonMiddleCentre;
        private System.Windows.Forms.Button ButtonMiddleLeft;
        private Button Retry;
    }
}

