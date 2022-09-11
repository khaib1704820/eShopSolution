using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Dtos
{
    public class PagedViewModel<T>
    {

        public List<T> Item { set; get; }
        public int TotalRecord { set; get; }
    }
}
