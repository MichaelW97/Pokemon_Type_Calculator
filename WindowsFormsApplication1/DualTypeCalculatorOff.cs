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
    public partial class DualTypeCalculatorOff : Form {

        /// <summary>
        /// assings values to labels as need be.
        /// no need to calculate dual typing as they are displayed diferently
        /// </summary>
        public void displayTypeOutcome() {
            double[] combotype = Typess.TypeFunctions.DualTypeOff(Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off"), Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off"));
            #region assigning values to text boxes
            label19.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[0].ToString();
            label20.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[1].ToString();
            label21.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[2].ToString();
            label22.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[3].ToString();
            label23.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[4].ToString();
            label24.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[5].ToString();
            label25.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[6].ToString();
            label26.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[7].ToString();
            label27.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[8].ToString();
            label28.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[9].ToString();
            label29.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[10].ToString();
            label30.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[11].ToString();
            label31.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[12].ToString();
            label32.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[13].ToString();
            label33.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[14].ToString();
            label34.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[15].ToString();
            label35.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[16].ToString();
            label36.Text = Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off")[17].ToString();

            label41.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[0].ToString();
            label42.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[1].ToString();
            label43.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[2].ToString();
            label44.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[3].ToString();
            label45.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[4].ToString();
            label46.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[5].ToString();
            label47.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[6].ToString();
            label48.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[7].ToString();
            label49.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[8].ToString();
            label50.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[9].ToString();
            label51.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[10].ToString();
            label52.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[11].ToString();
            label53.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[12].ToString();
            label54.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[13].ToString();
            label55.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[14].ToString();
            label56.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[15].ToString();
            label57.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[16].ToString();
            label58.Text = Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")[17].ToString();
            label61.Text = combotype[0].ToString();
            label62.Text = combotype[1].ToString();
            label63.Text = combotype[2].ToString();
            label64.Text = combotype[3].ToString();
            label65.Text = combotype[4].ToString();
            label66.Text = combotype[5].ToString();
            label67.Text = combotype[6].ToString();
            label68.Text = combotype[7].ToString();
            label69.Text = combotype[8].ToString();
            label70.Text = combotype[9].ToString();
            label71.Text = combotype[10].ToString();
            label72.Text = combotype[11].ToString();
            label73.Text = combotype[12].ToString();
            label74.Text = combotype[13].ToString();
            label75.Text = combotype[14].ToString();
            label76.Text = combotype[15].ToString();
            label77.Text = combotype[16].ToString();
            label78.Text = combotype[17].ToString();
            #endregion
        }

        /// <summary>
        /// gives the two combo boxes values and the labels names
        /// </summary>
        public DualTypeCalculatorOff() {
            InitializeComponent();
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

        /// <summary>
        /// calls method for disaplying outcome then assigns score value.
        /// makes all the labels visible after to make it look nicer when changing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cakcButton_Click(object sender, EventArgs e) {
            displayTypeOutcome();
            label38.Text = Typess.TypeFunctions.DualTypeScoreOff(Typess.TypeFunctions.StringToType(typeOneComboBox.SelectedIndex, "off"), Typess.TypeFunctions.StringToType(typeTwoComboBox.SelectedIndex, "off")).ToString();
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
            label41.Visible = true;
            label42.Visible = true;
            label43.Visible = true;
            label44.Visible = true;
            label45.Visible = true;
            label46.Visible = true;
            label47.Visible = true;
            label48.Visible = true;
            label49.Visible = true;
            label50.Visible = true;
            label51.Visible = true;
            label52.Visible = true;
            label53.Visible = true;
            label54.Visible = true;
            label55.Visible = true;
            label56.Visible = true;
            label57.Visible = true;
            label58.Visible = true;
            label61.Visible = true;
            label62.Visible = true;
            label63.Visible = true;
            label64.Visible = true;
            label65.Visible = true;
            label66.Visible = true;
            label67.Visible = true;
            label68.Visible = true;
            label69.Visible = true;
            label70.Visible = true;
            label71.Visible = true;
            label72.Visible = true;
            label73.Visible = true;
            label74.Visible = true;
            label75.Visible = true;
            label76.Visible = true;
            label77.Visible = true;
            label78.Visible = true;
            label58.Visible = true;
            #endregion
        }

        #region annoying things i clicked on and now cant get rid of
        private void label38_Click(object sender, EventArgs e) {

        }
        private void typeTwoComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void typeOneComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void DualTypeCalculatorOff_Load(object sender, EventArgs e) {

        }
        private void label39_Click(object sender, EventArgs e) {

        }
        #endregion

        private void label79_Click(object sender, EventArgs e) {

        }
    }
}
