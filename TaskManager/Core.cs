using Microsoft.Win32;
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
                RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                objRegistryKey.DeleteValue("DisableTaskMgr");

                objRegistryKey.Close();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int DisableTaskManager()
        {
            try
            {
                RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                objRegistryKey.SetValue("DisableTaskMgr", "1");

                objRegistryKey.Close();

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
                RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                if (objRegistryKey.GetValue("DisableTaskMgr") == null)
                    objRegistryKey.SetValue("DisableTaskMgr", "1");
                else
                    objRegistryKey.DeleteValue("DisableTaskMgr");
                objRegistryKey.Close();

                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
