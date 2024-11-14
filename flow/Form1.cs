namespace flow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Button d = new()
                {
                    Name = "eg" + i + "_btn",
                    Text = i.ToString()
                };
                flowLayoutPanel1.Controls.Add(d);
            }
        }
    }
}
