﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    /// <summary>
    /// Q.2.2
    /// </summary>
    class Gold : Item
    {
        private int amountOfGold;
        public int goldDrop
        {
            get
            {
                return amountOfGold;
            }
            set
            {
                amountOfGold = value;
            }
        }

        Random rng = new Random();

        public Gold ToString(int xPosition, int yPosition) : base()
        {
             amountOfGold = rng.Next(6);
            
        }
    }
}
