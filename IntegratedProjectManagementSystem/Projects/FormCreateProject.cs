using IntegratedProjectManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace IntegratedProjectManagementSystem.Projects
{
    public partial class FormCreateProject : Form
    {
        private ProjectService _projectService;
        private bool _isEditMode = false;
        private int _editingProjectId = 0;

        public FormCreateProject()
        {
            InitializeComponent();
            _projectService = new ProjectService();
            this.Text = "Create New Project";
            cmbbxProjectStatus.Enabled = false;
        }
        public FormCreateProject(int projectId)
        {
            InitializeComponent();
            _projectService = new ProjectService();
            _editingProjectId = projectId;
            _isEditMode = true;
            this.Text = "Edit Project";
            LoadProjectForEditing();
            cmbbxProjectStatus.Enabled = true;
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtProjectName.Text))
                {
                    MessageBox.Show("Project name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtClientName.Text))
                {
                    MessageBox.Show("Client name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse discount with error handling
                decimal discount = 0;
                if (!string.IsNullOrWhiteSpace(txtDiscount.Text) && !decimal.TryParse(txtDiscount.Text, out discount))
                {
                    MessageBox.Show("Please enter a valid discount amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Set default status for new projects
                string status = _isEditMode ? cmbbxProjectStatus.SelectedItem?.ToString() : "Quote Sent";

                // Create project object
                var project = new ProjectService.Project
                {
                    ProjectName = txtProjectName.Text.Trim(),
                    ProjectDescription = txtProjectDescription.Text.Trim(),
                    ProjectType = cmbbxProjectType.SelectedItem?.ToString(),
                    ClientName = txtClientName.Text.Trim(),
                    ClientContact = txtContact.Text.Trim(),
                    ClientAddress = txtAddress.Text.Trim(),
                    ClientEmail = txtEmail.Text.Trim(),
                    Discount = discount,
                    Deadline = clndrDeadline.SelectionStart,
                    ClientNotes = txtClientNotes.Text.Trim(),
                    Status = status // Add this line
                };

                bool success;

                if (_isEditMode)
                {
                    // Update existing project
                    project.ProjectId = _editingProjectId;
                    success = _projectService.UpdateProject(project);
                }
                else
                {
                    // Create new project
                    success = _projectService.CreateProject(project);

                }

                if (success)
                {
                    string message = _isEditMode ? "Project updated successfully!" : "Project created successfully!";
                    MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    string message = _isEditMode ? "Failed to update project." : "Failed to create project.";
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            // Clear all form fields
            txtProjectName.Clear();
            txtProjectDescription.Clear();
            cmbbxProjectType.SelectedIndex = -1;
            txtDiscount.Clear();
            txtClientName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtClientNotes.Clear();
            clndrDeadline.SetDate(DateTime.Now.AddDays(30)); // Set default to 30 days from now
        }


        /// ON EDITING PROJECT ///
        private void LoadProjectForEditing()
        {
            try
            {
                var project = _projectService.GetProjectById(_editingProjectId);
                if (project != null)
                {
                    // Fill form fields with project data
                    txtProjectName.Text = project.ProjectName;
                    txtProjectDescription.Text = project.ProjectDescription;

                    // Select the project type in combobox
                    if (!string.IsNullOrEmpty(project.ProjectType))
                    {
                        cmbbxProjectType.SelectedItem = project.ProjectType;
                    }

                    // Select the status in combobox
                    if (!string.IsNullOrEmpty(project.Status))
                    {
                        cmbbxProjectStatus.SelectedItem = project.Status;
                    }

                    txtDiscount.Text = project.Discount.ToString("F2");
                    clndrDeadline.SelectionStart = project.Deadline;
                    txtClientName.Text = project.ClientName;
                    txtContact.Text = project.ClientContact;
                    txtAddress.Text = project.ClientAddress;
                    txtEmail.Text = project.ClientEmail;
                    txtClientNotes.Text = project.ClientNotes;

                    // Update button text
                    btnSaveProject.Text = "Update Project";
                }
                else
                {
                    MessageBox.Show("Project not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading project: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (_isEditMode)
            {
                Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}