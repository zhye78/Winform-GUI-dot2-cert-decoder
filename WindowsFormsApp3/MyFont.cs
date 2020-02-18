using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class MyFont
    {
        //private static MyFont inst = new MyFont();
        //public PrivateFontCollection privateFont = new PrivateFontCollection();
        //public static FontFamily[] Families
        //{
        //    get
        //    {
        //        return inst.privateFont.Families; //이 객체의 폰트패밀리 배열 리턴
        //    }
        //}

        //public MyFont()
        //{
        //    AddFontFromMemory();
        //}

        //private void AddFontFromMemory()
        //{
        //    List<byte[]> fonts = new List<byte[]>(); //폰트 저장할 리스트-폰트마다 바이트배열 형태로 저장
        //    fonts.Add(Properties.Resources.NanumGothic); //프로젝트 리소스 폴더에서 나눔고딕 폰트 가져옴

        //    foreach (byte[] font in fonts) //리스트의 폰트 개수만큼
        //    {
        //        IntPtr fontBuffer = Marshal.AllocCoTaskMem(font.Length);
        //        Marshal.Copy(font, 0, fontBuffer, font.Length);
        //        privateFont.AddMemoryFont(fontBuffer, font.Length);
        //    }
        //}
    }
}
