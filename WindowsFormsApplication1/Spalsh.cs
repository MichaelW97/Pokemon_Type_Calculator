using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using TypingLibrary;
using Typess;

namespace WindowsFormsApplication1 {
    public partial class Splash_Page : Form {
        public Splash_Page() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Form DualTypeCalcDef = new DualTypeCalculatorcsDef();
            DualTypeCalcDef.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            Form DualTypeCalcOff = new DualTypeCalculatorOff();
            DualTypeCalcOff.Show();
        }
    }
}
