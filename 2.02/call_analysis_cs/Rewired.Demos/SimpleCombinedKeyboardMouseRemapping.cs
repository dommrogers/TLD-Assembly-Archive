using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
		[CallerCount(Count = 7)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "OnInputFieldClicked")]
		[CallsUnknownMethods(Count = 1)]
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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
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
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputMapper.Context), Member = "SWLfEyFPXLJuehSGNwYFDCbdZpfB")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_controllerMap")]
		[Calls(Type = typeof(InputMapper.Context), Member = "set_actionElementMapToReplace")]
		[Calls(Type = typeof(InputMapper), Member = "Start")]
		[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "get_player")]
		[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetMapsEnabled")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 40)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
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
		[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "RedrawUI")]
		[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "OnInputFieldClicked")]
		[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "OnStopped")]
		[CalledBy(Type = typeof(_003CStartListeningDelayed_003Ed__22), Member = "MoveNext")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[Calls(Type = typeof(InputMapper), Member = "add_InputMappedEvent")]
	[Calls(Type = typeof(InputMapper), Member = "add_StoppedEvent")]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "InitializeUI")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 49)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = "Stop")]
	[Calls(Type = typeof(InputMapper), Member = "RemoveAllEventListeners")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "InitializeUI")]
	[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "OnInputMapped")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[Calls(Type = typeof(ControllerMap), Member = "ElementMapsWithAction")]
	[Calls(Type = typeof(ActionElementMap), Member = "ShowInField")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveAllListeners")]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 43)]
	private void RedrawUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void ClearUI()
	{
	}

	[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(UserData), Member = "NWgAhTEOiqTFONpHuYAsYowsME")]
	[Calls(TypeFullName = "Rewired.Utils.EmptyObjects`1", Member = "get_EmptyReadOnlyIListT")]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "CreateUIRow")]
	[Calls(Type = typeof(InputAction), Member = "get_positiveDescriptiveName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputAction), Member = "get_negativeDescriptiveName")]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "RedrawUI")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 32)]
	private void InitializeUI()
	{
	}

	[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "InitializeUI")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 24)]
	private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
	{
	}

	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass17_0), Member = "<RedrawUI>b__0")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[Calls(Type = typeof(ControllerMap), Member = "ContainsElementMap")]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "StartListeningDelayed")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
	{
	}

	[CalledBy(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "OnInputFieldClicked")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = "Stop")]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "RedrawUI")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnInputMapped(InputMapper.InputMappedEventData data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCombinedKeyboardMouseRemapping), Member = "get_player")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetMapsEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public SimpleCombinedKeyboardMouseRemapping()
	{
	}
}
