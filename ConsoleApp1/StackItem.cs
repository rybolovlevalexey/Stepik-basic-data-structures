﻿using System;
using System.Collections.Generic;
using System.Text;
class StackItem
{
    public string value;
    public StackItem next = null;

    public StackItem(string st)
    {
        value = st;
    }
}