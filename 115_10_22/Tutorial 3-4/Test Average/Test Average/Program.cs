using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Test_Average
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用 Windows Forms 的視覺樣式與文字顯示設定。
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 啟動測驗平均分數表單。
            Application.Run(new Form1());
        }
    }
}
