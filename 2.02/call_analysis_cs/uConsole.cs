using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

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
		[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 11)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[Calls(Type = typeof(uConsole), Member = "InstantiateGUIPrefab")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsoleHistory), Member = "Restore")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsoleInput), Member = "DoFrame")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(CommandDelegate), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(uConsole), Member = "CommandAlreadyRegistered")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 462)]
	public static void RegisterCommand(string command, DebugCommand commandCallback)
	{
	}

	[CalledBy(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(CommandDelegate), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(uConsole), Member = "CommandAlreadyRegistered")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void RegisterCommand(string command, string help, DebugCommand commandCallback)
	{
	}

	[CallsUnknownMethods(Count = 3)]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static void RegisterCommandReturn(string command, DebugCommandReturn commandCallback)
	{
	}

	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(uConsole), Member = "CommandAlreadyRegistered")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandDelegate), Member = ".ctor")]
	public static void RegisterCommandReturn(string command, string help, DebugCommandReturn commandCallback)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ExampleCommands), Member = "OnDestroy")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "OnDestroy")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "OnDestroy")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "OnDestroy")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "OnDestroy")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "OnDestroy")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void UnRegisterCommand(string command)
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "Toggle4DON")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "OverrideDay4DON")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "TransitionToDay4DON")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "CompleteTimer4DON")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ResetBadgeProgress4DON")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "SubmitCommand")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_add")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "Toggle4DON")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "OverrideDay4DON")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(uConsoleHistory), Member = "Add")]
	[Calls(Type = typeof(uConsole), Member = "BuildArgListFromTokens")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static object RunCommand(string commandWithArgs)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(uConsole), Member = "BuildArgListFromTokens")]
	public static object RunCommandSilent(string commandWithArgs)
	{
		return null;
	}

	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoBool")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoStrings")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoStrings")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoString")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoBool")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoInteger")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoNothing")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoFloat")]
	[CallerCount(Count = 10)]
	public static void Log(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void TurnOn()
	{
	}

	[CalledBy(Type = typeof(Action_LoadScene), Member = "OnExecute")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "LoadScene")]
	[CalledBy(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_location_reveal")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shake_camera")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_movie_alpha_ext")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_movie_alpha")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_movie")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene")]
	public static void TurnOff()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsOn()
	{
		return default(bool);
	}

	[Calls(Type = typeof(uConsole), Member = "ParameterIsRegistered")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[Calls(Type = typeof(uConsole), Member = "CommandIsRegistered")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "CommandIsRegistered")]
	public static bool CommandIsUnabmiguousAutoComplete(string command)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "ShowHelp")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "ShowHelp")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "SearchForCommand")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void ShowHelp(string command)
	{
	}

	[CallerCount(Count = 111)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetNumParameters()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public static List<string> GetAllParameters()
	{
		return null;
	}

	[CallerCount(Count = 143)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	public static bool NextParameterIsBool()
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallerCount(Count = 153)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool GetBool()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_autosave")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_unlock")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_sleep_length")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_gear_add_type")]
	public static bool NextParameterIsInt()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public static int GetInt()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_set")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_texel_density")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shake_camera")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shake_camera")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shake_camera")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shake_camera")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shake_camera")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_speed")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_countdown")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_aurora_duration")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_debug_position")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_breakdown_all")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_addspace")]
	public static bool NextParameterIsFloat()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public static float GetFloat()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(uConsole), Member = "TryGetVector3")]
	[CalledBy(Type = typeof(uConsole), Member = "TryGetVector3")]
	[CalledBy(Type = typeof(uConsole), Member = "TryGetVector3")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	public static bool TryGetFloat(out float f)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref f) = null;
		return default(bool);
	}

	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public static bool TryGetVector3(out Vector3 v)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref v) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool NextParameterExists()
	{
		return default(bool);
	}

	[CallerCount(Count = 111)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetString()
	{
		return null;
	}

	[Calls(Type = typeof(uConsoleLog), Member = "Save")]
	[Calls(Type = typeof(uConsoleHistory), Member = "Save")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnApplicationQuit()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static void BuildArgListFromTokens(string[] tokens)
	{
	}

	[CalledBy(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[CalledBy(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(uConsole), Member = "RegisterCommand")]
	private static bool CommandAlreadyRegistered(string command)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(uConsole), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void InstantiateGUIPrefab()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "CommandIsRegistered")]
	[Calls(Type = typeof(uConsole), Member = "ParameterIsRegistered")]
	private static bool CommandAndParameterRegistered(string command, string parameter)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(uConsole), Member = "CommandIsUnabmiguousAutoComplete")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(uConsole), Member = "CommandIsUnabmiguousAutoComplete")]
	[CalledBy(Type = typeof(uConsole), Member = "CommandAndParameterRegistered")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private static bool CommandIsRegistered(string command)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(uConsole), Member = "CommandAndParameterRegistered")]
	[CalledBy(Type = typeof(uConsole), Member = "CommandIsUnabmiguousAutoComplete")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private static bool ParameterIsRegistered(string command, string parameter)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public uConsole()
	{
	}
}
