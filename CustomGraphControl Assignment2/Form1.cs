namespace CustomGraphControl_Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pieChartControl1 = new PieChartControl
            {
                Location = new Point(20, 100),
                Size = new Size(300, 300)
            };

            this.Controls.Add(pieChartControl1);
        }

       
        private void buttonAddData_Click(object sender, EventArgs e)
        {
            try
            {
                // split the input text by commas, parse each part as a float, and store in a list
                var input = textBoxInput.Text.Split(',');
                var numbers = input.Select(float.Parse).ToList();

                // set the parsed data to the PieChartControl's Data property
                pieChartControl1.Data = numbers;

                //refresh the PieChartControl to redraw with the new data
                pieChartControl1.Invalidate();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid list of numbers seperated by comma.");
            }
        }
    }
}
