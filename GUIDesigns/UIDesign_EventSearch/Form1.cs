namespace UIDesign_EventSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonEvents_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Establish connection to db
            //Send query to get all events from db
            //For each event, generate a button within eventFlowLayout
        }

        private void searchBox_Clicked(object sender, EventArgs e)
        {
            //Deletes the default text in the search box the first time it's clicked
            if (searchBox.ForeColor == Color.Gray)
            {
                searchBox.Text = null;
                searchBox.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}

 