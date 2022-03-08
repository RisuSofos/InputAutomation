﻿using System.Runtime.InteropServices;

namespace InputAutomation.Core.User32;

[StructLayout(LayoutKind.Sequential)]
public struct HardwareInput {
	internal int uMsg;
	internal short wParamL;
	internal short wParamH;
}