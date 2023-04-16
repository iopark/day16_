using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    public  enum Direction
    {
        Up, Down, Left, Right, None
    }
    public class GameInput
    {
        public Direction direction_; 
        public Action placedInput; 
        
        public Direction direction ()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                this.direction_ = Direction.Up; break;

                case ConsoleKey.DownArrow:
                case ConsoleKey.S: 
                this.direction_ = Direction.Down; break;

                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                this.direction_ = Direction.Left;
                break;

                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                this.direction_ = Direction.Left;
                break;

                default:
                this.direction_ = Direction.None;
                    break;
            }
            return direction_; 
        }
    }
}
