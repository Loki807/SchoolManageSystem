﻿using SchoolManageSystem.Data;
using SchoolManageSystem.Models;
using SchoolManageSystem.Services;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManageSystem.Controllers
{
    internal class StudentController
    {
        //private readonly StudentService _studentService;

        public StudentController()
        {
            //_studentService = new StudentService();
        }

        //public List<Student> GetAllStudents() => _studentService.GetAll();

        //public void AddStudent(Student student) => _studentService.Add(student);

        //public void UpdateStudent(Student student) => _studentService.Update(student);

        //public void DeleteStudent(int studentId) => _studentService.Delete(studentId);


        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT s.Id, s.Name, s.Address, s.SectionId, sec.Name AS SectionName
                    FROM Students s
                    LEFT JOIN Sections sec ON s.SectionId = sec.Id", conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Address = reader.GetString(2),
                        SectionId = reader.GetInt32(3),
                        SectionName = reader.GetString(4),
                    };
                    students.Add(student);
                    
                    //students.Add(new Student
                    //{
                    //    Id = reader.GetInt32(0),
                    //    Name = reader.GetString(1),
                    //    Address = reader.GetString(2),
                    //    SectionName = reader.IsDBNull(3) ? "" : reader.GetString(3)
                    //});
                }
            }

            return students;
        }

        public void AddStudent(Student student)
        {
            using (var conn = DbCon.GetConnection())
            {
                var command = new SQLiteCommand("INSERT INTO Students (Name, Address, SectionId) VALUES (@Name, @Address, @SectionId)", conn);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Address", student.Address);
                command.Parameters.AddWithValue("@SectionId", student.SectionId);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (var conn = DbCon.GetConnection())
            {
                var command = new SQLiteCommand("UPDATE Students SET Name = @Name, Address = @Address, SectionId = @SectionId WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Address", student.Address);
                command.Parameters.AddWithValue("@SectionId", student.SectionId);
                command.Parameters.AddWithValue("@Id", student.Id);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int studentId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM Students WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Id", studentId);
                command.ExecuteNonQuery();
            }
        }

        public Student GetStudentById(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Students WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            SectionId = reader.IsDBNull(3) ? 0 : reader.GetInt32(3)
                        };
                    }
                }
            }

            return null;
        }

    }
}
