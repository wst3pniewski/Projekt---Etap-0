namespace generator_hasel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            big_letters_checkbox = new CheckBox();
            title_label = new Label();
            pass_length_trackBar = new TrackBar();
            length_title_label = new Label();
            password_length_label = new Label();
            numbers_checkbox = new CheckBox();
            special_signs_checkbox = new CheckBox();
            small_letters_checkbox = new CheckBox();
            generate_pass_button = new Button();
            generated_password_textbox = new TextBox();
            copy_button = new Button();
            panel1 = new Panel();
            close_button = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pass_length_trackBar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // big_letters_checkbox
            // 
            big_letters_checkbox.AutoSize = true;
            big_letters_checkbox.BackColor = Color.FromArgb(24, 30, 54);
            big_letters_checkbox.ForeColor = Color.White;
            big_letters_checkbox.Location = new Point(53, 164);
            big_letters_checkbox.Name = "big_letters_checkbox";
            big_letters_checkbox.Size = new Size(209, 34);
            big_letters_checkbox.TabIndex = 0;
            big_letters_checkbox.Text = "Wielkie litery (A-Z)";
            big_letters_checkbox.UseVisualStyleBackColor = false;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.BackColor = Color.FromArgb(24, 30, 54);
            title_label.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            title_label.ForeColor = Color.White;
            title_label.Location = new Point(10, 37);
            title_label.Name = "title_label";
            title_label.Size = new Size(337, 38);
            title_label.TabIndex = 1;
            title_label.Text = "Ustaw parametry hasła";
            title_label.Click += title_label_Click;
            // 
            // pass_length_trackBar
            // 
            pass_length_trackBar.BackColor = Color.FromArgb(24, 30, 54);
            pass_length_trackBar.Cursor = Cursors.Hand;
            pass_length_trackBar.Location = new Point(46, 372);
            pass_length_trackBar.Maximum = 32;
            pass_length_trackBar.Minimum = 6;
            pass_length_trackBar.Name = "pass_length_trackBar";
            pass_length_trackBar.Size = new Size(191, 80);
            pass_length_trackBar.TabIndex = 2;
            pass_length_trackBar.TickStyle = TickStyle.None;
            pass_length_trackBar.Value = 6;
            pass_length_trackBar.Scroll += trackBar1_Scroll;
            // 
            // length_title_label
            // 
            length_title_label.AutoSize = true;
            length_title_label.BackColor = Color.Transparent;
            length_title_label.ForeColor = Color.White;
            length_title_label.Location = new Point(53, 327);
            length_title_label.Name = "length_title_label";
            length_title_label.Size = new Size(89, 30);
            length_title_label.TabIndex = 3;
            length_title_label.Text = "Długość";
            // 
            // password_length_label
            // 
            password_length_label.AutoSize = true;
            password_length_label.BackColor = Color.Transparent;
            password_length_label.Font = new Font("Segoe UI", 10F);
            password_length_label.ForeColor = Color.White;
            password_length_label.Location = new Point(243, 372);
            password_length_label.Name = "password_length_label";
            password_length_label.Size = new Size(27, 32);
            password_length_label.TabIndex = 4;
            password_length_label.Text = "6";
            // 
            // numbers_checkbox
            // 
            numbers_checkbox.AutoSize = true;
            numbers_checkbox.BackColor = Color.FromArgb(24, 30, 54);
            numbers_checkbox.ForeColor = Color.White;
            numbers_checkbox.Location = new Point(53, 264);
            numbers_checkbox.Name = "numbers_checkbox";
            numbers_checkbox.Size = new Size(134, 34);
            numbers_checkbox.TabIndex = 5;
            numbers_checkbox.Text = "Cyfry (0-9)";
            numbers_checkbox.UseVisualStyleBackColor = false;
            // 
            // special_signs_checkbox
            // 
            special_signs_checkbox.AutoSize = true;
            special_signs_checkbox.BackColor = Color.FromArgb(24, 30, 54);
            special_signs_checkbox.ForeColor = Color.White;
            special_signs_checkbox.Location = new Point(53, 214);
            special_signs_checkbox.Name = "special_signs_checkbox";
            special_signs_checkbox.Size = new Size(239, 34);
            special_signs_checkbox.TabIndex = 6;
            special_signs_checkbox.Text = "Znaki specjalne (#$%)";
            special_signs_checkbox.UseVisualStyleBackColor = false;
            // 
            // small_letters_checkbox
            // 
            small_letters_checkbox.AutoSize = true;
            small_letters_checkbox.BackColor = Color.FromArgb(24, 30, 54);
            small_letters_checkbox.ForeColor = Color.White;
            small_letters_checkbox.Location = new Point(53, 114);
            small_letters_checkbox.Name = "small_letters_checkbox";
            small_letters_checkbox.Size = new Size(184, 34);
            small_letters_checkbox.TabIndex = 7;
            small_letters_checkbox.Text = "Małe litery (a-z)";
            small_letters_checkbox.UseVisualStyleBackColor = false;
            // 
            // generate_pass_button
            // 
            generate_pass_button.BackColor = Color.FromArgb(41, 51, 73);
            generate_pass_button.FlatAppearance.BorderSize = 0;
            generate_pass_button.FlatStyle = FlatStyle.Flat;
            generate_pass_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generate_pass_button.ForeColor = Color.White;
            generate_pass_button.Location = new Point(21, 458);
            generate_pass_button.Name = "generate_pass_button";
            generate_pass_button.Padding = new Padding(5);
            generate_pass_button.Size = new Size(297, 61);
            generate_pass_button.TabIndex = 8;
            generate_pass_button.Text = "Wygeneruj hasło";
            generate_pass_button.UseVisualStyleBackColor = false;
            generate_pass_button.Click += generate_pass_button_Click;
            // 
            // generated_password_textbox
            // 
            generated_password_textbox.BackColor = Color.FromArgb(24, 30, 54);
            generated_password_textbox.BorderStyle = BorderStyle.FixedSingle;
            generated_password_textbox.Font = new Font("Segoe UI", 11F);
            generated_password_textbox.ForeColor = Color.White;
            generated_password_textbox.Location = new Point(368, 481);
            generated_password_textbox.Name = "generated_password_textbox";
            generated_password_textbox.ReadOnly = true;
            generated_password_textbox.Size = new Size(131, 42);
            generated_password_textbox.TabIndex = 10;
            generated_password_textbox.TextAlign = HorizontalAlignment.Center;
            generated_password_textbox.TextChanged += generated_password_textbox_TextChanged;
            // 
            // copy_button
            // 
            copy_button.BackColor = Color.FromArgb(24, 30, 54);
            copy_button.Enabled = false;
            copy_button.FlatAppearance.BorderSize = 0;
            copy_button.FlatStyle = FlatStyle.Flat;
            copy_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            copy_button.ForeColor = Color.White;
            copy_button.Location = new Point(368, 552);
            copy_button.Margin = new Padding(0);
            copy_button.Name = "copy_button";
            copy_button.Padding = new Padding(2);
            copy_button.Size = new Size(131, 40);
            copy_button.TabIndex = 11;
            copy_button.Text = "Kopiuj";
            copy_button.UseVisualStyleBackColor = false;
            copy_button.Click += copy_button_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(title_label);
            panel1.Controls.Add(small_letters_checkbox);
            panel1.Controls.Add(big_letters_checkbox);
            panel1.Controls.Add(generate_pass_button);
            panel1.Controls.Add(special_signs_checkbox);
            panel1.Controls.Add(length_title_label);
            panel1.Controls.Add(password_length_label);
            panel1.Controls.Add(numbers_checkbox);
            panel1.Controls.Add(pass_length_trackBar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 637);
            panel1.TabIndex = 12;
            // 
            // close_button
            // 
            close_button.Cursor = Cursors.Hand;
            close_button.FlatAppearance.BorderSize = 0;
            close_button.FlatStyle = FlatStyle.Flat;
            close_button.Font = new Font("Segoe UI", 8.142858F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_button.ForeColor = Color.White;
            close_button.Location = new Point(784, 12);
            close_button.Name = "close_button";
            close_button.Size = new Size(30, 30);
            close_button.TabIndex = 13;
            close_button.Text = "X";
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += close_button_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(391, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 408);
            panel2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 51, 73);
            ClientSize = new Size(826, 661);
            Controls.Add(panel2);
            Controls.Add(close_button);
            Controls.Add(copy_button);
            Controls.Add(generated_password_textbox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generator Haseł";
            ((System.ComponentModel.ISupportInitialize)pass_length_trackBar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox big_letters_checkbox;
        private Label title_label;
        private TrackBar pass_length_trackBar;
        private Label length_title_label;
        private Label password_length_label;
        private CheckBox numbers_checkbox;
        private CheckBox special_signs_checkbox;
        private CheckBox small_letters_checkbox;
        private Button generate_pass_button;
        private TextBox generated_password_textbox;
        private Button copy_button;
        private Panel panel1;
        private Button close_button;
        private Panel panel2;
    }
}
