using System;
using ObjCRuntime;

[assembly: LinkWith ("libAmplitude-sdk.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s| LinkTarget.Arm64 | LinkTarget.Simulator64 , SmartLink = true, ForceLoad = false)]
