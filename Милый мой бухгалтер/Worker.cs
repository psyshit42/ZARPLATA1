using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Worker
    {
        public int ID;
        public string Name;
        public int Age;
        public Positions Position;
        public double Wage;
        public int BranchID;

        public Worker(string Name, int Age, Positions Position, double Wage, int BranchID)
        {
            
            this.Name = Name;
            this.Age = Age;
            this.Position = Position;
            this.Wage = Wage;
            this.BranchID = BranchID;
        }

    }
}
