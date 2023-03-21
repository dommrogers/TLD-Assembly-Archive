using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class uConsoleGUI : MonoBehaviour
{
	private sealed class _003CMoveTextEnd_NextFrame_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uConsoleGUI _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 53)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 53)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CMoveTextEnd_NextFrame_003Ed__16(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public GameObject m_ConsoleEventSystem;

	public RectTransform m_PanelRectTransform;

	public Image m_PanelImage;

	public Text m_LogText;

	public InputField m_InputField;

	public Text m_InputFieldText;

	private RectTransform m_InputFieldRectTransform;

	private int m_LogScrollOffset;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsoleGUI), Member = "MaybeInstantiateEventSystem")]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[Calls(Type = typeof(uConsoleGUI), Member = "UpdateUIDimensions")]
	[Calls(Type = typeof(uConsoleGUI), Member = "UpdateUIWithCustomizationSettings")]
	[Calls(Type = typeof(uConsoleGUI), Member = "Animate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	public void ScrollLogUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	public void ScrollLogDown()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ScrollLogUpMax()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ScrollLogDownMax()
	{
	}

	[CalledBy(Type = typeof(uConsole), Member = "Start")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "ClearLogAndHistory")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogDown")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleLog), Member = "Add")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public void RefreshLogText()
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "SubmitCommand")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputField), Member = "ActivateInputField")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void InputFieldSetFocus()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveTextEnd_NextFrame_003Ed__16))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator MoveTextEnd_NextFrame()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string InputFieldGetText()
	{
		return null;
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "SubmitCommand")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(InputField), Member = "get_compositionString")]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 1)]
	public void InputFieldClearText()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[CallsUnknownMethods(Count = 1)]
	public void InputFieldSetText(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[CallsUnknownMethods(Count = 1)]
	public void InputFieldMoveCaretToEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[CallsUnknownMethods(Count = 1)]
	public void InputFieldDeactivate()
	{
	}

	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(uConsoleGUI), Member = "CalculatePixelsMovedForAnimation")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Animate(float deltaTimeSeconds)
	{
	}

	[CalledBy(Type = typeof(uConsoleGUI), Member = "Animate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float CalculatePixelsMovedForAnimation(float deltaSeconds, float fullAnimateSeconds)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors")]
	[Calls(Type = typeof(uConsoleGUI), Member = "GetInputFieldHeightInPixels")]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateUIDimensions()
	{
	}

	[CalledBy(Type = typeof(uConsoleGUI), Member = "UpdateUIDimensions")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private float GetInputFieldHeightInPixels()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Text), Member = "set_font")]
	[Calls(Type = typeof(Selectable), Member = "get_image")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateUIWithCustomizationSettings()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private int ComputeMaxDisplayLinesForLog()
	{
		return 0;
	}

	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventSystem), Member = "get_current")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeInstantiateEventSystem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeDeactivateInputField()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public uConsoleGUI()
	{
	}
}
