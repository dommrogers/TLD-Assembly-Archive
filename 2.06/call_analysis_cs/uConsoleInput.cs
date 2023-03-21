using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.UI;

public class uConsoleInput
{
	public static bool m_ForceSubmit;

	public static bool m_ForceAutoComplete;

	public static bool m_ForceRecallUp;

	public static bool m_ForceRecallDown;

	public static bool m_ForceScrollLogUp;

	public static bool m_ForceScrollLogDown;

	public static char[] m_DelimterChars;

	private static int m_LastHistoryIndexRecalled;

	private static float m_TimeRecallUpPressed;

	private static float m_TimeRecallDownPressed;

	private static float m_TimeScrollUpPressed;

	private static float m_TimeScrollDownPressed;

	private static float m_CommandRepeatTimeSeconds;

	[CallerCount(Count = 0)]
	public static void Initialize()
	{
	}

	[CalledBy(Type = typeof(uConsole), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	[Calls(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CallsUnknownMethods(Count = 2)]
	public static void DoFrame()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldClearText")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldSetFocus")]
	private static void SubmitCommand()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayParametersStartingWithMatch")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessAutoCompleteInput")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(uConsole), Member = "CommandIsRegistered")]
	[Calls(Type = typeof(uConsole), Member = "CommandIsRegistered")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestMatchFromList")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(uConsole), Member = "ParameterIsRegistered")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestCommandWithParameterCompletion")]
	private static void AutoComplete()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetLine")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	private static void RecallCommandUp()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetLine")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	private static void RecallCommandDown()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldClearText")]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldSetFocus")]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[Calls(Type = typeof(uConsole), Member = "TurnOff")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private static void ProcessActivationInput()
	{
	}

	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldClearText")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldSetFocus")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	private static void ProcessSubmitInput()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallsUnknownMethods(Count = 2)]
	private static void ProcessAutoCompleteInput()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[Calls(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[Calls(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[Calls(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	private static void ProcessHistoryInput()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
	private static void ProcessLogInput()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public uConsoleInput()
	{
	}
}
