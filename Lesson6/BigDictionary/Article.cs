using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.BigDictionary
{
    internal class Article : IComparable<Article>
    {
        public int Price { get; set; }
        public string Title { get; set; }
        public string Vendor { get; set; }
        public string Barcode { get; set; }

        public int CompareTo(Article other)
        {
            return this.Barcode.CompareTo(other.Barcode);
        }
    }
}
