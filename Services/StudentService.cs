using SchoolManageSystem.Data;
using SchoolManageSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManageSystem.Services
{
    internal class StudentService
    {
        public void Add(Student student)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Students (Name, Address, SectionId) VALUES (@name, @address, @sectionId)";
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.Parameters.AddWithValue("@sectionId", student.SectionId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Student> GetAll()
        {
            var students = new List<Student>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Students";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            SectionId = reader.GetInt32(3)
                        });
                    }
                }
            }
            return students;
        }

        public void Update(Student student)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Students SET Name = @name, Address = @address, SectionId = @sectionId WHERE Id = @id";
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.Parameters.AddWithValue("@sectionId", student.SectionId);
                cmd.Parameters.AddWithValue("@id", student.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Students WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
