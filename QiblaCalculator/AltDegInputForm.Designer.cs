namespace QiblaCalculator
{
  partial class AltDegInputForm
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
      this.buttonAccept = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.numericUpDownLatDeg = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownLatArcmin = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.numericUpDownLatArcsec = new System.Windows.Forms.NumericUpDown();
      this.label6 = new System.Windows.Forms.Label();
      this.numericUpDownLongArcsec = new System.Windows.Forms.NumericUpDown();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.numericUpDownLongArcmin = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownLongDeg = new System.Windows.Forms.NumericUpDown();
      this.label9 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatDeg)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatArcmin)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatArcsec)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongArcsec)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongArcmin)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongDeg)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonAccept
      // 
      this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonAccept.Location = new System.Drawing.Point(37, 157);
      this.buttonAccept.Name = "buttonAccept";
      this.buttonAccept.Size = new System.Drawing.Size(75, 23);
      this.buttonAccept.TabIndex = 0;
      this.buttonAccept.Text = "&Accept";
      this.buttonAccept.UseVisualStyleBackColor = true;
      this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(136, 157);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 1;
      this.buttonCancel.Text = "&Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(231, 27);
      this.label1.TabIndex = 2;
      this.label1.Text = "This is an alternate input option using degrees, arcminutes and arcseconds.";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(21, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Latitude:";
      // 
      // numericUpDownLatDeg
      // 
      this.numericUpDownLatDeg.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownLatDeg.Location = new System.Drawing.Point(24, 64);
      this.numericUpDownLatDeg.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
      this.numericUpDownLatDeg.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
      this.numericUpDownLatDeg.Name = "numericUpDownLatDeg";
      this.numericUpDownLatDeg.Size = new System.Drawing.Size(57, 20);
      this.numericUpDownLatDeg.TabIndex = 4;
      // 
      // numericUpDownLatArcmin
      // 
      this.numericUpDownLatArcmin.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownLatArcmin.Location = new System.Drawing.Point(104, 64);
      this.numericUpDownLatArcmin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDownLatArcmin.Name = "numericUpDownLatArcmin";
      this.numericUpDownLatArcmin.Size = new System.Drawing.Size(40, 20);
      this.numericUpDownLatArcmin.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(87, 65);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(11, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "°";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(150, 65);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(9, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "\'";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(211, 65);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(12, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "\"";
      // 
      // numericUpDownLatArcsec
      // 
      this.numericUpDownLatArcsec.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownLatArcsec.Location = new System.Drawing.Point(165, 64);
      this.numericUpDownLatArcsec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDownLatArcsec.Name = "numericUpDownLatArcsec";
      this.numericUpDownLatArcsec.Size = new System.Drawing.Size(40, 20);
      this.numericUpDownLatArcsec.TabIndex = 9;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(211, 115);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(12, 13);
      this.label6.TabIndex = 17;
      this.label6.Text = "\"";
      // 
      // numericUpDownLongArcsec
      // 
      this.numericUpDownLongArcsec.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownLongArcsec.Location = new System.Drawing.Point(165, 114);
      this.numericUpDownLongArcsec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDownLongArcsec.Name = "numericUpDownLongArcsec";
      this.numericUpDownLongArcsec.Size = new System.Drawing.Size(40, 20);
      this.numericUpDownLongArcsec.TabIndex = 16;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(150, 115);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(9, 13);
      this.label7.TabIndex = 15;
      this.label7.Text = "\'";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(87, 115);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(11, 13);
      this.label8.TabIndex = 14;
      this.label8.Text = "°";
      // 
      // numericUpDownLongArcmin
      // 
      this.numericUpDownLongArcmin.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownLongArcmin.Location = new System.Drawing.Point(104, 114);
      this.numericUpDownLongArcmin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numericUpDownLongArcmin.Name = "numericUpDownLongArcmin";
      this.numericUpDownLongArcmin.Size = new System.Drawing.Size(40, 20);
      this.numericUpDownLongArcmin.TabIndex = 13;
      // 
      // numericUpDownLongDeg
      // 
      this.numericUpDownLongDeg.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownLongDeg.Location = new System.Drawing.Point(24, 114);
      this.numericUpDownLongDeg.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
      this.numericUpDownLongDeg.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
      this.numericUpDownLongDeg.Name = "numericUpDownLongDeg";
      this.numericUpDownLongDeg.Size = new System.Drawing.Size(57, 20);
      this.numericUpDownLongDeg.TabIndex = 12;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(21, 98);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(57, 13);
      this.label9.TabIndex = 11;
      this.label9.Text = "Longitude:";
      // 
      // AltDegInputForm
      // 
      this.AcceptButton = this.buttonAccept;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonAccept;
      this.ClientSize = new System.Drawing.Size(247, 200);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.numericUpDownLongArcsec);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.numericUpDownLongArcmin);
      this.Controls.Add(this.numericUpDownLongDeg);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.numericUpDownLatArcsec);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.numericUpDownLatArcmin);
      this.Controls.Add(this.numericUpDownLatDeg);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonAccept);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AltDegInputForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Alternate Input";
      this.Load += new System.EventHandler(this.AltDegInputForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatDeg)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatArcmin)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatArcsec)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongArcsec)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongArcmin)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongDeg)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonAccept;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDownLatDeg;
    private System.Windows.Forms.NumericUpDown numericUpDownLatArcmin;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown numericUpDownLatArcsec;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown numericUpDownLongArcsec;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.NumericUpDown numericUpDownLongArcmin;
    private System.Windows.Forms.NumericUpDown numericUpDownLongDeg;
    private System.Windows.Forms.Label label9;
  }
}