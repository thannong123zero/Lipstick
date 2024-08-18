using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.UserInterfaceDTO
{
    public class LayoutUI
    {
        public NavigationUI Navigation;
        public LayoutUI() { 
            Navigation = new NavigationUI();
        }
    }
    public class NavigationUI
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<SubNavigationUI> SubNavigations { get; set; }
        public NavigationUI() { 
            Name = string.Empty;
            SubNavigations = new List<SubNavigationUI>();
        }
    }
    public class SubNavigationUI 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public SubNavigationUI()
        {
            Name = string.Empty;
        }
    }
}
