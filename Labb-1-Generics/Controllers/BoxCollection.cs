using System.Collections;
using Labb_1_Generics.Models;

namespace Labb_1_Generics.Controllers
{
    public class BoxCollection : ICollection<Box>
    {
        private readonly List<Box> Boxes = new List<Box>();

        public Box this[int index]
        {
            get => Boxes[index];
            set => Boxes[index] = value;
        }

        public IEnumerator<Box> GetEnumerator() => new BoxEnumerator(this);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Add(Box obj)
        {
            if (!Contains(obj) || !Contains(obj, new BoxSameVolume()))
            {
                Boxes.Add(obj);
            } else {
                Console.WriteLine("Box with Dimensions: Width = {0}, Height = {1}, Length = {2} does already exists in the collection!", obj.width, obj.height, obj.length);
            }
        }

        public bool Contains(Box obj) => Boxes.Any(box => box.Equals(obj));
        public bool Contains(Box obj, EqualityComparer<Box> comparer) => Boxes.Any(box => comparer.Equals(box, obj));
        public void Clear() => Boxes.Clear();
        public void CopyTo(Box[] array, int arrayIndex) => throw new NotImplementedException();
        public bool Remove(Box obj) => Boxes.RemoveAll(box => new BoxSameDimensions().Equals(box, obj)) > 0;
        public int Count => Boxes.Count;
        public bool IsReadOnly => false;

    }
}
