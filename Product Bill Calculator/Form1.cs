using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Bill_Calculator
{
    public partial class Form1 : Form
    {
        private int count = 2482;
        private int count1 = 0;
        int i;
        int sum = 0;
        int gst;
        int total1;
        
        public Form1()
        {
            InitializeComponent();
            PName_Text.Visible = false;
            NAmount.Visible = false;
            GST.Visible = false;
            TAmount.Visible = false;
            Pprice.Text = "0";
        }

        private void PType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PType.Text == "Stationary Items")
            {
                PName.Items.Clear();
                PName.Items.Insert(0, "Pen");
                PName.Items.Insert(1, "Paper");
                PName.Items.Insert(2, "Pencil");
                PName.Items.Insert(3, "Ink");
                PName.Items.Insert(4, "Pad");
                PName.Items.Insert(5, "Scale");
                PName.Items.Insert(6, "Notebooks");
                PName.Items.Insert(7, "Sketch");
                PName.Items.Insert(8, "Boxes and Pouches");
                PName.Items.Insert(9, "Others");
            }
            else if (PType.Text == "Food and Snacks")
            {
                PName.Items.Clear();
                PName.Items.Insert(0, "Tea");
                PName.Items.Insert(1, "Coffee");
                PName.Items.Insert(2, "Cake");
                PName.Items.Insert(3, "Bread");
                PName.Items.Insert(4, "Puffs");
                PName.Items.Insert(5, "Sandwich");
                PName.Items.Insert(6, "Burger");
                PName.Items.Insert(7, "Pizza");
                PName.Items.Insert(8, "Fried Rice");
                PName.Items.Insert(9, "Others");
            }
            else if (PType.Text == "Electronics and Gadgets")
            {
                PName.Items.Clear();
                PName.Items.Insert(0, "Desktops");
                PName.Items.Insert(1, "Laptops");
                PName.Items.Insert(2, "Mobile Phones");
                PName.Items.Insert(3, "Trimmer");
                PName.Items.Insert(4, "TVs");
                PName.Items.Insert(5, "Electrical Gadgets");
                PName.Items.Insert(6, "Smart Watch");                
                PName.Items.Insert(7, "Others");
            }
            else if (PType.Text == "Textiles and Wearables")
            {
                PName.Items.Clear();
                PName.Items.Insert(0, "Shirts");
                PName.Items.Insert(1, "Pants");
                PName.Items.Insert(2, "Chudithars");
                PName.Items.Insert(3, "Night Dresses");
                PName.Items.Insert(4, "Bed Sheet");
                PName.Items.Insert(5, "Towel");
                PName.Items.Insert(6, "Table Cloth");
                PName.Items.Insert(7, "Others");
            }
            else if (PType.Text == "Furnitures")
            {
                PName.Items.Clear();
                PName.Items.Insert(0, "Table");
                PName.Items.Insert(1, "Chair");
                PName.Items.Insert(2, "Desk");
                PName.Items.Insert(3, "Long Desk");
                PName.Items.Insert(4, "Boards");
                PName.Items.Insert(5, "Stools");
                PName.Items.Insert(6, "Mini Furitures");
                PName.Items.Insert(7, "Others");
            }
            else if (PType.Text == "General Items")
            {
                PName.Items.Clear();
                PName.Items.Insert(0, "Others");                
            }
        }       

        private void PName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PName.Text == "Pen")
            {
                PCode.Text = "SI0001";
                Pprice.Text = "100";
            }
            if (PName.Text == "Paper")
            {
                PCode.Text = "SI0002";
                Pprice.Text = "5";
            }
            if (PName.Text == "Pencil")
            {
                PCode.Text = "SI0003";
                Pprice.Text = "10";
            }
            if (PName.Text == "Ink")
            {
                PCode.Text = "SI0004";
                Pprice.Text = "50";
            }
            if (PName.Text == "Pad")
            {
                PCode.Text = "SI0005";
                Pprice.Text = "100";
            }
            if (PName.Text == "Scale")
            {
                PCode.Text = "SI0006";
                Pprice.Text = "20";
            }
            if (PName.Text == "Notebooks")
            {
                PCode.Text = "SI0007";
                Pprice.Text = "30";
            }
            if (PName.Text == "Sketch")
            {
                PCode.Text = "SI0008";
                Pprice.Text = "20";
            }
            if (PName.Text == "Boxes and Pouches")
            {
                PCode.Text = "SI0009";
                Pprice.Text = "100";
            }
            if (PName.Text == "Tea")
            {
                PCode.Text = "FS0001";
                Pprice.Text = "18";
            }
            if (PName.Text == "Coffee")
            {
                PCode.Text = "FS0002";
                Pprice.Text = "20";
            }
            if (PName.Text == "Cake")
            {
                PCode.Text = "FS0003";
                Pprice.Text = "100";
            }
            if (PName.Text == "Bread")
            {
                PCode.Text = "FS0004";
                Pprice.Text = "30";
            }
            if (PName.Text == "Puffs")
            {
                PCode.Text = "FS0005";
                Pprice.Text = "40";
            }
            if (PName.Text == "Sandwich")
            {
                PCode.Text = "FS0006";
                Pprice.Text = "100";
            }
            if (PName.Text == "Burger")
            {
                PCode.Text = "FS0007";
                Pprice.Text = "150";
            }
            if (PName.Text == "Pizza")
            {
                PCode.Text = "FS0008";
                Pprice.Text = "200";
            }
            if (PName.Text == "Fried Rice")
            {
                PCode.Text = "FS0009";
                Pprice.Text = "100";
            }
            if (PName.Text == "Desktops")
            {
                PCode.Text = "EG0001";
                Pprice.Text = "1000000";
            }
            if (PName.Text == "Laptops")
            {
                PCode.Text = "EG0002";
                Pprice.Text = "80000";
            }
            if (PName.Text == "Mobile Phones")
            {
                PCode.Text = "EG0003";
                Pprice.Text = "20000";
            }
            if (PName.Text == "Trimmer")
            {
                PCode.Text = "EG0004";
                Pprice.Text = "5000";
            }
            if (PName.Text == "TVs")
            {
                PCode.Text = "EG0005";
                Pprice.Text = "20000";
            }
            if (PName.Text == "Electrical Gadgets")
            {
                PCode.Text = "EG0006";
                Pprice.Text = "2000";
            }
            if (PName.Text == "Smart Watches")
            {
                PCode.Text = "EG0007";
                Pprice.Text = "1000";
            }
            if (PName.Text == "Shirts")
            {
                PCode.Text = "TW0001";
                Pprice.Text = "400";
            }
            if (PName.Text == "Pants")
            {
                PCode.Text = "TW0002";
                Pprice.Text = "200";
            }
            if (PName.Text == "Chudithars")
            {
                PCode.Text = "TW0003";
                Pprice.Text = "300";
            }
            if (PName.Text == "Night Dresses")
            {
                PCode.Text = "TW0004";
                Pprice.Text = "160";
            }
            if (PName.Text == "Bed Sheet")
            {
                PCode.Text = "TW0005";
                Pprice.Text = "200";
            }
            if (PName.Text == "Towel")
            {
                PCode.Text = "TW0006";
                Pprice.Text = "80";
            }
            if (PName.Text == "Table Cloth")
            {
                PCode.Text = "TW0007";
                Pprice.Text = "120";
            }
            if (PName.Text == "Table")
            {
                PCode.Text = "FU0001";
                Pprice.Text = "400";
            }
            if (PName.Text == "Chair")
            {
                PCode.Text = "FU0002";
                Pprice.Text = "200";
            }
            if (PName.Text == "Desk")
            {
                PCode.Text = "FU0003";
                Pprice.Text = "500";
            }
            if (PName.Text == "Long Desk")
            {
                PCode.Text = "FU0004";
                Pprice.Text = "600";
            }
            if (PName.Text == "Boards")
            {
                PCode.Text = "FU0005";
                Pprice.Text = "150";
            }
            if (PName.Text == "Stools")
            {
                PCode.Text = "FU0006";
                Pprice.Text = "200";
            }
            if (PName.Text == "Mini Furnitures")
            {
                PCode.Text = "FU0007";
                Pprice.Text = "500";
            }            
            else if (PName.Text == "Others")
            {
                PName_Text.Visible = true;
                PCode.Clear();
                Pprice.Clear();
            }
            else
            {
                PName_Text.Visible = false;
            }
        }

        private void Pprice_TextChanged(object sender, EventArgs e)
        {
            if (RC_RBY.Checked == true && RC_RBN.Checked == false)
            {
                double dis = double.Parse(Pprice.Text);
                double count = 0.05 * dis;
                Discount.Text = count.ToString();
                double tax = 0.1 * dis;
                Tax.Text = tax.ToString();
                double fin = dis + (0.1 * dis);
                Fprice.Text = fin.ToString();
            }
             else if (RC_RBY.Checked == true && RC_RBN.Checked == false && IsStudent.Checked==true)
            {
                double dis = double.Parse(Pprice.Text);
                double count = 0.1 * dis;
                Discount.Text = count.ToString();
                double tax = 0.1 * dis;
                Tax.Text = tax.ToString();
                double fin = dis + (0.1 * dis);
                Fprice.Text = fin.ToString();
            }
            else if (RC_RBN.Checked == true && RC_RBY.Checked==false)
            {
                double dis = double.Parse(Pprice.Text);
                Discount.Text = "0";
                double tax = 0.1 * dis;
                Tax.Text = tax.ToString();
                double fin = dis + (0.1 * dis);
                Fprice.Text = fin.ToString();
            }
            else if (RC_RBN.Checked == true && RC_RBY.Checked == false && IsStudent.Checked == true)
            {
                double dis = double.Parse(Pprice.Text);
                double count = 0.05 * dis;
                Discount.Text = count.ToString();
                double tax = 0.1 * dis;
                Tax.Text = tax.ToString();
                double fin = dis + (0.1 * dis);
                Fprice.Text = fin.ToString();
            }
            else
            {
                MessageBox.Show("Something Wents Wrong :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            
            count += 1;
            ID_Generated.Text = count.ToString();
        }

        private void SMan_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }

        private void Pprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }

        private void Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Tax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Fprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PName_Text_Enter(object sender, EventArgs e)
        {
            if(PName_Text.Text== "Enter the Product Name")
            {
                PName_Text.Text = "";
                PName_Text.ForeColor = Color.Black;
            }
        }

        private void PName_Text_Leave(object sender, EventArgs e)
        {
            if (PName_Text.Text == "")
            {
                PName_Text.Text = "Enter the Product Name";
                PName_Text.ForeColor = Color.Silver;
            }
        }
        
        private void Add_Click(object sender, EventArgs e)
        {              
            if(PName.Text=="Others")
            {
                count1 += 1;
                dataGridView1.Rows.Add(count1.ToString(), PName_Text.Text, Pprice.Text, Discount.Text, Tax.Text, Fprice.Text);
                Clear();
            }
            else
            {
                count1 += 1;
                dataGridView1.Rows.Add(count1.ToString(), PName.Text, Pprice.Text, Discount.Text, Tax.Text, Fprice.Text);
                Clear();
            }      
            for (int i=0; i<dataGridView1.Rows.Count;++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            gst = sum * 5 / 100;
            total1 = sum + gst;
            NAmount.Text = "Net Amount: "+ sum.ToString();
            GST.Text = "GST Amount: " + gst.ToString();
            TAmount.Text = "Total Amount: " + total1.ToString(); 
        }
        
        
        public void Clear()
        {
            PName.Text = "-Please Select-";
            PCode.Text = "";
            Pprice.Text = "0";
            PName_Text.Text = "";
            PType.Text = "-Please Select-";
            Discount.Text = "";
            Tax.Text = "";
            Fprice.Text = "";
        }
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            PName.Text = row.Cells[1].Value.ToString();
            Pprice.Text = row.Cells[2].Value.ToString();
            Discount.Text = row.Cells[3].Value.ToString();
            Tax.Text = row.Cells[4].Value.ToString();
            Fprice.Text = row.Cells[5].Value.ToString();
            if(PName.Text== "Pen" || PName.Text == "Paper" || PName.Text == "Pencil" || PName.Text == "Ink" || PName.Text == "Pad" || PName.Text == "Scale" || PName.Text == "Notebooks" || PName.Text == "Sketch" || PName.Text == "Boxes and Pouches")
            {
                PType.Text = "Stationary Items";
            }
            else if (PName.Text == "Tea" || PName.Text == "Coffee" || PName.Text == "Cake" || PName.Text == "Bread" || PName.Text == "Puffs" || PName.Text == "Sandwich" || PName.Text == "Burger" || PName.Text == "Pizza" || PName.Text == "Fried Rice")
            {
                PType.Text = "Food and Snacks";
            }
            else if (PName.Text == "Desktops" || PName.Text == "Laptops" || PName.Text == "Mobile Phones" || PName.Text == "Trimmer" || PName.Text == "TVs" || PName.Text == "Electrical Gadgets" || PName.Text == "Smart Watch")
            {
                PType.Text = "Electronics and Gadgets";
            }
            else if (PName.Text == "Shirts" || PName.Text == "Pants" || PName.Text == "Chudithars" || PName.Text == "Night Dresses" || PName.Text == "Bed Sheet" || PName.Text == "Towel" || PName.Text == "Table Cloth")
            {
                PType.Text = "Textiles and Wearables";
            }
            else if (PName.Text == "Table" || PName.Text == "Chair" || PName.Text == "Desk" || PName.Text == "Long Desk" || PName.Text == "Boards" || PName.Text == "Stools" || PName.Text == "Mini Furitures")
            {
                PType.Text = "Furnitures";
            }
            else if (PName.Text == "Others")
            {
                PType.Text = "General Items";
            }
            if (PName.Text == "Pen")
            {
                PCode.Text = "SI0001";
                Pprice.Text = "100";
            }
            if (PName.Text == "Paper")
            {
                PCode.Text = "SI0002";
                Pprice.Text = "5";
            }
            if (PName.Text == "Pencil")
            {
                PCode.Text = "SI0003";
                Pprice.Text = "10";
            }
            if (PName.Text == "Ink")
            {
                PCode.Text = "SI0004";
                Pprice.Text = "50";
            }
            if (PName.Text == "Pad")
            {
                PCode.Text = "SI0005";
                Pprice.Text = "100";
            }
            if (PName.Text == "Scale")
            {
                PCode.Text = "SI0006";
                Pprice.Text = "20";
            }
            if (PName.Text == "Notebooks")
            {
                PCode.Text = "SI0007";
                Pprice.Text = "30";
            }
            if (PName.Text == "Sketch")
            {
                PCode.Text = "SI0008";
                Pprice.Text = "20";
            }
            if (PName.Text == "Boxes and Pouches")
            {
                PCode.Text = "SI0009";
                Pprice.Text = "100";
            }
            if (PName.Text == "Tea")
            {
                PCode.Text = "FS0001";
                Pprice.Text = "18";
            }
            if (PName.Text == "Coffee")
            {
                PCode.Text = "FS0002";
                Pprice.Text = "20";
            }
            if (PName.Text == "Cake")
            {
                PCode.Text = "FS0003";
                Pprice.Text = "100";
            }
            if (PName.Text == "Bread")
            {
                PCode.Text = "FS0004";
                Pprice.Text = "30";
            }
            if (PName.Text == "Puffs")
            {
                PCode.Text = "FS0005";
                Pprice.Text = "40";
            }
            if (PName.Text == "Sandwich")
            {
                PCode.Text = "FS0006";
                Pprice.Text = "100";
            }
            if (PName.Text == "Burger")
            {
                PCode.Text = "FS0007";
                Pprice.Text = "150";
            }
            if (PName.Text == "Pizza")
            {
                PCode.Text = "FS0008";
                Pprice.Text = "200";
            }
            if (PName.Text == "Fried Rice")
            {
                PCode.Text = "FS0009";
                Pprice.Text = "100";
            }
            if (PName.Text == "Desktops")
            {
                PCode.Text = "EG0001";
                Pprice.Text = "1000000";
            }
            if (PName.Text == "Laptops")
            {
                PCode.Text = "EG0002";
                Pprice.Text = "80000";
            }
            if (PName.Text == "Mobile Phones")
            {
                PCode.Text = "EG0003";
                Pprice.Text = "20000";
            }
            if (PName.Text == "Trimmer")
            {
                PCode.Text = "EG0004";
                Pprice.Text = "5000";
            }
            if (PName.Text == "TVs")
            {
                PCode.Text = "EG0005";
                Pprice.Text = "20000";
            }
            if (PName.Text == "Electrical Gadgets")
            {
                PCode.Text = "EG0006";
                Pprice.Text = "2000";
            }
            if (PName.Text == "Smart Watches")
            {
                PCode.Text = "EG0007";
                Pprice.Text = "1000";
            }
            if (PName.Text == "Shirts")
            {
                PCode.Text = "TW0001";
                Pprice.Text = "400";
            }
            if (PName.Text == "Pants")
            {
                PCode.Text = "TW0002";
                Pprice.Text = "200";
            }
            if (PName.Text == "Chudithars")
            {
                PCode.Text = "TW0003";
                Pprice.Text = "300";
            }
            if (PName.Text == "Night Dresses")
            {
                PCode.Text = "TW0004";
                Pprice.Text = "160";
            }
            if (PName.Text == "Bed Sheet")
            {
                PCode.Text = "TW0005";
                Pprice.Text = "200";
            }
            if (PName.Text == "Towel")
            {
                PCode.Text = "TW0006";
                Pprice.Text = "80";
            }
            if (PName.Text == "Table Cloth")
            {
                PCode.Text = "TW0007";
                Pprice.Text = "120";
            }
            if (PName.Text == "Table")
            {
                PCode.Text = "FU0001";
                Pprice.Text = "400";
            }
            if (PName.Text == "Chair")
            {
                PCode.Text = "FU0002";
                Pprice.Text = "200";
            }
            if (PName.Text == "Desk")
            {
                PCode.Text = "FU0003";
                Pprice.Text = "500";
            }
            if (PName.Text == "Long Desk")
            {
                PCode.Text = "FU0004";
                Pprice.Text = "600";
            }
            if (PName.Text == "Boards")
            {
                PCode.Text = "FU0005";
                Pprice.Text = "150";
            }
            if (PName.Text == "Stools")
            {
                PCode.Text = "FU0006";
                Pprice.Text = "200";
            }
            if (PName.Text == "Mini Furnitures")
            {
                PCode.Text = "FU0007";
                Pprice.Text = "500";
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            int rowIndex = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow=dataGridView1.Rows[i];
            newDataRow.Cells[1].Value = PName.Text;
            newDataRow.Cells[2].Value = Pprice.Text;
            newDataRow.Cells[3].Value = Discount.Text;
            newDataRow.Cells[4].Value = Tax.Text;
            newDataRow.Cells[5].Value = Fprice.Text;
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "SS Departmental Stores";
            print.SubTitleColor = Color.Blue;
            print.SubTitle = DateTime.Now.ToString("-----------------------------------------------------\n" + "dddd, MMM dd yyyy, hh:mm:ss tt") + "\nCustomer ID: ID " + ID_Generated.Text + "\n" + SMan_ID.Text + "\nCustomer Name: " + CName.Text + "\n-----------------------------------------------------";
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PorportionalColumns = true;
            print.PageNumbers = false;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "-----------------------------------------------------\n" + "Net Amount: " + sum.ToString()  + "\nGST Amount: " + gst.ToString() + "\nTotal Amount: " +total1.ToString() + "\n-----------------------------------------------------\n" + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nDone By Saravana Balaji M & Sathieshwaran V.S";
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGridView1);
        }


        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Product Bill Calculator Is Done By Saravana Balaji M & Sathieshwaran V.S", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void C_Input_Click(object sender, EventArgs e)
        {
            PName.Text = "-Please Select-";
            PCode.Text = "";
            Pprice.Text = "0";
            PName_Text.Text = "";
            PType.Text = "-Please Select-";
            Discount.Text = "";
            Tax.Text = "";
            Fprice.Text = "";
            CName.Text = "";
            SMan_ID.Text = "-Please Select-";
            dataGridView1.Rows.Clear();          
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
