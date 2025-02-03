using FirstProgram1.Data;
using FirstProgram1.Properties;
using InfastructureLayer.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;
using Unity.Injection;

namespace FirstProgram1
{
    public partial class Form1 : MaterialForm
    {
        private int index;
        private BindingSource bindingSource;
        public readonly IProgramRepository dbContext;
        public bool isEdit = false;
        public DomainLayer.Models.Program ProgramEntity;
        public Form1(IProgramRepository dbContext)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.dbContext = dbContext;
            bindingSource = new BindingSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getPrograms();
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
