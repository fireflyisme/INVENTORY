using DomainLayer.Models;
using InfastructureLayer.Repositories;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProgram1
{
    public partial class Form2 : MaterialForm
    {
        public readonly IProgramRepository? dbContext;
        internal Form1 Form1;

        public string message { get; internal set; }

        public Form2(IProgramRepository? dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var entity = Form1.ProgramEntity;

            if (Form1.isEdit)
            {
                entity.ProgramName = textBoxProgramName.Text;
                entity.Description = textBoxProgramDescription.Text;
                entity.Department = textBoxProgramDepartment.Text;

                dbContext.Update(entity);
            }
            else
            {
                entity = new DomainLayer.Models.Program
                {
                    ProgramName = textBoxProgramName.Text,
                    Description = textBoxProgramDescription.Text,
                    Department = textBoxProgramDepartment.Text,
                };

                dbContext.Add(entity);
            }
            dbContext.Save();

            MessageBox.Show(message,
                "Adding Program",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Form1.getPrograms();
            Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.isEdit)
            {
                textBoxProgramName.Text = Form1.ProgramEntity.ProgramName;
                textBoxProgramDescription.Text = Form1.ProgramEntity.Description;
                textBoxProgramDepartment.Text = Form1.ProgramEntity.Department;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
