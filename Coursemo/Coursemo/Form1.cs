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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private CoursemoEntities db;
        private ArrayList students;
        private ArrayList classes;



        //when form loads create arraylists of students and classes
        //that are available in DB
        private void Form1_Load(object sender, EventArgs e)
        {
            //db = new CoursemoEntities();
            students = new ArrayList();
            classes = new ArrayList();

            using (var db = new CoursemoEntities())
            {
                foreach (Student s in db.Students)
                {
                    students.Add(s);
                }

                foreach (var clas in db.Classes)
                {
                    classes.Add(clas);
                }
            }
        }

        //add students to the list box 
        //it will save tripp to DB 
        private void button1_Click(object sender, EventArgs e)
        {
            clearGui();
            foreach (var s in students)
            {
                this.listBox1.Items.Add(s);
            }
        }


        //dispaly info about each student selected 
        //classses he/she has net id etc
        //call to getStudenList 
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getStudentLists();
        }

        //main function to updating students list do all operation on 
        //each student 
        private void getStudentLists()
        {
            clearGui();

            string netid = this.listBox1.SelectedIndex.ToString();
            Student g = (Student)students[this.listBox1.SelectedIndex];
            int studentID = g.STID;

            this.textBoxNETID.Text = g.NetID;

            using (var db = new CoursemoEntities())
            {

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
                    this.listBoxRegitered.Items.Add(clas);
                }

                //get list of waitlist classes
                var wait = (from a in db.Classes
                            join d in db.StudentWaitLists
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


                foreach (var p in wait)
                {
                    string clas = string.Format(@"{0}{1} --> CRN#: {2}", p.Dep, p.CLASS, p.CReN);
                    this.listBoxWait.Items.Add(clas);
                }
            }
        }


        //clear gui elements to prevent overalpping 
        private void clearGui()
        {
            //clear registered and wait list 
            this.listBoxRegitered.Items.Clear();
            this.listBoxWait.Items.Clear();
            this.textBoxNETID.Clear();
        }


        //display all courses that are offered for registration 
        private void buttonCourses_Click(object sender, EventArgs e)
        {
            this.listBoxAvailableCourses.Items.Clear();

            using (var db = new CoursemoEntities())
            {
                var c = (from a in db.Classes
                         join dep in db.Departments
                         on a.DID equals dep.DID
                         select new
                         {
                             Dep = dep.Department1,
                             CLASS = a.ClassNum,
                             CReN = a.CRN
                         }).ToList();

                foreach (var p in c)
                {
                    string clas = string.Format(@"{0}{1} --> CRN#: {2}", p.Dep, p.CLASS, p.CReN);
                    this.listBoxAvailableCourses.Items.Add(clas);
                }
            }
        }


        //display information about each course that was selected 
        //course can be selected on any listbox that are displayed 
        //registered courses available courses and waitlist courses 
        private void selectCourse(string clas)
        {
            using (var db = new CoursemoEntities())
            {
                try
                {
                    string[] values = clas.Split(' ');

                    int crn = Convert.ToInt32(values[3]);

                    var c = (from a in db.Classes
                             join s in db.Semesters
                             on a.Semester equals s.SMID
                             join t in db.ClassTypes
                             on a.CTID equals t.CTID
                             where a.CRN == crn
                             select new
                             {
                                 SEMESTER = s.Semester1,
                                 YEAR = a.Years,
                                 TYPE = t.ClassType1,
                                 DAY = a.WeekDays,
                                 TIME = a.Times,
                                 SIZE = a.Capcity,
                                 CURENTENROLMENT = a.CurrentTotal,
                                 WAIT = a.CID
                             }).ToArray();

                    this.textBoxDay.Text = c[0].DAY;
                    this.textBoxSemester.Text = c[0].SEMESTER;
                    this.textBoxSize.Text = c[0].SIZE.ToString();
                    this.textBoxType.Text = c[0].TYPE;
                    this.textBoxYear.Text = c[0].YEAR.ToString();
                    this.textBoxTime.Text = c[0].TIME;
                    this.textBoxCurrentEnrolment.Text = c[0].CURENTENROLMENT.ToString();
                    int cid = c[0].WAIT;

                    var x = (from i in db.StudentWaitLists
                             where i.CID == cid
                             select i).Count();

                    this.textBoxWaitList.Text = x.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------

        //display info about classes that are selected in register list box
        private void listBoxRegitered_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectCourse(this.listBoxRegitered.Text);
        }

        //-------------------------------------------------------------------------------------------------------

        //display info about classes that are selected in available list box
        private void listBoxAvailableCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            getWaitAndEnrolmentLists();
        }

        //-------------------------------------------------------------------------------------------------------

        //display list of netids in the list boxes for the 
        //registered student and student thta are on wait list 
        private void getWaitAndEnrolmentLists()
        {
            this.listBoxWaitList.Items.Clear();
            this.listBoxEnrolment.Items.Clear();

            //check students on the wait list and display netid 
            selectCourse(this.listBoxAvailableCourses.Text);
            int i = this.listBoxAvailableCourses.SelectedIndex;
            Class myCLass = (Class)classes[i];
            int cid = myCLass.CID;

            using (var db = new CoursemoEntities())
            {
                var query = (from a in db.StudentWaitLists
                             join b in db.Students
                             on a.STID equals b.STID
                             where a.CID == cid
                             select new
                             {
                                 NETID = b.NetID
                             }).ToList();
                foreach (var p in query)
                {
                    this.listBoxWaitList.Items.Add(p.NETID);
                }

                //make a list registered studetnts for selected class
                query = (from a in db.StudentClasses
                         join b in db.Students
                         on a.STID equals b.STID
                         where a.CID == cid
                         select new
                         {
                             NETID = b.NetID
                         }).ToList();
                foreach (var p in query)
                {
                    this.listBoxEnrolment.Items.Add(p.NETID);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------

        //display info about classes that are selected in wait list box
        private void listBoxWait_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectCourse(this.listBoxWait.Text);
        }

        //-------------------------------------------------------------------------------------------------------

        //register for a course using transaction if fail then will rollback 
        private void button2_Click(object sender, EventArgs e)
        {

            if (this.listBox1.SelectedItem == null)
            {
                MessageBox.Show("Select Student");
                return;
            }

            if (this.listBoxAvailableCourses.SelectedItem == null)
            {
                MessageBox.Show("Select Class from available courses.");
                return;
            }
            using (var db = new CoursemoEntities())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    ArrayList regiteredClasses = new ArrayList();
                    ArrayList waitList = new ArrayList();

                    delay();

                    string selectedClass = this.listBoxAvailableCourses.SelectedItem.ToString();

                    int index = this.listBox1.SelectedIndex;
                    int i = this.listBoxAvailableCourses.SelectedIndex;
                    Student student = (Student)students[index];
                    Class myClass = (Class)classes[i];


                    StudentClass studentClass = new StudentClass();
                    studentClass.YEARS = myClass.Years;
                    studentClass.STID = student.STID;
                    studentClass.CID = myClass.CID;
                    StudentWaitList studentWaitList = new StudentWaitList();
                    studentWaitList.YEARS = myClass.Years;
                    studentWaitList.STID = student.STID;
                    studentWaitList.CID = myClass.CID;

                    string[] values = selectedClass.Split(' ');
                    int crn = Convert.ToInt32(values[3]);

                    var x = (from c in db.Classes
                             join s in db.StudentClasses
                             on c.CID equals s.CID
                             where c.CRN == crn && s.STID == student.STID
                             select c).Count();



                    var y = (from c in db.Classes
                             join s in db.StudentWaitLists
                             on c.CID equals s.CID
                             where c.CRN == crn && s.STID == student.STID
                             select c).Count();

                    Console.WriteLine("this is x: {0}", x);
                    Console.WriteLine("this is y: {0}", y);
                    try
                    {
                        //check is student is on the wait list or class registerd list 
                        //if is on either one cancel transaction 
                        if (x > 0 || y > 0)
                        {
                            MessageBox.Show("You are on the list");
                            throw new System.InvalidOperationException("Aready on the list rollback");
                        }

                        //update classes total curretn
                        var query = from a in db.Classes
                                    where a.CID == studentClass.CID
                                    select a;

                        foreach (var p in query)
                        {
                            //if current enrolled equals capacity put student on the wait list 
                            if (p.CurrentTotal == p.Capcity)
                            {
                                db.StudentWaitLists.Add(studentWaitList);
                            }
                            //else put on the registered list and update db
                            else
                            {
                                p.CurrentTotal = p.CurrentTotal + 1;
                                db.StudentClasses.Add(studentClass);
                            }
                        }

                        db.SaveChanges();
                        db.Database.CurrentTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("rollback");
                        Console.WriteLine(ex);
                    }
                }
            }

            //update gui
            getStudentLists();
            getWaitAndEnrolmentLists();
            selectCourse(this.listBoxAvailableCourses.Text);
        }

        //-------------------------------------------------------------------------------------------------------

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.listBoxRegitered.SelectedItem == null)
            {
                MessageBox.Show("Select Class you want to drop");
                return;
            }

            string selectedClass = this.listBoxRegitered.SelectedItem.ToString();
            int index = this.listBox1.SelectedIndex;
            Student student = (Student)students[index];
            int stid = student.STID;
            string[] values = selectedClass.Split(' ');

            int crn = Convert.ToInt32(values[3]);
            int cid = -1;

            using (var db = new CoursemoEntities())
            {
                //begin transaction 
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        delay();
                        //check if registerd on this class for multi-user operation 
                        var xyz = (from h in db.StudentClasses
                                   join i in db.Classes
                                   on h.CID equals i.CID
                                   join s in db.Students
                                   on h.STID equals s.STID
                                   where i.CRN == crn && h.STID == stid
                                   select h).Count();
                        Console.WriteLine("to jest drop x: {0}", xyz);

                        //if its not on the list throw exception and rollback transaction 
                        if (xyz == 0)
                        {
                            throw new System.InvalidOperationException("Aready on the list rollback");
                        }

                        //search class by crn 
                        var query = from a in db.Classes
                                    where a.CRN == crn
                                    select a;

                        //update current total -1 and get course id 
                        foreach (var p in query)
                        {
                            p.CurrentTotal = p.CurrentTotal - 1;
                            cid = p.CID;
                        }

                        //find student in sthe classes registered and remove 
                        var q = from c in db.StudentClasses
                                where c.CID == cid && c.STID == stid
                                select c;

                        foreach (var p in q)
                        {
                            db.StudentClasses.Remove(p);

                        }

                        //now find if someone on the wait list if so remove from waitlist
                        //and add to registered 
                        var x = -1;
                        try
                        {
                            x = (from s in db.StudentWaitLists

                                 where s.CID == cid

                                 select s).Min(c => c.SCID);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            x = -1;
                        }

                        //if x =-1 no one on the wait list ignore and coninue 
                        if (x == -1)
                        {
                            Console.WriteLine("wait list is empty ");
                        }
                        //else create new student and put on the list 
                        else
                        {
                            var h = from s in db.StudentWaitLists
                                    where s.SCID == x
                                    select new
                                    {
                                        STID = s.STID,
                                        CID = s.CID,
                                        YEARS = s.YEARS
                                    };
                            StudentClass studentClass = new StudentClass();
                            foreach (var i in h)
                            {
                                studentClass.YEARS = i.YEARS;
                                studentClass.CID = i.CID;
                                studentClass.STID = i.STID;
                            }

                            //remove from waitlist
                            var z = from a in db.StudentWaitLists
                                    where a.SCID == x
                                    select a;
                            foreach (var i in z)
                            {
                                db.StudentWaitLists.Remove(i);
                            }

                            //update classes curent enrolment
                            var o = from i in db.Classes
                                    where i.CID == cid
                                    select i;
                            foreach (var i in o)
                            {
                                i.CurrentTotal = i.CurrentTotal + 1;
                            }
                            db.StudentClasses.Add(studentClass);
                        }

                        db.SaveChanges();
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Rollback");
                        Console.WriteLine(ex);
                    }
                }
            }

            //try catch if seleted item is null
            try
            {
                clearTXTboxes();
                getStudentLists();
                getWaitAndEnrolmentLists();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        //-------------------------------------------------------------------------------------------------------

        //reset DB to original state where registration is 0
        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new CoursemoEntities())
            {
                //remove from students classes 
                var clases = from s in db.StudentClasses
                             select s;
                foreach (var p in clases)
                {
                    db.StudentClasses.Remove(p);
                }

                //remove from studen waitlist 
                var waitList = from s in db.StudentWaitLists
                               select s;
                foreach (var p in waitList)
                {
                    db.StudentWaitLists.Remove(p);
                }

                var query = from a in db.Classes
                            select a;
                foreach (var p in query)
                {
                    p.CurrentTotal = 0;
                }

                try
                {
                    db.SaveChanges();
                    getStudentLists();
                    getWaitAndEnrolmentLists();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    clearGui();
                }

                MessageBox.Show("DATABASE WAS RESET");
                try
                {
                    getWaitAndEnrolmentLists();
                }
                catch (Exception ex){ Console.WriteLine(ex); }
            }
        }

        //-------------------------------------------------------------------------------------------------------

        //delay to simulate multiuser application 
        public void delay()
        {
            int timeInMS;
            if (System.Int32.TryParse(this.txtTimeInMS.Text, out timeInMS) == true)
                Console.WriteLine("empty statment");
            else
                timeInMS = 0;    //  no  delay:
            System.Threading.Thread.Sleep(timeInMS);

        }

        //-------------------------------------------------------------------------------------------------------

        //withdraw from wait list using transaction
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.listBoxWait.SelectedItem == null)
            {
                MessageBox.Show("Select Class you want to drop");
                return;
            }

            string selectedClass = this.listBoxWait.SelectedItem.ToString();
            int index = this.listBox1.SelectedIndex;
            Student student = (Student)students[index];
            int stid = student.STID;
            string[] values = selectedClass.Split(' ');

            int crn = Convert.ToInt32(values[3]);
            int cid = -1;

            using (var db = new CoursemoEntities())
            {
                //begin transaction 
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        delay();
                        var xyz = (from h in db.StudentWaitLists
                                   join i in db.Classes
                                   on h.CID equals i.CID
                                   join s in db.Students
                                   on h.STID equals s.STID
                                   where i.CRN == crn && h.STID == stid
                                   select h).Count();
                        Console.WriteLine("to jest drop wait x: {0}", xyz);

                        if (xyz == 0)
                        {
                            throw new System.InvalidOperationException("Aready on the list rollback");
                        }

                        var query = from a in db.Classes
                                    where a.CRN == crn
                                    select a;

                        foreach (var p in query)
                        {
                            cid = p.CID;
                        }

                        var q = from c in db.StudentWaitLists
                                where c.CID == cid && c.STID == stid
                                select c;

                        foreach (var p in q)
                        {
                            db.StudentWaitLists.Remove(p);

                        }

                        db.SaveChanges();
                        trans.Commit();

                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        Console.WriteLine(ex);
                        MessageBox.Show("Rollback");
                    }

                    try
                    {
                        getStudentLists();
                        getWaitAndEnrolmentLists();
                        clearTXTboxes();
                    }
                    catch (Exception ex) { Console.WriteLine(ex); }
                }
            }
        }

        private void clearTXTboxes()
        {
            this.textBoxDay.Clear();
            this.textBoxSemester.Clear();
            this.textBoxSize.Clear();
            this.textBoxType.Clear();
            this.textBoxYear.Clear();
            this.textBoxTime.Clear();
            this.textBoxCurrentEnrolment.Clear();
            this.textBoxWaitList.Clear();
        }

        //-------------------------------------------------------------------------------------------------------

        //load new form to perform swap 
        private void button5_Click(object sender, EventArgs e)
        {
            using (var db = new CoursemoEntities())
            {
                var box = new SwapOperation(this, students, db);
                box.StartPosition = FormStartPosition.CenterParent;
                box.ShowDialog();

                try
                {
                    getStudentLists();
                    getWaitAndEnrolmentLists();
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
        }
    }
}
//-------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------

