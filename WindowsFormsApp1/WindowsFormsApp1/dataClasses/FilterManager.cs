using Microsoft.SqlServer.Server;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dataClasses
{
    class FilterManager
    {

        List<string> modifiedFilters;
        List<(string type, object value)> filters;
        string filterContext = "";

        public FilterManager()
        {
            modifiedFilters = new List<string>();
            filters = new List<(string type, object value)>();
        }

        public void addModifiedFilter(string type)
        {
            if(!this.checkFilterPresence(type))
                modifiedFilters.Add(type);
        }

        public void addFilter(string type, object value)
        {
            var el = this.filters.Find(x => x.type == type);
            if (el == (null, null))
            {
                this.filters.Add((type, value));
            }
            else
            {
                int index = this.filters.IndexOf(el);
                (string type, object value) newEl = (type, value);
                this.filters[index] = newEl;
            }
        }

        public bool checkFilterPresence(string type)
        {
            if (this.modifiedFilters.Contains(type))
                return true;
            else
                return false;
        }

        public List<(string, object)> getFilters()
        {
            return this.filters;
        }

        public string ParseFilters()
        {
            List<string> filter = new List<string>();

            if (this.checkFilterPresence("Start Date"))
            {
                DateTime date = (DateTime)this.filters.Find(x => x.type == "Start Date").value;
                filter.Add($"Data >= #{date.ToString("s")}#");
            }
            if (this.checkFilterPresence("End Date"))
            {
                DateTime date = (DateTime)this.filters.Find(x => x.type == "End Date").value;
                filter.Add($"Data <= #{date.ToString("s")}#");
            }
            if (this.checkFilterPresence("Produttore")){
                var name = this.filters.Find(x => x.type == "Produttore").value;
                filter.Add($"Produttore LIKE '{name}'");
            }
            if (this.checkFilterPresence("Validità"))
            {
                var name = this.filters.Find(x => x.type == "Validità").value;
                filter.Add($"Validità LIKE '{name}'");
            }

            return String.Join(" and ", filter);
        }

        public void SetFilterContext(string ctx)
        {
            this.filterContext = ctx;
        }

        public void ClearFilters()
        {
            this.filterContext = "";
            this.modifiedFilters = new List<string>();
            this.filters = new List<(string type, object value)>();
        }

    }
}
