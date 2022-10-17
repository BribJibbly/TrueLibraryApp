using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueLibraryApp.Tree_items
{
    class CollectionNode<T>
    {
        public T Data { get; set; }
        public CollectionNode<T> Parent { get; set; }
        public List<CollectionNode<T>> Children { get; set; }
    }
}
