using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class uConsole : MonoBehaviour
{
	public delegate void DebugCommand();

	public delegate object DebugCommandReturn();

	public struct CommandDelegate
	{
		private DebugCommand m_Command;

		private DebugCommandReturn m_CommandReturn;

		[CalledBy(Type = typeof(uConsole), Member = "RegisterCommand")]
		[CalledBy(Type = typeof(uConsole), Member = "RegisterCommand")]
		[CallerCount(Count = 2)]
		public CommandDelegate(DebugCommand cmd)
		{
		}

		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
		[CalledBy(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
		public CommandDelegate(DebugCommandReturn cmd)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool IsValid()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public object Call()
		{
			return null;
		}
	}

	public float m_ConsoleHeightNormalized;

	public float m_SecondsToAnimateDown;

	public float m_SecondsToAnimateUp;

	public int m_MaxHistoryLines;

	public int m_MaxLogLines;

	public bool m_DoNotDestroy;

	public bool m_LogUnityMessages;

	public bool m_ForceUnityLegacyGUI;

	public Font m_LogFont;

	public int m_LogFontSize;

	public Color m_LogBackGroundColor;

	public Color m_LogFontColor;

	public int m_LogXOffset;

	public int m_LogYOffsetFromTopOfInputField;

	public Font m_InputFieldFont;

	public int m_InputFieldFontSize;

	public Color m_InputFieldBackGroundColor;

	public Color m_InputFieldFontColor;

	public int m_InputFieldXOffset;

	public int m_InputFieldPaddedPixelsTop;

	public int m_InputFieldPaddedPixelsBottom;

	public KeyCode m_Activate;

	public KeyCode m_Submit;

	public KeyCode m_AutoComplete;

	public KeyCode m_HistoryUp;

	public KeyCode m_HistoryDown;

	public KeyCode m_ScrollLogUp;

	public KeyCode m_ScrollLogDown;

	public static uConsole m_Instance;

	public static uConsoleGUI m_GUI;

	public static Dictionary<string, CommandDelegate> m_CommandsDict;

	public static List<string> m_CommandsList;

	public static Dictionary<string, string> m_CommandsHelp;

	public static string m_Version;

	private static List<string> m_Argv;

	private static int m_IndexOfNextArgToProcess;

	private static bool m_On;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Application.LogCallback), Member = ".ctor")]
	[Calls(Type = typeof(Application), Member = "add_logMessageReceived")]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[Calls(Type = typeof(uConsole), Member = "InstantiateGUIPrefab")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsoleHistory), Member = "Restore")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsoleInput), Member = "DoFrame")]
	private void Update()
	{
	}

	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(CommandDelegate), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsole), Member = "CommandAlreadyRegistered")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 472)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void RegisterCommand(string command, DebugCommand commandCallback)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(CommandDelegate), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(uConsole), Member = "CommandAlreadyRegistered")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void RegisterCommand(string command, string help, DebugCommand commandCallback)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "RegisterCommands")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "RegisterCommands")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "RegisterCommands")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "RegisterCommands")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "RegisterCommands")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "RegisterCommands")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "RegisterCommands")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(CommandDelegate), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(uConsole), Member = "CommandAlreadyRegistered")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static void RegisterCommandReturn(string command, DebugCommandReturn commandCallback)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(CommandDelegate), Member = ".ctor")]
	[Calls(Type = typeof(uConsole), Member = "CommandAlreadyRegistered")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void RegisterCommandReturn(string command, string help, DebugCommandReturn commandCallback)
	{
	}

	[CalledBy(Type = typeof(ExampleCommands), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ExampleCommands), Member = "OnDestroy")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "OnDestroy")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "OnDestroy")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "OnDestroy")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "OnDestroy")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void UnRegisterCommand(string command)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "SubmitCommand")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_add")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ResetBadgeProgress4DON")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "CompleteTimer4DON")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "TransitionToDay4DON")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "OverrideDay4DON")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "Toggle4DON")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "OverrideDay4DON")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(uConsoleHistory), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(uConsole), Member = "BuildArgListFromTokens")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "Toggle4DON")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static object RunCommand(string commandWithArgs)
	{
		return null;
	}

	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(uConsole), Member = "BuildArgListFromTokens")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Split")]
	public static object RunCommandSilent(string commandWithArgs)
	{
		return null;
	}

	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	public static void Log(string text)
	{
	}

	[CallerCount(Count = 0)]
	public static void TurnOn()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	public static void TurnOff()
	{
	}

	[CallerCount(Count = 0)]
	public static bool IsOn()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "ParameterIsRegistered")]
	[Calls(Type = typeof(uConsole), Member = "CommandIsRegistered")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "CommandIsRegistered")]
	public static bool CommandIsUnabmiguousAutoComplete(string command)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(uConsoleCommands), Member = "ShowHelp")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "SearchForCommand")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "ShowHelp")]
	[CallsUnknownMethods(Count = 1)]
	public static void ShowHelp(string command)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 113)]
	public static int GetNumParameters()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CallsUnknownMethods(Count = 8)]
	public static List<string> GetAllParameters()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallerCount(Count = 145)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static bool NextParameterIsBool()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 154)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static bool GetBool()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_gear_add_type")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_sleep_length")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_unlock")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_autosave")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[CallerCount(Count = 4)]
	public static bool NextParameterIsInt()
	{
		return default(bool);
	}

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static int GetInt()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_texel_density")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shake_camera")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shake_camera")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shake_camera")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shake_camera")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_object_hp_percent")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_set")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shake_camera")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_addspace")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_speed")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_debug_position")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_aurora_duration")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_countdown")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_breakdown_all")]
	public static bool NextParameterIsFloat()
	{
		return default(bool);
	}

	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public static float GetFloat()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(uConsole), Member = "TryGetVector3")]
	[CalledBy(Type = typeof(uConsole), Member = "TryGetVector3")]
	[CalledBy(Type = typeof(uConsole), Member = "TryGetVector3")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	public static bool TryGetFloat(out float f)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref f) = null;
		return default(bool);
	}

	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	public static bool TryGetVector3(out Vector3 v)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref v) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool NextParameterExists()
	{
		return default(bool);
	}

	[CallerCount(Count = 117)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsoleHistory), Member = "Save")]
	[Calls(Type = typeof(uConsoleLog), Member = "Save")]
	private void OnApplicationQuit()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private static void BuildArgListFromTokens(string[] tokens)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[CalledBy(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[CalledBy(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CalledBy(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	private static bool CommandAlreadyRegistered(string command)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(uConsole), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Addressables), Member = "InstantiateAsync")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void InstantiateGUIPrefab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "CommandIsRegistered")]
	[Calls(Type = typeof(uConsole), Member = "ParameterIsRegistered")]
	private static bool CommandAndParameterRegistered(string command, string parameter)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CalledBy(Type = typeof(uConsole), Member = "CommandAndParameterRegistered")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CalledBy(Type = typeof(uConsole), Member = "CommandIsUnabmiguousAutoComplete")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(uConsole), Member = "CommandIsUnabmiguousAutoComplete")]
	private static bool CommandIsRegistered(string command)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(uConsole), Member = "CommandAndParameterRegistered")]
	[CalledBy(Type = typeof(uConsole), Member = "CommandIsUnabmiguousAutoComplete")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private static bool ParameterIsRegistered(string command, string parameter)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public uConsole()
	{
	}
}
