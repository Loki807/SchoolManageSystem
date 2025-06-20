﻿using SchoolManageSystem.Data;
using SchoolManageSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManageSystem.Services
{
    internal class StudentTeacherService
    {
        public void AssignTeacherToStudent(int studentId, int teacherId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT OR IGNORE INTO StudentTeacher (StudentId, TeacherId)
                    VALUES (@studentId, @teacherId)";
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@teacherId", teacherId);
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveTeacherFromStudent(int studentId, int teacherId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    DELETE FROM StudentTeacher 
                    WHERE StudentId = @studentId AND TeacherId = @teacherId";
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@teacherId", teacherId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Teacher> GetTeachersForStudent(int studentId)
        {
            var teachers = new List<Teacher>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    SELECT T.Id, T.Name, T.Phone, T.Address
                    FROM Teachers T
                    INNER JOIN StudentTeacher ST ON T.Id = ST.TeacherId
                    WHERE ST.StudentId = @studentId";
                cmd.Parameters.AddWithValue("@studentId", studentId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teachers.Add(new Teacher
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Phone = reader.GetString(2),
                            Address = reader.GetString(3)
                        });
                    }
                }
            }
            return teachers;
        }
    }
}
