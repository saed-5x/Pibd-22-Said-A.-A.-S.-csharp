using lab_1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMonorail
{
    interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveMonorail(Direction direction);
        void DrawMonorail(Graphics g);
    }
}
