/*
<OxygenNEL>
Copyright (C) <2025>  <OxygenNEL>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
*/
using Codexus.Cipher.Protocol;

namespace OxygenNEL.type;

internal static class AppState
{
    private static WPFLauncher? _x19;
    
    public static WPFLauncher X19
    {
        get
        {
            if (_x19 == null)
            {
                _x19 = new WPFLauncher();
            }
            return _x19;
        }
    }
    
    public static void ResetX19()
    {
        _x19?.Dispose();
        _x19 = new WPFLauncher();
    }
    
    public static Services? Services;
    public static bool Debug;
    public static string AutoDisconnectOnBan;
    public static bool IrcEnabled = true;
}
