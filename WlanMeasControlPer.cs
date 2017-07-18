using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Agilent.BeFirst.Application.GuiControls;
using Agilent.BeFirst.DataAcquisition.Common;
using Agilent.BeFirst.DataAcquisition.Measurement.UISupport;
using Keysight.Ccl.Api.ApplicationFramework;
using Keysight.Ccl.Api.UI;
using Keysight.Ccl.Api.UI.Gui;
using Keysight.Ccl.Api.UI.UIAdapters;
using MathNet.Numerics;
using Keysight.Ccl.Api.UnitConversions;
using Agilent.BeFirst.Application;
using WeifenLuo.WinFormsUI.Docking;
using System.Windows.Forms.VisualStyles;
using Agilent.BeFirst.DataAcquisition.Measurement.UI.ResultsDisplays;
using System.Text;
using Agilent.BeFirst.Application.UISupport;
using System.Drawing.Imaging;
using Agilent.BeFirst.Measurement.Measurement.UI.ResultsDisplays.WifiSig;
using ZedGraph;
using Agilent.BeFirst.Application.Extensions;
using Agilent.BeFirst.Measurement.Measurement.Controller;
using Agilent.BeFirst.Measurement;

namespace Agilent.BeFirst.DataAcquisition.Measurement
{
    public partial class WlanMeasControlPer<TSettingSnapshot> : UserControl, ISwitchableControl
    {
        //AllResultsSnapshot rr;

        //public delegate void ResultChangeDelegate(AllResultsSnapshot results);

        //public event ResultChangeDelegate ResultChangeEvent;

        //public void DisplayResult()
        //{
        //    if (this.ResultChangeEvent != null)
        //    {
        //        ResultChangeEvent(rr);
        //    }
        //}
        Timer t;
        public WlanMeasControlPer()
        {
            InitializeComponent();
            t = new Timer();

            //ResultChangeEvent += Draw;
            // rr = new AllResultsSnapshot();
            t.Interval = 1;
            t.Start();
            t.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            SrawPic();    
        }

        public void SrawPic()
        {
            this.ZedGraphControl1.GraphPane.CurveList.Clear();
            this.ZedGraphControl1.GraphPane.GraphObjList.Clear();
            Random ran = new Random();

            PointPairList list = new PointPairList();

           // LineItem myCurve;
            int ii = ran.Next(1, 3);

            double[] x = new double[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] y = new double[10] {0.1, 0.3, 0.6, 0.6, 0.4, 0.7, 0.9, 0.2, 0.9, 0.9 };

            if (ii == 1)
            {
                x = new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                y = new double[] { 0.1, 0.3, 0.6, 0.6, 0.4, 0.7, 0.9, 0.2, 0.9, 0.9 };
            }
            else if (ii == 2)
            {
                x = new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                y = new double[] { 0.5, 0.6, 0.4, 0.1, 0.6, 0.7, 0.9, 0.5, 0.3, 0.3 };
            }




            //this.ZedGraphControl1.GraphPane.XAxis.Type = ZedGraph.AxisType.DateAsOrdinal;
            this.ZedGraphControl1.GraphPane.XAxis.Scale.Max = x[x.Length - 1];
            this.ZedGraphControl1.GraphPane.YAxis.Scale.Max = 1;
            this.ZedGraphControl1.GraphPane.XAxis.Scale.Min = x[0];
            this.ZedGraphControl1.GraphPane.YAxis.Scale.Min = 0;
           

            //ZedGraphControl1.GraphPane.AddCurve("Power -- Per",

            //        x, y, Color.Yellow, SymbolType.None);

            ZedGraphControl1.GraphPane.AddCurve("Power -- Per", x, y, Color.Yellow, SymbolType.None);


            
            this.ZedGraphControl1.AxisChange();
            this.ZedGraphControl1.Invalidate();
            this.ZedGraphControl1.Refresh();
            this.ZedGraphControl1.Update();
        }

        MeasurementUISupport m_uiSupport;
        int m_displayId;
        DataElementGroupCache<TSettingSnapshot> m_settingsCache;
        protected FeatureGuiControl m_parent;
        protected StringBuilder m_sb;
        protected Dictionary<DataElement, ResponseRequest> m_resultsResponseRequests;

        WlanCommonMeasurementResultsProperties m_properties;  //TODO
        protected void Initialize()
        {
            this.Text = "WLan common Measurement Results";
            m_properties = new WlanCommonMeasurementResultsProperties(
                m_parent,
                m_uiSupport.ResultsGroup.WlanResults.WlanComMeasureResults);  //TODO

            foreach (FeaturePropertyDescriptor p in m_properties.PropertyList)
            {
                m_uiSupport.AddResultResponseRequest(p.GuiParameter.DataElement, p.GuiParameter.CreateValueResponseRequest());
            }

            m_settingsCache = new DataElementGroupCache<TSettingSnapshot>(m_uiSupport.SettingsGroup.EVMDemodSettingsGroup, null);  //TODO
        }

