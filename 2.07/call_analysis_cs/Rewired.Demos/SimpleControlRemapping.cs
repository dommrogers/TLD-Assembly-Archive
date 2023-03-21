using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Data;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rewired.Demos;

public class SimpleControlRemapping : MonoBehaviour
{
	private class Row
	{
		public InputAction action;

		public AxisRange actionRange;

		public Button button;

		public Text text;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public Row()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public int index;

		public int actionElementMapId;

		public SimpleControlRemapping _003C_003E4__this;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CRedrawUI_003Eb__0()
		{
		}
	}

	private sealed class _003CStartListeningDelayed_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimpleControlRemapping _003C_003E4__this;

		public int index;

		public int actionElementMapToReplaceId;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CStartListeningDelayed_003Ed__28(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_player")]
		[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetMapsEnabled")]
		[Calls(Type = typeof(InputMapper), Member = "Start")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_actionElementMapToReplace")]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_actionRange")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_controllerMap")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_actionId")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private const string category = "Default";

	private const string layout = "Default";

	private const string uiCategory = "UI";

	private InputMapper inputMapper;

	public GameObject buttonPrefab;

	public GameObject textPrefab;

	public RectTransform fieldGroupTransform;

	public RectTransform actionGroupTransform;

	public Text controllerNameUIText;

	public Text statusUIText;

	private ControllerType selectedControllerType;

	private int selectedControllerId;

	private List<Row> rows;

	private Player player
	{
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[CalledBy(Type = typeof(_003CStartListeningDelayed_003Ed__28), Member = "MoveNext")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "SetSelectedController")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private ControllerMap controllerMap
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
		[CalledBy(Type = typeof(_003CStartListeningDelayed_003Ed__28), Member = "MoveNext")]
		[CalledBy(Type = typeof(_003CStartListeningDelayed_003Ed__28), Member = "MoveNext")]
		[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
		[Calls(Type = typeof(Controller), Member = "get_type")]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		get
		{
			return null;
		}
	}

	private Controller controller
	{
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnInputFieldClicked")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
		[CalledBy(Type = typeof(_003C_003Ec__DisplayClass21_0), Member = "<RedrawUI>b__0")]
		[Calls(Type = typeof(Player.ControllerHelper), Member = "GetController")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	[Calls(Type = typeof(InputMapper), Member = "add_StoppedEvent")]
	[Calls(Type = typeof(InputMapper), Member = "add_InputMappedEvent")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerDisconnectedEvent")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerConnectedEvent")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "remove_ControllerDisconnectedEvent")]
	[Calls(Type = typeof(InputMapper), Member = "RemoveAllEventListeners")]
	[Calls(Type = typeof(ReInput), Member = "remove_ControllerConnectedEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper.KFfTdKEYHyKIWgtQchMdsiMvqor), Member = "cLsgLNiZfZLdTfDERXbrfQHXqTPc")]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(UnityEventBase), Member = "RemoveAllListeners")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnInputMapped")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "SetSelectedController")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(ControllerMap), Member = "ElementMapsWithAction")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ActionElementMap), Member = "ShowInField")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
	private void RedrawUI()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void ClearUI()
	{
	}

	[CallsUnknownMethods(Count = 38)]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnEnable")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "CreateUIRow")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputAction), Member = "get_negativeDescriptiveName")]
	[Calls(Type = typeof(InputAction), Member = "get_negativeDescriptiveName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputAction), Member = "get_positiveDescriptiveName")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "CreateUIRow")]
	[Calls(Type = typeof(InputAction), Member = "get_positiveDescriptiveName")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "CreateUIRow")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(UserData), Member = "GIRDqTjLRaEIriZdEiTFKTpCEtce")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "CreateUIRow")]
	private void InitializeUI()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnControllerChanged")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnControllerSelected")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
	[Calls(Type = typeof(InputMapper.KFfTdKEYHyKIWgtQchMdsiMvqor), Member = "cLsgLNiZfZLdTfDERXbrfQHXqTPc")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	private void SetSelectedController(ControllerType controllerType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "SetSelectedController")]
	public void OnControllerSelected(int controllerType)
	{
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(_003CStartListeningDelayed_003Ed__28))]
	private IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "SetSelectedController")]
	private void OnControllerChanged(ControllerStatusChangedEventArgs args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
	private void OnInputMapped(InputMapper.InputMappedEventData data)
	{
	}

	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetMapsEnabled")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputMapper), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public SimpleControlRemapping()
	{
	}
}
