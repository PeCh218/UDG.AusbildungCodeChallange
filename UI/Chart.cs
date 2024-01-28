using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI;
public partial class Chart : UserControl
{
    #region Private Variables
    int x_margin = 20;
    int y_margin = 20;
    int x_in_margin = 20;
    int y_in_margin = 20;
    int font_size;
    double y_scale = 1;
    int n_datpoints = 4;
    Color primaryLineColor = Color.DeepSkyBlue;
    Color alternateLineColor = Color.Red;
    Color baselineColor = Color.Black;
    Color borderlineColor = Color.Black;
    Color primaryFillColor = Color.DeepSkyBlue;
    Color alternateFillColor = Color.Red;
    Color primaryValueColor = Color.Blue;
    Color alternateValueColor = Color.Red;
    //Databinding-Start
    private DataTable dataSource;
    private string dataMember_Y;
    private string dataMember_X;
    //Databinding-End
    #endregion Private Variables

    #region Public Properties

    public int Xmargin
    {
        get { return this.x_margin; }
        set { this.x_margin = value; }
    }

    public int Ymargin
    {
        get { return this.y_margin; }
        set { this.y_margin = value; }
    }

    public int Xinmargin
    {
        get { return this.x_in_margin; }
        set { this.x_in_margin = value; }
    }
    public int Yinmargin
    {
        get { return this.y_in_margin; }
        set { this.y_in_margin = value; }
    }
    public Color PrimaryLineColor
    {
        get { return this.primaryLineColor; }
        set { this.primaryLineColor = value; }
    }
    public Color AlternateLineColor
    {
        get { return this.alternateLineColor; }
        set { this.alternateLineColor = value; }
    }
    public Color BaselineColor
    {
        get { return this.baselineColor; }
        set { this.baselineColor = value; }
    }
    public Color BorderlineColor
    {
        get { return this.borderlineColor; }
        set { this.borderlineColor = value; }
    }
    public Color PrimaryFillColor
    {
        get { return this.primaryFillColor; }
        set { this.primaryFillColor = value; }
    }
    public Color AlternateFillColor
    {
        get { return this.alternateFillColor; }
        set { this.alternateFillColor = value; }
    }
    public Color PrimaryValueColor
    {
        get { return this.primaryValueColor; }
        set { this.primaryValueColor = value; }
    }
    public Color AlternateValueColor
    {
        get { return this.alternateValueColor; }
        set { this.alternateValueColor = value; }
    }
    //Data Binding - Start
    [TypeConverter("System.Windows.Forms.Design.DataSourceConverter,System.Design")]
    [Category("Data")]
    [DefaultValue(null)]
    public DataTable DataSource
    {
        get
        {
            return this.dataSource;
        }
        set
        {
            if (this.dataSource != value)
            {
                this.dataSource = value;
            }
        }
    }
    [Category("Data")]
    [Editor("System.Windows.Forms.Design.DataMemberListEditor,System.Design",
       "System.Drawing.Design.UITypeEditor, System.Drawing")]
    [DefaultValue("")]
    public string DataMemberY
    {
        get
        {
            return this.dataMember_Y;
        }
        set
        {
            if (this.dataMember_Y != value)
            {
                this.dataMember_Y = value;
            }
        }
    }
    [Category("Data")]
    [Editor("System.Windows.Forms.Design.DataMemberListEditor,System.Design",
      "System.Drawing.Design.UITypeEditor, System.Drawing")]
    [DefaultValue("")]
    public string DataMemberX
    {
        get
        {
            return this.dataMember_X;
        }
        set
        {
            if (this.dataMember_X != value)
            {
                this.dataMember_X = value;
            }
        }
    }
    //Data Binding - End