        protected void BuildInfoString(WlanMeasurementResults results)
        {
           

            //WlanMeasurementResults ww = WlanMeasurementResults.GetInstance();
            //if (ww == null)
            //    return;
            //m_sb.AppendLine("AP MAC: " + ww.wlanCommonMeasurementResult.ApMac + "\n");
            //m_sb.AppendLine("DUT MAC: " + ww.wlanCommonMeasurementResult.DutMac + "\n");
            //m_sb.AppendLine("TX Power (dBM): " + ww.wlanCommonMeasurementResult.TxPower + " dBm\n");
            //m_sb.AppendLine("RMS EVM: " + ww.wlanCommonMeasurementResult.RmsEvm + "\n");
            //m_sb.AppendLine("Freq Error: " + ww.wlanCommonMeasurementResult.FreqError + " \n");
            //m_sb.AppendLine("Becon Power Power (dBM): " + ww.wlanCommonMeasurementResult.BeaconPower + " dBm\n");
            //m_sb.AppendLine("Per : " + ww.wlanCommonMeasurementResult.Per + " %\n");
            //m_sb.AppendLine("Per Count: " + ww.wlanCommonMeasurementResult.PerCount + "\n");
            //m_sb.AppendLine("Throughput : " + ww.wlanCommonMeasurementResult.Thp + "\n");
        }

        public void Init(
            FeatureGuiControl parent,
            MeasurementUISupport uiSupport,
            int displayId,
            ContextMenuStrip measurementMenu)
        {
            m_uiSupport = uiSupport;
            m_displayId = displayId;
            m_parent = parent;
            traceControl.Init(parent, measurementMenu);

            m_helper = new GeneralDisplaySettingsHelper(
                m_uiSupport.SettingsGroup.GeneralDisplaySettings,
                traceControl);

            Initialize();
        }


        Pen minMaxTracePen = new Pen(Color.Yellow, 1f);
        Pen mainTracePen = new Pen(Color.FromArgb(100, Color.Yellow), 0.001f);
        Pen graticulePen = new Pen(Color.LightGray, 2);

        public void Draw(WlanMeasurementResults results)
        {
            m_settingsCache.Refresh();
            traceControl.DrawTrace(
                (Graphics g, Rectangle graticuleRect) => DrawDisplay(g, graticuleRect, results),
                false,
                0, 0);
        }

        Font bodyFont = new System.Drawing.Font("Arial", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        Font headerFont = new System.Drawing.Font("Arial", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        Pen thickPen = new Pen(Color.FromArgb(100, Color.Yellow), 3);

        GeneralDisplaySettingsHelper m_helper;


        private void DrawDisplay(
            Graphics graphics,
            Rectangle graticuleRect,
            WlanMeasurementResults results)
        {
            m_helper.ConfigureTextualDisplay(graphics);

            m_sb = new StringBuilder();
            m_resultsResponseRequests = this.m_uiSupport.ResultsResponseRequests;

            BuildInfoString(results);

            StringFormat f = GetStringFormat();

            traceControl.TextForClipboard = m_sb.ToString();

            SizeF stringSize = graphics.MeasureString(traceControl.TextForClipboard,
                traceControl.AnnotationFont,
                new Point(graticuleRect.Left + 10, graticuleRect.Top + 10),
                f);

            int h = (int)stringSize.Height + graticuleRect.Top + 30;
            int w = (int)stringSize.Width + graticuleRect.Left + 30;

            traceControl.AutoScrollMinSize = new Size(
                 Math.Max(w, 400),
                Math.Max(h, 380));

            graphics.DrawString(
                traceControl.TextForClipboard,
                traceControl.AnnotationFont,
                Brushes.Yellow,
                new Point(graticuleRect.Left + 10, graticuleRect.Top + 10),
                f);


            GraticuleRenderer.DrawRoundedRectangle(graphics,
                Pens.Yellow,
                new RectangleF(
                    graticuleRect.Left,
                    graticuleRect.Top,
                    this.traceControl.AutoScrollMinSize.Width - graticuleRect.Left - 10,
                    h - graticuleRect.Top - 10));

            // m_helper.DrawDirtyFlag(graphics, graticuleRect, results.GetDirty(), false, true);
        }

        protected virtual StringFormat GetStringFormat()
        {
            StringFormat f = new StringFormat();
            f.SetTabStops(0, new float[] { 10, 80, 80 });
            return f;
        }





        public bool PrepareClipBoardText()
        {
            return true;
        }

        public void Draw(AllResultsSnapshot results)
        {
            //Draw(this.WlanResults);
        }

        public SimpleTraceControl TraceControl
        {
            get { return traceControl; }
        }
    }
}
