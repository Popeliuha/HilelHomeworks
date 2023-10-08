using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FlowerManager<T> where T: Flower
    {
        public string GetFullFlowerInfo(T flower)
        {
            return $"{flower.GetDescription()}, {flower.Bloom()}. \nName: {flower.Name}";
        }
    }
}
