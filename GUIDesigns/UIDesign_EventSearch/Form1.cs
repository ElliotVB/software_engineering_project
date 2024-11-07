using System.Data;

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
            GenerateEventsFromDB();
        }

        private void GenerateEventsFromDB()
        {
            //Generates a button for each event within the database
            //Temporarily disabled for now
                //DataSet ds = DBConnectionClass.getInstanceOfDBConnection().getDataSet(Consts.SELECTALL);

            //TEMP - generates 20 "dummy" events
            for (int i = 0; i < 20; i++)
            {
                Button b = new Button();
                b.Name = "Event";
                b.Text = "Example event no. " + (i+1);
                b.Size = new System.Drawing.Size(150, 100);
                b.Cursor = System.Windows.Forms.Cursors.Hand;
                b.Image = UIDesign_EventSearch.Properties.Resources._event;
                b.Tag = i;
                eventFlowLayout.Controls.Add(b);
            }
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

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}

 