﻿using System;

namespace Open_Lab_03._07
{
    public class Divider
    {
        public bool EqualSlices(int total, int people, int each)
        {
            if ( total >= people*each)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
