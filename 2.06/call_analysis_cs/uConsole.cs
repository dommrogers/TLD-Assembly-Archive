using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Tasks.Actions;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

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

		[CalledBy(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
		[CalledBy(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
		[CallerCount(Count = 2)]
		public CommandDelegate(DebugCommandReturn cmd)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool IsValid()
		{
			return false;
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
	[Calls(Type = typeof(Application.LogCallback), Member = ".ctor")]
	[Calls(Type = typeof(Application), Member = "add_logMessageReceived")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "InstantiateGUIPrefab")]
	[Calls(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(uConsoleHistory), Member = "Restore")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsoleInput), Member = "DoFrame")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "RegisterCommands")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "Start")]
	[CallerCount(Count = 472)]
	[Calls(Type = typeof(uConsole), Member = "CommandAlreadyRegistered")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(CommandDelegate), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterCommand(string command, DebugCommand commandCallback)
	{
	}

	[CalledBy(Type = typeof(uConsoleCommands), Member = "RegisterBuiltInCommands")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(uConsole), Member = "CommandAlreadyRegistered")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(CommandDelegate), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterCommand(string command, string help, DebugCommand commandCallback)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "RegisterCommands")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(uConsole), Member = "CommandAlreadyRegistered")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(CommandDelegate), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterCommandReturn(string command, DebugCommandReturn commandCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "CommandAlreadyRegistered")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(CommandDelegate), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterCommandReturn(string command, string help, DebugCommandReturn commandCallback)
	{
	}

	[CalledBy(Type = typeof(ExampleCommands), Member = "OnDestroy")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnRegisterCommand(string command)
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "Toggle4DON")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "OverrideDay4DON")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "TransitionToDay4DON")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "CompleteTimer4DON")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ResetBadgeProgress4DON")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_add")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "SubmitCommand")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessSubmitInput")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(uConsoleHistory), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(uConsole), Member = "BuildArgListFromTokens")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	public static object RunCommand(string commandWithArgs)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyShowDaysSurvived")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_insomnia_risk")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_crow_flyover_test")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_debug_ai_lite")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_debug_radial_spawning")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hunted2_endgame")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_jump")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_days_survived")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_running_temp_bonus")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Start")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CalledBy(Type = typeof(NCUtils), Member = "ProcessCommandBlockLines")]
	[CalledBy(Type = typeof(Action_StartSideMission), Member = "OnExecute")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(uConsole), Member = "BuildArgListFromTokens")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static object RunCommandSilent(string commandWithArgs)
	{
		return null;
	}

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

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessActivationInput")]
	[CallerCount(Count = 2)]
	public static void TurnOff()
	{
	}

	[CallerCount(Count = 0)]
	public static bool IsOn()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(uConsole), Member = "CommandIsRegistered")]
	[Calls(Type = typeof(uConsole), Member = "ParameterIsRegistered")]
	[CallsUnknownMethods(Count = 2)]
	public static bool CommandIsUnabmiguousAutoComplete(string command)
	{
		return false;
	}

	[CalledBy(Type = typeof(uConsoleCommands), Member = "SearchForCommand")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "ShowHelp")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void ShowHelp(string command)
	{
	}

	[CallerCount(Count = 113)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetNumParameters()
	{
		return 0;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static List<string> GetAllParameters()
	{
		return null;
	}

	[CallerCount(Count = 145)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static bool NextParameterIsBool()
	{
		return false;
	}

	[CallerCount(Count = 154)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static bool GetBool()
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_autosave")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_unlock")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_sleep_length")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_gear_add_type")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static bool NextParameterIsInt()
	{
		return false;
	}

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static int GetInt()
	{
		return 0;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_breakdown_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_debug_position")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_aurora_duration")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_countdown")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_addspace")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_speed")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_set")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_object_hp_percent")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shake_camera")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_texel_density")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static bool NextParameterIsFloat()
	{
		return false;
	}

	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static float GetFloat()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	[CalledBy(Type = typeof(uConsole), Member = "TryGetVector3")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static bool TryGetFloat(out float f)
	{
		f = default(float);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	public static bool TryGetVector3(out Vector3 v)
	{
		v = default(Vector3);
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static bool NextParameterExists()
	{
		return false;
	}

	[CallerCount(Count = 117)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
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

	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private static void BuildArgListFromTokens(string[] tokens)
	{
	}

	[CalledBy(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CalledBy(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CalledBy(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[CalledBy(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static bool CommandAlreadyRegistered(string command)
	{
		return false;
	}

	[CalledBy(Type = typeof(uConsole), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Addressables), Member = "InstantiateAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void InstantiateGUIPrefab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "CommandIsRegistered")]
	[Calls(Type = typeof(uConsole), Member = "ParameterIsRegistered")]
	private static bool CommandAndParameterRegistered(string command, string parameter)
	{
		return false;
	}

	[CalledBy(Type = typeof(uConsole), Member = "CommandIsUnabmiguousAutoComplete")]
	[CalledBy(Type = typeof(uConsole), Member = "CommandAndParameterRegistered")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static bool CommandIsRegistered(string command)
	{
		return false;
	}

	[CalledBy(Type = typeof(uConsole), Member = "CommandIsUnabmiguousAutoComplete")]
	[CalledBy(Type = typeof(uConsole), Member = "CommandAndParameterRegistered")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static bool ParameterIsRegistered(string command, string parameter)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public uConsole()
	{
	}
}
