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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
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
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CStartListeningDelayed_003Ed__28(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_actionId")]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_controllerMap")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_actionRange")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_actionElementMapToReplace")]
		[Calls(Type = typeof(InputMapper), Member = "Start")]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_player")]
		[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetMapsEnabled")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
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
		[CalledBy(Type = typeof(_003CStartListeningDelayed_003Ed__28), Member = "MoveNext")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "SetSelectedController")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private ControllerMap controllerMap
	{
		[CalledBy(Type = typeof(_003CStartListeningDelayed_003Ed__28), Member = "MoveNext")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[Calls(Type = typeof(Controller), Member = "get_type")]
		[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private Controller controller
	{
		[CalledBy(Type = typeof(_003C_003Ec__DisplayClass21_0), Member = "<RedrawUI>b__0")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnInputFieldClicked")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[Calls(Type = typeof(Player.ControllerHelper), Member = "GetController")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerConnectedEvent")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerDisconnectedEvent")]
	[Calls(Type = typeof(InputMapper), Member = "add_InputMappedEvent")]
	[Calls(Type = typeof(InputMapper), Member = "add_StoppedEvent")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "Rewired.InputMapper.KFfTdKEYHyKIWgtQchMdsiMvqor", Member = "cLsgLNiZfZLdTfDERXbrfQHXqTPc")]
	[Calls(Type = typeof(InputMapper), Member = "RemoveAllEventListeners")]
	[Calls(Type = typeof(ReInput), Member = "remove_ControllerConnectedEvent")]
	[Calls(Type = typeof(ReInput), Member = "remove_ControllerDisconnectedEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "SetSelectedController")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnInputMapped")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
	[Calls(Type = typeof(ControllerMap), Member = "ElementMapsWithAction")]
	[Calls(Type = typeof(ActionElementMap), Member = "ShowInField")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveAllListeners")]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	private void RedrawUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void ClearUI()
	{
	}

	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(UserData), Member = "GIRDqTjLRaEIriZdEiTFKTpCEtce")]
	[Calls(TypeFullName = "Rewired.Logger", Member = "LogError")]
	[Calls(TypeFullName = "Rewired.Utils.EmptyObjects`1", Member = "get_EmptyReadOnlyIListT")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "CreateUIRow")]
	[Calls(Type = typeof(InputAction), Member = "get_positiveDescriptiveName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputAction), Member = "get_negativeDescriptiveName")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 38)]
	private void InitializeUI()
	{
	}

	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 10)]
	private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
	{
	}

	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnControllerSelected")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnControllerChanged")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(TypeFullName = "Rewired.InputMapper.KFfTdKEYHyKIWgtQchMdsiMvqor", Member = "cLsgLNiZfZLdTfDERXbrfQHXqTPc")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
	[CallsUnknownMethods(Count = 2)]
	private void SetSelectedController(ControllerType controllerType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "SetSelectedController")]
	public void OnControllerSelected(int controllerType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
	{
	}

	[IteratorStateMachine(typeof(_003CStartListeningDelayed_003Ed__28))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetMapsEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SimpleControlRemapping()
	{
	}
}
