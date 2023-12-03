using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overseas
{
    public partial class Overseas : Form
    {
        public Overseas()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            panelMenu.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void gradientpanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customButton1_MouseEnter(object sender, EventArgs e)
        {
            ViewAccountButton.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void customButton1_MouseHover(object sender, EventArgs e)
        {
            ViewAccountButton.BackColor = Color.FromArgb(100, 0,0,0);
        }

        private void customButton1_MouseLeave(object sender, EventArgs e)
        {
            ViewAccountButton.BackColor = Color.Transparent;
        }


        private void WithdrawButton_MouseEnter(object sender, EventArgs e)
        {
            WithdrawButton.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void WithdrawButton_MouseHover(object sender, EventArgs e)
        {
            WithdrawButton.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void WithdrawButton_MouseLeave(object sender, EventArgs e)
        {
            WithdrawButton.BackColor = Color.Transparent;
        }

        private void DepositButton_MouseEnter_1(object sender, EventArgs e)
        {
            DepositButton.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void DepositButton_MouseHover_1(object sender, EventArgs e)
        {
            DepositButton.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void DepositButton_MouseLeave_1(object sender, EventArgs e)
        {
            DepositButton.BackColor = Color.Transparent;
        }

        private void HistoryButton_MouseEnter_1(object sender, EventArgs e)
        {
            HistoryButton.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void HistoryButton_MouseHover_1(object sender, EventArgs e)
        {
            HistoryButton.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void HistoryButton_MouseLeave_1(object sender, EventArgs e)
        {
            HistoryButton.BackColor = Color.Transparent;
        }

        private void CreateAccountButton_MouseEnter_1(object sender, EventArgs e)
        {
            CreateAccountButton.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void CreateAccountButton_MouseHover(object sender, EventArgs e)
        {
            CreateAccountButton.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void CreateAccountButton_MouseLeave_1(object sender, EventArgs e)
        {
            CreateAccountButton.BackColor = Color.Transparent;
        }

        private void RemoveAccountButton_MouseEnter_1(object sender, EventArgs e)
        {
            RemoveAccountButton.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void RemoveAccountButton_MouseHover_1(object sender, EventArgs e)
        {
            RemoveAccountButton.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void RemoveAccountButton_MouseLeave_1(object sender, EventArgs e)
        {
            RemoveAccountButton.BackColor = Color.Transparent;
        }

        private void UpdateAccountButton_MouseEnter_1(object sender, EventArgs e)
        {
            UpdateAccountButton.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void UpdateAccountButton_MouseHover_1(object sender, EventArgs e)
        {
            UpdateAccountButton.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void UpdateAccountButton_MouseLeave_1(object sender, EventArgs e)
        {
            UpdateAccountButton.BackColor = Color.Transparent;
        }
    }
}
