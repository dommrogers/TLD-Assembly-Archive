using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Rewired.Demos.GamepadTemplateUI;

public class GamepadTemplateUI : MonoBehaviour
{
	private class Stick
	{
		private RectTransform _transform;

		private Vector2 _origPosition;

		private int _xAxisElementId;

		private int _yAxisElementId;

		public Vector2 position
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(Vector2);
			}
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			set
			{
			}
		}

		[CalledBy(Type = typeof(GamepadTemplateUI), Member = "Awake")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
		[CallsUnknownMethods(Count = 1)]
		public Stick(RectTransform transform, int xAxisElementId, int yAxisElementId)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public void Reset()
		{
		}

		[CallerCount(Count = 0)]
		public bool ContainsElement(int elementId)
		{
			return false;
		}

		[CalledBy(Type = typeof(GamepadTemplateUI), Member = "ActivateElements")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public void SetAxisPosition(int elementId, float value)
		{
		}
	}

	private class UIElement
	{
		public int id;

		public ControllerUIElement element;

		[DeduplicatedMethod]
		[CallerCount(Count = 100)]
		public UIElement(int id, ControllerUIElement element)
		{
		}
	}

	private const float stickRadius = 20f;

	public int playerId;

	private RectTransform leftStick;

	private RectTransform rightStick;

	private ControllerUIElement leftStickX;

	private ControllerUIElement leftStickY;

	private ControllerUIElement leftStickButton;

	private ControllerUIElement rightStickX;

	private ControllerUIElement rightStickY;

	private ControllerUIElement rightStickButton;

	private ControllerUIElement actionBottomRow1;

	private ControllerUIElement actionBottomRow2;

	private ControllerUIElement actionBottomRow3;

	private ControllerUIElement actionTopRow1;

	private ControllerUIElement actionTopRow2;

	private ControllerUIElement actionTopRow3;

	private ControllerUIElement leftShoulder;

	private ControllerUIElement leftTrigger;

	private ControllerUIElement rightShoulder;

	private ControllerUIElement rightTrigger;

	private ControllerUIElement center1;

	private ControllerUIElement center2;

	private ControllerUIElement center3;

	private ControllerUIElement dPadUp;

	private ControllerUIElement dPadRight;

	private ControllerUIElement dPadDown;

	private ControllerUIElement dPadLeft;

	private UIElement[] _uiElementsArray;

	private Dictionary<int, ControllerUIElement> _uiElements;

	private IList<ControllerTemplateElementTarget> _tempTargetList;

	private Stick[] _sticks;

	private Player player
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stick), Member = ".ctor")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerConnectedEvent")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerDisconnectedEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 104)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GamepadTemplateUI), Member = "DrawLabels")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "remove_ControllerConnectedEvent")]
	[Calls(Type = typeof(ReInput), Member = "remove_ControllerDisconnectedEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControllerUIElement), Member = "Deactivate")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(TypeFullName = "BkfCnyksRntdMWqKutrNDmKklsX", Member = "kkZUFmepoMvetrsAbIdaNqfeQZH")]
	[Calls(TypeFullName = "Rewired.Logger", Member = "LogError")]
	[Calls(Type = typeof(GamepadTemplateUI), Member = "ActivateElements")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void DrawActiveElements()
	{
	}

	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawActiveElements")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetCurrentInputSources")]
	[Calls(Type = typeof(Controller), Member = "GetTemplate")]
	[Calls(Type = typeof(ControllerElementTarget), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[Calls(Type = typeof(Player), Member = "GetNegativeButton")]
	[Calls(Type = typeof(ControllerUIElement), Member = "Activate")]
	[Calls(Type = typeof(GamepadTemplateUI), Member = "GetStick")]
	[Calls(Type = typeof(Stick), Member = "SetAxisPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void ActivateElements(Player player, int actionId)
	{
	}

	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "Start")]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "OnControllerConnected")]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "OnControllerDisconnected")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ControllerUIElement), Member = "ClearLabels")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(TypeFullName = "BkfCnyksRntdMWqKutrNDmKklsX", Member = "kkZUFmepoMvetrsAbIdaNqfeQZH")]
	[Calls(TypeFullName = "Rewired.Logger", Member = "LogError")]
	[Calls(Type = typeof(GamepadTemplateUI), Member = "DrawLabels")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void DrawLabels()
	{
	}

	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabels")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "GetFirstControllerWithTemplate")]
	[Calls(Type = typeof(Controller), Member = "GetTemplate")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[Calls(Type = typeof(GamepadTemplateUI), Member = "DrawLabel")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void DrawLabels(Player player, InputAction action)
	{
	}

	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabels")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ControllerMap), Member = "GetFirstElementMapWithElementTarget")]
	[Calls(Type = typeof(ControllerUIElement), Member = "SetLabel")]
	[Calls(Type = typeof(ControllerElementTarget), Member = ".ctor")]
	[Calls(Type = typeof(ControllerMap), Member = "GetFirstElementMapWithElementTarget")]
	[CallsUnknownMethods(Count = 17)]
	private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element)
	{
	}

	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "ActivateElements")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Stick GetStick(int elementId)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GamepadTemplateUI), Member = "DrawLabels")]
	private void OnControllerConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GamepadTemplateUI), Member = "DrawLabels")]
	private void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public GamepadTemplateUI()
	{
	}
}
