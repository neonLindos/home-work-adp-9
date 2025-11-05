using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_adp_9.task2
{
    public abstract class FileSystemComponent
    {
        public string Name { get; protected set; }

        protected FileSystemComponent(string name)
        {
            Name = name;
        }

        public abstract void Display(string indent = "");
        public abstract int GetSize();
    }
}
