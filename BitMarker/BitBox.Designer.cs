﻿namespace BitMarker
{
  partial class BitBox
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.SuspendLayout();
      // 
      // BitBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "BitBox";
      this.Size = new System.Drawing.Size(8, 16);
      this.MouseEnter += new System.EventHandler(this.BitBox_MouseEnter);
      this.MouseLeave += new System.EventHandler(this.BitBox_MouseLeave);
      this.ResumeLayout(false);

    }

    #endregion
  }
}
