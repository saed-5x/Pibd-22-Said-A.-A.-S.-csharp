using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);

        void MoveMonorail(Direction direction);

        void DrawMonorail(Graphics g);
    }
}
