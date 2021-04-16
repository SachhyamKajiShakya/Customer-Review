    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerReview
{
    public partial class CustomerReview : Form
    {

        public CustomerReview()
        {
            InitializeComponent();
            BindGrid();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Review7 r = new Review7();
            r.ReviewerName = txtReviewerName.Text;
            r.ReviewerEmail = txtReviewerEmail.Text;
            r.ReviewerPhone = txtReviewerPhone.Text;
            r.FoodRating = int.Parse(cmbFoodRating.Text);
            r.ServiceRating = int.Parse(cmbServiceRating.Text);
            r.EnvironmentRating = int.Parse(cmbEnvironmentRating.Text);
            r.Suggestions = txtSuggestions.Text;

            string flag = r.SaveReview(r);
            if (flag == "success")
            {
                ClearForm();
            }
        }

        private void ClearForm()
        {
            txtReviewerName.Text = "";
            txtReviewerEmail.Text = "";
            txtReviewerPhone.Text = "";
            cmbFoodRating.Text = "";
            cmbServiceRating.Text = "";
            cmbEnvironmentRating.Text = "";
            txtSuggestions.Text = "";

           
        }

        private void BindGrid() {
            Review7 obj = new Review7();
            List<Review7> listReview = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listReview);
            gridReview.DataSource = dt;
            BindChart(listReview);
        }
        private void BindChart(List<Review7> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.FoodRating)
                    .Select(c1 => new //creating new dynamic object
                    {
                        FoodRating = c1.First().FoodRating,
                        Count = c1.Count().ToString()
                    }).ToList();
                //select count(l) as Count, Foodrating from Review group by FoodRating;
                DataTable dt = Utility.ConvertToDataTable(result);
                chartReview.DataSource = dt;
                chartReview.Series["Series1"].XValueMember = "FoodRating";
                chartReview.Series["Series1"].YValueMembers = "Count";
            }
        }
    }
}
