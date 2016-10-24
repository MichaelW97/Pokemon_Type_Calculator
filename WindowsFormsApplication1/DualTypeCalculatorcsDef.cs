using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Typess;
using TypeList;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1 {
    public partial class DualTypeCalculatorcsDef : Form {
        public void displayTypeOutcome() {
            double[] aVal = Typess.TypeFunctions.DualType(Typess.TypeFunctions.StringToTypeDef(typeOneComboBox.SelectedIndex), Typess.TypeFunctions.StringToTypeDef(typeTwoComboBox.SelectedIndex));
            #region setting label names
            label19.Text = aVal[0].ToString();
            label20.Text = aVal[1].ToString();
            label21.Text = aVal[2].ToString();
            label22.Text = aVal[3].ToString();
            label23.Text = aVal[4].ToString();
            label24.Text = aVal[5].ToString();
            label25.Text = aVal[6].ToString();
            label26.Text = aVal[7].ToString();
            label27.Text = aVal[8].ToString();
            label28.Text = aVal[9].ToString();
            label29.Text = aVal[10].ToString();
            label30.Text = aVal[11].ToString();
            label31.Text = aVal[12].ToString();
            label32.Text = aVal[13].ToString();
            label33.Text = aVal[14].ToString();
            label34.Text = aVal[15].ToString();
            label35.Text = aVal[16].ToString();
            label36.Text = aVal[17].ToString();
            #endregion
        }
        

        public DualTypeCalculatorcsDef() {
            InitializeComponent();
            //enbles valus for combo boxes
            typeOneComboBox.DataSource = Enum.GetValues(typeof(Typess.TypeStats.AllTypes));
            typeTwoComboBox.DataSource = Enum.GetValues(typeof(Typess.TypeStats.AllTypes));
            #region assigning values for table labels
            label1.Text = Typess.TypeStats.AllTypes.NORMAL.ToString();
            label2.Text = Typess.TypeStats.AllTypes.FIRE.ToString();
            label3.Text = Typess.TypeStats.AllTypes.WATER.ToString();
            label4.Text = Typess.TypeStats.AllTypes.ELECTIC.ToString();
            label5.Text = Typess.TypeStats.AllTypes.GRASS.ToString();
            label6.Text = Typess.TypeStats.AllTypes.ICE.ToString();
            label7.Text = Typess.TypeStats.AllTypes.FIGHTING.ToString();
            label8.Text = Typess.TypeStats.AllTypes.POISON.ToString();
            label9.Text = Typess.TypeStats.AllTypes.GROUND.ToString();
            label10.Text = Typess.TypeStats.AllTypes.FLYING.ToString();
            label11.Text = Typess.TypeStats.AllTypes.PSYCHIC.ToString();
            label12.Text = Typess.TypeStats.AllTypes.BUG.ToString();
            label13.Text = Typess.TypeStats.AllTypes.ROCK.ToString();
            label14.Text = Typess.TypeStats.AllTypes.GHOST.ToString();
            label15.Text = Typess.TypeStats.AllTypes.DRAGON.ToString();
            label16.Text = Typess.TypeStats.AllTypes.DARK.ToString();
            label17.Text = Typess.TypeStats.AllTypes.STEEL.ToString();
            label18.Text = Typess.TypeStats.AllTypes.FAIRY.ToString();
            #endregion
        }

       
        private void cakcButton_Click(object sender, EventArgs e) {
            displayTypeOutcome();
            label38.Text = Typess.TypeFunctions.DualTypeScoreDef(Typess.TypeFunctions.StringToTypeDef(typeOneComboBox.SelectedIndex), Typess.TypeFunctions.StringToTypeDef(typeTwoComboBox.SelectedIndex)).ToString();
            #region displaying text labels
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label31.Visible = true;
            label32.Visible = true;
            label33.Visible = true;
            label34.Visible = true;
            label35.Visible = true;
            label36.Visible = true;
            label38.Visible = true;
            #endregion
        }

        private void typeTwoComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void typeOneComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label39_Click(object sender, EventArgs e) {

        }
    }
}
