using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weatherAPIExam
{
    public class CAreaManager
    {
        public SortedList<string, SortedList<string, SortedList<string, string>>> theAreas;
        public CAreaManager()
        {
            theAreas = new SortedList<string, SortedList<string, SortedList<string, string>>>();
        }

        public int AddArea( string aArea1, string aArea2, string aArea3, string aValue )
        {
            SortedList<string, SortedList<string, string>> tmpArea2;
            if( theAreas.ContainsKey( aArea1 ) == true )
            {
                tmpArea2 = theAreas[aArea1];
            }
            else
            {
                theAreas.Add(aArea1, new SortedList<string, SortedList<string, string>>());
                tmpArea2 = theAreas[aArea1];
            }

            SortedList<string, string> tmpArea3;
            if( tmpArea2.ContainsKey( aArea2 ) == true )
            {
                tmpArea3 = tmpArea2[aArea2];
            }
            else
            {
                tmpArea2.Add(aArea2, new SortedList<string, string>());
                tmpArea3 = tmpArea2[aArea2];
            }

            if( tmpArea3.ContainsKey( aArea3 ) == true )
            {
                tmpArea3[aArea3] = aValue;
            }
            else
            {
                tmpArea3.Add(aArea3, aValue);
            }
            return (1);
        }
    }
}
