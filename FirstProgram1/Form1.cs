using Inventory.Data;
using Inventory.Properties;
using InfastructureLayer.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;
using Unity.Injection;
using inventory;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource;
        public readonly IProgramRepository dbContext;
        public bool isEdit = false;
        public DomainLayer.Models.Program ProgramEntity;
        private bool isDragging = false;
        private SidebarManager sidebarManager;
        public Form1(IProgramRepository dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            bindingSource = new BindingSource();
            sidebarManager = new SidebarManager(sidebarPanel, tabControl1);
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getPrograms();
            sidebarManager.ToggleSidebar();
            sidebarManager.ToggleSidebar();

            sidebarPanel.Refresh();
            sidebarPanel.Invalidate();
            sidebarPanel.Update();

            guna2Panel1.Refresh();
            guna2Panel1.Invalidate();
            guna2Panel1.Update();

            guna2Panel1.BringToFront();
            sidebarPanel.BringToFront();

            sidebarManager.ApplyTagColors();
            sidebarManager.UpdateSidebarUI();
        }

        public void getPrograms()
        {
            var programs = dbContext.GetAll();
            bindingSource.DataSource = programs;
            dataGridView1.DataSource = bindingSource;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            isEdit = false;
            var form2 = new Form2(dbContext);
            form2.Form1 = this;
            form2.textBoxProgramDepartment.Text = "";
            form2.textBoxProgramDescription.Text = "";
            form2.textBoxProgramName.Text = "";
            form2.message = "Program added successfully.";
            form2.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProgramEntity = (DomainLayer.Models.Program)bindingSource.Current;
            isEdit = true;
            var form2 = new Form2(dbContext);
            form2.Form1 = this;
            form2.Text = "Edit Program Information";
            form2.message = "Program updated successfully.";
            form2.ShowDialog();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            ProgramEntity = (DomainLayer.Models.Program)bindingSource.Current;

            dbContext.Remove(ProgramEntity);
            dbContext.Save();

            MessageBox.Show("Program deleted successfully.");

            getPrograms();
        }

        private void materialMultiLineTextBox21_TextChanged(object sender, EventArgs e)
        {
            dbContext.GetAll(c => c.ProgramName == materialMultiLineTextBox21.Text.Trim());
        }


        //private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}

        //private void openToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Settings.Default.Name = "Jay Al Gallenero";
        //    Settings.Default.Program = "MSCpE";
        //    Settings.Default.Save();

        //    var form2 = new Form2();
        //    form2.Text = "OK";
        //    form2.ShowDialog();
        //}
    }
}
