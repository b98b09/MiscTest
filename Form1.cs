using MiscTest.CustomControls;
using System.Diagnostics;

namespace MiscTest
{
    public partial class Form1 : Form
    {
        private RadioGroupBox radioGroupBox;

        public Form1()
        {
            InitializeComponent();

            radioGroupBox = new();

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
            radioGroupBox.Text = "RadioGroup";
            radioGroupBox.AddItem("Option 1");
            radioGroupBox.AddItem("Option ffffffffffffffffffff2");
            radioGroupBox.AddItem("Option 3wfwfwe");
            radioGroupBox.AddItem("Option 4");
            radioGroupBox.AddItem("Option 5");
            radioGroupBox.CheckedChanged += (sender, e) =>
            {
                if (sender is RadioButton rb)
                {
                    Debug.WriteLine($"Selected: {rb.Tag}, Checked: {rb.Checked}");
                }
            };
            tabPage2.Controls.Add(radioGroupBox);

            checkGroupBox1.Text = "CheckGroup";
            checkGroupBox1.ToAutoSize(true);
            checkGroupBox1.AddItem("Check 1");
            checkGroupBox1.AddItem("Check 2");
            checkGroupBox1.AddItem("Check 3");
            checkGroupBox1.CheckedChanged += (sender, e) =>
            {
                if (sender is CheckBox cb)
                {
                    Debug.WriteLine($"Checked: {cb.Tag}, Checked: {cb.Checked}");
                }
            };
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

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"Tag: {radioGroupBox.CheckedTag}");
            Debug.WriteLine($"Index: {radioGroupBox.CheckedIndex}");
            Debug.WriteLine($"Radio: {radioGroupBox.CheckedItem}");
            Debug.WriteLine($"Text: {radioGroupBox.CheckedItem?.Text}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioGroupBox.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            radioGroupBox.SelectNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            radioGroupBox.SelectPrevious();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            checkGroupBox1.AddItem($"Check {checkGroupBox1.ItemCount + 1}");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            switch (checkGroupBox1.FlowDirection)
            {
                case FlowDirection.TopDown:
                    checkGroupBox1.FlowDirection = FlowDirection.LeftToRight;
                    break;
                case FlowDirection.LeftToRight:
                    checkGroupBox1.FlowDirection = FlowDirection.TopDown;
                    break;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            checkGroupBox1.CheckAll();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            checkGroupBox1.UncheckAll();
        }
    }
}
