namespace QiblaCalculator
{
  partial class SettingsForm
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
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.numericUpDownLongitude = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownLatitude = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonAccept = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongitude)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatitude)).BeginInit();
      this.SuspendLayout();
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(172, 78);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(11, 13);
      this.label8.TabIndex = 12;
      this.label8.Text = "°";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(172, 51);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(11, 13);
      this.label7.TabIndex = 9;
      this.label7.Text = "°";
      // 
      // numericUpDownLongitude
      // 
      this.numericUpDownLongitude.DecimalPlaces = 4;
      this.numericUpDownLongitude.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownLongitude.Location = new System.Drawing.Point(91, 76);
      this.numericUpDownLongitude.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
      this.numericUpDownLongitude.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
      this.numericUpDownLongitude.Name = "numericUpDownLongitude";
      this.numericUpDownLongitude.Size = new System.Drawing.Size(75, 20);
      this.numericUpDownLongitude.TabIndex = 11;
      // 
      // numericUpDownLatitude
      // 
      this.numericUpDownLatitude.DecimalPlaces = 4;
      this.numericUpDownLatitude.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownLatitude.Location = new System.Drawing.Point(91, 49);
      this.numericUpDownLatitude.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
      this.numericUpDownLatitude.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
      this.numericUpDownLatitude.Name = "numericUpDownLatitude";
      this.numericUpDownLatitude.Size = new System.Drawing.Size(75, 20);
      this.numericUpDownLatitude.TabIndex = 8;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 77);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 10;
      this.label2.Text = "L&ongitude:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 50);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "L&atitude:";
      // 
      // buttonAccept
      // 
      this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonAccept.Location = new System.Drawing.Point(13, 129);
      this.buttonAccept.Name = "buttonAccept";
      this.buttonAccept.Size = new System.Drawing.Size(75, 23);
      this.buttonAccept.TabIndex = 13;
      this.buttonAccept.Text = "&Accept";
      this.buttonAccept.UseVisualStyleBackColor = true;
      this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(108, 129);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 14;
      this.buttonCancel.Text = "&Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(187, 13);
      this.label3.TabIndex = 15;
      this.label3.Text = "Change the coordinates of the Kaaba!";
      // 
      // SettingsForm
      // 
      this.AcceptButton = this.buttonAccept;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(206, 174);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonAccept);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.numericUpDownLongitude);
      this.Controls.Add(this.numericUpDownLatitude);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SettingsForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Settings";
      this.Load += new System.EventHandler(this.SettingsForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongitude)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatitude)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.NumericUpDown numericUpDownLongitude;
    private System.Windows.Forms.NumericUpDown numericUpDownLatitude;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonAccept;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Label label3;
  }
}