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
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 28)]
			[DebuggerHidden]
			[DeduplicatedMethod]
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

		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(uConsoleGUI), Member = "UpdateUIWithCustomizationSettings")]
	[Calls(Type = typeof(uConsoleGUI), Member = "Animate")]
	[Calls(Type = typeof(uConsoleGUI), Member = "UpdateUIDimensions")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsoleGUI), Member = "MaybeInstantiateEventSystem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	private void Update()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	public void ScrollLogUp()
	{
	}

	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(uConsoleLog), Member = "Add")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogDown")]
	[CalledBy(Type = typeof(uConsole), Member = "Start")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "ClearLogAndHistory")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	public void RefreshLogText()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "SubmitCommand")]
	[Calls(Type = typeof(InputField), Member = "ActivateInputField")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	public void InputFieldSetFocus()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveTextEnd_NextFrame_003Ed__16))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator MoveTextEnd_NextFrame()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string InputFieldGetText()
	{
		return null;
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	[Calls(Type = typeof(InputField), Member = "get_compositionString")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "SubmitCommand")]
	[CallerCount(Count = 3)]
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

	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void InputFieldDeactivate()
	{
	}

	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(uConsoleGUI), Member = "CalculatePixelsMovedForAnimation")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(uConsoleGUI), Member = "CalculatePixelsMovedForAnimation")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void Animate(float deltaTimeSeconds)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Animate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Animate")]
	private float CalculatePixelsMovedForAnimation(float deltaSeconds, float fullAnimateSeconds)
	{
		return default(float);
	}

	[Calls(Type = typeof(Graphic), Member = "get_rectTransform")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform")]
	[Calls(Type = typeof(uConsoleGUI), Member = "GetInputFieldHeightInPixels")]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors")]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors")]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors")]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsoleGUI), Member = "GetInputFieldHeightInPixels")]
	private void UpdateUIDimensions()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "UpdateUIDimensions")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "UpdateUIDimensions")]
	[CallsUnknownMethods(Count = 1)]
	private float GetInputFieldHeightInPixels()
	{
		return default(float);
	}

	[Calls(Type = typeof(Text), Member = "set_font")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[Calls(Type = typeof(Selectable), Member = "get_image")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Text), Member = "set_font")]
	private void UpdateUIWithCustomizationSettings()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private int ComputeMaxDisplayLinesForLog()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[Calls(Type = typeof(EventSystem), Member = "get_current")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
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
	[CallerCount(Count = 0)]
	public uConsoleGUI()
	{
	}
}
