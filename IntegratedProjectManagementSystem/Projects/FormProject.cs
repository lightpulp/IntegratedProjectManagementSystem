using IntegratedProjectManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegratedProjectManagementSystem.Projects
{
    public partial class FormProject : Form
    {

        private ProjectService projectService;


        public FormProject()
        {
            InitializeComponent();
            projectService = new ProjectService();
            LoadProjects();
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            FormCreateProject newForm = new FormCreateProject();
            newForm.Show();
            this.Hide();
        }

        private void LoadProjects()
        {
            // Clear existing controls (except maybe some headers)
            pnlProjects.Controls.Clear();

            try
            {
                var projects = projectService.GetAllProjects();

                if (projects.Count == 0)
                {
                    // Show message if no projects
                    Label noProjectsLabel = new Label
                    {
                        Text = "No projects found. Create your first project!",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10),
                        ForeColor = Color.Gray,
                        Location = new Point(20, 20)
                    };
                    pnlProjects.Controls.Add(noProjectsLabel);
                    return;
                }

                int yPosition = 10;

                foreach (var project in projects)
                {
                    // Create project panel
                    Panel projectPanel = CreateProjectPanel(project, yPosition);
                    pnlProjects.Controls.Add(projectPanel);

                    yPosition += 120; // Space between project panels
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading projects: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CreateProjectPanel(ProjectService.Project project, int yPosition)
        {
            Panel panel = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(pnlProjects.Width - 30, 100),
                Location = new Point(10, yPosition),
                Tag = project.ProjectId, // Store project ID for click event
                Cursor = Cursors.Hand
            };

            // Project Name
            Label lblName = new Label
            {
                Text = project.ProjectName,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10)
            };

            // Client Name
            Label lblClient = new Label
            {
                Text = $"Client: {project.ClientName}",
                Font = new Font("Segoe UI", 9),
                AutoSize = true,
                Location = new Point(10, 35)
            };

            // Description (truncated if too long)
            string description = string.IsNullOrEmpty(project.ProjectDescription) ?
                "No description" :
                (project.ProjectDescription.Length > 50 ?
                 project.ProjectDescription.Substring(0, 50) + "..." :
                 project.ProjectDescription);

            Label lblDesc = new Label
            {
                Text = description,
                Font = new Font("Segoe UI", 9),
                AutoSize = false,
                Size = new Size(panel.Width - 120, 30),
                Location = new Point(10, 55)
            };

            // Status
            Label lblStatus = new Label
            {
                Text = $"Status: {project.Status}",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(panel.Width - 150, 10),
                ForeColor = GetStatusColor(project.Status)
            };

            // Deadline
            Label lblDeadline = new Label
            {
                Text = $"Deadline: {project.Deadline:MMM dd, yyyy}",
                Font = new Font("Segoe UI", 8),
                AutoSize = true,
                Location = new Point(panel.Width - 150, 30)
            };

            // Total Price
            Label lblPrice = new Label
            {
                Text = $"Total: ₱{project.TotalPrice:N2}",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(panel.Width - 150, 50)
            };

            // Add controls to panel
            panel.Controls.Add(lblName);
            panel.Controls.Add(lblClient);
            panel.Controls.Add(lblDesc);
            panel.Controls.Add(lblStatus);
            panel.Controls.Add(lblDeadline);
            panel.Controls.Add(lblPrice);

            // Add click event
            panel.Click += (sender, e) => OpenProjectDetails(project.ProjectId);

            // Make all labels clickable too
            foreach (Control control in panel.Controls)
            {
                control.Click += (sender, e) => OpenProjectDetails(project.ProjectId);
                control.Cursor = Cursors.Hand;
            }

            return panel;
        }
        private Color GetStatusColor(string status)
        {
            switch (status?.ToLower())
            {
                case "completed": return Color.Green;
                case "in workshop": return Color.Blue;
                case "quote sent": return Color.Orange;
                case "ready for delivery": return Color.Purple;
                default: return Color.Black;
            }
        }

        private void OpenProjectDetails(int projectId)
        {
            try
            {
                FormClickProject projectDetailsForm = new FormClickProject(projectId);
                projectDetailsForm.ShowDialog(); // Or Show() if you want non-modal

                // Optional: Refresh projects after closing details form
                LoadProjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening project: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
