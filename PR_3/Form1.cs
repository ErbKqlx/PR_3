using Microsoft.VisualBasic.ApplicationServices;

namespace PR_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var list1 = db.TypesOfProducts.ToList();
                var list2 = db.TypesOfPartners.ToList();
                //TypesOfProducts.Text =;
                foreach (TypesOfProducts type in list1)
                {
                    TypesOfProducts.Text += $"{type.Id}. {type.TypeOfProduct} - {type.TypeCoefficient}\n";
                }

                foreach (TypesOfPartners type in list2)
                {
                    TypesOfPartners.Text += $"{type.Id}. {type.TypeOfPartner}\n";
                }
            }
        }
    }
}
