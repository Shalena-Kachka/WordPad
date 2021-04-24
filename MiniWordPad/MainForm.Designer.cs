namespace MiniWordPad
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.MinimizeWindowButton = new System.Windows.Forms.Button();
            this.MaximizeWindowButton = new System.Windows.Forms.Button();
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RichTextBoxEditor = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитькакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьвсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.содержаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индексToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteButton = new System.Windows.Forms.Button();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предварительныйпросмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.CutButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.FontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SetBoldButton = new System.Windows.Forms.Button();
            this.SetItalicButton = new System.Windows.Forms.Button();
            this.SetUnderlineButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.MinimizeWindowButton);
            this.panel1.Controls.Add(this.MaximizeWindowButton);
            this.panel1.Controls.Add(this.CloseWindowButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 30);
            this.panel1.TabIndex = 0;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.FileNameLabel.Location = new System.Drawing.Point(0, 0);
            this.FileNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(703, 30);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "Название файла.rtf - MiniWordPad";
            this.FileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FileNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowDrag);
            // 
            // MinimizeWindowButton
            // 
            this.MinimizeWindowButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeWindowButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeWindowButton.FlatAppearance.BorderSize = 0;
            this.MinimizeWindowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.MinimizeWindowButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.MinimizeWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeWindowButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F);
            this.MinimizeWindowButton.Location = new System.Drawing.Point(793, 0);
            this.MinimizeWindowButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeWindowButton.Name = "MinimizeWindowButton";
            this.MinimizeWindowButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeWindowButton.TabIndex = 2;
            this.MinimizeWindowButton.Text = "_";
            this.MinimizeWindowButton.UseVisualStyleBackColor = false;
            this.MinimizeWindowButton.Click += new System.EventHandler(this.MaximizeMinimizeButton);
            // 
            // MaximizeWindowButton
            // 
            this.MaximizeWindowButton.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeWindowButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizeWindowButton.FlatAppearance.BorderSize = 0;
            this.MaximizeWindowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.MaximizeWindowButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.MaximizeWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeWindowButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F);
            this.MaximizeWindowButton.Location = new System.Drawing.Point(823, 0);
            this.MaximizeWindowButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeWindowButton.Name = "MaximizeWindowButton";
            this.MaximizeWindowButton.Size = new System.Drawing.Size(30, 30);
            this.MaximizeWindowButton.TabIndex = 1;
            this.MaximizeWindowButton.Text = "O";
            this.MaximizeWindowButton.UseVisualStyleBackColor = false;
            this.MaximizeWindowButton.Click += new System.EventHandler(this.MaximizeMinimizeButton);
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseWindowButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseWindowButton.FlatAppearance.BorderSize = 0;
            this.CloseWindowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.CloseWindowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.CloseWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindowButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F);
            this.CloseWindowButton.ForeColor = System.Drawing.Color.White;
            this.CloseWindowButton.Location = new System.Drawing.Point(853, 0);
            this.CloseWindowButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(30, 30);
            this.CloseWindowButton.TabIndex = 0;
            this.CloseWindowButton.Text = "X";
            this.CloseWindowButton.UseVisualStyleBackColor = false;
            this.CloseWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F);
            this.SaveButton.Location = new System.Drawing.Point(0, 0);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(30, 30);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "💾";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // RedoButton
            // 
            this.RedoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RedoButton.BackColor = System.Drawing.Color.Transparent;
            this.RedoButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RedoButton.FlatAppearance.BorderSize = 0;
            this.RedoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.RedoButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.RedoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedoButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F);
            this.RedoButton.Location = new System.Drawing.Point(60, 0);
            this.RedoButton.Margin = new System.Windows.Forms.Padding(0);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(30, 30);
            this.RedoButton.TabIndex = 5;
            this.RedoButton.Text = "↪";
            this.RedoButton.UseVisualStyleBackColor = false;
            // 
            // UndoButton
            // 
            this.UndoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UndoButton.BackColor = System.Drawing.Color.Transparent;
            this.UndoButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.UndoButton.FlatAppearance.BorderSize = 0;
            this.UndoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.UndoButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.UndoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F);
            this.UndoButton.Location = new System.Drawing.Point(30, 0);
            this.UndoButton.Margin = new System.Windows.Forms.Padding(0);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(30, 30);
            this.UndoButton.TabIndex = 6;
            this.UndoButton.Text = "↩";
            this.UndoButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.RedoButton);
            this.panel2.Controls.Add(this.UndoButton);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 30);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.FileNameLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(90, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(703, 30);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel3.Controls.Add(this.SetUnderlineButton);
            this.panel3.Controls.Add(this.SetItalicButton);
            this.panel3.Controls.Add(this.SetBoldButton);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.FontSizeComboBox);
            this.panel3.Controls.Add(this.CopyButton);
            this.panel3.Controls.Add(this.CutButton);
            this.panel3.Controls.Add(this.FontSelectorComboBox);
            this.panel3.Controls.Add(this.PasteButton);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 100);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel5.Controls.Add(this.RichTextBoxEditor);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 130);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panel5.Size = new System.Drawing.Size(883, 375);
            this.panel5.TabIndex = 2;
            // 
            // RichTextBoxEditor
            // 
            this.RichTextBoxEditor.AcceptsTab = true;
            this.RichTextBoxEditor.BackColor = System.Drawing.Color.White;
            this.RichTextBoxEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxEditor.EnableAutoDragDrop = true;
            this.RichTextBoxEditor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RichTextBoxEditor.Location = new System.Drawing.Point(50, 0);
            this.RichTextBoxEditor.Name = "RichTextBoxEditor";
            this.RichTextBoxEditor.Size = new System.Drawing.Size(783, 375);
            this.RichTextBoxEditor.TabIndex = 0;
            this.RichTextBoxEditor.Text = "Привет мир\n\nТестовый набор слов для проверки отображения текстбокса";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator,
            this.сохранитьToolStripMenuItem,
            this.сохранитькакToolStripMenuItem,
            this.toolStripSeparator1,
            this.печатьToolStripMenuItem,
            this.предварительныйпросмотрToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(261, 6);
            // 
            // сохранитькакToolStripMenuItem
            // 
            this.сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
            this.сохранитькакToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.сохранитькакToolStripMenuItem.Text = "Сохранить &как";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(261, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменадействияToolStripMenuItem,
            this.отменадействияToolStripMenuItem1,
            this.toolStripSeparator3,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставкаToolStripMenuItem,
            this.toolStripSeparator4,
            this.выделитьвсеToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.правкаToolStripMenuItem.Text = "&Правка";
            // 
            // отменадействияToolStripMenuItem
            // 
            this.отменадействияToolStripMenuItem.Name = "отменадействияToolStripMenuItem";
            this.отменадействияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменадействияToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.отменадействияToolStripMenuItem.Text = "&Отмена действия";
            // 
            // отменадействияToolStripMenuItem1
            // 
            this.отменадействияToolStripMenuItem1.Name = "отменадействияToolStripMenuItem1";
            this.отменадействияToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.отменадействияToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.отменадействияToolStripMenuItem1.Text = "&Отмена действия";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(236, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(236, 6);
            // 
            // выделитьвсеToolStripMenuItem
            // 
            this.выделитьвсеToolStripMenuItem.Name = "выделитьвсеToolStripMenuItem";
            this.выделитьвсеToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.выделитьвсеToolStripMenuItem.Text = "Выделить &все";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.сервисToolStripMenuItem.Text = "&Сервис";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.настройкиToolStripMenuItem.Text = "&Настройки";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.параметрыToolStripMenuItem.Text = "&Параметры";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.содержаниеToolStripMenuItem,
            this.индексToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.toolStripSeparator5,
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // содержаниеToolStripMenuItem
            // 
            this.содержаниеToolStripMenuItem.Name = "содержаниеToolStripMenuItem";
            this.содержаниеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.содержаниеToolStripMenuItem.Text = "&Содержание";
            // 
            // индексToolStripMenuItem
            // 
            this.индексToolStripMenuItem.Name = "индексToolStripMenuItem";
            this.индексToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.индексToolStripMenuItem.Text = "&Индекс";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поискToolStripMenuItem.Text = "&Поиск";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            // 
            // PasteButton
            // 
            this.PasteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PasteButton.FlatAppearance.BorderSize = 0;
            this.PasteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F);
            this.PasteButton.Image = global::MiniWordPad.Properties.Resources.paste;
            this.PasteButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PasteButton.Location = new System.Drawing.Point(6, 26);
            this.PasteButton.Margin = new System.Windows.Forms.Padding(0);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(65, 70);
            this.PasteButton.TabIndex = 0;
            this.PasteButton.Text = "Вставить";
            this.PasteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PasteButton.UseVisualStyleBackColor = true;
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem.Image")));
            this.создатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.создатьToolStripMenuItem.Text = "&Создать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.открытьToolStripMenuItem.Text = "&Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripMenuItem.Image")));
            this.печатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.печатьToolStripMenuItem.Text = "&Печать";
            // 
            // предварительныйпросмотрToolStripMenuItem
            // 
            this.предварительныйпросмотрToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("предварительныйпросмотрToolStripMenuItem.Image")));
            this.предварительныйпросмотрToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.предварительныйпросмотрToolStripMenuItem.Name = "предварительныйпросмотрToolStripMenuItem";
            this.предварительныйпросмотрToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.предварительныйпросмотрToolStripMenuItem.Text = "Предварительный про&смотр";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripMenuItem.Image")));
            this.вырезатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезат&ь";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripMenuItem.Image")));
            this.копироватьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.копироватьToolStripMenuItem.Text = "&Копировать";
            // 
            // вставкаToolStripMenuItem
            // 
            this.вставкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripMenuItem.Image")));
            this.вставкаToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
            this.вставкаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставкаToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.вставкаToolStripMenuItem.Text = "Вст&авка";
            // 
            // FontSelectorComboBox
            // 
            this.FontSelectorComboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontSelectorComboBox.FormattingEnabled = true;
            this.FontSelectorComboBox.Location = new System.Drawing.Point(189, 31);
            this.FontSelectorComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.FontSelectorComboBox.Name = "FontSelectorComboBox";
            this.FontSelectorComboBox.Size = new System.Drawing.Size(124, 23);
            this.FontSelectorComboBox.TabIndex = 2;
            this.FontSelectorComboBox.Text = "Calibri";
            // 
            // CutButton
            // 
            this.CutButton.FlatAppearance.BorderSize = 0;
            this.CutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.CutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CutButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F);
            this.CutButton.ForeColor = System.Drawing.Color.Black;
            this.CutButton.Location = new System.Drawing.Point(75, 30);
            this.CutButton.Margin = new System.Windows.Forms.Padding(0);
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(100, 23);
            this.CutButton.TabIndex = 3;
            this.CutButton.Text = "✂️ Вырезать";
            this.CutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CutButton.UseVisualStyleBackColor = true;
            // 
            // CopyButton
            // 
            this.CopyButton.FlatAppearance.BorderSize = 0;
            this.CopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F);
            this.CopyButton.ForeColor = System.Drawing.Color.Black;
            this.CopyButton.Location = new System.Drawing.Point(75, 54);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(100, 23);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "⎘ Копировать";
            this.CopyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopyButton.UseVisualStyleBackColor = true;
            // 
            // FontSizeComboBox
            // 
            this.FontSizeComboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontSizeComboBox.FormattingEnabled = true;
            this.FontSizeComboBox.Location = new System.Drawing.Point(313, 31);
            this.FontSizeComboBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.FontSizeComboBox.Name = "FontSizeComboBox";
            this.FontSizeComboBox.Size = new System.Drawing.Size(52, 23);
            this.FontSizeComboBox.TabIndex = 5;
            this.FontSizeComboBox.Text = "12";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel6.Location = new System.Drawing.Point(176, 24);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 74);
            this.panel6.TabIndex = 6;
            // 
            // SetBoldButton
            // 
            this.SetBoldButton.FlatAppearance.BorderSize = 0;
            this.SetBoldButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SetBoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetBoldButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetBoldButton.Location = new System.Drawing.Point(189, 60);
            this.SetBoldButton.Margin = new System.Windows.Forms.Padding(0);
            this.SetBoldButton.Name = "SetBoldButton";
            this.SetBoldButton.Size = new System.Drawing.Size(25, 25);
            this.SetBoldButton.TabIndex = 7;
            this.SetBoldButton.Text = "Ж";
            this.SetBoldButton.UseVisualStyleBackColor = true;
            // 
            // SetItalicButton
            // 
            this.SetItalicButton.FlatAppearance.BorderSize = 0;
            this.SetItalicButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SetItalicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetItalicButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetItalicButton.Location = new System.Drawing.Point(214, 60);
            this.SetItalicButton.Margin = new System.Windows.Forms.Padding(0);
            this.SetItalicButton.Name = "SetItalicButton";
            this.SetItalicButton.Size = new System.Drawing.Size(25, 25);
            this.SetItalicButton.TabIndex = 8;
            this.SetItalicButton.Text = "К";
            this.SetItalicButton.UseVisualStyleBackColor = true;
            // 
            // SetUnderlineButton
            // 
            this.SetUnderlineButton.FlatAppearance.BorderSize = 0;
            this.SetUnderlineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SetUnderlineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetUnderlineButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetUnderlineButton.Location = new System.Drawing.Point(239, 60);
            this.SetUnderlineButton.Margin = new System.Windows.Forms.Padding(0);
            this.SetUnderlineButton.Name = "SetUnderlineButton";
            this.SetUnderlineButton.Size = new System.Drawing.Size(25, 25);
            this.SetUnderlineButton.TabIndex = 9;
            this.SetUnderlineButton.Text = "Ч";
            this.SetUnderlineButton.UseCompatibleTextRendering = true;
            this.SetUnderlineButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(891, 509);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseWindowButton;
        private System.Windows.Forms.Button MinimizeWindowButton;
        private System.Windows.Forms.Button MaximizeWindowButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button RedoButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox RichTextBoxEditor;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитькакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem выделитьвсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem содержаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem индексToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button CutButton;
        private System.Windows.Forms.ComboBox FontSelectorComboBox;
        private System.Windows.Forms.ComboBox FontSizeComboBox;
        private System.Windows.Forms.Button SetUnderlineButton;
        private System.Windows.Forms.Button SetItalicButton;
        private System.Windows.Forms.Button SetBoldButton;
        private System.Windows.Forms.Panel panel6;
    }
}

