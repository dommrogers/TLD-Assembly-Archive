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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(uConsole), Member = "Update")]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[Calls(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	public static void DoFrame()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldSetFocus")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldClearText")]
	[CallsUnknownMethods(Count = 1)]
	private static void SubmitCommand()
	{
	}

	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessAutoCompleteInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestCompletion")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(uConsole), Member = "CommandIsUnabmiguousAutoComplete")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayPossibleMatches")]
	private static void AutoComplete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetLine")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	private static void RecallCommandUp()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetLine")]
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
	[Calls(Type = typeof(string), Member = "Contains")]
	private static void ProcessActivationInput()
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldClearText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldSetFocus")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	private static void ProcessHistoryInput()
	{
	}

	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	private static void ProcessLogInput()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public uConsoleInput()
	{
	}
}
