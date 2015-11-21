using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BitMarker
{
  public partial class BitBox : UserControl
  {
    private int _index = 0;
    private bool _showIndex = true;

    public int Index
    {
      get { return _index; }
      set
      {
        _index = value;
        Refresh();
      }
    }

    public bool ShowIndex
    {
      get { return _showIndex; }
      set
      {
        _showIndex = value;
        Refresh();
      }
    }

    #region Constructor
    public BitBox()
    {
      InitializeComponent();
    }
    #endregion Constructor 

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      if (_showIndex)
      {
        //TODO: center
        e.Graphics.DrawString(_index.ToString(), this.Font, new SolidBrush(this.ForeColor), 0, 0);
      }
    }

    private void BitBox_MouseEnter(object sender, EventArgs e)
    {
      this.BorderStyle = BorderStyle.FixedSingle;
    }

    private void BitBox_MouseLeave(object sender, EventArgs e)
    {
      this.BorderStyle = BorderStyle.Fixed3D;
    }
  }
}
