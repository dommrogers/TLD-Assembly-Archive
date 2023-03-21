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

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CHandleTouchpad_003Eb__0(Touch x)
		{
			return false;
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
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
		[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "OnGUI")]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "HandleTouchpad")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "SetRandomLightColor")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "StartLightFlash")]
	[Calls(Type = typeof(Controller), Member = "get_enabled")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(GUILayout), Member = "BeginArea")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstElementMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "EndArea")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 10)]
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

	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void SetRandomLightColor()
	{
	}

	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(Controller), Member = "get_enabled")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallsUnknownMethods(Count = 3)]
	private void StartLightFlash()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(DualShock4SpecialFeaturesExample), Member = "GetFirstDS4")]
	[Calls(Type = typeof(Controller), Member = "get_enabled")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallsUnknownMethods(Count = 2)]
	private void StopLightFlash()
	{
	}

	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "OnGUI")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "ResetOrientation")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "SetRandomLightColor")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "StartLightFlash")]
	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "StopLightFlash")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "GetExtension")]
	[CallsUnknownMethods(Count = 13)]
	private IDualShock4Extension GetFirstDS4(Player player)
	{
		return null;
	}

	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Queue<>), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 22)]
	private void InitializeTouchObjects()
	{
	}

	[CalledBy(Type = typeof(DualShock4SpecialFeaturesExample), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(List<>), Member = "Find")]
	[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 18)]
	private void HandleTouchpad(IDualShock4Extension ds4)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public DualShock4SpecialFeaturesExample()
	{
	}
}
