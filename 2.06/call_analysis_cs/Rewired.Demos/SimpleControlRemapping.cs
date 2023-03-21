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

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "OnInputFieldClicked")]
		[CallerCount(Count = 0)]
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
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
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

		[CallsUnknownMethods(Count = 12)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetMapsEnabled")]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_player")]
		[Calls(Type = typeof(InputMapper), Member = "Start")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_actionElementMapToReplace")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_controllerMap")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_actionRange")]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_actionId")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
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
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
		[CalledBy(Type = typeof(_003CStartListeningDelayed_003Ed__28), Member = "MoveNext")]
		[CalledBy(Type = typeof(_003CStartListeningDelayed_003Ed__28), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Controller), Member = "get_type")]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
		get
		{
			return null;
		}
	}

	private Controller controller
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnInputFieldClicked")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
		[Calls(Type = typeof(Player.ControllerHelper), Member = "GetController")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
		[CalledBy(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ReInput), Member = "add_ControllerConnectedEvent")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	[Calls(Type = typeof(InputMapper), Member = "add_StoppedEvent")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerDisconnectedEvent")]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ReInput), Member = "remove_ControllerDisconnectedEvent")]
	[Calls(Type = typeof(InputMapper), Member = "RemoveAllEventListeners")]
	[Calls(Type = typeof(ReInput), Member = "remove_ControllerConnectedEvent")]
	[Calls(Type = typeof(InputMapper.KFfTdKEYHyKIWgtQchMdsiMvqor), Member = "EqPgiPmfSOBssCubKMDkHibjeil")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper.KFfTdKEYHyKIWgtQchMdsiMvqor), Member = "phyIjntGRGdruzJQpjVunAYjwjK")]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Events.InvokableCallList), Member = "Clear")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnInputMapped")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "SetSelectedController")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener")]
	[CallsUnknownMethods(Count = 54)]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(ControllerMap), Member = "ElementMapsWithAction")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controllerMap")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ActionElementMap), Member = "ShowInField")]
	private void RedrawUI()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void ClearUI()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 45)]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnEnable")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "CreateUIRow")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputAction), Member = "get_negativeDescriptiveName")]
	[Calls(Type = typeof(InputAction), Member = "get_negativeDescriptiveName")]
	[Calls(Type = typeof(InputAction), Member = "get_positiveDescriptiveName")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "CreateUIRow")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "CreateUIRow")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "CreateUIRow")]
	[Calls(Type = typeof(UserData), Member = "GIRDqTjLRaEIriZdEiTFKTpCEtce")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputAction), Member = "get_positiveDescriptiveName")]
	private void InitializeUI()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "InitializeUI")]
	private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
	{
	}

	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnControllerChanged")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(InputMapper), Member = "Stop")]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
	[CalledBy(Type = typeof(SimpleControlRemapping), Member = "OnControllerSelected")]
	[CallsUnknownMethods(Count = 2)]
	private void SetSelectedController(ControllerType controllerType)
	{
	}

	[Calls(Type = typeof(SimpleControlRemapping), Member = "SetSelectedController")]
	[CallerCount(Count = 0)]
	public void OnControllerSelected(int controllerType)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "get_controller")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass21_0), Member = "<RedrawUI>b__0")]
	[CallsUnknownMethods(Count = 6)]
	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
	{
	}

	[IteratorStateMachine(typeof(_003CStartListeningDelayed_003Ed__28))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleControlRemapping), Member = "SetSelectedController")]
	private void OnControllerChanged(ControllerStatusChangedEventArgs args)
	{
	}

	[Calls(Type = typeof(SimpleControlRemapping), Member = "RedrawUI")]
	[CallerCount(Count = 0)]
	private void OnInputMapped(InputMapper.InputMappedEventData data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetMapsEnabled")]
	[CallsUnknownMethods(Count = 1)]
	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputMapper), Member = ".ctor")]
	[CallsUnknownMethods(Count = 11)]
	public SimpleControlRemapping()
	{
	}
}
