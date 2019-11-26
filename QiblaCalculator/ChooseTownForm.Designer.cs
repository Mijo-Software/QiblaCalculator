namespace QiblaCalculator
{
  partial class ChooseTownForm
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
      this.comboBoxCountry = new System.Windows.Forms.ComboBox();
      this.comboBoxCity = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.buttonAccept = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxLatitude = new System.Windows.Forms.TextBox();
      this.textBoxLongitude = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // comboBoxCountry
      // 
      this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxCountry.FormattingEnabled = true;
      this.comboBoxCountry.Location = new System.Drawing.Point(32, 53);
      this.comboBoxCountry.Name = "comboBoxCountry";
      this.comboBoxCountry.Size = new System.Drawing.Size(121, 21);
      this.comboBoxCountry.TabIndex = 2;
      // 
      // comboBoxCity
      // 
      this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxCity.FormattingEnabled = true;
      this.comboBoxCity.Location = new System.Drawing.Point(181, 53);
      this.comboBoxCity.Name = "comboBoxCity";
      this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
      this.comboBoxCity.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(29, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "C&ountry:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(178, 37);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "C&ity:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(315, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Select your country and the city to get the geograhic coordinates!";
      // 
      // buttonAccept
      // 
      this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonAccept.Location = new System.Drawing.Point(227, 98);
      this.buttonAccept.Name = "buttonAccept";
      this.buttonAccept.Size = new System.Drawing.Size(75, 23);
      this.buttonAccept.TabIndex = 11;
      this.buttonAccept.Text = "&Accept";
      this.buttonAccept.UseVisualStyleBackColor = true;
      this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(227, 129);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 12;
      this.buttonCancel.Text = "&Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(29, 103);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Latitude:";
      // 
      // textBoxLatitude
      // 
      this.textBoxLatitude.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxLatitude.Location = new System.Drawing.Point(90, 101);
      this.textBoxLatitude.Name = "textBoxLatitude";
      this.textBoxLatitude.ReadOnly = true;
      this.textBoxLatitude.Size = new System.Drawing.Size(75, 20);
      this.textBoxLatitude.TabIndex = 6;
      this.textBoxLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // textBoxLongitude
      // 
      this.textBoxLongitude.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxLongitude.Location = new System.Drawing.Point(89, 127);
      this.textBoxLongitude.Name = "textBoxLongitude";
      this.textBoxLongitude.ReadOnly = true;
      this.textBoxLongitude.Size = new System.Drawing.Size(75, 20);
      this.textBoxLongitude.TabIndex = 9;
      this.textBoxLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(29, 129);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(57, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Longitude:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(171, 103);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(11, 13);
      this.label9.TabIndex = 7;
      this.label9.Text = "°";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(170, 129);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(11, 13);
      this.label6.TabIndex = 10;
      this.label6.Text = "°";
      // 
      // ChooseTownForm
      // 
      this.AcceptButton = this.buttonAccept;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(339, 175);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBoxLatitude);
      this.Controls.Add(this.textBoxLongitude);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonAccept);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.comboBoxCity);
      this.Controls.Add(this.comboBoxCountry);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ChooseTownForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Choose your City";
      this.Load += new System.EventHandler(this.ChooseTownForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBoxCountry;
    private System.Windows.Forms.ComboBox comboBoxCity;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button buttonAccept;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxLatitude;
    private System.Windows.Forms.TextBox textBoxLongitude;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label6;
  }
}