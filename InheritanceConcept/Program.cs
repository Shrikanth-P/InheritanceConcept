using System;

namespace InheritanceWithProtected
{
    class EmplpoyeeBonus
    {
        protected int eid;
        protected string ename;
        protected int esal;
        protected int bonus = 10000;

        public EmplpoyeeBonus(int eid, string ename, int esal)
        {
            this.eid = eid;
            this.ename = ename;
            this.esal = esal;
            Console.WriteLine($"Employee ID : {eid}");
            Console.WriteLine($"Employee Name : {ename}");
            Console.WriteLine($"Employee Salary : {esal}");
        }
        public EmplpoyeeBonus()
        {
            //Empty Constructor for using non static variable in employeebonus method
        }
        public static void employeeBonus()
        {
            EmplpoyeeBonus eb = new EmplpoyeeBonus();
            Console.WriteLine($"For Staff 3 times the bonus {3 * eb.bonus}");
            Console.WriteLine($"For NonStaff 2 times the bonus {2 * eb.bonus}");
            Console.WriteLine("\n");
        }
    }
    class Staff : EmplpoyeeBonus
    {
        public Staff(int eid, string ename, int esal) : base(eid, ename, esal)
        {
        }

        public void displayStaffBonus()
        {
            Console.Write($"Bonus for Staff members is : {esal + (3 * bonus)} ");
            Console.WriteLine("\n");
        }
    }
    class NonStaff : EmplpoyeeBonus
    {
        public NonStaff(int eid, string ename, int esal) : base(eid, ename, esal)
        {
        }

        public void displayStaffBonus()
        {
            Console.Write($"Bonus for Non Staff members is : {esal + (2 * bonus)} ");
            Console.WriteLine("\n");
        }
    }


    class InheritanceWithProtected
    {
        public static void Main()
        {
            EmplpoyeeBonus.employeeBonus();
            
            Staff staff = new Staff(1, "sam", 40000);
            staff.displayStaffBonus();
            
            NonStaff Nonstaff = new NonStaff(12, "john", 20000);
            Nonstaff.displayStaffBonus();
        }
    }
}
