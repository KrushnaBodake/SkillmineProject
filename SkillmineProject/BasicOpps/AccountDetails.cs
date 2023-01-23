using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.BasicOpps
{
    class AccountDetails
    {
        int accountno;
        string actype;
        int acbalance;
        string customername;


        public int AccountNo
        {
            set
            {
                accountno = value;
            }
            get
            {
                return accountno;
            }
        }
        public string AcType
        {
            set
            {
                actype = value;
            }
            get
            {
                return actype;
            }
        }
        public int AcBalance
        {
            set
            {
                acbalance = value;
            }
            get
            {
                return acbalance;
            }
        }
        public string CustomerName
        {
            set
            {
                customername = value;
            }
            get
            {
                return customername;
            }
        }
    }
    class AccountInfo
    {
        static void Main(string[] args)
        {
            AccountDetails c = new AccountDetails();

            c.AcBalance = -2630;
            c.AccountNo = 123456;
            c.AcType = "saving";
            c.CustomerName = "Mr. Krishna";

            Console.WriteLine(c.CustomerName + " " + c.AcType + " " + c.AccountNo + " " + c.AcBalance);
        }
    }
    class Student
    {
        int id;
        string name;
        int chem;
        int physics;
        int math;

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Chem
        {
            set
            {
                chem = value;
            }
            get
            {
                return chem;
            }
        }
        public int Physics
        {
            set
            {
                physics = value;
            }
            get
            {
                return physics;
            }
        }
        public int Math
        {
            set
            {
                math = value;
            }
            get
            {
                return math;
            }
        }

    }
    class StudentInfo
    {
        static void Main(string[] args)
        {
            Student v = new Student();
            v.Id =123;
            v.Name = "Vikas";
            v.Chem = 65;
            v.Physics = 87;
            v.Math = 55;
            int totalMarks = (v.Chem + v.Physics + v.Math);
            double per = (totalMarks * 100) / 300.0;
            Console.WriteLine(per);
        }

    }
    class StudentClass
    {
       private int strength;
       internal char div;
       protected int totalboys;
       public int totalgirls;

        public int Strength
        {
            set
            {
                strength = value;
            }
            get
            {
                return strength;
            }
        }
        private char Div
        {
            set
            {
                div=value;
            }
            get
            {
                return div;
            }
        }
        protected int TotalBoys
        {
            set
            {
                totalboys = value;
            }
            get
            {
                return totalboys;
            }
        }
        internal int TotalGirls
        {
            set
            {
                totalgirls = value;
            }
            get
            {
                return totalgirls;
            }
        }
        public void Class()
        {
            Div = 'a';
            TotalBoys = 60;
            Console.WriteLine("Div: "+Div +" "+"Total Boys:"+ TotalBoys);
        }

    }
    class StudentsClassDetails
    {
        static void Main(string[] args)
        {
            StudentClass r = new StudentClass();

            r.Strength =100;
            //r.Div = 'a';
            //r.TotalBoys = 60;
            r.TotalGirls = 40;
            r.Class();
            Console.WriteLine("Class Strength: " + r.Strength +" " + "Total Girls:" + r.TotalGirls);
        }

    }    

}
