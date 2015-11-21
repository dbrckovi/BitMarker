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
  public partial class BitMarkerControl : UserControl
  {
    private Point? _mouseLocation = null;
    private int _bits = 16;
    private Size _boxSize = new Size(16, 16);

    #region Properties
    public int Bits
    {
      get { return _bits; }
      set
      {
        if (value < 1) value = 1;
        _bits = value;
        Refresh();
      }
    }

    public Size BoxSize
    {
      get { return _boxSize; }
      set
      {
        if (value.Height < 4) value.Height = 4;
        if (value.Width < 4) value.Width = 4;
        _boxSize = value;
        Refresh();
      }
    }
    #endregion Properties

    #region Constructor
    public BitMarkerControl()
    {
      InitializeComponent();
    }
    #endregion Constructor

    protected override void OnPaint(PaintEventArgs pe)
    {
      base.OnPaint(pe);
      for (int x = 0; x < _bits; x++)
      {
        Point p = new Point(x * _boxSize.Width, 0);
        DrawBox(p, pe.Graphics);
      }
    }

    private void DrawBox(Point location, Graphics g)
    {
      Brush brush = new SolidBrush(this.BackColor);
      Rectangle rect = new Rectangle(location.X, location.Y, _boxSize.Width, _boxSize.Height);

      bool highlighted = false;

      #region Determine highlighted
      if (_mouseLocation.HasValue)
      {
        if (
          _mouseLocation.Value.X >= location.X
          && _mouseLocation.Value.X < location.X + _boxSize.Width
          && _mouseLocation.Value.Y >= location.Y
          && _mouseLocation.Value.Y < location.Y + _boxSize.Height
          )
          highlighted = true;
      }
      #endregion Determine highlighted 

      g.FillRectangle(brush, rect);
      if (highlighted) g.DrawRectangle(Pens.Red, rect);
      else g.DrawRectangle(Pens.Black, rect);
    }

    private void BitMarkerControl_MouseMove(object sender, MouseEventArgs e)
    {
      _mouseLocation = new Point(e.X, e.Y);
      Refresh();
    }

    private void BitMarkerControl_MouseLeave(object sender, EventArgs e)
    {
      _mouseLocation = null;
      Refresh();
    }
  }
}
