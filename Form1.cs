namespace MiscTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Tab1
            textBoxTab1Input.TextChanged += TextBoxTab1Input_TextChanged;
            textBoxTab1Output.ReadOnly = true;
        }

        private void TextBoxTab1Input_TextChanged(object? sender, EventArgs e)
        {
            string input = textBoxTab1Input.Text;
            string output = Uri.EscapeDataString(input);
            textBoxTab1Output.Text = output;
        }
    }
}
