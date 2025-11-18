using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IntegratedProjectManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace IntegratedProjectManagementSystem.Projects
{
    public partial class FormClickProject : Form
    {
        private int _projectId;
        private ProjectService _projectService;

        public FormClickProject(int projectId)
        {
            InitializeComponent();
            _projectId = projectId;
            _projectService = new ProjectService();
            LoadProjectDetails();
        }

        private void LoadProjectDetails()
        {
            try
            {
                var project = _projectService.GetProjectById(_projectId);
                if (project != null)
                {
                    // Display project details in your form controls
                    this.Text = $"Project: {project.ProjectName} - ID: {project.ProjectId}";

                    // Example: Display in labels or other controls
                    lblProjectName.Text = project.ProjectName;
                    lblClientName.Text = project.ClientName;
                    lblStatus.Text = project.Status;
                    // ... populate other controls as needed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading project details: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            try
            {
                // Open FormCreateProject in edit mode
                FormCreateProject editForm = new FormCreateProject(_projectId);
                editForm.ShowDialog();

                // Refresh project details after editing
                if (editForm.DialogResult == DialogResult.OK)
                {
                    LoadProjectDetails();
                    // Optional: Refresh parent form if needed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening edit form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}