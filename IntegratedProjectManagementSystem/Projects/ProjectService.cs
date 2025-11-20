using IntegratedProjectManagementSystem.Resources;
using System;
using System.Data;
using System.Data.SqlClient;

namespace IntegratedProjectManagementSystem.Services
{
    public class ProjectService
    {
        private object _projectId;

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

            public  DateTime CompletedDate { get; set; }
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
                 @ClientAddress, @ClientEmail, @Discount, @Deadline, @ClientNotes, @Status, GETDATE())";

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
                        cmd.Parameters.AddWithValue("@Status", project.Status); // Add this line

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating project: " + ex.Message);
            }
        }


        //////// GETTING PROJECTS LIST /////////
        public List<Project> GetAllProjects()
        {
            var projects = new List<Project>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT ProjectId, ProjectName, ProjectDescription, ProjectType, 
                           ClientName, Status, TotalPrice, Discount, Deadline, DateCreated, CompletedDate
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
                            Status = reader.IsDBNull("Status") ? "" : reader.GetString("Status"),
                            TotalPrice = reader.GetDecimal("TotalPrice"),
                            Discount = reader.GetDecimal("Discount"),
                            Deadline = reader.GetDateTime("Deadline"),
                            DateCreated = reader.GetDateTime("DateCreated"),
                            CompletedDate = reader.IsDBNull("CompletedDate") ? DateTime.MinValue : reader.GetDateTime("CompletedDate")
                        });
                    }
                }
            }

            return projects;
        }

        
        public Project GetProjectById(int projectId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT ProjectId, ProjectName, ProjectDescription, ProjectType, 
                   ClientName, ClientContact, ClientAddress, ClientEmail,
                   Status, TotalPrice, Discount, DateCreated, Deadline, ClientNotes, CompletedDate
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
                                ClientNotes = reader.IsDBNull("ClientNotes") ? "" : reader.GetString("ClientNotes"),
                                CompletedDate = reader.IsDBNull("CompletedDate") ? DateTime.MinValue : reader.GetDateTime("CompletedDate")

                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<Project> GetProjectsByStatus(string status)
        {
            var projects = new List<Project>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT ProjectId, ProjectName, ProjectDescription, ProjectType, 
                   ClientName, Status, TotalPrice, Discount, Deadline, DateCreated, CompletedDate
            FROM Projects 
            WHERE Status = @Status
            ORDER BY DateCreated DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
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
                                DateCreated = reader.GetDateTime("DateCreated"),
                                CompletedDate = reader.IsDBNull("CompletedDate") ? DateTime.MinValue : reader.GetDateTime("CompletedDate")
                            });
                        }
                    }
                }
            }

            return projects;
        }

        public List<Project> SearchProjects(string searchTerm)
        {
            var projects = new List<Project>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT ProjectId, ProjectName, ProjectDescription, ProjectType, 
                   ClientName, Status, TotalPrice, Discount, Deadline, DateCreated
            FROM Projects 
            WHERE ProjectName LIKE @SearchTerm OR ClientName LIKE @SearchTerm
            ORDER BY DateCreated DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
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
            }

            return projects;
        }


        ///////////// ON EDIT PROJECT ///////////
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
                    ClientNotes = @ClientNotes,
                    Status = @Status,
                    CompletedDate = CASE 
                        WHEN @Status = 'Completed' AND CompletedDate IS NULL THEN GETDATE()
                        WHEN @Status != 'Completed' THEN NULL
                        ELSE CompletedDate
                    END
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
                        cmd.Parameters.AddWithValue("@Status", project.Status);

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

        ////////////////// ON PDF CREATION //////////////////


        /// QUOTATION ///
        private DataTable GetProjectProductsTable()
        {
            // reuse your LoadProjectProducts query but return DataTable instead
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT pp.ProjectProductId, pp.Quantity, 
                   p.ProductName, p.Description, p.Category, p.Dimension, p.SalePrice,
                   (pp.Quantity * p.SalePrice) as TotalPrice
            FROM ProjectProducts pp
            INNER JOIN Products p ON pp.ProductId = p.ProductId
            WHERE pp.ProjectId = @ProjectId
            ORDER BY p.ProductName";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@ProjectId", _projectId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

    }
}