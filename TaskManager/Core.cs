using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public static class Core
    {
        public static int EnableTaskManager()
        {
            try
            {
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int DisaableTaskManager()
        {
            try
            {
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int ToggleTaskManager()
        {
            try
            {
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
