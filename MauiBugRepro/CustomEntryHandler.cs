using AndroidX.AppCompat.Widget;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBugRepro;

public partial class CustomEntryHandler : EntryHandler
{

    public CustomEntryHandler()
    {

    }

#if IOS
    protected override void DisconnectHandler(MauiTextField nativeView)
    {
        base.DisconnectHandler(nativeView);
    }
#elif ANDROID
    protected override void DisconnectHandler(AppCompatEditText nativeView)
    {
        base.DisconnectHandler(nativeView);
    }
#endif
}
