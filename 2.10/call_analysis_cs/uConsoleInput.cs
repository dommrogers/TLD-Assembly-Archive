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
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	[Calls(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessAutoCompleteInput")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestCompletion")]
	[Calls(Type = typeof(uConsole), Member = "CommandIsUnabmiguousAutoComplete")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayPossibleMatches")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[CallsUnknownMethods(Count = 1)]
	private static void AutoComplete()
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetLine")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[CallsUnknownMethods(Count = 1)]
	private static void RecallCommandUp()
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetLine")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[CallsUnknownMethods(Count = 1)]
	private static void RecallCommandDown()
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "TurnOff")]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldSetFocus")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldClearText")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static void ProcessActivationInput()
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldSetFocus")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldClearText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void ProcessSubmitInput()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void ProcessAutoCompleteInput()
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[Calls(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	private static void ProcessHistoryInput()
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 15)]
	private static void ProcessLogInput()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public uConsoleInput()
	{
	}
}
