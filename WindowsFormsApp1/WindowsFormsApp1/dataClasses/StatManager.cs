using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dataClasses
{
    class StatManager
    {
        private string path;
        private List<Stat> stats;

        public StatManager(string projectPath)
        {
            this.path = projectPath;
            this.stats = new List<Stat>();
        }

        public void loadStats()
        {
            string fileName = "\\stat.log";

            // Check if file exists and if not create it
            if (!File.Exists(this.path + fileName))
            {
                FileStream newFile = File.Open(this.path + fileName, FileMode.Create);
                //File.SetAttributes(this.path + fileName, FileAttributes.Hidden);
                newFile.Close();
                return;
            }

            // Read Lines and then load in data struct
            string[] lines = File.ReadAllLines(this.path + fileName);
            foreach (string line in lines)
            {
                string[] sline = line.Split(';');

                string prjName = sline[0];
                int prjCount = int.Parse(sline[1]);

                Stat st = new Stat(prjName, prjCount);
                this.stats.Add(st);
            }
        }

        public string getMostUsedPrj()
        {
            string ret = "";
            if (this.stats == null)
                return ret;

            int count = 0;
            foreach(var st in this.stats)
            {
                // If count is equal clear most used variable
                if (st.projectCount == count)
                    ret = "";

                // If prjCount is greater save the Name
                if(st.projectCount > count)
                {
                    count = st.projectCount;
                    ret = st.projectName;
                }
            }

            return ret;
        }

        public void updateProjectCount(string projectName)
        {
            string text = "";

            Stat st = stats.Find(x => (x.projectName == projectName));

            // If no equal project name existing in struct create new
            if(st == null)
            {
                st = new Stat(projectName, 1);
                this.stats.Add(st);
            }
            else
            {
                int id = this.stats.IndexOf(st);

                st.projectCount += 1;

                this.stats[id] = st;

            }



            // Create file text
            foreach (var el in this.stats)
                text += el.getString(";") + "\n";

            File.WriteAllText(this.path + "\\stat.log", text);
        }

    }
}
