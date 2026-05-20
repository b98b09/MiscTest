using MiscTest.CustomControls;
using System.Diagnostics;

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

            textBoxTab1DecInput.TextChanged += TextBoxTab1DecInput_TextChanged;
            textBoxTab1DecOutput.ReadOnly = true;

            this.Load += Form1_Load;
            this.Shown += Form1_Shown;
            this.FormClosed += Form1_FormClosed;
        }





        private void Form1_Load(object? sender, EventArgs e)
        {
            RadioGroupBox rBox = new();
            rBox.AddItem("Option 1", 1);
            rBox.AddItem("Option 2", 2);
            rBox.AddItem("Option 3", 3);
            rBox.CheckedChanged += (sender, e) =>
            {
                if (sender is RadioButton rb)
                {
                    Debug.WriteLine($"Selected: {rb.Tag}, Checked: {rb.Checked}");
                }
            };
            tabPage2.Controls.Add(rBox);
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
        private void Form1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void TextBoxTab1DecInput_TextChanged(object? sender, EventArgs e)
        {
            string input = textBoxTab1DecInput.Text;
            string output = Uri.UnescapeDataString(input);
            textBoxTab1DecOutput.Text = output;
        }

        private void TextBoxTab1Input_TextChanged(object? sender, EventArgs e)
        {
            string input = textBoxTab1Input.Text;
            string output = Uri.EscapeDataString(input);
            textBoxTab1Output.Text = output;
            if (checkBoxTab1AutoCopy.Checked)
            {
                textBoxTab1DecInput.Text = output;
            }
        }
    }
}
