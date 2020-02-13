using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal class Sorter : IComparer
    {
        public int column = 0;
        public SortOrder order = SortOrder.Ascending;

        public int Compare(object x, object y)
        {
            if (!(x is ListViewItem))
                return (0);
            if (!(y is ListViewItem))
                return (0);

            ListViewItem itemX = (ListViewItem)x;
            ListViewItem itemY = (ListViewItem)y;

            if (itemX.ListView.Columns[column].Tag == null) //listview tag 속성이 null이면
                itemX.ListView.Columns[column].Tag = "Text"; //기본적으로 text속성을 할당

            //속성이 Numeric이면
            //if (itemX.ListView.Columns[column].Tag.ToString() == "Numeric")
            //{
            //    string strX = itemX.SubItems[column].Text;
            //    string strY = itemY.SubItems[column].Text;

            //    if (strX == "")
            //        strX = "99999";
            //    if (strY == "")
            //        strY = "99999";

            //    //숫자형식으로 변환해서 비교하기 위함
            //    float flX = float.Parse(strX);
            //    float flY = float.Parse(strY);

            //    if (order == SortOrder.Ascending)
            //        return flX.CompareTo(flY);
            //    else
            //        return flY.CompareTo(flX);
            //}
            //Img 이면
            //else if (itemX.ListView.Columns[column].Tag.ToString() == "Img")
            //{
            //    //활성상태인 리스트를 위로
            //}
            //Numeric 이외이면

            string strX = itemX.SubItems[column].Text;
            string strY = itemY.SubItems[column].Text;

            if (order == SortOrder.Ascending)
                return strX.CompareTo(strY);
            else
                return strY.CompareTo(strX);
        }
    }
}