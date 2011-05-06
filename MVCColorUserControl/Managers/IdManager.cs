using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCColorUserControl.Managers
{
    /// <summary>
    /// Simple static ID generator. Used for assigning unique index values to MVC user controls.
    /// </summary>
    public static class IdManager
    {
        public static int Id = 0;

        public static int GetNextId()
        {
            Id++;

            return Id;
        }
    }
}