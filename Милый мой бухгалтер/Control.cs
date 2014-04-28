using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    class Control
    {
        public void Save(Worker Worker)
        {
            int ID = GenerationID(@"BD.db");
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"BD.db", true))
            {
                file.WriteLine(ID + " " + Worker.Name + " " + Worker.Age + " " + Worker.Position + " " + Worker.Wage + " " + Worker.BranchID);

            }
        }

        public int GenerationID(string filename)
        {
            string line = null, lineChecker;
            int ID;
            using (System.IO.StreamReader file = new System.IO.StreamReader(filename, true))
            {
                while ((lineChecker = file.ReadLine()) != "")
                {
                    if (lineChecker != null)
                    {
                        line = lineChecker;
                    }
                    else
                    {
                        file.Close();
                        break;
                    }
                }
                if (String.IsNullOrEmpty(line))
                {
                    ID = 1;
                }
                else
                {

                    ID = Convert.ToInt32(line.Substring(0, line.IndexOf(" "))) + 1;
                }
                

            }
            
            return ID;

        }

        public void SaveBranch(Branch Branch)
        {
            int ID = GenerationID(@"BDBranch.db");
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"BDBranch.db", true))
            {
                
                file.WriteLine(ID + " " + Branch.BranchName);

            }
        }

        public string GetStringByID(string filename, int ID)
        {
            string line = null, lineChecker;
            using (System.IO.StreamReader file = new System.IO.StreamReader(filename, true))
            {
                while ((lineChecker = file.ReadLine()) != "")
                {
                    if (lineChecker != null)
                    {
                        line = lineChecker;
                        if (ID == Convert.ToInt32(line.Substring(0, line.IndexOf(" "))))
                        {
                            break;
                            
                        }
                                               
                    }
                    else
                    {
                        file.Close();
                        break;
                    }
                }
            }
            
            return line;
        }

        public void EditWorker(int ID)
        {
            string LineWorker = this.GetStringByID(@"BD.db", ID);



        }
    }
}
