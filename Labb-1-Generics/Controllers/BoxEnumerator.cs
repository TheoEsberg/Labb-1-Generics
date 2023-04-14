using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_1_Generics.Models;

namespace Labb_1_Generics.Controllers
{
    public class BoxEnumerator : IEnumerator<Box>
    {   
        private BoxCollection Boxes;
        private int CurrentIndex;
        private Box? CurrentBox;

        public BoxEnumerator(BoxCollection boxes)
        {
            Boxes = boxes;
            CurrentIndex = -1;
            CurrentBox = default;
        }

        public bool MoveNext()
        {
            if (++CurrentIndex < Boxes.Count)
            {
                CurrentBox = Boxes[CurrentIndex];
                return true;
            }
            return false;
        }

        public void Reset() => throw new NotImplementedException();
        public Box Current => CurrentBox;   // CurrentBox can be null...
        object IEnumerator.Current => Current;

        // Do something with this one maybe?
        public void Dispose(){}
    }
}
