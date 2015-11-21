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
    public int Bits
    {
      get { return this.Controls.Count; }
      set
      {
        int oldBits = this.Controls.Count;
        if (value < 0) value = 0;
        if (value > oldBits)
        {
          #region Add new bits
          for (int x = 1; x <= value - oldBits; x++)
          {
            AddBit();
          }
          #endregion Add new bits 
        }
        else if (value < oldBits)
        {
          #region Remove extra bits
          for (int x = 1; x <= oldBits - value; x++)
          {
            this.Controls.RemoveAt(0);
          }
          #endregion Remove extra bits 
        }
      }
    }

    #region Constructor
    public BitMarkerControl()
    {
      InitializeComponent();
    }
    #endregion Constructor

    private void AddBit()
    {
      int newIndex = Bits;
      BitBox box = new BitBox();
      box.Size = new Size(24, 16);
      box.Index = newIndex;
      box.Dock = DockStyle.Left;
      this.Controls.Add(box);
      box.BringToFront();
    }
  }
}
