namespace BitMarker
{
  partial class Form1
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.bitMarkerControl1 = new BitMarker.BitMarkerControl();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(24, 16);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(72, 32);
      this.button1.TabIndex = 1;
      this.button1.Text = "add";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(96, 16);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(72, 32);
      this.button2.TabIndex = 2;
      this.button2.Text = "remove";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.button2);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(567, 48);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "groupBox1";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.panel1.Controls.Add(this.bitMarkerControl1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 48);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(4);
      this.panel1.Size = new System.Drawing.Size(567, 32);
      this.panel1.TabIndex = 4;
      // 
      // bitMarkerControl1
      // 
      this.bitMarkerControl1.BackColor = System.Drawing.SystemColors.Control;
      this.bitMarkerControl1.Bits = 12;
      this.bitMarkerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bitMarkerControl1.Location = new System.Drawing.Point(4, 4);
      this.bitMarkerControl1.Name = "bitMarkerControl1";
      this.bitMarkerControl1.Size = new System.Drawing.Size(559, 24);
      this.bitMarkerControl1.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(567, 262);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private BitMarkerControl bitMarkerControl1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Panel panel1;
  }
}

