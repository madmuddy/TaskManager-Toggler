﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerEnable
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TaskManager.Core.EnableTaskManager();
            }
            catch
            {
            }
        }
    }
}
