using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public static class KeyboardControler
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int ActivateKeyboardLayout(int HKL, int flags);

        public static void SetFarsiKeyboard()
        {
            try
            {
                ActivateKeyboardLayout(1065, 0);
            }
            catch { }
        }
        public static void SetEnglishKeyboard()
        {
            try
            {
                ActivateKeyboardLayout(67699721, 0);
            }
            catch { }
        }
    }
}
