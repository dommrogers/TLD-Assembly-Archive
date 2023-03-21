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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Awake()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(CustomControllerDemo), Member = "Update")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Controller), Member = "get_buttonCount")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_axisCount")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Player.ControllerHelper.BnvLPSemkwrCfKYYABiuIneeJhx), Member = "eFsFDEPBoBwkCtkCNRQkVwhlOQ")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput), Member = "add_InputSourceUpdateEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomControllerDemo), Member = "Initialize")]
	private void Update()
	{
	}

	[Calls(Type = typeof(CustomControllerDemo), Member = "SetControllerButtonValues")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomControllerDemo), Member = "SetControllerAxisValues")]
	[CallsUnknownMethods(Count = 2)]
	private void OnInputSourceUpdate()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void GetSourceAxisValues()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void GetSourceButtonValues()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Logger), Member = "LogWarning")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CalledBy(Type = typeof(CustomControllerDemo), Member = "OnInputSourceUpdate")]
	[CallsUnknownMethods(Count = 2)]
	private void SetControllerAxisValues()
	{
	}

	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CustomControllerDemo), Member = "OnInputSourceUpdate")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Logger), Member = "LogWarning")]
	private void SetControllerButtonValues()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private float GetAxisValueCallback(int index)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool GetButtonValueCallback(int index)
	{
		return default(bool);
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public CustomControllerDemo()
	{
	}
}
