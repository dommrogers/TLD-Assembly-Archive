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
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DeduplicatedMethod]
			[DebuggerHidden]
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

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
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
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(uConsoleGUI), Member = "Animate")]
	[Calls(Type = typeof(uConsoleGUI), Member = "UpdateUIWithCustomizationSettings")]
	[Calls(Type = typeof(uConsoleGUI), Member = "UpdateUIDimensions")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsoleGUI), Member = "MaybeInstantiateEventSystem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	private void Update()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogDown")]
	[CalledBy(Type = typeof(uConsoleLog), Member = "Add")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[Calls(Type = typeof(uConsoleLog), Member = "GetLine")]
	[CalledBy(Type = typeof(uConsole), Member = "Start")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "ClearLogAndHistory")]
	public void RefreshLogText()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "SubmitCommand")]
	[Calls(Type = typeof(InputField), Member = "ActivateInputField")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(uConsoleGUI), Member = "MoveTextEnd_NextFrame")]
	public void InputFieldSetFocus()
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "InputFieldSetFocus")]
	[CallsUnknownMethods(Count = 7)]
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
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "SubmitCommand")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[CallerCount(Count = 0)]
	public void InputFieldDeactivate()
	{
	}

	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition")]
	[CallsUnknownMethods(Count = 18)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition")]
	private void Animate(float deltaTimeSeconds)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Animate")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Animate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private float CalculatePixelsMovedForAnimation(float deltaSeconds, float fullAnimateSeconds)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors")]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors")]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors")]
	[Calls(Type = typeof(uConsoleGUI), Member = "GetInputFieldHeightInPixels")]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors")]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform")]
	[Calls(Type = typeof(uConsoleGUI), Member = "GetInputFieldHeightInPixels")]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateUIDimensions()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "UpdateUIDimensions")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "UpdateUIDimensions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private float GetInputFieldHeightInPixels()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Text), Member = "set_font")]
	[Calls(Type = typeof(Text), Member = "set_font")]
	[Calls(Type = typeof(Selectable), Member = "get_image")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[CallsUnknownMethods(Count = 21)]
	private void UpdateUIWithCustomizationSettings()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private int ComputeMaxDisplayLinesForLog()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventSystem), Member = "get_current")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeInstantiateEventSystem()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeDeactivateInputField()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public uConsoleGUI()
	{
	}
}
