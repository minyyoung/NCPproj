using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            dateLabel.Text = DateTime.Today.ToString( "yyyy-MM-dd" ) +
                                 "(" + GetStrDayOfWeek( DateTime.Today.ToString( "yyyy-MM-dd" ) ) + ") " +
                                 DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            dateLabel.Text = DateTime.Today.ToString( "yyyy-MM-dd" ) +
                                 "(" + GetStrDayOfWeek( DateTime.Today.ToString( "yyyy-MM-dd" ) ) + ") " +
                                 DateTime.Now.ToLongTimeString();
        }

        public static string GetStrDayOfWeek( string o_DateTime )                                     //요일을 Return한다.
        {
            DateTime l_Date = DateTime.ParseExact( o_DateTime.Replace( "-", "" ), "yyyyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo, System.Globalization.DateTimeStyles.None );
            switch( l_Date.DayOfWeek )
            {
                case DayOfWeek.Monday: return "월";
                case DayOfWeek.Tuesday: return "화";
                case DayOfWeek.Wednesday: return "수";
                case DayOfWeek.Thursday: return "목";
                case DayOfWeek.Friday: return "금";
                case DayOfWeek.Saturday: return "토";
                case DayOfWeek.Sunday: return "일";
            }
            return "";
        }
    }
}
