using System.Diagnostics;
using TouchInputSimulator;
using TouchInputSimulator.Native;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        InputSimulator inputSimulator = new InputSimulator();
        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_A);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_B);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_C);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            inputSimulator.Keyboard.TextEntry("Hello!");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
        }

      
        private async void label2_Click(object sender, EventArgs e)
        {
            await inputSimulator.Mouse.LeftButtonDoubleClickAsync();
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Ë«»÷666");
        }
    }
}