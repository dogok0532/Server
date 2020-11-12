using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClientCSharp
{
    public class DrawInfo
    {
        DrawInfo(Point beginPoint, Point endPoint, Color color, int size)
        {
            _beginX = beginPoint.X;
            _beginY = beginPoint.Y;
            _endX = endPoint.X;
            _endY = endPoint.Y;
        }

        private int _beginX;
        private int _beginY;
        private int _endX;
        private int _endY;

        
    }

    public class ChatInfo
    {
        
    }
}
