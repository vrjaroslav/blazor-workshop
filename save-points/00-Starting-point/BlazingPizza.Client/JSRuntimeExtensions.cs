using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Client
{
    public static class JSRuntimeExtensions
    {
        public static ValueTask<bool> Confirm(this IJSRuntime jSRuntime, string message)
        {
            return jSRuntime.InvokeAsync<bool>("confirm", message);
        }
    }
}
