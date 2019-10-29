using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace StudentExercises5
{
    class Repository
    {
        public SqlConnection Connection
        {
            get
            {
                // This is "address" of the database
                string _connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=StudentExercises5;Integrated Security=True";
                return new SqlConnection(_connectionString);
            }
        }
        //Assign an existing exercise to an existing student.
        public void AssignExercise(int studentId, int exerciseId)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    // These SQL parameters are annoying. Why can't we use string interpolation?
                    // ... sql injection attacks!!!
                    cmd.CommandText = "INSERT INTO StudentExercise (StudentId, ExerciseId) Values (@StudentId, @ExerciseId)";
                    cmd.Parameters.Add(new SqlParameter("@StudentId", studentId));
                    cmd.Parameters.Add(new SqlParameter("@ExerciseId", exerciseId));
                    cmd.ExecuteNonQuery(); //catch all for anything that is not select
                }
            }

        }

    }
}
