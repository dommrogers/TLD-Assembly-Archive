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
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
			get
			{
				return default(Vector2);
			}
			[CallsUnknownMethods(Count = 2)]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			set
			{
			}
		}

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
		[CalledBy(Type = typeof(GamepadTemplateUI), Member = "Awake")]
		[CalledBy(Type = typeof(GamepadTemplateUI), Member = "Awake")]
		[CallsUnknownMethods(Count = 1)]
		public Stick(RectTransform transform, int xAxisElementId, int yAxisElementId)
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void Reset()
		{
		}

		[CallerCount(Count = 0)]
		public bool ContainsElement(int elementId)
		{
			return default(bool);
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
		[CalledBy(Type = typeof(GamepadTemplateUI), Member = "ActivateElements")]
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

	[CallsUnknownMethods(Count = 104)]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerConnectedEvent")]
	[Calls(Type = typeof(Stick), Member = ".ctor")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerDisconnectedEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stick), Member = ".ctor")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GamepadTemplateUI), Member = "DrawLabels")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "remove_ControllerConnectedEvent")]
	[Calls(Type = typeof(ReInput), Member = "remove_ControllerDisconnectedEvent")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ControllerUIElement), Member = "Deactivate")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(BkfCnyksRntdMWqKutrNDmKklsX), Member = "kkZUFmepoMvetrsAbIdaNqfeQZH")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(GamepadTemplateUI), Member = "ActivateElements")]
	[CallsUnknownMethods(Count = 5)]
	private void DrawActiveElements()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawActiveElements")]
	[Calls(Type = typeof(GamepadTemplateUI), Member = "GetStick")]
	[Calls(Type = typeof(ControllerUIElement), Member = "Activate")]
	[Calls(Type = typeof(Player), Member = "GetNegativeButton")]
	[Calls(Type = typeof(Stick), Member = "SetAxisPosition")]
	[Calls(Type = typeof(ControllerElementTarget), Member = ".ctor")]
	[Calls(Type = typeof(Player), Member = "GetCurrentInputSources")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	private void ActivateElements(Player player, int actionId)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "OnControllerDisconnected")]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "OnControllerConnected")]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "Start")]
	[Calls(Type = typeof(GamepadTemplateUI), Member = "DrawLabels")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ControllerUIElement), Member = "ClearLabels")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BkfCnyksRntdMWqKutrNDmKklsX), Member = "kkZUFmepoMvetrsAbIdaNqfeQZH")]
	private void DrawLabels()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabels")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[Calls(Type = typeof(GamepadTemplateUI), Member = "DrawLabel")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "GetFirstControllerWithTemplate")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	private void DrawLabels(Player player, InputAction action)
	{
	}

	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabels")]
	[Calls(Type = typeof(ControllerMap), Member = "GetFirstElementMapWithElementTarget")]
	[Calls(Type = typeof(ControllerUIElement), Member = "SetLabel")]
	[Calls(Type = typeof(ControllerMap), Member = "GetFirstElementMapWithElementTarget")]
	[Calls(Type = typeof(ControllerMap), Member = "GetFirstElementMapWithElementTarget")]
	[Calls(Type = typeof(ControllerElementTarget), Member = ".ctor")]
	[Calls(Type = typeof(ControllerElementTarget), Member = ".ctor")]
	[Calls(Type = typeof(ControllerMap), Member = "GetFirstElementMapWithElementTarget")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(ControllerMap), Member = "GetFirstElementMapWithElementTarget")]
	[Calls(Type = typeof(ControllerUIElement), Member = "SetLabel")]
	[Calls(Type = typeof(ControllerMap), Member = "GetFirstElementMapWithElementTarget")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ControllerUIElement), Member = "SetLabel")]
	private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "ActivateElements")]
	[CallerCount(Count = 1)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public GamepadTemplateUI()
	{
	}
}
