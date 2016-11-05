using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Splash_Page : Form {
        public Splash_Page() {
            InitializeComponent();
        }
        /// <summary>
        /// button to go open new defenisve form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            Form DualTypeCalcDef = new DualTypeCalculatorcsDef();
            DualTypeCalcDef.Show();
        }

        /// <summary>
        /// button to go open new offensive form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) {
            Form DualTypeCalcOff = new DualTypeCalculatorOff();
            DualTypeCalcOff.Show();
        }

        #region annoying things i clicked on and now cant get rid of
        private void Form1_Load(object sender, EventArgs e) {

        }
        private void groupBox1_Enter(object sender, EventArgs e) {

        }
        #endregion

        private void aboutLabel_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/MichaelW97/Pokemon_Type_Calculator/wiki");
        }

        private void contributeLabel_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/MichaelW97/Pokemon_Type_Calculator");
        }
    }
}
