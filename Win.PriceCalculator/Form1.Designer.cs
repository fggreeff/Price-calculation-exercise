namespace Win.PriceCalculator
{
    partial class frmPriceCalc
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
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblButter = new System.Windows.Forms.Label();
            this.lblMilk = new System.Windows.Forms.Label();
            this.lblBread = new System.Windows.Forms.Label();
            this.lblPromotion = new System.Windows.Forms.Label();
            this.gboxBasket = new System.Windows.Forms.GroupBox();
            this.numBread = new System.Windows.Forms.NumericUpDown();
            this.numMilk = new System.Windows.Forms.NumericUpDown();
            this.numButter = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gboxBasket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMilk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numButter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(366, 248);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(100, 40);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblButter
            // 
            this.lblButter.AutoSize = true;
            this.lblButter.Location = new System.Drawing.Point(131, 54);
            this.lblButter.Name = "lblButter";
            this.lblButter.Size = new System.Drawing.Size(35, 13);
            this.lblButter.TabIndex = 4;
            this.lblButter.Text = "Butter";
            // 
            // lblMilk
            // 
            this.lblMilk.AutoSize = true;
            this.lblMilk.Location = new System.Drawing.Point(131, 82);
            this.lblMilk.Name = "lblMilk";
            this.lblMilk.Size = new System.Drawing.Size(26, 13);
            this.lblMilk.TabIndex = 5;
            this.lblMilk.Text = "Milk";
            // 
            // lblBread
            // 
            this.lblBread.AutoSize = true;
            this.lblBread.Location = new System.Drawing.Point(131, 109);
            this.lblBread.Name = "lblBread";
            this.lblBread.Size = new System.Drawing.Size(35, 13);
            this.lblBread.TabIndex = 6;
            this.lblBread.Text = "Bread";
            // 
            // lblPromotion
            // 
            this.lblPromotion.AutoSize = true;
            this.lblPromotion.Location = new System.Drawing.Point(13, 22);
            this.lblPromotion.Name = "lblPromotion";
            this.lblPromotion.Size = new System.Drawing.Size(47, 13);
            this.lblPromotion.TabIndex = 7;
            this.lblPromotion.Text = "lblPromo";
            // 
            // gboxBasket
            // 
            this.gboxBasket.Controls.Add(this.numBread);
            this.gboxBasket.Controls.Add(this.numMilk);
            this.gboxBasket.Controls.Add(this.numButter);
            this.gboxBasket.Controls.Add(this.lblBread);
            this.gboxBasket.Controls.Add(this.lblMilk);
            this.gboxBasket.Controls.Add(this.lblButter);
            this.gboxBasket.Location = new System.Drawing.Point(12, 83);
            this.gboxBasket.Name = "gboxBasket";
            this.gboxBasket.Size = new System.Drawing.Size(250, 171);
            this.gboxBasket.TabIndex = 8;
            this.gboxBasket.TabStop = false;
            this.gboxBasket.Text = "Basket";
            // 
            // numBread
            // 
            this.numBread.Location = new System.Drawing.Point(7, 107);
            this.numBread.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBread.Name = "numBread";
            this.numBread.Size = new System.Drawing.Size(120, 20);
            this.numBread.TabIndex = 9;
            // 
            // numMilk
            // 
            this.numMilk.Location = new System.Drawing.Point(7, 80);
            this.numMilk.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMilk.Name = "numMilk";
            this.numMilk.Size = new System.Drawing.Size(120, 20);
            this.numMilk.TabIndex = 8;
            // 
            // numButter
            // 
            this.numButter.Location = new System.Drawing.Point(7, 52);
            this.numButter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numButter.Name = "numButter";
            this.numButter.Size = new System.Drawing.Size(118, 20);
            this.numButter.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(366, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(16, 277);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // frmPriceCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gboxBasket);
            this.Controls.Add(this.lblPromotion);
            this.Controls.Add(this.btnCheckout);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "frmPriceCalc";
            this.Text = "Price Calculator";
            this.gboxBasket.ResumeLayout(false);
            this.gboxBasket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMilk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numButter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblButter;
        private System.Windows.Forms.Label lblMilk;
        private System.Windows.Forms.Label lblBread;
        private System.Windows.Forms.Label lblPromotion;
        private System.Windows.Forms.GroupBox gboxBasket;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown numBread;
        private System.Windows.Forms.NumericUpDown numMilk;
        private System.Windows.Forms.NumericUpDown numButter;
    }
}

