using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Rewired.Demos;

public class PlayerMouseSpriteExample : MonoBehaviour
{
	public int playerId;

	public string horizontalAction;

	public string verticalAction;

	public string wheelAction;

	public string leftButtonAction;

	public string rightButtonAction;

	public string middleButtonAction;

	public float distanceFromCamera;

	public float spriteScale;

	public GameObject pointerPrefab;

	public GameObject clickEffectPrefab;

	public bool hideHardwarePointer;

	[NonSerialized]
	private GameObject pointer;

	[NonSerialized]
	private PlayerMouse mouse;

	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(PlayerMouse), Member = "add_ScreenPositionChangedEvent")]
	[Calls(Type = typeof(PlayerMouse), Member = "aRljyCnbaetbamKSsBaXDdNQipi")]
	[Calls(Type = typeof(PlayerController.MouseWheel), Member = "get_yAxis")]
	[Calls(Type = typeof(PlayerMouse), Member = "get_wheel")]
	[Calls(Type = typeof(PlayerMouse), Member = "set_pointerSpeed")]
	[Calls(Type = typeof(PlayerController.ElementWithSource), Member = "set_actionName")]
	[Calls(Type = typeof(PlayerMouse), Member = "get_middleButton")]
	[Calls(Type = typeof(PlayerController.ElementWithSource), Member = "set_actionName")]
	[Calls(Type = typeof(PlayerMouse), Member = "get_rightButton")]
	[Calls(Type = typeof(PlayerController.ElementWithSource), Member = "set_actionName")]
	[Calls(Type = typeof(PlayerMouse), Member = "get_screenPosition")]
	[Calls(Type = typeof(PlayerController.ElementWithSource), Member = "set_actionName")]
	[Calls(Type = typeof(PlayerMouse), Member = "get_leftButton")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(PlayerMouse.Factory), Member = "iMviRVGHjpzwJOpMWSPIIPuZgHL")]
	[Calls(Type = typeof(PlayerController), Member = "set_playerId")]
	[Calls(Type = typeof(PlayerMouse), Member = "get_xAxis")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerMouse), Member = "get_yAxis")]
	[Calls(Type = typeof(PlayerController.ElementWithSource), Member = "set_actionName")]
	[Calls(Type = typeof(PlayerMouse), Member = "get_wheel")]
	[Calls(Type = typeof(PlayerController.MouseWheel), Member = "get_yAxis")]
	[Calls(Type = typeof(PlayerController.ElementWithSource), Member = "set_actionName")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(PlayerController.Element), Member = "get_player")]
	[Calls(Type = typeof(PlayerMouseSpriteExample), Member = "CreateClickEffect")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(PlayerController.Element), Member = "get_player")]
	[Calls(Type = typeof(PlayerController.Element), Member = "get_player")]
	[Calls(Type = typeof(PlayerMouse), Member = "get_middleButton")]
	[Calls(Type = typeof(PlayerMouseSpriteExample), Member = "CreateClickEffect")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(PlayerController.Element), Member = "get_player")]
	[Calls(Type = typeof(PlayerMouse), Member = "get_rightButton")]
	[Calls(Type = typeof(PlayerMouse), Member = "get_leftButton")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(PlayerController.Element), Member = "get_player")]
	[Calls(Type = typeof(PlayerController.Element), Member = "get_player")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(PlayerController.MouseWheel), Member = "get_yAxis")]
	[Calls(Type = typeof(PlayerMouse), Member = "get_wheel")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerMouseSpriteExample), Member = "CreateClickEffect")]
	private void Update()
	{
	}

	[Calls(Type = typeof(PlayerMouse), Member = "remove_ScreenPositionChangedEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(PlayerMouseSpriteExample), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMouseSpriteExample), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMouseSpriteExample), Member = "Update")]
	[Calls(Type = typeof(PlayerMouse), Member = "get_screenPosition")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerMouse), Member = "get_screenPosition")]
	[CallsDeduplicatedMethods(Count = 10)]
	private void CreateClickEffect(Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void OnScreenPositionChanged(Vector2 position)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlayerMouseSpriteExample()
	{
	}
}
