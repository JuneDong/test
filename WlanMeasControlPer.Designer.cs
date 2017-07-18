using ZedGraph;

namespace Agilent.BeFirst.DataAcquisition.Measurement
{
    partial class WlanMeasControlPer<TSettingSnapshot>
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
            this.traceControl = new Agilent.BeFirst.Application.GuiControls.SimpleTraceControl();
            this.ZedGraphControl1 = new ZedGraphControl();
            this.SuspendLayout();
            // 
            // traceControl
            // 
            //this.traceControl.AnnotationFont = new System.Drawing.Font("Arial", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.traceControl.AutoScroll = true;
            //this.traceControl.AutoScrollMinSize = new System.Drawing.Size(380, 310);
            //this.traceControl.BackColor = System.Drawing.Color.Black;
            //this.traceControl.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.traceControl.GraticulePadding = new System.Windows.Forms.Padding(10, 25, 10, 10);
            //this.traceControl.Location = new System.Drawing.Point(0, 0);
            //this.traceControl.Name = "traceControl";
            //this.traceControl.ShowGraticule = false;
            //this.traceControl.Size = new System.Drawing.Size(605, 424);
            //this.traceControl.TabIndex = 0;
            //this.traceControl.TextForClipboard = null;


            this.ZedGraphControl1.AutoScroll = true;
            this.ZedGraphControl1.AutoScrollMinSize = new System.Drawing.Size(380, 310);
            this.ZedGraphControl1.BackColor = System.Drawing.Color.Black;
            this.ZedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.ZedGraphControl1.Name = "ZedGraphControl1";
            this.ZedGraphControl1.Size = new System.Drawing.Size(605, 424);
            this.ZedGraphControl1.TabIndex = 0;
            this.ZedGraphControl1.BackColor = System.Drawing.Color.Black;
            this.ZedGraphControl1.GraphPane.Fill = new Fill(System.Drawing.Color.Black);
            this.ZedGraphControl1.GraphPane.Chart.Fill = new Fill(System.Drawing.Color.Black);
            this.ZedGraphControl1.GraphPane.XAxis.Color = System.Drawing.Color.White;
            this.ZedGraphControl1.GraphPane.X2Axis.Color = System.Drawing.Color.White;
            this.ZedGraphControl1.GraphPane.YAxis.Color = System.Drawing.Color.White;
            this.ZedGraphControl1.GraphPane.Y2Axis.Color = System.Drawing.Color.White;

            this.ZedGraphControl1.GraphPane.Title.Text = "PER %";
            this.ZedGraphControl1.GraphPane.XAxis.Title.Text = "Power/dbm";
            this.ZedGraphControl1.GraphPane.YAxis.Title.Text = "PER (%)";
            this.ZedGraphControl1.GraphPane.Title.FontSpec.FontColor = System.Drawing.Color.White;
            this.ZedGraphControl1.GraphPane.XAxis.Title.FontSpec.FontColor = System.Drawing.Color.White;
            this.ZedGraphControl1.GraphPane.XAxis.Title.FontSpec.FontColor = System.Drawing.Color.White;
            this.ZedGraphControl1.GraphPane.XAxis.Color = System.Drawing.Color.White;
            this.ZedGraphControl1.GraphPane.YAxis.Color = System.Drawing.Color.White;
            this.ZedGraphControl1.GraphPane.XAxis.Scale.FontSpec.FontColor = System.Drawing.Color.White;
            this.ZedGraphControl1.GraphPane.YAxis.Scale.FontSpec.FontColor = System.Drawing.Color.White;

            this.ZedGraphControl1.GraphPane.XAxis.Scale.MajorStep = 0.1;
            this.ZedGraphControl1.GraphPane.YAxis.Scale.MajorStep = 0.1;

            this.ZedGraphControl1.IsEnableHZoom = false;
            this.ZedGraphControl1.IsEnableVZoom = false;

            // 
            // ErrorSummaryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ZedGraphControl1);
            this.Controls.Add(this.traceControl);
            this.Name = "WlanPERResults";
            this.Size = new System.Drawing.Size(605, 424);
            this.ResumeLayout(false);

        }

        #endregion
        private ZedGraphControl ZedGraphControl1;
        private Agilent.BeFirst.Application.GuiControls.SimpleTraceControl traceControl;
    }

    //partial class WlanMeasControlPer
    //{
    //    /// <summary> 
    //    /// Required designer variable.
    //    /// </summary>
    //    private System.ComponentModel.IContainer components = null;
    //    private ZedGraph.ZedGraphControl ZedGraphControl1 = null;

    //    /// <summary> 
    //    /// Clean up any resources being used.
    //    /// </summary>
    //    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing && (components != null))
    //        {
    //            components.Dispose();

    //            m_LimitPen.Dispose();
    //            m_TwoSegsLimitPen.Dispose();
    //            m_FailedPointPen.Dispose();

    //            m_NormalTextBrush.Dispose();
    //            m_FailedTextBrush.Dispose();
    //            m_FailedRegionBrush.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    #region Component Designer generated code

    //    /// <summary> 
    //    /// Required method for Designer support - do not modify 
    //    /// the contents of this method with the code editor.
    //    /// </summary>
    //    private void InitializeComponent()
    //    {
    //        this.SuspendLayout();
    //        // 
    //        // WiGigCorrelatorControl
    //        // 
    //        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        this.Name = "WiGigCorrelatorControl";
    //        this.Size = new System.Drawing.Size(636, 413);
    //        this.ResumeLayout(false);


    //    }

    //    #endregion

    //}
}
