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

namespace XMLParsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            HttpWebRequest http = (HttpWebRequest) WebRequest.Create(
               "http://203.247.66.146/iros/RetrieveLifeIndexService/getUltrvLifeList?ServiceKey=6SWK3Ll%2BXniV1bEC%2F06SPf8PiL4vbC8sCX%2BcmuMr1VDOCVaiD%2F%2FWpqOpM0KhfIg4%2Fi6KUeRyJVcDktuYuOKOsg%3D%3D&AreaNo=1100000000&numOfRows=999&pageNo=1" );

            WebResponse response = http.GetResponse();
            StreamReader sr = new StreamReader( response.GetResponseStream() );

            string content = sr.ReadToEnd();
            xml.Text = content;

            parsingXML(content);
        }

        private void parsingXML(string strXml) {
            XmlDocument xml = new XmlDocument(); // XmlDocument 생성
            xml.LoadXml( strXml );
            XmlNode code = xml.GetElementsByTagName( "code" )[0];
            XmlNode areaNo = xml.GetElementsByTagName( "areaNo" )[ 0 ];
            XmlNode date = xml.GetElementsByTagName( "date" )[ 0 ];
            XmlNode today = xml.GetElementsByTagName( "today" )[ 0 ];
            XmlNode tomorrow = xml.GetElementsByTagName( "tomorrow" )[ 0 ];
            XmlNode afterTo = xml.GetElementsByTagName( "theDayAfterTomorrow" )[ 0 ];

            xmlResult.Text = "code : " + code.InnerText;
        }
    }
}
