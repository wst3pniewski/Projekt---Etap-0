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
            ((System.ComponentModel.ISupportInitialize)pass_length_trackBar).BeginInit();
            SuspendLayout();
            // 
            // big_letters_checkbox
            // 
            big_letters_checkbox.AutoSize = true;
            big_letters_checkbox.Location = new Point(65, 231);
            big_letters_checkbox.Name = "big_letters_checkbox";
            big_letters_checkbox.Size = new Size(209, 34);
            big_letters_checkbox.TabIndex = 0;
            big_letters_checkbox.Text = "Wielkie litery (A-Z)";
            big_letters_checkbox.UseVisualStyleBackColor = true;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.BorderStyle = BorderStyle.FixedSingle;
            title_label.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_label.Location = new Point(125, 80);
            title_label.Name = "title_label";
            title_label.Size = new Size(504, 59);
            title_label.TabIndex = 1;
            title_label.Text = "Ustaw parametry hasła";
            // 
            // pass_length_trackBar
            // 
            pass_length_trackBar.Cursor = Cursors.Hand;
            pass_length_trackBar.Location = new Point(438, 249);
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
            length_title_label.Location = new Point(482, 216);
            length_title_label.Name = "length_title_label";
            length_title_label.Size = new Size(89, 30);
            length_title_label.TabIndex = 3;
            length_title_label.Text = "Długość";
            // 
            // password_length_label
            // 
            password_length_label.AutoSize = true;
            password_length_label.Location = new Point(635, 249);
            password_length_label.Name = "password_length_label";
            password_length_label.Size = new Size(24, 30);
            password_length_label.TabIndex = 4;
            password_length_label.Text = "6";
            // 
            // numbers_checkbox
            // 
            numbers_checkbox.AutoSize = true;
            numbers_checkbox.Location = new Point(65, 311);
            numbers_checkbox.Name = "numbers_checkbox";
            numbers_checkbox.Size = new Size(134, 34);
            numbers_checkbox.TabIndex = 5;
            numbers_checkbox.Text = "Cyfry (0-9)";
            numbers_checkbox.UseVisualStyleBackColor = true;
            // 
            // special_signs_checkbox
            // 
            special_signs_checkbox.AutoSize = true;
            special_signs_checkbox.Location = new Point(65, 271);
            special_signs_checkbox.Name = "special_signs_checkbox";
            special_signs_checkbox.Size = new Size(239, 34);
            special_signs_checkbox.TabIndex = 6;
            special_signs_checkbox.Text = "Znaki specjalne (#$%)";
            special_signs_checkbox.UseVisualStyleBackColor = true;
            // 
            // small_letters_checkbox
            // 
            small_letters_checkbox.AutoSize = true;
            small_letters_checkbox.Location = new Point(65, 191);
            small_letters_checkbox.Name = "small_letters_checkbox";
            small_letters_checkbox.Size = new Size(184, 34);
            small_letters_checkbox.TabIndex = 7;
            small_letters_checkbox.Text = "Małe litery (a-z)";
            small_letters_checkbox.UseVisualStyleBackColor = true;
            // 
            // generate_pass_button
            // 
            generate_pass_button.BackColor = SystemColors.MenuHighlight;
            generate_pass_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generate_pass_button.Location = new Point(65, 402);
            generate_pass_button.Name = "generate_pass_button";
            generate_pass_button.Size = new Size(387, 65);
            generate_pass_button.TabIndex = 8;
            generate_pass_button.Text = "Wygeneruj hasło";
            generate_pass_button.UseVisualStyleBackColor = false;
            generate_pass_button.Click += generate_pass_button_Click;
            // 
            // generated_password_textbox
            // 
            generated_password_textbox.BackColor = SystemColors.Info;
            generated_password_textbox.BorderStyle = BorderStyle.FixedSingle;
            generated_password_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generated_password_textbox.Location = new Point(65, 498);
            generated_password_textbox.Name = "generated_password_textbox";
            generated_password_textbox.ReadOnly = true;
            generated_password_textbox.Size = new Size(131, 45);
            generated_password_textbox.TabIndex = 10;
            generated_password_textbox.TextAlign = HorizontalAlignment.Center;
            generated_password_textbox.TextChanged += generated_password_textbox_TextChanged;
            // 
            // copy_button
            // 
            copy_button.BackColor = SystemColors.MenuHighlight;
            copy_button.Enabled = false;
            copy_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            copy_button.Location = new Point(65, 573);
            copy_button.Name = "copy_button";
            copy_button.Size = new Size(131, 40);
            copy_button.TabIndex = 11;
            copy_button.Text = "Kopiuj";
            copy_button.UseVisualStyleBackColor = false;
            copy_button.Click += copy_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(817, 661);
            Controls.Add(copy_button);
            Controls.Add(generated_password_textbox);
            Controls.Add(generate_pass_button);
            Controls.Add(small_letters_checkbox);
            Controls.Add(special_signs_checkbox);
            Controls.Add(numbers_checkbox);
            Controls.Add(password_length_label);
            Controls.Add(length_title_label);
            Controls.Add(pass_length_trackBar);
            Controls.Add(title_label);
            Controls.Add(big_letters_checkbox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generator Haseł";
            ((System.ComponentModel.ISupportInitialize)pass_length_trackBar).EndInit();
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
    }
}
