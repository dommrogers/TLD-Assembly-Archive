using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Gamepad;

public class GamepadPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static extern bool SetGamepadVibration(ulong id, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void UpdatePlugin();

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void PulseGamepadsLeftMotor(ulong id, float startValue, float endValue, ulong duration);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void PulseGamepadsRightMotor(ulong id, float startValue, float endValue, ulong duration);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void PulseGamepadsLeftTrigger(ulong id, float startValue, float endValue, ulong duration);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void PulseGamepadsRightTrigger(ulong id, float startValue, float endValue, ulong duration);

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public GamepadPlugin()
	{
	}
}
