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
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Initialize()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	[Calls(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[Calls(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsole), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	public static void DoFrame()
	{
	}

	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldClearText")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldSetFocus")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	private static void SubmitCommand()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessAutoCompleteInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(uConsole), Member = "CommandIsUnabmiguousAutoComplete")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestCompletion")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayPossibleMatches")]
	private static void AutoComplete()
	{
	}

	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetLine")]
	private static void RecallCommandUp()
	{
	}

	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessHistoryInput")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetNumLines")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsoleHistory), Member = "GetLine")]
	private static void RecallCommandDown()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldClearText")]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[Calls(Type = typeof(InputField), Member = "SetText")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldSetFocus")]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField")]
	[Calls(Type = typeof(uConsole), Member = "TurnOff")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private static void ProcessActivationInput()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldSetFocus")]
	[Calls(Type = typeof(uConsoleGUI), Member = "InputFieldClearText")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	private static void ProcessSubmitInput()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void ProcessAutoCompleteInput()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[Calls(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[Calls(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[Calls(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[CallsUnknownMethods(Count = 14)]
	private static void ProcessHistoryInput()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "DoFrame")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[Calls(Type = typeof(uConsoleLog), Member = "GetNumLines")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	private static void ProcessLogInput()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public uConsoleInput()
	{
	}
}
