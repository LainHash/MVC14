
using MVC14.Models;

namespace MVC14.ViewModels
{
    public class ProductVM : VwProduct
    {
        public VwLaptopSpec? Laptop { get; set; }
        public VwCpuSpec? Cpu { get; set; }
        public VwGpuSpec? Gpu { get; set; }
        public VwRamSpec? Ram { get; set; }
        public VwStorageSpec? Storage { get; set; }
    }
}
