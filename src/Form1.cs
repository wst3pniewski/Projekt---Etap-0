namespace generator_hasel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            password_length_label.Text = pass_length_trackBar.Value.ToString();
        }

        private void generate_pass_button_Click(object sender, EventArgs e)
        {
            PasswordGenerator p = new PasswordGenerator();
            try
            {
                generated_password_textbox.Text = p.generatePassword(pass_length_trackBar.Value, big_letters_checkbox.Checked,
                                                                        small_letters_checkbox.Checked, numbers_checkbox.Checked, special_signs_checkbox.Checked);
            }
            catch (AnyCheckBoxSelectedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void generated_password_textbox_TextChanged(object sender, EventArgs e)
        {
            generated_password_textbox.Width = TextRenderer.MeasureText(generated_password_textbox.Text, generated_password_textbox.Font).Width + 15;
            copy_button.Enabled = !string.IsNullOrEmpty(generated_password_textbox.Text);
        }

        private void copy_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(generated_password_textbox.Text);
            //CustomMessageBox messageBox = new CustomMessageBox("Skopiowano hasło do schowka");
            //messageBox.ShowDialog();
            MessageBox.Show("Skopiowano haslo do schowka.");
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void title_label_Click(object sender, EventArgs e)
        {

        }
    }
}
