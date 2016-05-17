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

namespace weather01_0510
{
    public partial class Form1 :Form
    {
        CAreaManager theAM;

        String areaNumber;
        string selectID2;
        string selectID3;

        public SortedList<string, string> theCode;

        public Form1 ()
        {
            InitializeComponent();

            theAM = new CAreaManager();

            theAM.theAreas.Clear();

            StreamReader tmpSR = null;
            try
            {
                tmpSR = new StreamReader(new FileStream("address.csv", FileMode.Open));

            while(tmpSR.EndOfStream == false)
            {
                String tmpStr = tmpSR.ReadLine();
                String[] tmpClass = tmpStr.Split(',');


                if(tmpClass[2] == "")
                {
                    theAM.AddArea(tmpClass[1], "-", "-", tmpClass[0]);
                }
                else if(tmpClass[3] == "")
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
            } catch (Exception e) {
                tbResult.Text = e.ToString();
            }
            finally
            {
                if(tmpSR != null)
                {
                    tmpSR.Close();
                }
            }
        }

        private void label1_Click ( object sender, EventArgs e )
        {

        }

        private void cbKind1_SelectedIndexChanged ( object sender, EventArgs e )
        {
            selectID2 = cbKind1.Items[cbKind1.SelectedIndex].ToString();
            SortedList<string, SortedList<string, string>> tmpArea2 = theAM.theAreas[selectID2];

            cbKind2.Items.Clear();
            foreach(KeyValuePair<string, SortedList<string, string>> iter in tmpArea2)
            {
                cbKind2.Items.Add(iter.Key);
            }
            cbKind2.SelectedIndex = 0;
        }

        private void cbKind2_SelectedIndexChanged ( object sender, EventArgs e )
        {
            selectID3 = cbKind2.Items[cbKind2.SelectedIndex].ToString();
            SortedList<string, string> tmpArea3 = theAM.theAreas[selectID2][selectID3];

            cbKind3.Items.Clear();
            foreach(KeyValuePair<string, string> iter in tmpArea3)
            {
                cbKind3.Items.Add(iter.Key);
            }
            cbKind3.SelectedIndex = 0;
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            HttpWebRequest http = (HttpWebRequest)WebRequest.Create(
                " http://203.247.66.146/iros/RetrieveLifeIndexService/getFsnLifeList?ServiceKey="
                + "6SWK3Ll%2BXniV1bEC%2F06SPf8PiL4vbC8sCX%2BcmuMr1VDOCVaiD%2F%2FWpqOpM0KhfIg4%2Fi6KUeRyJVcDktuYuOKOsg%3D%3D&"
                + "AreaNo=" + areaNumber + "&numOfRows=999&pageSize=999&pageNp=1");

            //           string tmpCode = theCode[ cbCode.SelectedItem.ToString() ];

            WebResponse response = http.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());

            //            MemoryStream stream = response.GetResponseStream();
            //            StreamReader sr = new StreamReader( stream );
            string content = sr.ReadToEnd();
            tbResult.Text = content;
        }

        private void cbKind3_SelectedIndexChanged ( object sender, EventArgs e )
        {
            string tmpselectID2 = cbKind1.Items[cbKind1.SelectedIndex].ToString();
            string tmpselectID3 = cbKind2.Items[cbKind2.SelectedIndex].ToString();
            string tmpselectID4 = cbKind3.Items[cbKind3.SelectedIndex].ToString();

            areaNumber = theAM.theAreas[tmpselectID2][tmpselectID3][tmpselectID4];
        }

        private void label1_Click_1 ( object sender, EventArgs e )
        {

        }

    }
}
