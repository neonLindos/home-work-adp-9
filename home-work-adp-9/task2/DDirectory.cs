using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_adp_9.task2
{
    public class DDirectory : FileSystemComponent
    {
        private readonly List<FileSystemComponent> _components = new();

        public DDirectory(string name) : base(name) { }

        public void Add(FileSystemComponent component)
        {
            if (_components.Contains(component))
            {
                Console.WriteLine($"[!] Компонент \"{component.Name}\" уже существует в \"{Name}\".");
                return;
            }

            _components.Add(component);
        }

        public void Remove(FileSystemComponent component)
        {
            if (!_components.Contains(component))
            {
                Console.WriteLine($"[!] Компонент \"{component.Name}\" не найден в \"{Name}\".");
                return;
            }

            _components.Remove(component);
        }

        public override void Display(string indent = "")
        {
            Console.WriteLine($"{indent}+ Directory: {Name}");
            foreach (var component in _components)
                component.Display(indent + "   ");
        }

        public override int GetSize()
        {
            return _components.Sum(c => c.GetSize());
        }
    }
}
