using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_1_Generics.Models;

namespace Labb_1_Generics.Controllers
{
    public class BoxSameVolume : EqualityComparer<Box>
    {
        public override bool Equals(Box? obj1, Box? obj2)
        {
            if (obj1.width * obj1.length * obj1.height == obj2.width * obj2.length * obj2.height)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode([DisallowNull] Box obj)
        {
            var hash = obj.height ^ obj.width ^ obj.length;
            return hash.GetHashCode();
        }
    }
}
