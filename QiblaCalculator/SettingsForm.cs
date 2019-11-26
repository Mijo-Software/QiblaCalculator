using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QiblaCalculator
{
  public partial class SettingsForm : Form
  {
    double latitude_kaaba = 21.4225;
    double longitude_kaaba = 39.826111;

    QiblaCalculatorForm mainform;

    public SettingsForm(QiblaCalculatorForm caller)
    {
      mainform = caller;
      InitializeComponent();
    }

    public double getLatitudeOfKaaba()
    {
      return latitude_kaaba;
    }

    public double getLongitudeOfKaaba()
    {
      return longitude_kaaba;
    }

    private void buttonAccept_Click(object sender, EventArgs e)
    {
      mainform.setLatitudeOfKaaba((double)numericUpDownLatitude.Value);
      mainform.setLongitudeOfKaaba((double)numericUpDownLongitude.Value);
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void SettingsForm_Load(object sender, EventArgs e)
    {
      numericUpDownLatitude.Value = (decimal)latitude_kaaba;
      numericUpDownLongitude.Value = (decimal)longitude_kaaba;
    }
  }
}
