namespace ConsoleApp2.Visuals
{
    partial class Table
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playerSeat1 = new ConsoleApp2.Visuals.PlayerSeat();
            this.seat6 = new ConsoleApp2.Visuals.Seat();
            this.seat5 = new ConsoleApp2.Visuals.Seat();
            this.seat3 = new ConsoleApp2.Visuals.Seat();
            this.seat2 = new ConsoleApp2.Visuals.Seat();
            this.seat1 = new ConsoleApp2.Visuals.Seat();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playerSeat1
            // 
            this.playerSeat1.Location = new System.Drawing.Point(570, 476);
            this.playerSeat1.Name = "playerSeat1";
            this.playerSeat1.Size = new System.Drawing.Size(281, 112);
            this.playerSeat1.TabIndex = 6;
            // 
            // seat6
            // 
            this.seat6.BackColor = System.Drawing.Color.Silver;
            this.seat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat6.Location = new System.Drawing.Point(13, 245);
            this.seat6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat6.Name = "seat6";
            this.seat6.Size = new System.Drawing.Size(240, 92);
            this.seat6.TabIndex = 5;
            // 
            // seat5
            // 
            this.seat5.BackColor = System.Drawing.Color.Silver;
            this.seat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat5.Location = new System.Drawing.Point(133, 518);
            this.seat5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat5.Name = "seat5";
            this.seat5.Size = new System.Drawing.Size(240, 92);
            this.seat5.TabIndex = 4;
            // 
            // seat3
            // 
            this.seat3.BackColor = System.Drawing.Color.Silver;
            this.seat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat3.Location = new System.Drawing.Point(739, 245);
            this.seat3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat3.Name = "seat3";
            this.seat3.Size = new System.Drawing.Size(240, 92);
            this.seat3.TabIndex = 2;
            // 
            // seat2
            // 
            this.seat2.BackColor = System.Drawing.Color.Silver;
            this.seat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat2.Location = new System.Drawing.Point(536, 14);
            this.seat2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat2.Name = "seat2";
            this.seat2.Size = new System.Drawing.Size(240, 92);
            this.seat2.TabIndex = 1;
            // 
            // seat1
            // 
            this.seat1.BackColor = System.Drawing.Color.Silver;
            this.seat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat1.Location = new System.Drawing.Point(133, 14);
            this.seat1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat1.Name = "seat1";
            this.seat1.Size = new System.Drawing.Size(240, 92);
            this.seat1.TabIndex = 0;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 624);
            this.Controls.Add(this.playerSeat1);
            this.Controls.Add(this.seat6);
            this.Controls.Add(this.seat5);
            this.Controls.Add(this.seat3);
            this.Controls.Add(this.seat2);
            this.Controls.Add(this.seat1);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Seat seat1;
        private Seat seat2;
        private Seat seat3;
        private Seat seat5;
        private Seat seat6;
        private System.Windows.Forms.Timer timer1;
        private PlayerSeat playerSeat1;
    }
}