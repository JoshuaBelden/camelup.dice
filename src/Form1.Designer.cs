namespace CamelUp.DiceApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnNextRound = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lstCurrentRolls = new System.Windows.Forms.ListBox();
            this.lblCurrentRoll = new System.Windows.Forms.Label();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CamelUp.DiceApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Berlin Sans FB", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(662, 776);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(181, 136);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnNextRound
            // 
            this.btnNextRound.Font = new System.Drawing.Font("Berlin Sans FB", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextRound.Location = new System.Drawing.Point(918, 776);
            this.btnNextRound.Name = "btnNextRound";
            this.btnNextRound.Size = new System.Drawing.Size(181, 136);
            this.btnNextRound.TabIndex = 1;
            this.btnNextRound.Text = "Next Round";
            this.btnNextRound.UseVisualStyleBackColor = true;
            this.btnNextRound.Click += new System.EventHandler(this.btnNextRound_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(483, 26);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(759, 63);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "CamelUp - The Dice App";
            // 
            // lstCurrentRolls
            // 
            this.lstCurrentRolls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCurrentRolls.Font = new System.Drawing.Font("Berlin Sans FB", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCurrentRolls.FormattingEnabled = true;
            this.lstCurrentRolls.ItemHeight = 32;
            this.lstCurrentRolls.Location = new System.Drawing.Point(12, 487);
            this.lstCurrentRolls.Name = "lstCurrentRolls";
            this.lstCurrentRolls.Size = new System.Drawing.Size(454, 452);
            this.lstCurrentRolls.TabIndex = 3;
            // 
            // lblCurrentRoll
            // 
            this.lblCurrentRoll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentRoll.BackColor = System.Drawing.Color.White;
            this.lblCurrentRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentRoll.Font = new System.Drawing.Font("Berlin Sans FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRoll.Location = new System.Drawing.Point(562, 212);
            this.lblCurrentRoll.Name = "lblCurrentRoll";
            this.lblCurrentRoll.Size = new System.Drawing.Size(629, 511);
            this.lblCurrentRoll.TabIndex = 5;
            this.lblCurrentRoll.Text = "?";
            this.lblCurrentRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(511, 776);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(145, 136);
            this.Player.TabIndex = 6;
            this.Player.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 966);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.lblCurrentRoll);
            this.Controls.Add(this.lstCurrentRolls);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.btnNextRound);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CamelUp - The Dice App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnNextRound;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.ListBox lstCurrentRolls;
        private System.Windows.Forms.Label lblCurrentRoll;
        private AxWMPLib.AxWindowsMediaPlayer Player;
    }
}

