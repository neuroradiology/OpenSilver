﻿#if WORKINPROGRESS

#if MIGRATION
namespace System.Windows.Input
#else
namespace Windows.UI.Xaml.Input
#endif
{
    //
    // Summary:
    //     Defines values for the type of devices the tablet device uses.
    public enum TabletDeviceType
    {
        //
        // Summary:
        //     Indicates the tablet device is a mouse.
        Mouse = 0,
        //
        // Summary:
        //     Indicates the tablet device is a stylus.
        Stylus = 1,
        //
        // Summary:
        //     Indicates the tablet device is a touch screen.
        Touch = 2
    }
}

#endif