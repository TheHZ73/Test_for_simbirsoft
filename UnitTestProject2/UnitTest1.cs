using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindWord_in_File;
using System.Windows.Forms;




namespace FindWord_in_File
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMetodHtmlTextForRecord()
        {
            string TestValueFunctionHtml=@"<!DOCTYPE html>
                                    <html>
                                    <head>
                                    <title>Прочитанный файл</title>
                                    <meta http-equiv=""content-type"" content=""text/html; charset=windows-1251"" />
                                    </head>
                                    <body>
                                    <div style=""margin:30px"">
                                    <p>Запись сделаная для теста</p>
                                    </div>
                                    </body>
                                    </html> ";
            Form1 form1test = new Form1();
            Assert.AreEqual(form1test.HtmlTextForRecordFile("Запись сделаная для теста"), TestValueFunctionHtml);
        }
    }
}