    #endregion Public Properties
    public Chart()
    {
        InitializeComponent();
    }
    #region DrawBarChart method
    private void DrawBarChart(System.Windows.Forms.PaintEventArgs e)
    {
        try
        {
            // Create a new pen.
            Pen PrimaryColorPen = new Pen(primaryLineColor);
            Pen AlternateColorPen = new Pen(alternateLineColor);
            Pen BaseLinePen = new Pen(baselineColor);
            Pen BorderLinePen = new Pen(borderlineColor);
            // Create new Solid Brush
            SolidBrush PrimarysolidBrush = new SolidBrush(primaryFillColor);
            SolidBrush AlternatesolidBrush = new SolidBrush(alternateFillColor);
            SolidBrush PrimaryValueBrush = new SolidBrush(primaryValueColor);
            SolidBrush AlternateValueBrush = new SolidBrush(alternateValueColor);

            if (dataSource.Rows.Count != 0)
            {
                n_datpoints = dataSource.Rows.Count;
            }
            float fbar_space = (float)(this.Width - 2 * (x_margin + x_in_margin))
            / (2 * n_datpoints);
            int bar_space = (int)Math.Round(fbar_space);
            int bar_width = (int)Math.Floor(fbar_space);
            font_size = (int)this.Font.Size;

            //Calculate the scale
            y_scale = (this.Height - 2 * (y_margin + y_in_margin)) /
            double.Parse(dataSource.Compute("MAX(" + dataMember_Y + ")", "").ToString());
            //Draw border
            e.Graphics.DrawRectangle(BorderLinePen,
             new Rectangle(x_margin, y_margin, this.Width - 2 * x_margin, this.Height - 2 * y_margin));
            for (int i = 0; i < n_datpoints; i++)
            {
                if (i % 2 == 0)
                {
                    e.Graphics.DrawRectangle(PrimaryColorPen,
                     new Rectangle(x_margin + x_in_margin + (i + 1) * bar_width + i * bar_space,
                  this.Height - y_margin - y_in_margin - (int)(Convert.ToInt32
                  (dataSource.Rows[i][dataMember_Y].ToString()) * y_scale), bar_width,
                  (int)(Convert.ToInt32(dataSource.Rows[i][dataMember_Y].ToString()) * y_scale)));

                    e.Graphics.FillRectangle(PrimarysolidBrush, x_margin + x_in_margin + (i + 1)
                  * bar_width + i * bar_space, this.Height - y_margin - y_in_margin - (int)
                  (Convert.ToInt32(dataSource.Rows[i][dataMember_Y].ToString()) * y_scale),
                   bar_width, (int)(Convert.ToInt32
                  (dataSource.Rows[i][dataMember_Y].ToString()) * y_scale));

                    using (Font font = new Font
                       (this.Font.Name, font_size, this.Font.Style, this.Font.Unit))
                    {
                        Point point1 = new Point(x_margin + x_in_margin + (i + 1) * bar_width + i *
                         bar_space - 3, this.Height - y_margin - y_in_margin -
                         (int)(Convert.ToInt32
                     (dataSource.Rows[i][dataMember_Y].ToString()) * y_scale) - (int)font.Size - 5);
                        Point point2 = new Point(x_margin + x_in_margin + (i + 1) * bar_width + i *
                         bar_space - 3, this.Height - y_margin - y_in_margin);
                        e.Graphics.DrawString(Convert.ToInt32(dataSource.Rows[i]
                         [dataMember_Y].ToString()).ToString(), font, PrimaryValueBrush, point1);
                        e.Graphics.DrawString(dataSource.Rows[i][dataMember_X].ToString()
                         .Substring(0, (bar_width / font_size) + 1), font, PrimaryValueBrush, point2);
                    }
                }
                else
                {
                    e.Graphics.DrawRectangle(AlternateColorPen,
                     new Rectangle(x_margin + x_in_margin + (i + 1) * bar_width + i * bar_space,
                      this.Height - y_margin - y_in_margin - (int)(Convert.ToInt32
                      (dataSource.Rows[i][dataMember_Y].ToString()) * y_scale),
                      bar_width, (int)
                  (Convert.ToInt32(dataSource.Rows[i][dataMember_Y].ToString()) * y_scale)));

                    e.Graphics.FillRectangle(AlternatesolidBrush, x_margin + x_in_margin + (i + 1) *
                  bar_width + i * bar_space, this.Height - y_margin - y_in_margin -
                  (int)(Convert.ToInt32(dataSource.Rows[i][dataMember_Y].ToString()) * y_scale),
                  bar_width, (int)
                  (Convert.ToInt32(dataSource.Rows[i][dataMember_Y].ToString()) * y_scale));

                    using (Font font =
                  new Font(this.Font.Name, font_size, this.Font.Style, this.Font.Unit))
                    {
                        Point point1 = new Point(x_margin + x_in_margin + (i + 1) * bar_width + i *
                     bar_space - 3, this.Height - y_margin - y_in_margin -
                     (int)(Convert.ToInt32
                     (dataSource.Rows[i][dataMember_Y].ToString()) * y_scale) - (int)font.Size - 5);
                        Point point2 = new Point(x_margin + x_in_margin + (i + 1) * bar_width + i *
                         bar_space - 3, this.Height - y_margin - y_in_margin);
                        e.Graphics.DrawString(Convert.ToInt32(dataSource.Rows[i]
                         [dataMember_Y].ToString()).ToString(), font, AlternateValueBrush, point1);
                        e.Graphics.DrawString(dataSource.Rows[i]
                         [dataMember_X].ToString().Substring(0, (bar_width / font_size) + 1)
                         , font, AlternateValueBrush, point2);
                    }
                }
            }
            // Draw Baseline below bars
            e.Graphics.DrawLine(BaseLinePen, x_margin + x_in_margin, this.Height
                 - y_margin - y_in_margin, this.Width - x_margin - x_in_margin,
                this.Height - y_margin - y_in_margin);

            // Draw Vertical Line
            e.Graphics.DrawLine(BaseLinePen, x_margin + x_in_margin,
                this.Height - y_margin - y_in_margin, x_margin + x_in_margin,
                y_margin + y_in_margin);
            //Dispose of Pens and Brushes.
            PrimaryColorPen.Dispose();
            AlternateColorPen.Dispose();
            BaseLinePen.Dispose();
            BorderLinePen.Dispose();
            PrimarysolidBrush.Dispose();
            AlternatesolidBrush.Dispose();
            PrimaryValueBrush.Dispose();
            AlternateValueBrush.Dispose();
        }
        catch (Exception ex)
        {
            string str = ex.Message;
        }
    }
    #endregion DrawBarChart method

    #region Event Handlers
    private void Barchart_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
    {
        DrawBarChart(e);
    }
    #endregion Event Handlers
}
