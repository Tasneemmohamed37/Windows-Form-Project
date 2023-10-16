using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Tables;
using Syncfusion.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VersionOfProject.Entity;
using VersionOfProject.VeiwModel;

namespace VersionOfProject
{
    public partial class Form2 : Form
    {
        WFContext con;
        List<int> CompoDays;
        List<int> CompoMonthes;
        AdminDashbordForm adminForm;
        Login loginForm;
        public Form2()
        {
            InitializeComponent();
            adminForm = new AdminDashbordForm();
            con = new WFContext();
            CompoDays = new List<int>();
            CompoMonthes = new List<int>();
            var Key = con.orders.Select(o => o.OrderDate.Date.Month).Distinct().ToList();

            foreach (var k in Key)
            {
                CompoMonthes.Add(k);
            }

            CB_month.DataSource = new BindingSource(CompoMonthes.Distinct().ToList(), null);// new BindingSource(CompoMonthes, null);
            CB_month.DisplayMember = "Key";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminDashbordForm admin = new AdminDashbordForm();
            admin.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void Charts_Load(object sender, EventArgs e)
        {

            LabelForNumberOfOrderToday.Text = "";
            LabelForNumberOfOrderToday.Text = con.orders.Where(o => o.OrderDate.Day == DateTime.Now.Day).ToList().Count.ToString();
            LabLForNumberOForders.Text = "";
            LabLForNumberOForders.Text = con.orders.Where(o => o.OrderDate.Month == DateTime.Now.Month).ToList().Count.ToString();
            LabelForEmployCount.Text = "";
            LabelForEmployCount.Text = con.Employies.ToList().Count.ToString();
            LabelForFoodCount.Text = "";
            LabelForFoodCount.Text = con.Foods.ToList().Count().ToString();
            labelfordrinks.Text = " ";
            labelfordrinks.Text = con.Drinks.ToList().Count.ToString();
            LabelForFoodCategory.Text = "";
            LabelForFoodCategory.Text = con.FoodCategories.ToList().Count.ToString();
            LabelForDrinkCategory.Text = "";
            LabelForDrinkCategory.Text = con.DrinkCategories.ToList().Count.ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DG_Orders_pdf.DataSource = null;
            int day = int.Parse(CB_day.SelectedValue.ToString());
            int Month = int.Parse(CB_month.SelectedValue.ToString());

            var data = con.orders.Where(o => o.OrderDate.Date.Day == day && o.OrderDate.Date.Month == Month).Select(o => new OrderViewModel
            {
                OrderDate = o.OrderDate,
                CountItems = o.OrderItems.Count,
                Price = o.TotalCost
            }).ToList();

            DG_Orders_pdf.DataSource = data;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CB_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_day.DataSource = null;
            CompoDays.Clear();
            int SelectedMonth = int.Parse(CB_month.SelectedValue.ToString());
            var DaysOfMonth = con.orders.Where(o => o.OrderDate.Date.Month == SelectedMonth).Distinct().ToList();
            foreach (var k in DaysOfMonth)
            {
                CompoDays.Add(k.OrderDate.Date.Day);
            }

            CB_day.DataSource = new BindingSource(CompoDays.Distinct().ToList(), null);
            CB_day.DisplayMember = "Key";

        }

        private void btn_print_Click(object sender, EventArgs e)
        {

            int day = int.Parse(CB_day.SelectedValue.ToString());
            int Month = int.Parse(CB_month.SelectedValue.ToString());
            var dataOrder = con.orders.Include("OrderItems").Where(o => o.OrderDate.Date.Month == Month && o.OrderDate.Date.Day == day).ToList();

            using (PdfDocument document = new PdfDocument())
            {
                // Add a page to the document.
                PdfPage page = document.Pages.Add();

                // Create PDF graphics for a page.
                PdfGraphics graphics = page.Graphics;

                // Set the standard font.
                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);

                var sum = dataOrder.Sum(o => o.TotalCost);
                foreach (var item in dataOrder)
                {

                    page = document.Pages.Add();
                    // Create a data table with your static data.
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Name");
                    dataTable.Columns.Add("Amount");
                    dataTable.Columns.Add("Price");


                    // Add data rows to the table. 
                    foreach (var orderItem in item.OrderItems)
                    {
                        dataTable.Rows.Add(orderItem.Name, orderItem.Amount, orderItem.Cost);

                    }



                    string introText = $"Order Date: {item.OrderDate}";
                    graphics.DrawString(introText, font, PdfBrushes.Black, new PointF(50, 50));

                    string introText_2 = $"total Cost = {sum} ".ToUpper();
                    graphics.DrawString(introText_2, font, PdfBrushes.Black, new PointF(50, 100));

                    // Create a PDF table to display the data.
                    PdfLightTable pdfTable = new PdfLightTable();
                    pdfTable.DataSource = dataTable;
                    pdfTable.Style.ShowHeader = true;

                    // Set the font for the table cells.
                    pdfTable.Style.DefaultStyle.Font = font;

                    // Set the position of the table below the string.
                    PointF tableLocation = new PointF(50, 150);



                    // Draw the table on the page.
                    pdfTable.Draw(page, tableLocation);

                }

                // Save the document.
                document.Save($"{day}{Month}.pdf");
                MessageBox.Show("PDF created successfully");
                string fullPath = Path.GetFullPath($"{day}{Month}.pdf");
                MessageBox.Show("PDF file saved to: " + fullPath);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();

            adminForm.ShowDialog();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm.ShowDialog();

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
