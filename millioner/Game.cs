using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace millioner
{
    public partial class Game : Form, IGameView
    {
        public Game()
        {
            InitializeComponent();
        }
        public event EventHandler<EventArgs> NewGame;
        public event EventHandler<EventArgs> Stop;
        public event EventHandler<EventArgs> Exit;

        public event EventHandler<EventArgs> Answer;
        public event EventHandler<EventArgs> Edit;
        public event EventHandler<EventArgs> Delete;
        public event EventHandler<EventArgs> Add;
        public string answ { get; }
        public void MakeVisible()
        {
            button10.Visible = true;
            button9.Visible = true;
            button8.Visible = true;
            button7.Visible = true;
            textBox1.Visible = true;

        }
        public void Fail()
        {

        }
        public void Proceed()
        {

        }
        public void MakeInvisible()
        {
            button10.Visible = false;
            button9.Visible = false;
            button8.Visible = false;
            button7.Visible = false;
            textBox1.Visible = false;
        }

        public void Quit()
        {
            Close();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Exit.Invoke(this, EventArgs.Empty);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            NewGame.Invoke(this, EventArgs.Empty);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stop.Invoke(this, EventArgs.Empty);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit.Invoke(this, EventArgs.Empty);

        }

        private void остановитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop.Invoke(this, EventArgs.Empty);

        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame.Invoke(this, EventArgs.Empty);

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
