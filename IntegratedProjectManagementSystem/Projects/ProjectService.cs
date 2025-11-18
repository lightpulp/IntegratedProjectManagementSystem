using IntegratedProjectManagementSystem.Resources;
using System;
using System.Data;
using System.Data.SqlClient;

namespace IntegratedProjectManagementSystem.Services
{
    public class ProjectService
    {
        public class Project
        {
            public int ProjectId { get; set; }

            public string ProjectName { get; set; }
            public string ProjectDescription { get; set; }
            public string ProjectType { get; set; }
            public string ClientName { get; set; }
            public string ClientContact { get; set; }
            public string ClientAddress { get; set; }
            public string ClientEmail { get; set; }
            public decimal Discount { get; set; }
            public DateTime Deadline { get; set; }
            public string ClientNotes { get; set; }
            public string Status { get; set; }
            public decimal TotalPrice { get; set; }
            public DateTime DateCreated { get; set; }
        }


        //////////////// ON CREATE PROJECT ///////////
        public bool CreateProject(Project project)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                    INSERT INTO Projects 
                    (ProjectName, ProjectDescription, ProjectType, ClientName, ClientContact, 
                     ClientAddress, ClientEmail, Discount, Deadline, ClientNotes, Status, DateCreated)
                    VALUES 
                    (@ProjectName, @ProjectDescription, @ProjectType, @ClientName, @ClientContact,
                     @ClientAddress, @ClientEmail, @Discount, @Deadline, @ClientNotes, 'Quote Sent', GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectName", project.ProjectName);
                        cmd.Parameters.AddWithValue("@ProjectDescription", (object)project.ProjectDescription ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ProjectType", (object)project.ProjectType ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ClientName", project.ClientName);
                        cmd.Parameters.AddWithValue("@ClientContact", (object)project.ClientContact ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ClientAddress", (object)project.ClientAddress ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ClientEmail", (object)project.ClientEmail ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Discount", project.Discount);
                        cmd.Parameters.AddWithValue("@Deadline", project.Deadline);
                        cmd.Parameters.AddWithValue("@ClientNotes", (object)project.ClientNotes ?? DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Rethrow as is so caller can inspect exception details
                throw;
            }
        }

        public List<Project> GetAllProjects()
        {
            var projects = new List<Project>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT ProjectId, ProjectName, ProjectDescription, ProjectType, 
                           ClientName, Status, TotalPrice, Discount, Deadline, DateCreated
                    FROM Projects 
                    ORDER BY DateCreated DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        projects.Add(new Project
                        {
                            ProjectId = reader.GetInt32("ProjectId"),
                            ProjectName = reader.GetString("ProjectName"),
                            ProjectDescription = reader.IsDBNull("ProjectDescription") ? "" : reader.GetString("ProjectDescription"),
                            ProjectType = reader.IsDBNull("ProjectType") ? "" : reader.GetString("ProjectType"),
                            ClientName = reader.GetString("ClientName"),
                            Status = reader.IsDBNull("Status") ? "Quote Sent" : reader.GetString("Status"),
                            TotalPrice = reader.GetDecimal("TotalPrice"),
                            Discount = reader.GetDecimal("Discount"),
                            Deadline = reader.GetDateTime("Deadline"),
                            DateCreated = reader.GetDateTime("DateCreated")
                        });
                    }
                }
            }

            return projects;
        }

        ///////////// ON EDIT PROJECT ///////////

        public Project GetProjectById(int projectId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT ProjectId, ProjectName, ProjectDescription, ProjectType, 
                   ClientName, ClientContact, ClientAddress, ClientEmail,
                   Status, TotalPrice, Discount, DateCreated, Deadline, ClientNotes
            FROM Projects 
            WHERE ProjectId = @ProjectId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectId", projectId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Project
                            {
                                ProjectId = reader.GetInt32("ProjectId"),
                                ProjectName = reader.GetString("ProjectName"),
                                ProjectDescription = reader.IsDBNull("ProjectDescription") ? "" : reader.GetString("ProjectDescription"),
                                ProjectType = reader.IsDBNull("ProjectType") ? "" : reader.GetString("ProjectType"),
                                ClientName = reader.GetString("ClientName"),
                                ClientContact = reader.IsDBNull("ClientContact") ? "" : reader.GetString("ClientContact"),
                                ClientAddress = reader.IsDBNull("ClientAddress") ? "" : reader.GetString("ClientAddress"),
                                ClientEmail = reader.IsDBNull("ClientEmail") ? "" : reader.GetString("ClientEmail"),
                                Status = reader.IsDBNull("Status") ? "Quote Sent" : reader.GetString("Status"),
                                TotalPrice = reader.GetDecimal("TotalPrice"),
                                Discount = reader.GetDecimal("Discount"),
                                DateCreated = reader.GetDateTime("DateCreated"),
                                Deadline = reader.GetDateTime("Deadline"),
                                ClientNotes = reader.IsDBNull("ClientNotes") ? "" : reader.GetString("ClientNotes")
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool UpdateProject(Project project)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                UPDATE Projects 
                SET ProjectName = @ProjectName, 
                    ProjectDescription = @ProjectDescription, 
                    ProjectType = @ProjectType, 
                    ClientName = @ClientName, 
                    ClientContact = @ClientContact,
                    ClientAddress = @ClientAddress, 
                    ClientEmail = @ClientEmail, 
                    Discount = @Discount, 
                    Deadline = @Deadline, 
                    ClientNotes = @ClientNotes
                WHERE ProjectId = @ProjectId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", project.ProjectId);
                        cmd.Parameters.AddWithValue("@ProjectName", project.ProjectName);
                        cmd.Parameters.AddWithValue("@ProjectDescription", (object)project.ProjectDescription ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ProjectType", (object)project.ProjectType ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ClientName", project.ClientName);
                        cmd.Parameters.AddWithValue("@ClientContact", (object)project.ClientContact ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ClientAddress", (object)project.ClientAddress ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ClientEmail", (object)project.ClientEmail ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Discount", project.Discount);
                        cmd.Parameters.AddWithValue("@Deadline", project.Deadline);
                        cmd.Parameters.AddWithValue("@ClientNotes", (object)project.ClientNotes ?? DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating project: " + ex.Message);
            }
        }

    }
}