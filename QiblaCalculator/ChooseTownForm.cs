using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QiblaCalculator
{
  public partial class ChooseTownForm : Form
  {
    public ChooseTownForm()
    {
      InitializeComponent();
    }

    private void ChooseTownForm_Load(object sender, EventArgs e)
    {
      //List list = new List();
    }

    private void buttonAccept_Click(object sender, EventArgs e)
    {

    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
