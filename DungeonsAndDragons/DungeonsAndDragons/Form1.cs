namespace DungeonsAndDragons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void roll_Button_Click(object sender, EventArgs e)
        {
            int dieType = dieTypeSelect.SelectedIndex;
            int numOfDie = (int)numOfDieSelect.Value;

            int numOfSides = 0;

            switch (dieType)
            {
                case 0:
                    numOfSides = 4;
                    break;
                case 1:
                    numOfSides = 6;
                    break;
                case 2:
                    numOfSides = 10;
                    break;
                case 3:
                    numOfSides = 12;
                    break;
                case 4:
                    numOfSides = 20;
                    break;
                default:
                    break;
            }

            Die dice = new Die(numOfSides, numOfDie);

            List<int> dice_list = dice.roll();

            string dice_results = dice.get_results(dice_list);
            string dice_total = dice.get_sum(dice_list).ToString();

            dieCombo_Label.Text = numOfDie.ToString() + "D" + numOfSides.ToString();
            dieTotal_Label.Text = dice_results + " = " + dice_total;
        }
    }
}