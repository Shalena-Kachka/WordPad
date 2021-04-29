using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniWordPad
{
    //проверка
    public partial class MainForm : Form
    {
        public string OpenedDocumentPath { get; set; } = "Новый документ"; //Путь к открытому документу
        public bool IsOpened { get; set; } = false; //Если false, то при нажатии на сохранить затребовать путь к файлу
        List<string> _FontsName = new List<string>();
        List<float> _FontSize = new List<float>();
        public string DefaultSaveDirectory { get; set; } = "c:\\";

        public MainForm()
        {
            InitializeComponent();
            InitializeFonts();
        }

        /// <summary>
        /// Кнопка для сворачивания и увеличивания формы
        /// </summary>
        private void MaximizeMinimizeButton(object sender, EventArgs e)
        {
            var buttonText = ((System.Windows.Forms.Button)sender).Text;
            if (buttonText == "_") WindowState = FormWindowState.Minimized;
            else WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        /// <summary>
        /// Обновляет строку в заголовке окна
        /// </summary>
        private void UpdatePath()
        {
            FileNameLabel.Text = $"{OpenedDocumentPath} - MiniWordPad";
        }

        /// <summary>
        /// Кнопка для создания нового файла
        /// </summary>
        private void CreateFileMenuButton_Click(object sender, EventArgs e)
        {
            IsOpened = false;
            RichTextBoxEditor.Text = String.Empty;
            OpenedDocumentPath = "Новый документ";
            UpdatePath();
        }

        /// <summary>
        /// Вызов окна для сохранения файла по другому пути
        /// </summary>
        private void SaveAsMenuButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = DefaultSaveDirectory;
                saveFileDialog.Filter = "Текст с форматированием (*.rtf)|*.rtf|Простой текст (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dirPath = saveFileDialog.FileName.Substring(0, saveFileDialog.FileName.LastIndexOf(Path.DirectorySeparatorChar) + 1);
                    Directory.CreateDirectory(dirPath); //Если каталог не существует - создать

                    RichTextBoxEditor.SaveFile(saveFileDialog.FileName,
                        saveFileDialog.FileName.EndsWith(".rtf") ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText); //Если .rtf, сохранить с форматированием

                    OpenedDocumentPath = saveFileDialog.FileName;
                    IsOpened = true;
                    UpdatePath();
                }
            }
        }

        /// <summary>
        /// Кнопка для печати документа
        /// </summary>
        private void PrintMenuButton_Click(object sender, EventArgs e)
        {
            if (PrintDialogElement.ShowDialog() == DialogResult.OK)
            {
                PrintDocumentElement.DocumentName = OpenedDocumentPath.Substring(OpenedDocumentPath.LastIndexOf(Path.DirectorySeparatorChar));
                PrintDocumentElement.Print();
            }
        }

        /// <summary>
        /// https://www.codeproject.com/Tips/673996/RichTextBox-Printing-in-Csharp-with-WinForms-VS201
        /// </summary>
        private void PrintDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            char[] param = { '\n' };
            if (PrintDialogElement.PrinterSettings.PrintRange == PrintRange.Selection)
            {
                lines = RichTextBoxEditor.SelectedText.Split(param);
            }
            else
            {
                lines = RichTextBoxEditor.Text.Split(param);
            }
            int i = 0;
            char[] trimParam = { '\r' };
            foreach (string s in lines)
            {
                lines[i++] = s.TrimEnd(trimParam);
            }
        }

        private int linesPrinted;
        private string[] lines;

        /// <summary>
        /// Рендер RTF документа для печати
        /// </summary>
        private void OnPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            Brush brush = new SolidBrush(RichTextBoxEditor.ForeColor);

            while (linesPrinted < lines.Length)
            {
                e.Graphics.DrawString(lines[linesPrinted++],
                    RichTextBoxEditor.Font, brush, x, y);
                y += 15;
                if (y >= e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            linesPrinted = 0;
            e.HasMorePages = false;
        }

        /// <summary>
        /// Кнопка которая открывает файл в WordPad
        /// </summary>
        private void PreviewMenuButton_Click(object sender, EventArgs e)
        {
            if (IsOpened)
            {
                Process fileopener = new Process();
                fileopener.StartInfo.FileName = "wordpad";
                fileopener.StartInfo.Arguments = "\"" + OpenedDocumentPath + "\"";
                fileopener.Start();
            }
        }

        /// <summary>
        /// Кнопка для сохранения файла
        /// </summary>
        private void SaveMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsOpened) //Если файл уже был открыт, просто сохранить по пути (проверив существование директории)
                {
                    var dirPath = OpenedDocumentPath.Substring(0, OpenedDocumentPath.LastIndexOf(Path.DirectorySeparatorChar) + 1);
                    Directory.CreateDirectory(dirPath); //Если каталог не существует - создать

                    RichTextBoxEditor.SaveFile(OpenedDocumentPath,
                        OpenedDocumentPath.EndsWith(".rtf") ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText); //Если .rtf, сохранить с форматированием
                }
                else //Файл новый, значит вызвать диалог для сохранения
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.InitialDirectory = DefaultSaveDirectory;
                        saveFileDialog.Filter = "Текст с форматированием (*.rtf)|*.rtf|Простой текст (*.txt)|*.txt|Все файлы (*.*)|*.*";
                        saveFileDialog.FilterIndex = 1;
                        saveFileDialog.RestoreDirectory = true;

                        if(saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var dirPath = saveFileDialog.FileName.Substring(0, saveFileDialog.FileName.LastIndexOf(Path.DirectorySeparatorChar) + 1);
                            Directory.CreateDirectory(dirPath); //Если каталог не существует - создать

                            RichTextBoxEditor.SaveFile(saveFileDialog.FileName,
                                saveFileDialog.FileName.EndsWith(".rtf") ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText); //Если .rtf, сохранить с форматированием

                            OpenedDocumentPath = saveFileDialog.FileName;
                            IsOpened = true;
                            UpdatePath();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Кнопка открытия файла
        /// </summary>
        private void OpenFileMenuButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = DefaultSaveDirectory;
                openFileDialog.Filter = "Документы (*.rtf;*.pdf;*.txt)|*.rtf;*.pdf;*.txt|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK &&
                    openFileDialog.FileName.Length > 0)
                {
                    OpenedDocumentPath = openFileDialog.FileName;
                    IsOpened = true; //Файл теперь открыт
                    UpdatePath();

                    try
                    {
                        if (OpenedDocumentPath.EndsWith(".rtf")) //Открытие RTF файлов
                        {
                            RichTextBoxEditor.LoadFile(OpenedDocumentPath);
                        }
                        else if (OpenedDocumentPath.EndsWith(".pdf")) //Обработка PDF файлов
                        {
                            //TODO: 
                            //Добавить чтение PDF файлов
                            MessageBox.Show("PDF Временно не поддерживается!");

                            //Создать новый файл чтобы не возникало ошибок
                            IsOpened = false;
                            RichTextBoxEditor.Text = String.Empty;
                            OpenedDocumentPath = "Новый документ";
                            UpdatePath();
                        }
                        else //Любой другой файл просто открыть в текстовом режиме
                        {
                            var fileStream = openFileDialog.OpenFile();
                            using (StreamReader reader = new StreamReader(fileStream))
                            {
                                RichTextBoxEditor.Text = reader.ReadToEnd();
                            }
                        }
                    }
                    catch(IOException ex)
                    {
                        MessageBox.Show("Не удалось открыть файл. Возможно он занят другим процессом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Метод для перетаскивания формы
        /// </summary>
        private void WindowDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); //Вызывает API Windows для захвата окна
            }
        }

        /// <summary>
        /// Кнопка для закрытия формы
        /// </summary>
        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Перетаскивание и растягивание окна
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 16;
        Rectangle TopCursor { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle LeftCursor { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }

        private void PastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                RichTextBoxEditor.Paste();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBoxEditor.SelectionLength > 0)
                RichTextBoxEditor.Copy();
        }

        private void CutoolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (RichTextBoxEditor.SelectionLength > 0)
                RichTextBoxEditor.Cut();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBoxEditor.SelectAll();
        }

        private void RepitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBoxEditor.CanRedo == true)
                if (RichTextBoxEditor.RedoActionName != "Delete")
                    RichTextBoxEditor.Redo();
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBoxEditor.Undo();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Тут была копия кода "Сохранить как"
        }

        //Изменение цвета MainForm
        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
            ForeColor = Color.Black;
        }

        //Изменение цвета MainForm
        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            ForeColor = Color.White;
        }

        private void BackColorPickerMenuItem_Click(object sender, EventArgs e)
        {
            using(ColorDialog colorDialog = new ColorDialog())
            {
                if(colorDialog.ShowDialog() == DialogResult.OK)
                    BackColor = colorDialog.Color;
            }
        }

        private void ForeColorPickerMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                    ForeColor = colorDialog.Color;
            }
        }

        Rectangle BottomCursor { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle RightCursor { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        //о программе
        private void AboutMenuButton_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }
        
        // вывод справки
        private void ShowHelpMenuMenuButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm");//засунул help.chm в bin/Debug
        }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (TopCursor.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (LeftCursor.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (RightCursor.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (BottomCursor.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
        #endregion

        /// <summary>
        /// Метод запонения шрифтов и размеров
        /// </summary>
        private void InitializeFonts()
        {
            FontFamily[] fontList = new System.Drawing.Text.InstalledFontCollection().Families;
            foreach (var item in fontList)            
                _FontsName.Add(item.Name);

            FontSelectorComboBox.DataSource = _FontsName;
            FontSelectorComboBox.SelectedIndex = 10;
            for (int i = 1; i < 50; i++)
                _FontSize.Add(i);
            FontSizeComboBox.DataSource = _FontSize;
            FontSizeComboBox.SelectedIndex = 10;
           
        }

        private int GetFontIndex(string name)
        {
            return _FontsName.IndexOf(name);
        }

        private void FontSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RichTextBoxEditor.SelectionFont = new Font
            (
                FontSelectorComboBox.SelectedItem.ToString(),
                (float)FontSizeComboBox.SelectedItem,
                (
                    (checkBoxBold.Checked ? FontStyle.Bold : 0) |
                    (checkBoxItalic.Checked ? FontStyle.Italic : 0) |
                    (checkBoxUnderline.Checked ? FontStyle.Underline : 0)
                )
            );
        }

        private void RichTextBoxEditor_SelectionChanged(object sender, EventArgs e)
        {
            if (RichTextBoxEditor.SelectionFont != null) {
                checkBoxBold.Checked = RichTextBoxEditor.SelectionFont.Bold;
                checkBoxItalic.Checked = RichTextBoxEditor.SelectionFont.Italic;
                checkBoxUnderline.Checked = RichTextBoxEditor.SelectionFont.Underline;

                FontSelectorComboBox.SelectedIndex = GetFontIndex(RichTextBoxEditor.SelectionFont.FontFamily.Name);
                FontSizeComboBox.SelectedItem = RichTextBoxEditor.SelectionFont.Size;
            }
        }
    }
}
