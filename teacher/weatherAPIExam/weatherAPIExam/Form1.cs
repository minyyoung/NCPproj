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

namespace weatherAPIExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /* to be continue...
            theCode = new SortedList<string, string>();
            theCode.Add( "청운효자동", "1111051500" );
            theCode.Add( "사직동", "1111053000" );

            foreach( KeyValuePair<string, string> iter in theCode )
            {
                cbCode.Items.Add( iter.Key );
            }

//            cbCode.Items.Add( "1111000000" );
//            cbCode.Items.Add( "1111051500" );*/

            theAM = new CAreaManager();
/*          theAM.AddArea("서울", "종로구", "청운효자동", "1111051500");
            theAM.AddArea("서울", "종로구", "혜화동", "1111065000");
            theAM.AddArea("서울", "종로구", "-", "1111000000");
            theAM.AddArea("서울", "도봉구", "창제1동", "1132051100");
            theAM.AddArea("서울", "관악구", "대학동", "1162073500");
            theAM.AddArea("서울", "관악구", "신림동", "1162069500");
            theAM.AddArea("서울", "관악구", "보라매동", "1162052500");
            theAM.AddArea("서울", "동작구", "신대방제2동", "1159068000");
            theAM.AddArea("전라북도", "군산시", "소룡동", "4513071000");
            theAM.AddArea("전라북도", "군산시", "월명동", "4513053000");
            theAM.AddArea("광주광역시", "동구", "충장동", "2911052500");
            theAM.AddArea("전라북도", "전주시덕진구", "진북동", "4511352500");
            theAM.AddArea("부산광역시", "영도구", "청학제1동", "2620063000");

            cbKind1.Items.Clear();
            foreach (KeyValuePair<string, SortedList<string, SortedList<string, string>> > iter in theAM.theAreas)
            {
                cbKind1.Items.Add(iter.Key);
            }
            cbKind1.SelectedIndex = 0;
*/
            /*            cbCode.Items.Add( "1111053000" );
                      cbCode.Items.Add( "1111054000" );
                      cbCode.Items.Add( "1111055000" );
                      cbCode.Items.Add( "1111056000" );
                      cbCode.Items.Add( "1111057000" );
                      cbCode.Items.Add( "1111058000" );
                     cbCode.SelectedIndex = 0;
          */        }

        string selectID2;
        string selectID3;

        private void cbKind1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectID2 = cbKind1.Items[cbKind1.SelectedIndex].ToString();
            SortedList<string, SortedList<string, string>> tmpArea2 = theAM.theAreas[selectID2];

            cbKind2.Items.Clear();
            foreach (KeyValuePair<string, SortedList<string, string>> iter in tmpArea2)
            {
                cbKind2.Items.Add(iter.Key);
            }
            cbKind2.SelectedIndex = 0;
        }

        private void cbKind2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectID3 = cbKind2.Items[cbKind2.SelectedIndex].ToString();
            SortedList<string, string> tmpArea3 = theAM.theAreas[selectID2][selectID3];

            cbKind3.Items.Clear();
            foreach (KeyValuePair<string, string> iter in tmpArea3)
            {
                cbKind3.Items.Add(iter.Key);
            }
            cbKind3.SelectedIndex = 0;
        }

        public SortedList<string, string> theCode;

        private void button1_Click( object sender, EventArgs e )
        {
//            HttpWebRequest http = (HttpWebRequest) WebRequest.Create(
//                "http://203.247.66.146/iros/RetrieveWhoIndexService/getAsthmaWhoList?ServiceKey=6SWK3Ll%2BXniV1bEC%2F06SPf8PiL4vbC8sCX%2BcmuMr1VDOCVaiD%2F%2FWpqOpM0KhfIg4%2Fi6KUeRyJVcDktuYuOKOsg%3D%3D&AreaNo=1100000000&numOfRows=999&pageSize=999&pageNo=1&startPage=1" );
            HttpWebRequest http = (HttpWebRequest) WebRequest.Create(
                "http://203.247.66.146/iros/RetrieveWhoIndexService/getAsthmaWhoList?ServiceKey="
                + "6SWK3Ll%2BXniV1bEC%2F06SPf8PiL4vbC8sCX%2BcmuMr1VDOCVaiD%2F%2FWpqOpM0KhfIg4%2Fi6KUeRyJVcDktuYuOKOsg%3D%3D&"
                + "AreaNo=" + areaNumber.Text + "&numOfRows=999&pageSize=999&pageNo="+ tbPage.Text + "&startPage=1" );

//           string tmpCode = theCode[ cbCode.SelectedItem.ToString() ];

            WebResponse response = http.GetResponse();
            StreamReader sr = new StreamReader( response.GetResponseStream() );

//            MemoryStream stream = response.GetResponseStream();
//            StreamReader sr = new StreamReader( stream );
            string content = sr.ReadToEnd();
            tbResult.Text = content;
        }

        private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {

        }

        CAreaManager theAM;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click ( object sender, EventArgs e )
        {
            theAM.theAreas.Clear();

            StreamReader tmpSR = new StreamReader(new FileStream("address.csv", FileMode.Open));
            while(tmpSR.EndOfStream == false)
            {
                String tmpStr = tmpSR.ReadLine();
                String[] tmpClass = tmpStr.Split( ',' );


                if( tmpClass[2] == "")
                {
                    theAM.AddArea(tmpClass[1], "-", "-", tmpClass[0]);
                }
                else if( tmpClass[3] == "" )
                {
                    theAM.AddArea(tmpClass[1], tmpClass[2], "-", tmpClass[0]);
                }
                else
                {
                    theAM.AddArea(tmpClass[1], tmpClass[2], tmpClass[3], tmpClass[0]);
                }


            }
            cbKind1.Items.Clear();
            foreach(KeyValuePair<string, SortedList<string, SortedList<string, string>>> iter in theAM.theAreas)
            {
                cbKind1.Items.Add(iter.Key);
            }
            cbKind1.SelectedIndex = 0;
            tmpSR.Close();
        }

        private void textBox1_TextChanged ( object sender, EventArgs e )
        {

        }

        private void cbKind3_SelectedIndexChanged ( object sender, EventArgs e )
        {
            string tmpselectID2 = cbKind1.Items[cbKind1.SelectedIndex].ToString();
            string tmpselectID3 = cbKind2.Items[cbKind2.SelectedIndex].ToString();
            string tmpselectID4 = cbKind3.Items[cbKind3.SelectedIndex].ToString();

            areaNumber.Text = theAM.theAreas[tmpselectID2][tmpselectID3][tmpselectID4];
        }




    }
}
