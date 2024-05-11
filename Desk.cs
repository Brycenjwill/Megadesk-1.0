using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megadesk_1._0
{
    internal class Desk
    {
        public static int minWidth = 24;
        public static int maxWidth = 96;
        public static int minDepth = 12;
        public static int maxDepth = 48;
    }
}
enum SurfaceTypes
{
    Laminate, 
    Oak,
    Rosewood, 
    Veneer,
    Pine,
}