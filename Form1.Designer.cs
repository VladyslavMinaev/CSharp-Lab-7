namespace variant_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.delete_selected = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.групиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відрахуватиВсіхСтудентівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вільніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.зарахуватиУВибрануToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалиІзУніверситетуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уГрупахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відрахуватиІзГрупиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевестиУІншуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відрахуватиІзУніверситетуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиІнфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Групи";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(4, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(731, 392);
            this.splitContainer1.SplitterDistance = 288;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(288, 392);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(439, 392);
            this.splitContainer2.SplitterDistance = 182;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(439, 182);
            this.dataGridView2.TabIndex = 10;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.delete_selected);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView3);
            this.splitContainer3.Size = new System.Drawing.Size(439, 206);
            this.splitContainer3.SplitterDistance = 37;
            this.splitContainer3.TabIndex = 0;
            // 
            // delete_selected
            // 
            this.delete_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(174)))), ((int)(((byte)(217)))));
            this.delete_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_selected.Location = new System.Drawing.Point(184, 2);
            this.delete_selected.Name = "delete_selected";
            this.delete_selected.Size = new System.Drawing.Size(252, 33);
            this.delete_selected.TabIndex = 23;
            this.delete_selected.Text = "ЗАРАХУВАТИ У ВИБРАНУ";
            this.delete_selected.UseVisualStyleBackColor = false;
            this.delete_selected.Click += new System.EventHandler(this.delete_selected_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вільні студенти";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(439, 165);
            this.dataGridView3.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.групиToolStripMenuItem,
            this.студентиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // групиToolStripMenuItem
            // 
            this.групиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.редагуватиToolStripMenuItem,
            this.відрахуватиВсіхСтудентівToolStripMenuItem,
            this.видалиToolStripMenuItem});
            this.групиToolStripMenuItem.Name = "групиToolStripMenuItem";
            this.групиToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.групиToolStripMenuItem.Text = "Групи";
            // 
            // додатиToolStripMenuItem
            // 
            this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            this.додатиToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.додатиToolStripMenuItem.Text = "Додати";
            this.додатиToolStripMenuItem.Click += new System.EventHandler(this.додатиToolStripMenuItem_Click);
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            this.редагуватиToolStripMenuItem.Click += new System.EventHandler(this.редагуватиToolStripMenuItem_Click);
            // 
            // відрахуватиВсіхСтудентівToolStripMenuItem
            // 
            this.відрахуватиВсіхСтудентівToolStripMenuItem.Name = "відрахуватиВсіхСтудентівToolStripMenuItem";
            this.відрахуватиВсіхСтудентівToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.відрахуватиВсіхСтудентівToolStripMenuItem.Text = "Відрахувати всіх студентів";
            this.відрахуватиВсіхСтудентівToolStripMenuItem.Click += new System.EventHandler(this.відрахуватиВсіхСтудентівToolStripMenuItem_Click);
            // 
            // видалиToolStripMenuItem
            // 
            this.видалиToolStripMenuItem.Name = "видалиToolStripMenuItem";
            this.видалиToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.видалиToolStripMenuItem.Text = "Видали";
            this.видалиToolStripMenuItem.Click += new System.EventHandler(this.видалиToolStripMenuItem_Click);
            // 
            // студентиToolStripMenuItem
            // 
            this.студентиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вільніToolStripMenuItem,
            this.уГрупахToolStripMenuItem});
            this.студентиToolStripMenuItem.Name = "студентиToolStripMenuItem";
            this.студентиToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.студентиToolStripMenuItem.Text = "Студенти";
            // 
            // вільніToolStripMenuItem
            // 
            this.вільніToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem2,
            this.редагуватиToolStripMenuItem2,
            this.зарахуватиУВибрануToolStripMenuItem,
            this.видалиІзУніверситетуToolStripMenuItem});
            this.вільніToolStripMenuItem.Name = "вільніToolStripMenuItem";
            this.вільніToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.вільніToolStripMenuItem.Text = "Вільні";
            // 
            // додатиToolStripMenuItem2
            // 
            this.додатиToolStripMenuItem2.Name = "додатиToolStripMenuItem2";
            this.додатиToolStripMenuItem2.Size = new System.Drawing.Size(250, 26);
            this.додатиToolStripMenuItem2.Text = "Додати";
            this.додатиToolStripMenuItem2.Click += new System.EventHandler(this.додатиToolStripMenuItem2_Click);
            // 
            // редагуватиToolStripMenuItem2
            // 
            this.редагуватиToolStripMenuItem2.Name = "редагуватиToolStripMenuItem2";
            this.редагуватиToolStripMenuItem2.Size = new System.Drawing.Size(250, 26);
            this.редагуватиToolStripMenuItem2.Text = "Редагувати";
            this.редагуватиToolStripMenuItem2.Click += new System.EventHandler(this.редагуватиToolStripMenuItem2_Click);
            // 
            // зарахуватиУВибрануToolStripMenuItem
            // 
            this.зарахуватиУВибрануToolStripMenuItem.Name = "зарахуватиУВибрануToolStripMenuItem";
            this.зарахуватиУВибрануToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.зарахуватиУВибрануToolStripMenuItem.Text = "Зарахувати у вибрану";
            this.зарахуватиУВибрануToolStripMenuItem.Click += new System.EventHandler(this.зарахуватиУВибрануToolStripMenuItem_Click);
            // 
            // видалиІзУніверситетуToolStripMenuItem
            // 
            this.видалиІзУніверситетуToolStripMenuItem.Name = "видалиІзУніверситетуToolStripMenuItem";
            this.видалиІзУніверситетуToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.видалиІзУніверситетуToolStripMenuItem.Text = "Видали із університету";
            this.видалиІзУніверситетуToolStripMenuItem.Click += new System.EventHandler(this.видалиІзУніверситетуToolStripMenuItem_Click);
            // 
            // уГрупахToolStripMenuItem
            // 
            this.уГрупахToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відрахуватиІзГрупиToolStripMenuItem,
            this.перевестиУІншуToolStripMenuItem,
            this.відрахуватиІзУніверситетуToolStripMenuItem,
            this.редагуватиІнфоToolStripMenuItem});
            this.уГрупахToolStripMenuItem.Name = "уГрупахToolStripMenuItem";
            this.уГрупахToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.уГрупахToolStripMenuItem.Text = "У групах";
            // 
            // відрахуватиІзГрупиToolStripMenuItem
            // 
            this.відрахуватиІзГрупиToolStripMenuItem.Name = "відрахуватиІзГрупиToolStripMenuItem";
            this.відрахуватиІзГрупиToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.відрахуватиІзГрупиToolStripMenuItem.Text = "Відрахувати із групи";
            this.відрахуватиІзГрупиToolStripMenuItem.Click += new System.EventHandler(this.відрахуватиІзГрупиToolStripMenuItem_Click);
            // 
            // перевестиУІншуToolStripMenuItem
            // 
            this.перевестиУІншуToolStripMenuItem.Name = "перевестиУІншуToolStripMenuItem";
            this.перевестиУІншуToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.перевестиУІншуToolStripMenuItem.Text = "Перевести у іншу";
            this.перевестиУІншуToolStripMenuItem.Click += new System.EventHandler(this.перевестиУІншуToolStripMenuItem_Click);
            // 
            // відрахуватиІзУніверситетуToolStripMenuItem
            // 
            this.відрахуватиІзУніверситетуToolStripMenuItem.Name = "відрахуватиІзУніверситетуToolStripMenuItem";
            this.відрахуватиІзУніверситетуToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.відрахуватиІзУніверситетуToolStripMenuItem.Text = "Відрахувати із університету";
            this.відрахуватиІзУніверситетуToolStripMenuItem.Click += new System.EventHandler(this.відрахуватиІзУніверситетуToolStripMenuItem_Click);
            // 
            // редагуватиІнфоToolStripMenuItem
            // 
            this.редагуватиІнфоToolStripMenuItem.Name = "редагуватиІнфоToolStripMenuItem";
            this.редагуватиІнфоToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.редагуватиІнфоToolStripMenuItem.Text = "Редагувати інфо";
            this.редагуватиІнфоToolStripMenuItem.Click += new System.EventHandler(this.редагуватиІнфоToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(174)))), ((int)(((byte)(217)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(598, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(740, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem групиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відрахуватиВсіхСтудентівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button delete_selected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStripMenuItem вільніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem зарахуватиУВибрануToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалиІзУніверситетуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уГрупахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відрахуватиІзГрупиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевестиУІншуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відрахуватиІзУніверситетуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиІнфоToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

