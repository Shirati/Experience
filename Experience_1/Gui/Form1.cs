using BLL;

namespace Gui
{
    public partial class Form1 : Form
    {
        CitiesBLL CitiesBLL=new CitiesBLL();
        int  citiDTO,index=0;

        public Form1()
        {
            InitializeComponent();
            lstCities.DisplayMember = "CityName";
           // btUpdate.Enabled = false;
        }

        private void order_Click(object sender, EventArgs e)
        {
            lstCities.DataSource = CitiesBLL.OrderBy();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            CitiesBLL.Add(txtAdd.Text);
            lstCities.DataSource = CitiesBLL.GetAll();
            txtAdd.Clear();
        }

        private void lstCities_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (lstCities.SelectedIndex >0)
            //{
            //    txtAdd.Text = lstCities.SelectedIndex.ToString();
            
            //   btUpdate.Enabled = true;
            //    citiDTO = (lstCities.SelectedItem as CityDTO).CityId;
                

               
            //}

            //else
            //    btUpdate.Enabled = false;

        }
        
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btorderdesc_Click(object sender, EventArgs e)
        {
            lstCities.DataSource = CitiesBLL.OrderByDesc();
        }

        private void btTop5_Click(object sender, EventArgs e)
        {
            lstCities.DataSource = CitiesBLL.GetTop5Cities();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            CitiesBLL.Update(txtpre.Text,txtafter.Text);
            lstCities.DataSource = CitiesBLL.GetAll();
            txtpre.Clear();
            txtafter.Clear();   
          

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstCities.DataSource = CitiesBLL.GetCitiesByPartialName(txtAdd.Text);
           // txtAdd.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("בטוח שרצונך למחוק");
            CitiesBLL.Delete(txtAdd.Text);
            lstCities.DataSource = CitiesBLL.GetAll();
           // txtAdd.Clear();
        }

        private void btRev_Click(object sender, EventArgs e)
        {
            lstCities.DataSource = CitiesBLL.GetCitiesInPage(index, 3);
            index--;
            if (index < 0)
                index = 0;
        }

        private void bthibrish_Click(object sender, EventArgs e)
        {
            lstCities.DataSource = CitiesBLL.SelectByName_hibrish(txtAdd.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            lstCities.DataSource = CitiesBLL.GetCitiesInPage(index,3);
            index ++;
        }
    }
}