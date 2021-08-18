using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class Demo
    {
        #region State

        private bool IsLoggedIn { get; set; }

        #endregion State

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                //IsLoggedIn = true;
                IsLoggedIn = false;
                base.StateHasChanged();
            }
        }
    }
}