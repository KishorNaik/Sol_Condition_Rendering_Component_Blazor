using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Components
{
    public partial class Choose
    {
        #region Props

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        #endregion Props
    }
}