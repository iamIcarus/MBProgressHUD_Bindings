using System;
using ObjCRuntime;
using Foundation;

[assembly: LinkerSafe]
[assembly: LinkWith ("libMBProgressHUD.a", LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.ArmV7s | LinkTarget.Simulator, SmartLink = false, ForceLoad = true, Frameworks = "CoreGraphics")]