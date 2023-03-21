using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using Rewired.ControllerExtensions;
using UnityEngine;

namespace Rewired.Demos;

public class DualShock4SpecialFeaturesExample : MonoBehaviour
{
	private class Touch
	{
		public GameObject go;

		public int touchId;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public Touch()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public int touchId;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal bool _003CHandleTouchpad_003Eb__0(Touch x)
		{
			return default(bool);
		}
	}

	private const int maxTouches = 2;

	public int playerId;

	public Transform touchpadTransform;

	public GameObject lightObject;

	public Transform accelerometerTransform;

	private List<Touch> touches;

	private Queue<Touch> unusedTouches;

	private bool isFlashing;

	private GUIStyle textStyle;

	private Player player
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "OnGUI")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "OnGUI")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "OnGUI")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "OnGUI")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "OnGUI")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
		[CallerCount(Count = 11)]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "InitializeTouchObjects")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "StartLightFlash")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(Controller), Member = "get_enabled")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "HandleTouchpad")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "SetRandomLightColor")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	private void Update()
	{
	}

	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstElementMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstElementMapWithAction")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstElementMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "EndArea")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(GUILayout), Member = "BeginArea")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstElementMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstElementMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	private void OnGUI()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	private void ResetOrientation()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	private void SetRandomLightColor()
	{
	}

	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Controller), Member = "get_enabled")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 1)]
	private void StartLightFlash()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Controller), Member = "get_enabled")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 0)]
	private void StopLightFlash()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "StopLightFlash")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "SetRandomLightColor")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "ResetOrientation")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "OnGUI")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "StartLightFlash")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	private IDualShock4Extension GetFirstDS4(Player player)
	{
		return null;
	}

	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Awake")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 7)]
	private void InitializeTouchObjects()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[CallsUnknownMethods(Count = 13)]
	private void HandleTouchpad(IDualShock4Extension ds4)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DualShock4SpecialFeaturesExample()
	{
	}
}
