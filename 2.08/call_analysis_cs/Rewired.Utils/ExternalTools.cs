using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Internal;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Utils;

public class ExternalTools : IExternalTools
{
	private static Func<object> _getPlatformInitializerDelegate;

	private bool _isEditorPaused;

	private Action<bool> _EditorPausedStateChangedEvent;

	public static Func<object> getPlatformInitializerDelegate
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool isEditorPaused
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool UnityInput_IsTouchPressureSupported
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public event Action<bool> EditorPausedStateChangedEvent
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 4)]
		add
		{
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 4)]
		remove
		{
		}
	}

	public event Action<uint, bool> XboxOneInput_OnGamepadStateChange
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ExternalTools()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Destroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public object GetPlatformInitializer()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public string GetFocusedEditorWindowTitle()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public bool IsEditorSceneViewFocused()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public bool LinuxInput_IsJoystickPreconfigured(string name)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int XboxOneInput_GetUserIdForGamepad(uint id)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
	{
		return default(ulong);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public string XboxOneInput_GetControllerType(ulong xboxControllerId)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
	{
		return default(uint);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void XboxOne_Gamepad_UpdatePlugin()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector3 PS4Input_GetLastAcceleration(int id)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Vector3 PS4Input_GetLastGyro(int id)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Vector4 PS4Input_GetLastOrientation(int id)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 0)]
	public void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref touchNum) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref touch0x) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref touch0y) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref touch0id) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref touch1x) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref touch1y) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref touch1id) = null;
	}

	[CallerCount(Count = 0)]
	public void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref touchpixelDensity) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref touchResolutionX) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref touchResolutionY) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref analogDeadZoneLeft) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref analogDeadZoneright) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref connectionType) = null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_PadSetMotionSensorState(int id, bool bEnable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_PadSetLightBar(int id, int red, int green, int blue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_PadResetLightBar(int id)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_PadResetOrientation(int id)
	{
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public bool PS4Input_PadIsConnected(int id)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_GetUsersDetails(int slot, object loggedInUser)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 16)]
	public int PS4Input_GetDeviceClassForHandle(int handle)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string PS4Input_GetDeviceClassString(int intValue)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int PS4Input_PadGetUsersHandles2(int maxControllers, int[] handles)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_GetSpecialControllerInformation(int id, int padIndex, object controllerInformation)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector3 PS4Input_SpecialGetLastAcceleration(int id)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Vector3 PS4Input_SpecialGetLastGyro(int id)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Vector4 PS4Input_SpecialGetLastOrientation(int id)
	{
		return default(Vector4);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int PS4Input_SpecialGetUsersHandles(int maxNumberControllers, int[] handles)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int PS4Input_SpecialGetUsersHandles2(int maxNumberControllers, int[] handles)
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public bool PS4Input_SpecialIsConnected(int id)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_SpecialResetLightSphere(int id)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_SpecialResetOrientation(int id)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_SpecialSetAngularVelocityDeadbandState(int id, bool bEnable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_SpecialSetLightSphere(int id, int red, int green, int blue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_SpecialSetMotionSensorState(int id, bool bEnable)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void PS4Input_SpecialSetTiltCorrectionState(int id, bool bEnable)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void PS4Input_SpecialSetVibration(int id, int largeMotor, int smallMotor)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Vector3 PS4Input_AimGetLastAcceleration(int id)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Vector3 PS4Input_AimGetLastGyro(int id)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Vector4 PS4Input_AimGetLastOrientation(int id)
	{
		return default(Vector4);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int PS4Input_AimGetUsersHandles(int maxNumberControllers, int[] handles)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int PS4Input_AimGetUsersHandles2(int maxNumberControllers, int[] handles)
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public bool PS4Input_AimIsConnected(int id)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_AimResetLightSphere(int id)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_AimResetOrientation(int id)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_AimSetAngularVelocityDeadbandState(int id, bool bEnable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_AimSetLightSphere(int id, int red, int green, int blue)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void PS4Input_AimSetMotionSensorState(int id, bool bEnable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_AimSetTiltCorrectionState(int id, bool bEnable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void PS4Input_AimSetVibration(int id, int largeMotor, int smallMotor)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Vector3 PS4Input_GetLastMoveAcceleration(int id, int index)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Vector3 PS4Input_GetLastMoveGyro(int id, int index)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int PS4Input_MoveGetButtons(int id, int index)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int PS4Input_MoveGetAnalogButton(int id, int index)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public bool PS4Input_MoveIsConnected(int id, int index)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles, int[] secondaryHandles)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public IntPtr PS4Input_MoveGetControllerInputForTracking()
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int PS4Input_MoveSetLightSphere(int id, int index, int red, int green, int blue)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int PS4Input_MoveSetVibration(int id, int index, int motor)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
	{
		vids = null;
		pids = null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 16)]
	public int GetAndroidAPILevel()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	public void WindowsStandalone_ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
	{
	}

	[CallerCount(Count = 0)]
	public float UnityInput_GetTouchPressure(ref Touch touch)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControllerTemplateFactory), Member = "Create")]
	public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public Type[] GetControllerTemplateTypes()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public Type[] GetControllerTemplateInterfaceTypes()
	{
		return null;
	}
}
