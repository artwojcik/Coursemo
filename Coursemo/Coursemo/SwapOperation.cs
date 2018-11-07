//
//  Multi-user  Coursemo  application  for  UIC  course  registrations.
//
//  Artur Wojcik
//  NetID: awojci5
//  U. of Illinois, Chicago
//  CS480, Summer 2018
//  Project #4
//


using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursemo
{
    public partial class SwapOperation : Form
    {
        private CoursemoEntities db;
        private ArrayList students;
        private Form1 form1;

        public SwapOperation(Form1 form, ArrayList _students, CoursemoEntities _db)
        {
            InitializeComponent();
            form1 = form;
            students = _students;
            db = _db; 
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //same students is sellected 
            if (this.listBoxStudentX.SelectedIndex == this.listBoxStudentY.SelectedIndex)
            {
                MessageBox.Show("Select Two different Students !!!");
                return; 
            }

            //same class is selected
            try
            {
                if (this.listBoxCoursesX.SelectedItem.ToString() == this.listBoxCoursesY.SelectedItem.ToString())
                {
                    MessageBox.Show("Both Students are enrolled to this class! Swap Cancel !!!");
                    return;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("No class selected !!! Select classes for both students!");
                return;
            }
            //check student x if he is not in the class that other what to swapp
            foreach(var x in this.listBoxCoursesX.Items)
            {
                if (x.ToString() == this.listBoxCoursesY.SelectedItem.ToString())
                {
                    Console.WriteLine("oops");
                    MessageBox.Show("Illegal swap Student already has this class"); 
                    return; 
                }
            }

            foreach (var y in this.listBoxCoursesY.Items)
            {
                if (y.ToString() == this.listBoxCoursesX.SelectedItem.ToString())
                {
                    Console.WriteLine("oops");
                    MessageBox.Show("Illegal swap Student already has this class");
                    return;
                }
            }

            string classX = this.listBoxCoursesX.SelectedItem.ToString();
            string classY = this.listBoxCoursesY.SelectedItem.ToString();

            string[] valuesX = classX.Split(' ');
            string[] valuesY = classY.Split(' ');

            int crnX = Convert.ToInt32(valuesX[3]);
            int crnY = Convert.ToInt32(valuesY[3]);

            Student sX = (Student)students[this.listBoxStudentX.SelectedIndex];
            int stidX = sX.STID;

            Student sY = (Student)students[this.listBoxStudentY.SelectedIndex];
            int stidY = sY.STID;

            int cidX = getCID(crnX);
            int cidY = getCID(crnY);             

            //now we can perform transaction of swap 
            using (var trans = db.Database.BeginTransaction())
            {
                try
                {
                    form1.delay();

                    int scid_X = getSCID(cidX, stidX);
                    int countX = getCount(cidX, stidX, scid_X); 

                    if (countX != 1)
                    {
                        throw new System.InvalidOperationException("Aready on the list rollback");
                    }

                    int scid_Y = getSCID(cidY, stidY);
                    int countY = getCount(cidY, stidY, scid_Y); 
                    
                    if (countY != 1)
                    {
                        throw new System.InvalidOperationException("Aready on the list rollback");
                    }

                    //remove student x from class
                    var x = from c in db.StudentClasses
                            where c.CID == cidX && c.STID == stidX
                            select c;

                    foreach (var p in x)
                    {
                        p.STID = stidY; 
                    }

                    //remove student y from class 
                    var y = from c in db.StudentClasses
                            where c.CID == cidY && c.STID == stidY
                            select c;

                    foreach (var p in y)
                    {
                        p.STID = stidX;  
                    }

                    //check if student is on the wait list after swap
                    //if so remove from wait list after complete swap 
                    //do selection from left window 
                    var SCIDleft = from s in db.StudentWaitLists
                               where s.CID == cidY && s.STID == stidX
                               select s.SCID;

                    int sc = -1;
                    foreach (var p in SCIDleft)
                    {
                        sc = p; 
                    }


                    var removeLeft = from sw in db.StudentWaitLists
                                 where sw.SCID == sc
                                 select sw; 

                    foreach(var a in removeLeft)
                    { 
                        db.StudentWaitLists.Remove(a);
                    }

                    //check if student is on the wait list after swap
                    //if so remove from wait list after complete swap 
                    //do selection from rigth window 
                    var SCIDrigth = from s in db.StudentWaitLists
                                   where s.CID == cidX && s.STID == stidY
                                   select s.SCID;

                    int scrigth = -1;
                    foreach (var p in SCIDrigth)
                    {
                        scrigth = p;
                    }


                    var removeRigth = from sw in db.StudentWaitLists
                                     where sw.SCID == scrigth
                                     select sw;

                    foreach (var a in removeRigth)
                    {
                        db.StudentWaitLists.Remove(a);
                    }

                    db.SaveChanges();
                    trans.Commit(); 

                }
                catch(Exception ex)
                {
                    trans.Rollback();
                    Console.WriteLine(ex);
                    MessageBox.Show("Rollback Swap Cancel");
                }
               

            }


            //refresh list of classes
            getStudentClasses(this.listBoxStudentX, this.listBoxCoursesX);
            getStudentClasses(this.listBoxStudentY, this.listBoxCoursesY);

        }

        //-------------------------------------------------------------------------------------------------------

        //get count of the students from stusdent classes always should be 1 if not transaction 
        //will rollback 
        private int getCount(int cidX, int stidX, int scid_X)
        {
            return (from c in db.StudentClasses
                    where c.CID == cidX && c.STID == stidX && c.SCID == scid_X
                    select c).Count();
        }

        //-------------------------------------------------------------------------------------------------------

        //get Student Classes ID 
        private int getSCID(int cidX, int stidX)
        {
            int scid = -1;
            var scidX = from xz in db.StudentClasses
                        where xz.STID == stidX && xz.CID == cidX
                        select xz.SCID;

            foreach (var p in scidX)
            {
                Console.WriteLine(p);
                scid = p;

            }
            return scid; 
        }

        //-------------------------------------------------------------------------------------------------------

        //get course ID 
        private int getCID(int crnX)
        {
            int cid = -1;
            var query = from a in db.Classes
                        where a.CRN == crnX
                        select a;

            foreach (var p in query)
            {
                cid = p.CID;
            }
            return cid;
        }

        //-------------------------------------------------------------------------------------------------------

        //when form loads higlight first index in both listboxes
        private void SwapOperation_Load(object sender, EventArgs e)
        {
          
            foreach (var s in students)
            {
                this.listBoxStudentX.Items.Add(s);
                this.listBoxStudentY.Items.Add(s);
            }
            this.listBoxStudentX.SelectedIndex = 0;
            this.listBoxStudentY.SelectedIndex = 0;
        }

        private void listBoxCoursesX_SelectedIndexChanged(object sender, EventArgs e)
        {        
            
        }

        //-------------------------------------------------------------------------------------------------------

        //get list of the classes for student selected in listbox
        private void getStudentClasses(ListBox student, ListBox courses)
        {

            courses.Items.Clear();
            Student g = (Student)students[student.SelectedIndex];
            int studentID = g.STID;

            //get registered classes 
            var c = (from a in db.Classes
                     join d in db.StudentClasses
                     on a.CID equals d.CID
                     join dep in db.Departments
                     on a.DID equals dep.DID
                     join s in db.Students
                     on d.STID equals s.STID
                     where a.CID == d.CID
                     where d.STID == g.STID

                     select new
                     {
                         Dep = dep.Department1,
                         ID = a.CID,
                         CLASS = a.ClassNum,
                         CReN = a.CRN
                     }).ToList();


            foreach (var p in c)
            {
                string clas = string.Format(@"{0}{1} --> CRN#: {2}", p.Dep, p.CLASS, p.CReN);
                courses.Items.Add(clas);
            }
        }

        //-------------------------------------------------------------------------------------------------------

        //display student x classes 
        private void listBoxStudentX_SelectedIndexChanged(object sender, EventArgs e)
        {
            getStudentClasses(this.listBoxStudentX, this.listBoxCoursesX);
        }

        //-------------------------------------------------------------------------------------------------------

        //display student y classes
        private void listBoxStudentY_SelectedIndexChanged(object sender, EventArgs e)
        {

            getStudentClasses(this.listBoxStudentY, this.listBoxCoursesY);
        }

        //-------------------------------------------------------------------------------------------------------

        //close this form swap operation and go back to the main form 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

//-------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------

