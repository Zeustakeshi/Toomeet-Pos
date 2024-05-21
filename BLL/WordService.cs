using MiniSoftware;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace Toomeet_Pos.BLL.Interfaces
{

    public interface IWordService
    {
        void ExportFile(string filePath, Action<Word.Application> callback);
        void ExportFile(string filePath, string templatePath, object value);
        void FindAndReplace(Word.Application wordApp, string findText, string replaceText);
    }
    public class WordService : IWordService
    {

        private readonly string templatesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "templates");


        public void ExportFile(string filePath, string templatePath, object value)
        {
            MiniWord.SaveAsByTemplate(filePath, templatePath, value);

        }

        public void ExportFile (string filePath, Action<Word.Application> callback)
        {

            string templateFilePath = Path.Combine(templatesDirectory, "bao_cao_mau.docx");
            object objMiss = Missing.Value;

            // Tạo một ứng dụng Word mới
            Word.Application wordApp = new Word.Application();

            // Tạo một tài liệu Word mới
            Word.Document wordDoc = wordApp.Documents.Open(
                templateFilePath,
                ref objMiss,
                ref objMiss,
                ref objMiss,
                ref objMiss,
                ref objMiss,
                ref objMiss,
                ref objMiss,
                ref objMiss,
                ref objMiss,
                ref objMiss,
                ref objMiss,
                ref objMiss,
                ref objMiss,
                ref objMiss,
                ref objMiss);


            wordApp.Activate();

            callback(wordApp);

            wordDoc.SaveAs2(filePath, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss);


            // Đóng tài liệu và ứng dụng Word
            wordDoc.Close(ref objMiss, ref objMiss, ref objMiss);
            wordApp.Quit();
        }



        public void FindAndReplace(Word.Application wordApp, string findText, string replaceText)
        {
            // Ensure findText is not empty
            if (string.IsNullOrEmpty(findText))
            {
                throw new ArgumentException("findText cannot be empty or null.");
            }

            // Use Word.WdFindReplace options for better control
            Word.Find find = wordApp.Selection.Find;
            find.Text = findText;
            find.Replacement.Text = replaceText;
            


            // Set common search options
            find.Forward = true;
            find.Wrap = Word.WdFindWrap.wdFindContinue;
            find.Format = true;
            find.MatchCase = true;
            find.MatchWholeWord = true;

            // Execute the search and handle potential errors
            try
            {
                find.Execute(); 
            }
            catch (COMException ex)
            {
                // Handle potential COM exceptions (e.g., "Text not found")
                MessageBox.Show("Text not found: " + ex.Message);
            }
        }

    }
}
