using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingLibrary;

namespace WindowsFormsApplication1 {
    public partial class DualTypeCalculatorcs : Form {

        public static double[] calculateTypings(string itypeOneComboBox, string  itypeTwoComboBox ) {
            Typing.typeChart = new double[17,17];
            Typing.SetAllTypes();

            //return Typing.DualType(ntypeOneComboBox, ntypeTwoComboBox);
            return new double[] {1};
        }



        public DualTypeCalculatorcs() {
            InitializeComponent();
            //enbles valus for combo boxes
            typeOneComboBox.DataSource = Enum.GetValues(typeof(Typing.Types));
            typeTwoComboBox.DataSource = Enum.GetValues(typeof(Typing.Types));
            #region assigning vlaues for table labels
            label1.Text = Typing.Types.Normal.ToString();
            label2.Text = Typing.Types.Fire.ToString();
            label3.Text = Typing.Types.Water.ToString();
            label4.Text = Typing.Types.Electic.ToString();
            label5.Text = Typing.Types.Grass.ToString();
            label6.Text = Typing.Types.Ice.ToString();
            label7.Text = Typing.Types.Fighting.ToString();
            label8.Text = Typing.Types.Poison.ToString();
            label9.Text = Typing.Types.Ground.ToString();
            label10.Text = Typing.Types.Flying.ToString();
            label11.Text = Typing.Types.Pyschic.ToString();
            label12.Text = Typing.Types.Bug.ToString();
            label13.Text = Typing.Types.Rock.ToString();
            label14.Text = Typing.Types.Ghost.ToString();
            label15.Text = Typing.Types.Dragon.ToString();
            label16.Text = Typing.Types.Dark.ToString();
            label17.Text = Typing.Types.Steel.ToString();
            label18.Text = Typing.Types.Fairy.ToString();
            #endregion
        }

       
        private void cakcButton_Click(object sender, EventArgs e) {
            calculateTypings(typeOneComboBox.SelectedText, typeTwoComboBox.SelectedText);
        }

        private void typeTwoComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void typeOneComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
