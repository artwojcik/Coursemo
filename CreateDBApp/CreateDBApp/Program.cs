
//
// Console app to create a database, e.g. BikeHike.
//
// Artur Wojcik
// NetID: awojci5
// U. of Illinois, Chicago
// CS480, Summer 2018
// Project #4
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDBApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("** Create Database Console App **");
            Console.WriteLine();

            string baseDatabaseName = "Coursemo";
            string sql;

            try
            {
                //
                // 1. Make a copy of empty MDF file to get us started:
                //
                Console.WriteLine("Copying empty database to {0}.mdf and {0}_log.ldf...", baseDatabaseName);

                CopyEmptyFile("__EmptyDB", baseDatabaseName);

                Console.WriteLine();

                //
                // 2. Now let's make sure we can connect to SQL Server on local machine:
                //
                DataAccessTier.Data data = new DataAccessTier.Data(baseDatabaseName + ".mdf");

                Console.Write("Testing access to database: ");

                if (data.TestConnection())
                    Console.WriteLine("success");
                else
                    Console.WriteLine("failure?!");

                Console.WriteLine();

                //
                // 3. Create tables by reading from .sql file and executing DDL queries:
                //
                Console.WriteLine("Creating tables by executing {0}.sql file...", baseDatabaseName);

                string[] lines = System.IO.File.ReadAllLines(baseDatabaseName + ".sql");

                sql = "";

                for (int i = 0; i < lines.Length; ++i)
                {
                    string next = lines[i];

                    if (next.Trim() == "")  // empty line, ignore...
                    {
                    }
                    else if (next.Contains(";"))  // we have found the end of the query:
                    {
                        sql = sql + next + System.Environment.NewLine;

                        Console.WriteLine("** Executing '{0}'...", sql.Substring(0, 32));

                        data.ExecuteActionQuery(sql);

                        sql = "";  // reset:
                    }
                    else  // add to existing query:
                    {
                        sql = sql + next + System.Environment.NewLine;
                    }
                }

                Console.WriteLine();

                //
                // 4. Insert data by parsing data from .csv files:
                //
                Console.WriteLine("Inserting data...");

                //  
                //  execute BikeType .csv 
                //  using  stmt  will  close  file  when  scope  is  exited:
                //
                //using (var file = new System.IO.StreamReader("biketypes.csv"))
                //{
                //    while (!file.EndOfStream)
                //    {
                //        string line = file.ReadLine();
                //        string[] values = line.Split(',');
                //        int typeid = Convert.ToInt32(values[0]);
                //        string description = values[1];
                //        double priceperhour = Convert.ToDouble(values[2]);

                //        //
                //        //  create query and execute 
                //        //
                //        sql = string.Format(@"Insert Into BikeTypes(Price, info) 
                //                                Values({1},'{2}');", typeid, priceperhour, description);
                //        data.ExecuteActionQuery(sql);

                //    }//while
                //}//using

                //
                //  execute student.csv 
                //
                using (var file = new System.IO.StreamReader("students.csv"))
                {

                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine();
                        string[] values = line.Split(',');
                        string first_name = values[1];
                        string last_name = values[0];
                        string email = values[2];
                        if (last_name.Contains("'"))
                        {
                            last_name = last_name.Replace("'", "\"");
                            Console.WriteLine("Replacing Single Quotes in Last Name");
                        }
                        if (first_name.Contains("'"))
                        {
                            first_name = first_name.Replace("'", "\"");
                            Console.WriteLine("Replacing Single Qoutes in First Name");
                        }


                        //
                        //  create query and execute 
                        //
                        sql = string.Format(@"insert into Students (FirstName, Lastname, NetID) 
                                                values ('{0}', '{1}', '{2}');", first_name, last_name, email);
                        data.ExecuteActionQuery(sql);
                    }//while
                }//using

                //
                //  execute bike.csv 
                //
                using (var file = new System.IO.StreamReader("courses.csv"))
                {
                    ArrayList departmets = new ArrayList();
                    ArrayList semesters = new ArrayList();
                    ArrayList classtypes = new ArrayList(); 

                    while (!file.EndOfStream)
                    {

                        //CS,251,fall,2018,37159,lab,R,1100-1150,8
                        string line = file.ReadLine();
                        string[] values = line.Split(',');
                        string cs = values[0]; 
                        int classNum = Convert.ToInt32(values[1]);
                        string semester = values[2]; 
                        int year = Convert.ToInt32(values[3]);
                        int crn = Convert.ToInt32(values[4]);
                        string lecture = values[5]; 
                        string day = values[6];
                        string time = values[7];
                        int capacity = Convert.ToInt32(values[8]);

                        //check if contains cs in the table 
                        if (!departmets.Contains(cs))
                        {
                            departmets.Add(cs);                            
                            sql = string.Format(@"INSERT INTO Departments(Department) VALUES ('{0}')", cs);
                            data.ExecuteActionQuery(sql);
                        }

                        //check if contains semester 
                        if (!semesters.Contains(semester))
                        {
                            semesters.Add(semester);
                            sql = string.Format(@"INSERT INTO Semesters(Semester) VALUES ('{0}')", semester);
                            data.ExecuteActionQuery(sql);
                        }

                        //check if classtype lab lecture etc 
                        if (!classtypes.Contains(lecture))
                        {
                            classtypes.Add(lecture);
                            sql = string.Format(@"INSERT INTO ClassTypes(ClassType) VALUES ('{0}')", lecture);
                            data.ExecuteActionQuery(sql);
                        }


                        int csindex = departmets.IndexOf(cs) + 1;
                        int semesterindex = semesters.IndexOf(semester) + 1;
                        int ctype = classtypes.IndexOf(lecture) + 101;

                        sql = string.Format(@"INSERT INTO Classes(DID, ClassNum, Semester, Years,CRN, CTID, 
WeekDays, Times, Capcity, CurrentTotal)
VALUES
(   {0},   -- DID - int
    {1},   -- ClassNum - int
    {2},   -- Semester - int
    {3},   -- Years - int
    {4},   -- CRN - int
    {5},   -- CTID - int
    N'{6}', -- WeekDays - nvarchar(128)
    N'{7}', -- Times - nvarchar(128)
    {8}  ,  -- Capcity - int
   0 )", csindex, classNum, semesterindex, year, crn, ctype, day, time, capacity);

                        data.ExecuteActionQuery(sql);

                        //
                        //  create query and execute 
                        //


                    }//while
                }//using


                Console.WriteLine();

                //
                // Done
                //
            }
            catch (Exception ex)
            {
                Console.WriteLine(" * *Exception: '{0}'", ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("** Done **");
            Console.WriteLine();
        }//Main


        /// <summary>
        /// Makes a copy of an existing Microsoft SQL Server database file 
        /// and log file.  Throws an exception if an error occurs, otherwise
        /// returns normally upon successful copying.  Assumes files are in
        /// sub-folder bin\Debug or bin\Release --- i.e. same folder as .exe.
        /// </summary>
        /// <param name="basenameFrom">base file name to copy from</param>
        /// <param name="basenameTo">base file name to copy to</param>
        static void CopyEmptyFile(string basenameFrom, string basenameTo)
        {
            string from_file, to_file;

            //
            // copy .mdf:
            //
            from_file = basenameFrom + ".mdf";
            to_file = basenameTo + ".mdf";

            if (System.IO.File.Exists(to_file))
            {
                System.IO.File.Delete(to_file);
            }

            System.IO.File.Copy(from_file, to_file);

            // 
            // now copy .ldf:
            //
            from_file = basenameFrom + "_log.ldf";
            to_file = basenameTo + "_log.ldf";

            if (System.IO.File.Exists(to_file))
            {
                System.IO.File.Delete(to_file);
            }

            System.IO.File.Copy(from_file, to_file);
        }

    }//class
}//namespace

