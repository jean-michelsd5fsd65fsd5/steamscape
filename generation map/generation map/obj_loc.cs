using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generation_map
{
    public class Obj_loc
    {
        private int posX;
        private int posY;
        private int dir;
        private int type;
        private int index;

        public Obj_loc(int posX, int posY, int dir, int type)
        {
            PosX = posX;
            PosY = posY;
            Dir = dir;
            Type = type;
        }
        public Obj_loc()
        {

        }

        public int Index
        {
            get { return index; }
            set { index = value; }
        }


        public int Type
        {
            get { return type; }
            set { type = value; }
        }


        public int Dir
        {
            get { return dir; }
            set { dir = value; }
        }


        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }


        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public override string ToString()
        {
            return this.PosX + " " + this.PosY + " " + this.Dir + " " + this.Index;
        }

    }
}
