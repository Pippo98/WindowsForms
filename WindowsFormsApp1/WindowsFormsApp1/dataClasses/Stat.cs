namespace WindowsFormsApp1.dataClasses
{
    class Stat
    {
        public string projectName;
        public int projectCount;

        public Stat(string projectName, int projectCount)
        {
            this.projectName = projectName;
            this.projectCount = projectCount;
        }

        public string getString(string separator)
        {
            string text = "";

            text += this.projectName + separator;
            text += this.projectCount.ToString();

            return text;
        }
    }
}
