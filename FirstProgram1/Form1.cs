using FirstProgram1.Data;
using FirstProgram1.Properties;
using InfastructureLayer.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FirstProgram1
{
    public partial class Form1 : MaterialForm
    {
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getPrograms();
        }

        public void getPrograms()
        {
            var programs = dbContext.GetAll();
            dataGridView1.DataSource = programs;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2(dbContext);
            form2.Form1 = this;
            form2.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridView1.DataSource;
            ProgramEntity = (DomainLayer.Models.Program)bindingSource.Current;
            isEdit = true;
            var form2 = new Form2(dbContext);
            form2.Form1 = this;
            form2.ShowDialog();
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
