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
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CMoveTextEnd_NextFrame_003Ed__16(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsoleGUI), Member = "MaybeInstantiateEventSystem")]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[Calls(Type = typeof(uConsoleGUI), Member = "UpdateUIDimensions")]
	[Calls(Type = typeof(uConsoleGUI), Member = "UpdateUIWithCustomizationSettings")]
	[Calls(Type = typeof(uConsoleGUI), Member = "Animate")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void ScrollLogDownMax()
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogDown")]
	[CalledBy(Type = typeof(uConsoleLog), Member = "Add")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsole), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "ClearLogAndHistory")]
	public void RefreshLogText()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "SubmitCommand")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputField), Member = "ActivateInputField")]
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

	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "SubmitCommand")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel")]
	public void InputFieldClearText()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "SetText")]
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

	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(uConsoleGUI), Member = "CalculatePixelsMovedForAnimation")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(uConsoleGUI), Member = "CalculatePixelsMovedForAnimation")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition")]
	private void Animate(float deltaTimeSeconds)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Animate")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Animate")]
	[CallsUnknownMethods(Count = 2)]
	private float CalculatePixelsMovedForAnimation(float deltaSeconds, float fullAnimateSeconds)
	{
		return default(float);
	}

	[Calls(Type = typeof(Graphic), Member = "get_rectTransform")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform")]
	[Calls(Type = typeof(uConsoleGUI), Member = "GetInputFieldHeightInPixels")]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors")]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors")]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsoleGUI), Member = "GetInputFieldHeightInPixels")]
	private void UpdateUIDimensions()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "UpdateUIDimensions")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "UpdateUIDimensions")]
	private float GetInputFieldHeightInPixels()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Text), Member = "set_font")]
	[Calls(Type = typeof(Text), Member = "set_font")]
	[Calls(Type = typeof(Selectable), Member = "get_image")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateUIWithCustomizationSettings()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private int ComputeMaxDisplayLinesForLog()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventSystem), Member = "get_current")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeInstantiateEventSystem()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[CallerCount(Count = 0)]
	private void MaybeDeactivateInputField()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public uConsoleGUI()
	{
	}
}
