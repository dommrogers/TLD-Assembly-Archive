using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Rewired.Demos;

public class CustomControllerDemo : MonoBehaviour
{
	public int playerId;

	public string controllerTag;

	public bool useUpdateCallbacks;

	private int buttonCount;

	private int axisCount;

	private float[] axisValues;

	private bool[] buttonValues;

	private TouchJoystickExample[] joysticks;

	private TouchButtonExample[] buttons;

	private CustomController controller;

	[NonSerialized]
	private bool initialized;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(CustomControllerDemo), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "add_InputSourceUpdateEvent")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(TypeFullName = "Rewired.Player.ControllerHelper.BnvLPSemkwrCfKYYABiuIneeJhx", Member = "eFsFDEPBoBwkCtkCNRQkVwhlOQ")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Controller), Member = "get_buttonCount")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_axisCount")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomControllerDemo), Member = "Initialize")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomControllerDemo), Member = "SetControllerAxisValues")]
	[Calls(Type = typeof(CustomControllerDemo), Member = "SetControllerButtonValues")]
	[CallsUnknownMethods(Count = 2)]
	private void OnInputSourceUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void GetSourceAxisValues()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void GetSourceButtonValues()
	{
	}

	[CalledBy(Type = typeof(CustomControllerDemo), Member = "OnInputSourceUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "Rewired.Logger", Member = "LogWarning")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallsUnknownMethods(Count = 2)]
	private void SetControllerAxisValues()
	{
	}

	[CalledBy(Type = typeof(CustomControllerDemo), Member = "OnInputSourceUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "Rewired.Logger", Member = "LogWarning")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallsUnknownMethods(Count = 2)]
	private void SetControllerButtonValues()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private float GetAxisValueCallback(int index)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool GetButtonValueCallback(int index)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public CustomControllerDemo()
	{
	}
}
