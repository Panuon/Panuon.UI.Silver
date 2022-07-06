﻿using System;

namespace Panuon.UI.Silver
{
    [Flags]
    public enum ComboKeys
        : int
    {
        None = 1,
        Ctrl = 2,
        Alt = 4,
        Shift = 8,
        CtrlAndShift = 16,
        CtrlAndAlt = 32,
        CtrlAltAndShift = 64,
    }
}
