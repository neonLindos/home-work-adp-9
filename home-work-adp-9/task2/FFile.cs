using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_adp_9.task2
{
    public class FFile : FileSystemComponent
    {
        public int Size { get; private set; }

        public FFile(string name, int size) : base(name)
        {
            Size = size;
        }

        public override void Display(string indent = "")
        {
            Console.WriteLine($"{indent}- File: {Name} ({Size} KB)");
        }

        public override int GetSize() => Size;
    }
}
