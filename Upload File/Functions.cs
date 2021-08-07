using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upload_File
{
    class Functions
    {
        public static bool popupMessage(string message, string popupTitle = "Alert")
        {
            bool returnVal = false;
            using (Popup form = new Popup(popupTitle, message))
            {
                form.Text = popupTitle;
                form.ShowDialog();
                returnVal = form.ok_Clicked;
            }
            return returnVal;
        }
        public bool nameMatch(ref string nameA, ref string nameB, string didYouMean = null)
        {
            if(nameA.ToLower() == nameB.ToLower())
            {
                return true;
            } else
            {
                if(didYouMean != null)
                {

                }
                return false;
            }
        }
    }
}
