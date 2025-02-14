using InfastructureLayer.Repositories;
using inventory;
using System.Runtime.InteropServices;

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
            //getPrograms();
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
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guna2Taskbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                this.Opacity = 0.7;
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void Guna2Taskbar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            this.Opacity = 1.0;
        }

        private void Guna2Taskbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && e.Button != MouseButtons.Left)
            {
                isDragging = false;
                this.Opacity = 1.0;
            }
        }

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private void btnToggle_Click(object sender, EventArgs e)
        {
            sidebarManager.ToggleSidebar();
        }

        /*
        public void getPrograms()
        {
            var programs = dbContext.GetAll();
            bindingSource.DataSource = programs;
            dataGridView1.DataSource = bindingSource;
        }*/

        /*
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProgramEntity = (DomainLayer.Models.Program)bindingSource.Current;
            isEdit = true;
            var form2 = new Form2(dbContext);
            form2.Form1 = this;
            form2.Text = "Edit Program Information";
            form2.Setmessage("Program updated successfully.");
            form2.ShowDialog();
        }*/

        private void materialMultiLineTextBox21_TextChanged(object sender, EventArgs e)
        {
            dbContext.GetAll(c => c.ProgramName == txtSearch.Text.Trim());
        }

        /*
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isEdit = false;
            var form2 = new Form2(dbContext);
            form2.Form1 = this;
            form2.textBoxProgramDepartment.Text = "";
            form2.textBoxProgramDescription.Text = "";
            form2.textBoxProgramName.Text = "";
            form2.Setmessage("Program added successfully.");
            form2.ShowDialog();
        }*/

        /*
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProgramEntity = (DomainLayer.Models.Program)bindingSource.Current;

            dbContext.Remove(ProgramEntity);
            dbContext.Save();

            MessageBox.Show("Program deleted successfully.");

            getPrograms();
        }*/
    }
}
