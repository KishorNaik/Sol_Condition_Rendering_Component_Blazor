using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Components
{
    public partial class When
    {
        #region Props

        [Parameter]
        public bool Condition { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        #endregion Props
    }
}