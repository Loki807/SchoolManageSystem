using SchoolManageSystem.Data;
using SchoolManageSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManageSystem.Services
{
    internal class SectionService
    {
        public void Add(Section section)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Sections (Name) VALUES (@name)";
                cmd.Parameters.AddWithValue("@name", section.Name);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Section> GetAll()
        {
            var sections = new List<Section>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Sections";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sections.Add(new Section
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            }
            return sections;
        }

        public void Update(Section section)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Sections SET Name = @name WHERE Id = @id";
                cmd.Parameters.AddWithValue("@name", section.Name);
                cmd.Parameters.AddWithValue("@id", section.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Sections WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
