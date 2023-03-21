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

public class SimpleCombinedKeyboardMouseRemapping : MonoBehaviour
{
	private class Row
	{
		public InputAction action;

		public AxisRange actionRange;

		public Button button;

		public Text text;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public Row()
		{
		}
	}

	private struct TargetMapping
	{
		public ControllerMap controllerMap;

		public int actionElementMapId;
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public int index;

		public int actionElementMapId;

		public SimpleCombinedKeyboardMouseRemapping _003C_003E4__this;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "OnInputFieldClicked")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal void _003CRedrawUI_003Eb__0()
		{
		}
	}

	private sealed class _003CStartListeningDelayed_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimpleCombinedKeyboardMouseRemapping _003C_003E4__this;

		public int index;

		public ControllerMap keyboardMap;

		public int actionElementMapToReplaceId;

		public ControllerMap mouseMap;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CStartListeningDelayed_003Ed__22(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(InputMapper.Context), Member = "SWLfEyFPXLJuehSGNwYFDCbdZpfB")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetMapsEnabled")]
		[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "get_player")]
		[Calls(Type = typeof(InputMapper), Member = "Start")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_actionElementMapToReplace")]
		[Calls(Type = typeof(InputMapper), Member = "Start")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_controllerMap")]
		[CallsUnknownMethods(Count = 40)]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_actionElementMapToReplace")]
		[Calls(Type = typeof(InputMapper.Context), Member = "SWLfEyFPXLJuehSGNwYFDCbdZpfB")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_controllerMap")]
		[Calls(Type = typeof(InputMapper.Context), Member = "SWLfEyFPXLJuehSGNwYFDCbdZpfB")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputMapper.Context), Member = "SWLfEyFPXLJuehSGNwYFDCbdZpfB")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
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

	private InputMapper inputMapper_keyboard;

	private InputMapper inputMapper_mouse;

	public GameObject buttonPrefab;

	public GameObject textPrefab;

	public RectTransform fieldGroupTransform;

	public RectTransform actionGroupTransform;

	public Text controllerNameUIText;

	public Text statusUIText;

	private List<Row> rows;

	private TargetMapping _replaceTargetMapping;

	private Player player
	{
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(_003CStartListeningDelayed_003Ed__22), Member = "MoveNext")]
		[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "OnStopped")]
		[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "OnInputFieldClicked")]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "RedrawUI")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "OnInputFieldClicked")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(InputMapper), Member = "add_InputMappedEvent")]
	[Calls(Type = typeof(InputMapper), Member = "add_StoppedEvent")]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[Calls(Type = typeof(InputMapper), Member = "add_StoppedEvent")]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "InitializeUI")]
	[Calls(Type = typeof(InputMapper), Member = "add_InputMappedEvent")]
	[CallsUnknownMethods(Count = 49)]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputMapper), Member = "RemoveAllEventListeners")]
	[Calls(Type = typeof(InputMapper), Member = "RemoveAllEventListeners")]
	[Calls(Type = typeof(InputMapper), Member = "Stop")]
	[Calls(Type = typeof(InputMapper), Member = "Stop")]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 43)]
	[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "OnInputMapped")]
	[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "InitializeUI")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveAllListeners")]
	[Calls(Type = typeof(ControllerMap), Member = "ElementMapsWithAction")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "get_player")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ActionElementMap), Member = "ShowInField")]
	private void RedrawUI()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	private void ClearUI()
	{
	}

	[Calls(Type = typeof(InputAction), Member = "get_positiveDescriptiveName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "CreateUIRow")]
	[Calls(Type = typeof(InputAction), Member = "get_negativeDescriptiveName")]
	[Calls(Type = typeof(InputAction), Member = "get_negativeDescriptiveName")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "CreateUIRow")]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "RedrawUI")]
	[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "OnEnable")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputAction), Member = "get_positiveDescriptiveName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "CreateUIRow")]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "CreateUIRow")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(UserData), Member = "NWgAhTEOiqTFONpHuYAsYowsME")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void InitializeUI()
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 16)]
	[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "InitializeUI")]
	[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "InitializeUI")]
	[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "InitializeUI")]
	[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "InitializeUI")]
	private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
	{
	}

	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "StartListeningDelayed")]
	[Calls(Type = typeof(ControllerMap), Member = "ContainsElementMap")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(ControllerMap), Member = "ContainsElementMap")]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass17_0), Member = "<RedrawUI>b__0")]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "get_player")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[CallerCount(Count = 1)]
	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "OnInputFieldClicked")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "RedrawUI")]
	[Calls(Type = typeof(InputMapper), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = "Stop")]
	private void OnInputMapped(InputMapper.InputMappedEventData data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetMapsEnabled")]
	[CallsUnknownMethods(Count = 4)]
	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputMapper), Member = ".ctor")]
	[Calls(Type = typeof(InputMapper), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SimpleCombinedKeyboardMouseRemapping()
	{
	}
}
