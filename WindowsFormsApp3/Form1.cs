using System;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form : System.Windows.Forms.Form
    {
        DateTime currentTime = DateTime.Now;
        PrivateFontCollection privateFont;

        public Form()
        {
            InitializeComponent();

            //font
            privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("./Resources/NanumGothic.ttf");
            Font font = new Font(privateFont.Families[0], 9);

            this.Font = font;

            label.Font = new Font(privateFont.Families[0], 8);
            label2.Font = new Font(privateFont.Families[0], 8);
            labelWeekCount.Font = new Font(privateFont.Families[0], 8);
            labelWeek.Font = new Font(privateFont.Families[0], 7);

            labelList.Font = new Font(privateFont.Families[0], 8);
            labelInsert.Font = new Font(privateFont.Families[0], 7);
        }

        private void setGridView()
        {
            gridView.Rows.Add("", "");
            gridView.Rows.Add("", "");
            gridView.Rows.Add("", "");
            gridView.Rows.Add("", "");
            gridView.Rows.Add("", "");
            gridView.Rows.Add("", "");
            gridView.Rows.Add("", "");
            gridView.Rows.Add("", "");
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            gridView.ClearSelection();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ////////////listview////////////
            listView.Columns[5].ImageIndex = 1;
            listView.Columns[4].ImageIndex = 0;

            /////////////map///////////////
            map.DisableFocusOnMouseEnter = true;

            //////////gridview/////////////
            setGridView();
            gridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridView.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            ///////////label///////////////
            //2004년 1월 1일(EST)부터 오늘까지의 일수 계산
            DateTime start = DateTime.ParseExact("20150106 040000", "yyyyMMdd HHmmss", CultureInfo.InvariantCulture);
            TimeSpan day = currentTime - start;
            int dayNum = day.Days;
            int weekNum;

            if (dayNum % 7 == 0) //currentTime이 화요일
                weekNum = (dayNum / 7) - 1;
            else
                weekNum = (dayNum / 7);

            labelWeekCount.Text = weekNum + "( 0x" + Convert.ToString(weekNum, 16) + " )";

            //현재 날짜가 속한 주 표기
            switch (currentTime.DayOfWeek)
            {
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                case DayOfWeek.Saturday:
                    labelWeek.Text = "("
                        + (DateTime.Today.AddDays(Convert.ToInt32(DayOfWeek.Sunday) - Convert.ToInt32(DateTime.Today.DayOfWeek))).AddDays(3).ToShortDateString()
                        + "  09:00:00" 
                        + " ~ "
                        + (DateTime.Today.AddDays(Convert.ToInt32(DayOfWeek.Saturday) - Convert.ToInt32(DateTime.Today.DayOfWeek))).AddDays(4).ToShortDateString()
                        + "  08:59:59" 
                        + ")";
                    break;
                case DayOfWeek.Sunday:
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                    labelWeek.Text = "("
                        + (DateTime.Today.AddDays(Convert.ToInt32(DayOfWeek.Sunday) - Convert.ToInt32(DateTime.Today.DayOfWeek))).AddDays(-3).ToShortDateString()
                        + "  09:00:00" 
                        + " ~ "
                        + (DateTime.Today.AddDays(Convert.ToInt32(DayOfWeek.Saturday) - Convert.ToInt32(DateTime.Today.DayOfWeek))).AddDays(-2).ToShortDateString()
                        + "  08:59:59" 
                        + ")";
                    break;
            }
        }

       
    }
}
