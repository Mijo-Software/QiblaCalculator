namespace QiblaCalculator
{
  partial class QiblaCalculatorForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QiblaCalculatorForm));
      this.buttonCalc = new System.Windows.Forms.Button();
      this.textBoxAngleToQibla = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.numericUpDownLatitude = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownLongitude = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxDistance = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBoxOrthodromicAngle = new System.Windows.Forms.TextBox();
      this.buttonChooseTown = new System.Windows.Forms.Button();
      this.buttonLocateOnMap = new System.Windows.Forms.Button();
      this.pictureBoxBismillah = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.buttonConvert = new System.Windows.Forms.Button();
      this.buttonCopyOrthodromicAngle = new System.Windows.Forms.Button();
      this.buttonCopyDistance = new System.Windows.Forms.Button();
      this.buttonAngleToQibla = new System.Windows.Forms.Button();
      this.buttonSettings = new System.Windows.Forms.Button();
      this.buttonCompass = new System.Windows.Forms.Button();
      this.buttonAltInputOptionsLatitude = new System.Windows.Forms.Button();
      this.buttonbuttonAltInputOptionsLongitude = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatitude)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongitude)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBismillah)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonCalc
      // 
      this.buttonCalc.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonCalc.Location = new System.Drawing.Point(115, 123);
      this.buttonCalc.Name = "buttonCalc";
      this.buttonCalc.Size = new System.Drawing.Size(75, 24);
      this.buttonCalc.TabIndex = 10;
      this.buttonCalc.Text = "&Calc";
      this.buttonCalc.UseVisualStyleBackColor = true;
      this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
      // 
      // textBoxAngleToQibla
      // 
      this.textBoxAngleToQibla.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxAngleToQibla.Location = new System.Drawing.Point(115, 221);
      this.textBoxAngleToQibla.Name = "textBoxAngleToQibla";
      this.textBoxAngleToQibla.ReadOnly = true;
      this.textBoxAngleToQibla.Size = new System.Drawing.Size(75, 20);
      this.textBoxAngleToQibla.TabIndex = 21;
      this.textBoxAngleToQibla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "L&atitude:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 84);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "L&ongitude:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 224);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(76, 13);
      this.label3.TabIndex = 20;
      this.label3.Text = "Angle to &Qibla:";
      // 
      // numericUpDownLatitude
      // 
      this.numericUpDownLatitude.DecimalPlaces = 4;
      this.numericUpDownLatitude.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownLatitude.Location = new System.Drawing.Point(115, 55);
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
      this.numericUpDownLatitude.TabIndex = 2;
      // 
      // numericUpDownLongitude
      // 
      this.numericUpDownLongitude.DecimalPlaces = 4;
      this.numericUpDownLongitude.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numericUpDownLongitude.Location = new System.Drawing.Point(115, 82);
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
      this.numericUpDownLongitude.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 198);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(52, 13);
      this.label4.TabIndex = 15;
      this.label4.Text = "&Distance:";
      // 
      // textBoxDistance
      // 
      this.textBoxDistance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxDistance.Location = new System.Drawing.Point(115, 195);
      this.textBoxDistance.Name = "textBoxDistance";
      this.textBoxDistance.ReadOnly = true;
      this.textBoxDistance.Size = new System.Drawing.Size(75, 20);
      this.textBoxDistance.TabIndex = 16;
      this.textBoxDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 172);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(97, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Orthodromic &Angle:";
      // 
      // textBoxOrthodromicAngle
      // 
      this.textBoxOrthodromicAngle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxOrthodromicAngle.Location = new System.Drawing.Point(115, 169);
      this.textBoxOrthodromicAngle.Name = "textBoxOrthodromicAngle";
      this.textBoxOrthodromicAngle.ReadOnly = true;
      this.textBoxOrthodromicAngle.Size = new System.Drawing.Size(75, 20);
      this.textBoxOrthodromicAngle.TabIndex = 12;
      this.textBoxOrthodromicAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // buttonChooseTown
      // 
      this.buttonChooseTown.Image = ((System.Drawing.Image)(resources.GetObject("buttonChooseTown.Image")));
      this.buttonChooseTown.Location = new System.Drawing.Point(221, 55);
      this.buttonChooseTown.Name = "buttonChooseTown";
      this.buttonChooseTown.Size = new System.Drawing.Size(47, 47);
      this.buttonChooseTown.TabIndex = 7;
      this.buttonChooseTown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.buttonChooseTown.UseVisualStyleBackColor = true;
      this.buttonChooseTown.Click += new System.EventHandler(this.buttonChooseTown_Click);
      // 
      // buttonLocateOnMap
      // 
      this.buttonLocateOnMap.Image = ((System.Drawing.Image)(resources.GetObject("buttonLocateOnMap.Image")));
      this.buttonLocateOnMap.Location = new System.Drawing.Point(274, 55);
      this.buttonLocateOnMap.Name = "buttonLocateOnMap";
      this.buttonLocateOnMap.Size = new System.Drawing.Size(47, 47);
      this.buttonLocateOnMap.TabIndex = 8;
      this.buttonLocateOnMap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.buttonLocateOnMap.UseVisualStyleBackColor = true;
      this.buttonLocateOnMap.Click += new System.EventHandler(this.buttonLocateOnMap_Click);
      // 
      // pictureBoxBismillah
      // 
      this.pictureBoxBismillah.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBismillah.Image")));
      this.pictureBoxBismillah.Location = new System.Drawing.Point(196, 11);
      this.pictureBoxBismillah.Name = "pictureBoxBismillah";
      this.pictureBoxBismillah.Size = new System.Drawing.Size(134, 23);
      this.pictureBoxBismillah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBoxBismillah.TabIndex = 15;
      this.pictureBoxBismillah.TabStop = false;
      this.pictureBoxBismillah.Click += new System.EventHandler(this.pictureBoxBismillah_Click);
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(3, 11);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(35, 24);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 16;
      this.pictureBox2.TabStop = false;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(32, 11);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(158, 24);
      this.label6.TabIndex = 1;
      this.label6.Text = "Qibla Calculator";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(196, 57);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(11, 13);
      this.label7.TabIndex = 3;
      this.label7.Text = "°";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(196, 84);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(11, 13);
      this.label8.TabIndex = 6;
      this.label8.Text = "°";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(196, 172);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(11, 13);
      this.label9.TabIndex = 13;
      this.label9.Text = "°";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(196, 198);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(21, 13);
      this.label10.TabIndex = 17;
      this.label10.Text = "km";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(196, 224);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(11, 13);
      this.label11.TabIndex = 22;
      this.label11.Text = "°";
      // 
      // buttonConvert
      // 
      this.buttonConvert.Location = new System.Drawing.Point(253, 194);
      this.buttonConvert.Name = "buttonConvert";
      this.buttonConvert.Size = new System.Drawing.Size(68, 21);
      this.buttonConvert.TabIndex = 19;
      this.buttonConvert.Text = "Con&vert";
      this.buttonConvert.UseVisualStyleBackColor = true;
      // 
      // buttonCopyOrthodromicAngle
      // 
      this.buttonCopyOrthodromicAngle.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyOrthodromicAngle.Image")));
      this.buttonCopyOrthodromicAngle.Location = new System.Drawing.Point(221, 168);
      this.buttonCopyOrthodromicAngle.Name = "buttonCopyOrthodromicAngle";
      this.buttonCopyOrthodromicAngle.Size = new System.Drawing.Size(26, 21);
      this.buttonCopyOrthodromicAngle.TabIndex = 14;
      this.buttonCopyOrthodromicAngle.UseVisualStyleBackColor = true;
      this.buttonCopyOrthodromicAngle.Click += new System.EventHandler(this.buttonCopyOrthodromicAngle_Click);
      // 
      // buttonCopyDistance
      // 
      this.buttonCopyDistance.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyDistance.Image")));
      this.buttonCopyDistance.Location = new System.Drawing.Point(221, 194);
      this.buttonCopyDistance.Name = "buttonCopyDistance";
      this.buttonCopyDistance.Size = new System.Drawing.Size(26, 21);
      this.buttonCopyDistance.TabIndex = 18;
      this.buttonCopyDistance.UseVisualStyleBackColor = true;
      this.buttonCopyDistance.Click += new System.EventHandler(this.buttonCopyDistance_Click);
      // 
      // buttonAngleToQibla
      // 
      this.buttonAngleToQibla.Image = ((System.Drawing.Image)(resources.GetObject("buttonAngleToQibla.Image")));
      this.buttonAngleToQibla.Location = new System.Drawing.Point(221, 220);
      this.buttonAngleToQibla.Name = "buttonAngleToQibla";
      this.buttonAngleToQibla.Size = new System.Drawing.Size(26, 21);
      this.buttonAngleToQibla.TabIndex = 23;
      this.buttonAngleToQibla.UseVisualStyleBackColor = true;
      this.buttonAngleToQibla.Click += new System.EventHandler(this.buttonAngleToQibla_Click);
      // 
      // buttonSettings
      // 
      this.buttonSettings.Location = new System.Drawing.Point(15, 123);
      this.buttonSettings.Name = "buttonSettings";
      this.buttonSettings.Size = new System.Drawing.Size(75, 23);
      this.buttonSettings.TabIndex = 9;
      this.buttonSettings.Text = "&Settings";
      this.buttonSettings.UseVisualStyleBackColor = true;
      this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
      // 
      // buttonCompass
      // 
      this.buttonCompass.Location = new System.Drawing.Point(253, 221);
      this.buttonCompass.Name = "buttonCompass";
      this.buttonCompass.Size = new System.Drawing.Size(68, 21);
      this.buttonCompass.TabIndex = 24;
      this.buttonCompass.Text = "Co&mpass";
      this.buttonCompass.UseVisualStyleBackColor = true;
      this.buttonCompass.Click += new System.EventHandler(this.buttonCompass_Click);
      // 
      // buttonAltInputOptionsLatitude
      // 
      this.buttonAltInputOptionsLatitude.Location = new System.Drawing.Point(78, 55);
      this.buttonAltInputOptionsLatitude.Name = "buttonAltInputOptionsLatitude";
      this.buttonAltInputOptionsLatitude.Size = new System.Drawing.Size(31, 18);
      this.buttonAltInputOptionsLatitude.TabIndex = 25;
      this.buttonAltInputOptionsLatitude.Text = "° \' \'\'";
      this.buttonAltInputOptionsLatitude.UseVisualStyleBackColor = true;
      this.buttonAltInputOptionsLatitude.Click += new System.EventHandler(this.buttonAltInputOptionsLatitude_Click);
      // 
      // buttonbuttonAltInputOptionsLongitude
      // 
      this.buttonbuttonAltInputOptionsLongitude.Location = new System.Drawing.Point(78, 84);
      this.buttonbuttonAltInputOptionsLongitude.Name = "buttonbuttonAltInputOptionsLongitude";
      this.buttonbuttonAltInputOptionsLongitude.Size = new System.Drawing.Size(31, 18);
      this.buttonbuttonAltInputOptionsLongitude.TabIndex = 26;
      this.buttonbuttonAltInputOptionsLongitude.Text = "° \' \'\'";
      this.buttonbuttonAltInputOptionsLongitude.UseVisualStyleBackColor = true;
      this.buttonbuttonAltInputOptionsLongitude.Click += new System.EventHandler(this.buttonbuttonAltInputOptionsLongitude_Click);
      // 
      // QiblaCalculatorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(342, 259);
      this.Controls.Add(this.buttonbuttonAltInputOptionsLongitude);
      this.Controls.Add(this.buttonAltInputOptionsLatitude);
      this.Controls.Add(this.buttonCompass);
      this.Controls.Add(this.buttonSettings);
      this.Controls.Add(this.buttonAngleToQibla);
      this.Controls.Add(this.buttonCopyDistance);
      this.Controls.Add(this.buttonCopyOrthodromicAngle);
      this.Controls.Add(this.buttonConvert);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBoxBismillah);
      this.Controls.Add(this.buttonLocateOnMap);
      this.Controls.Add(this.buttonChooseTown);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBoxOrthodromicAngle);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBoxDistance);
      this.Controls.Add(this.numericUpDownLongitude);
      this.Controls.Add(this.numericUpDownLatitude);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxAngleToQibla);
      this.Controls.Add(this.buttonCalc);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "QiblaCalculatorForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Qibla Calculator";
      this.Load += new System.EventHandler(this.QiblaCalculatorForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatitude)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongitude)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBismillah)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonCalc;
    private System.Windows.Forms.TextBox textBoxAngleToQibla;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numericUpDownLatitude;
    private System.Windows.Forms.NumericUpDown numericUpDownLongitude;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxDistance;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBoxOrthodromicAngle;
    private System.Windows.Forms.Button buttonChooseTown;
    private System.Windows.Forms.Button buttonLocateOnMap;
    private System.Windows.Forms.PictureBox pictureBoxBismillah;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Button buttonConvert;
    private System.Windows.Forms.Button buttonCopyOrthodromicAngle;
    private System.Windows.Forms.Button buttonCopyDistance;
    private System.Windows.Forms.Button buttonAngleToQibla;
    private System.Windows.Forms.Button buttonSettings;
    private System.Windows.Forms.Button buttonCompass;
    private System.Windows.Forms.Button buttonAltInputOptionsLatitude;
    private System.Windows.Forms.Button buttonbuttonAltInputOptionsLongitude;
  }
}

