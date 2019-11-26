using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace QiblaCalculator
{
  public partial class QiblaCalculatorForm : Form
  {
    double latitude_kaaba = 21.4225;
    double longitude_kaaba = 39.826111;
    
    public QiblaCalculatorForm()
    {
      InitializeComponent();
    }

    public void setLatitudeOfKaaba(double latitude)
    {
      latitude_kaaba = latitude;
    }

    public void setLongitudeOfKaaba(double longitude)
    {
      longitude_kaaba = longitude;
    }

    public void setLatitude(double latitude2)
    {
      //latitude = latitude2;
      numericUpDownLatitude.Value = (decimal)latitude2;
    }

    public void setLongitude(double longitude2)
    {
      numericUpDownLongitude.Value = (decimal)longitude2;
    }

    public double getLatitudeOfKaaba()
    {
      return latitude_kaaba;
    }

    public double getLongitudeOfKaaba()
    {
      return longitude_kaaba;
    }

    public double getLatitude()
    {
      return (double)numericUpDownLatitude.Value;
    }

    public double getLongitude()
    {
      return (double)numericUpDownLongitude.Value;
    }

    private void buttonCalc_Click(object sender, EventArgs e)
    {
      double latitude = (double)numericUpDownLatitude.Value * (Math.PI / 180);
      double longitude = (double)numericUpDownLongitude.Value * (Math.PI / 180);
      //double latitude_kaaba = 21.4225 * (Math.PI / 180);
      //double longitude_kaaba = 39.826111 * (Math.PI / 180);
      double latitude_kaaba = getLatitudeOfKaaba() * (Math.PI / 180);
      double longitude_kaaba = getLongitudeOfKaaba() * (Math.PI / 180);
      double orthodromicAngle = Math.Acos(Math.Sin(latitude) * Math.Sin(latitude_kaaba) + Math.Cos(latitude) * Math.Cos(latitude_kaaba) * Math.Cos(longitude_kaaba - longitude)) * (180 / Math.PI);
      double orthodromicDistance = orthodromicAngle * 40076 / 360;
      double diff_longitude = longitude_kaaba - longitude;
      double angleToQibla = Math.Atan2(Math.Sin(diff_longitude), Math.Cos(latitude) * Math.Tan(latitude_kaaba) - Math.Sin(latitude) * Math.Cos(diff_longitude)) * (180 / Math.PI);
      string szOrthodromicAngle = String.Format("{0:0.0000}", orthodromicAngle);
      string szOrthodromicDistance = String.Format("{0:0.0000}", orthodromicDistance);
      string szAngleToQibla = String.Format("{0:0.0000}", angleToQibla);
      textBoxOrthodromicAngle.Text = szOrthodromicAngle;
      textBoxDistance.Text = szOrthodromicDistance;
      textBoxAngleToQibla.Text = szAngleToQibla;
    }

    private void buttonLocateOnMap_Click(object sender, EventArgs e)
    {
      Form formLocateOnMap = new LocateOnMapForm();
      formLocateOnMap.ShowDialog();
    }

    private void buttonChooseTown_Click(object sender, EventArgs e)
    {
      Form formChooseTown = new ChooseTownForm();
      formChooseTown.ShowDialog();
    }

    private void QiblaCalculatorForm_Load(object sender, EventArgs e)
    {
      numericUpDownLatitude.Value = (decimal)24.4690;
      numericUpDownLongitude.Value = (decimal)39.6139;
    }

    private void buttonCopyOrthodromicAngle_Click(object sender, EventArgs e)
    {
      textBoxOrthodromicAngle.SelectAll();
      textBoxOrthodromicAngle.Copy();
    }

    private void buttonCopyDistance_Click(object sender, EventArgs e)
    {
      textBoxDistance.SelectAll();
      textBoxDistance.Copy();
    }

    private void buttonAngleToQibla_Click(object sender, EventArgs e)
    {
      textBoxAngleToQibla.SelectAll();
      textBoxAngleToQibla.Copy();
    }

    private void buttonSettings_Click(object sender, EventArgs e)
    {
      Form formSettings = new SettingsForm(this);
      formSettings.ShowDialog();
    }

    private void buttonCompass_Click(object sender, EventArgs e)
    {
      double angle = 0;
      string szIn = textBoxAngleToQibla.Text;
      szIn = szIn.Replace(",", ".");
      try
      {
        angle = double.Parse(szIn, CultureInfo.InvariantCulture);
        Form formCompass = new CompassForm(angle);
        formCompass.ShowDialog();
      }
      catch
      {
        MessageBox.Show("Click 'CALC' to initialize the angle to the qibla!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
      }
    }

    private void buttonAltInputOptionsLatitude_Click(object sender, EventArgs e)
    {
      Form formAltDegInput = new AltDegInputForm(this);
      formAltDegInput.ShowDialog();
    }

    private void buttonbuttonAltInputOptionsLongitude_Click(object sender, EventArgs e)
    {
      Form formAltDegInput = new AltDegInputForm(this);
      formAltDegInput.ShowDialog();
    }

    private void pictureBoxBismillah_Click(object sender, EventArgs e)
    {
      SoundPlayer sound = new SoundPlayer(Properties.Resources.bismillah);
      sound.Play();
    }

  }
}
