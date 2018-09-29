using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWICPipesAndFilters2
{
    public class KwicPipeline : Pipeline<string>
    {
        public KwicPipeline()
        {
            Register(new Reader());
            Register(new Shifter());
            Register(new Sorter());
            Register(new Writer());
        }
    }
}
