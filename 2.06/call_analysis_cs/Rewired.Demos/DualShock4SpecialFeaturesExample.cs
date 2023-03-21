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

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[CallerCount(Count = 11)]
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

	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "StartLightFlash")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Controller), Member = "get_enabled")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "HandleTouchpad")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "SetRandomLightColor")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstElementMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstElementMapWithAction")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstElementMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "EndArea")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(GUILayout), Member = "BeginArea")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstElementMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstElementMapWithAction")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[CallsUnknownMethods(Count = 2)]
	private void ResetOrientation()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	private void SetRandomLightColor()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(Controller), Member = "get_enabled")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void StartLightFlash()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Controller), Member = "get_enabled")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	private void StopLightFlash()
	{
	}

	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "ResetOrientation")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "StopLightFlash")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "StartLightFlash")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "SetRandomLightColor")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "OnGUI")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	private IDualShock4Extension GetFirstDS4(Player player)
	{
		return null;
	}

	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Awake")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 24)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "set_color")]
	private void InitializeTouchObjects()
	{
	}

	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 21)]
	private void HandleTouchpad(IDualShock4Extension ds4)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public DualShock4SpecialFeaturesExample()
	{
	}
}
