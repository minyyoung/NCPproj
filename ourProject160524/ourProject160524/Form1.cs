using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Net;
using System.Xml;

namespace ourProject160524
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            theAM = new CAreaManager();
        }

        string selectID2;
        string selectID3;

        private void Form1_Load( object sender, EventArgs e )
        {
            theAM.theAreas.Clear();

            StreamReader tmpSR = new StreamReader( new FileStream( "address.csv", FileMode.Open ) );
            while( tmpSR.EndOfStream == false )
            {
                String tmpStr = tmpSR.ReadLine();
                String[] tmpClass = tmpStr.Split( ',' );


                if( tmpClass[ 2 ] == "" )
                {
                    theAM.AddArea( tmpClass[ 1 ], "-", "-", tmpClass[ 0 ] );
                }
                else if( tmpClass[ 3 ] == "" )
                {
                    theAM.AddArea( tmpClass[ 1 ], tmpClass[ 2 ], "-", tmpClass[ 0 ] );
                }
                else
                {
                    theAM.AddArea( tmpClass[ 1 ], tmpClass[ 2 ], tmpClass[ 3 ], tmpClass[ 0 ] );
                }

            }
            cbKind1.Items.Clear();
            foreach( KeyValuePair<string, SortedList<string, SortedList<string, string>>> iter in theAM.theAreas )
            {
                cbKind1.Items.Add( iter.Key );
            }
            cbKind1.SelectedIndex = 0;
            tmpSR.Close();

            dateLabel.Text = DateTime.Today.ToString( "yyyy-MM-dd" ) +
                                 "(" + GetStrDayOfWeek( DateTime.Today.ToString( "yyyy-MM-dd" ) ) + ") " +
                                 DateTime.Now.ToLongTimeString();
        }

        private void cbKind1_SelectedIndexChanged( object sender, EventArgs e )
        {
            selectID2 = cbKind1.Items[ cbKind1.SelectedIndex ].ToString();
            SortedList<string, SortedList<string, string>> tmpArea2 = theAM.theAreas[ selectID2 ];

            cbKind2.Items.Clear();
            foreach( KeyValuePair<string, SortedList<string, string>> iter in tmpArea2 )
            {
                cbKind2.Items.Add( iter.Key );
            }
            cbKind2.SelectedIndex = 0;
        }

        private void cbKind2_SelectedIndexChanged( object sender, EventArgs e )
        {
            selectID3 = cbKind2.Items[ cbKind2.SelectedIndex ].ToString();
            SortedList<string, string> tmpArea3 = theAM.theAreas[ selectID2 ][ selectID3 ];

            cbKind3.Items.Clear();
            foreach( KeyValuePair<string, string> iter in tmpArea3 )
            {
                cbKind3.Items.Add( iter.Key );
            }
            cbKind3.SelectedIndex = 0;
        }

        public SortedList<string, string> theCode;
        private CAreaManager theAM;

        private void button1_Click( object sender, EventArgs e )
        {
            HttpWebRequest http = (HttpWebRequest) WebRequest.Create(
                "http://203.247.66.146/iros/RetrieveLifeIndexService/getUltrvLifeList?ServiceKey=6SWK3Ll%2BXniV1bEC%2F06SPf8PiL4vbC8sCX%2BcmuMr1VDOCVaiD%2F%2FWpqOpM0KhfIg4%2Fi6KUeRyJVcDktuYuOKOsg%3D%3D&AreaNo=1100000000&numOfRows=999&pageNo=1" );


            WebResponse response = http.GetResponse();
            StreamReader sr = new StreamReader( response.GetResponseStream() );

            string content = sr.ReadToEnd();
            tbResult.Text = content;

            parsingXML(content);
        }

        private void parsingXML(string strXml)
        {
            XmlDocument xml = new XmlDocument(); // XmlDocument 생성
            xml.LoadXml(strXml);
            XmlNode code = xml.GetElementsByTagName("code")[0];
            XmlNode areaNo = xml.GetElementsByTagName("areaNo")[0];
            XmlNode date = xml.GetElementsByTagName("date")[0];
            XmlNode today = xml.GetElementsByTagName("today")[0];
            XmlNode tomorrow = xml.GetElementsByTagName("tomorrow")[0];
            XmlNode afterTo = xml.GetElementsByTagName("theDayAfterTomorrow")[0];

            parsingText.Text = "code : " + code.InnerText + "\n";
            parsingText.AppendText("areaNo : " + areaNo.InnerText + "\n");
            parsingText.AppendText("date : " + date.InnerText + "\n");
            parsingText.AppendText("today : " + today.InnerText + "\n");
            parsingText.AppendText("tomorrow : " + tomorrow.InnerText + "\n");
            parsingText.AppendText("afterTo : " + afterTo.InnerText + "\n");
        }

        private void cbKind3_SelectedIndexChanged( object sender, EventArgs e )
        {
            string tmpselectID2 = cbKind1.Items[ cbKind1.SelectedIndex ].ToString();
            string tmpselectID3 = cbKind2.Items[ cbKind2.SelectedIndex ].ToString();
            string tmpselectID4 = cbKind3.Items[ cbKind3.SelectedIndex ].ToString();

            areaNumber.Text = theAM.theAreas[ tmpselectID2 ][ tmpselectID3 ][ tmpselectID4 ];
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

        private void moreInfoButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 form = new Form2();
            form.Owner = this;
            form.Show();
        }
    }
}
