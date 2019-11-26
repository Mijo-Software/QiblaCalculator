using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QiblaCalculator
{
  public partial class AltDegInputForm : Form
  {

    QiblaCalculatorForm mainform;

    public AltDegInputForm(QiblaCalculatorForm caller)
    {
      mainform = caller;
      InitializeComponent();
    }

    private void buttonAccept_Click(object sender, EventArgs e)
    {
      double latitude = (double)numericUpDownLatDeg.Value + ((double)numericUpDownLatArcmin.Value / 60) + ((double)numericUpDownLatArcsec.Value / 3600);
      double longitude = (double)numericUpDownLongDeg.Value + ((double)numericUpDownLongArcmin.Value / 60) + ((double)numericUpDownLongArcsec.Value / 3600);
      mainform.setLatitude(latitude);
      mainform.setLongitude(longitude);
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void AltDegInputForm_Load(object sender, EventArgs e)
    {
      NumericUpDown numericUpDownLat = (NumericUpDown)mainform.Controls["numericUpDownLatitude"];
      NumericUpDown numericUpDownLong = (NumericUpDown)mainform.Controls["numericUpDownLongitude"];
      
      double latitude = (double)numericUpDownLat.Value;
      numericUpDownLatDeg.Value = (decimal)Math.Floor(latitude);
      latitude = (latitude - Math.Floor(latitude)) * 60;
      numericUpDownLatArcmin.Value = (decimal)Math.Floor(latitude);
      latitude = (latitude - Math.Floor(latitude)) * 60;
      numericUpDownLatArcsec.Value = (decimal)Math.Floor(latitude);

      double longitude = (double)numericUpDownLong.Value;
      numericUpDownLongDeg.Value = (decimal)Math.Floor(longitude);
      longitude = (longitude - Math.Floor(longitude)) * 60;
      numericUpDownLongArcmin.Value = (decimal)Math.Floor(longitude);
      longitude = (longitude - Math.Floor(longitude)) * 60;
      numericUpDownLongArcsec.Value = (decimal)Math.Floor(longitude);
    }

  }
}
