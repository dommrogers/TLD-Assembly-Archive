using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Framework;
using NodeCanvas.Tasks.Actions;
using TLD.Audio;
using TLD.Gameplay;
using TLD.Gameplay.Condition;
using TLD.GameplayTags;
using TLD.Gear;
using TLD.OptionalContent;
using TLD.SaveState;
using TLD.Scenes;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class ConsoleManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MissionObjectIdentifier> _003C_003E9__124_0;

		public static Action<bool> _003C_003E9__166_0;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsUnknownMethods(Count = 3)]
		internal int _003CCONSOLE_dump_mission_objects_003Eb__124_0(MissionObjectIdentifier a, MissionObjectIdentifier b)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		internal void _003CCONSOLE_dlc_install_from_path_003Eb__166_0(bool result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass243_0
	{
		public string regionName;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass243_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallerCount(Count = 0)]
		internal bool _003CCONSOLE_unlock_region_003Eb__0(RegionSpecification region)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass474_0
	{
		public string prefabName;

		public float dist;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass474_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
		[Calls(Type = typeof(ConsoleManager), Member = "set_spawn_position")]
		[CallsUnknownMethods(Count = 3)]
		internal void _003Cspawn_common_003Eb__0(AsyncOperationHandle<GameObject> goOp)
		{
		}
	}

	public static Dictionary<string, List<string>> m_ComponentNameToGearNames;

	private static Dictionary<string, string> m_SearchStringToGearNames;

	private static bool m_Initialized;

	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "CreateCommandParameterSet")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "CreateCommandParameterSet")]
	[Calls(Type = typeof(Panel_Debug), Member = "PopulateTimelineOptions")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "CreateCommandParameterSet")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(ConsoleManager), Member = "RegisterCommands")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "CreateCommandParameterSet")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "CreateCommandParameterSet")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(ConsoleManager), Member = "StoreAutoCompleteGearNames")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public static void Initialize()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallsUnknownMethods(Count = 1121)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallsDeduplicatedMethods(Count = 472)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	public static void RegisterCommands()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[CallsUnknownMethods(Count = 5)]
	public static void CONSOLE_add_all_gear()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public static void CONSOLE_ai_feeding_test()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_ai_batchgroundraycast()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(BaseAiManager), Member = "UpdateCollisionMode")]
	public static void CONSOLE_ai_continuouscollision()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_weather_usejobsystem()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_audiospline_usejobsystem()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InsomniaManager), Member = "ApplyInsomniaAffliction")]
	[Calls(Type = typeof(Frostbite), Member = "FrostbiteStart")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[Calls(Type = typeof(Infection), Member = "InfectionStart")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricStart")]
	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryStart")]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	public static void CONSOLE_afflictions()
	{
	}

	[Calls(Type = typeof(InfectionRisk), Member = "Cure")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[Calls(Type = typeof(Suffocating), Member = "StopAudio")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_god")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(BloodLoss), Member = "Cure")]
	[Calls(Type = typeof(Infection), Member = "Cure")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaEnd")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningEnd")]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryEnd")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SprainedWrist), Member = "Cure")]
	[Calls(Type = typeof(SprainPain), Member = "CureAffliction")]
	[Calls(Type = typeof(Burns), Member = "BurnsEnd")]
	[Calls(Type = typeof(SprainedAnkle), Member = "Cure")]
	public static void CONSOLE_afflictions_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_afflictions_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_almanac_debug()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadReplacementAtlases")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadReplacementAtlases")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_atlas_sd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_aurora()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsInt")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_autosave()
	{
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_bearhuntredux_encounter_activate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(BearHuntRedux), Member = "SetLastEncounter")]
	public static void CONSOLE_bearhuntredux_encounter_last()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BearHuntRedux), Member = "SetPostStruggleBehavior")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_bearhuntredux_encounter_poststrugglemode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "Begin")]
	[Calls(Type = typeof(BearHuntRedux), Member = "End")]
	public static void CONSOLE_bear_hunt_redux()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_bearspear()
	{
	}

	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	public static void CONSOLE_blood_loss()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BloodLoss), Member = "Cure")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_blood_loss_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_blood_loss_no_damage()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	public static void CONSOLE_blood_loss_nofx()
	{
	}

	[Calls(Type = typeof(InsomniaManager), Member = "ApplyInsomniaAffliction")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_insomnia()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_insomnia_risk()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	public static void CONSOLE_brokenrib()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	public static void CONSOLE_brokenrib_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_brokenrib_minor()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_brokenrib_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_brokenrib_minor_nofx()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BlueprintManager), Member = "UnlockWithNotification")]
	[Calls(Type = typeof(BlueprintManager), Member = "FindBlueprintsForGear")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_blueprint_unlock()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_blueprint_grant()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_bow()
	{
	}

	[Calls(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	public static void CONSOLE_breakdown_all()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(ConditionRestBuff), Member = "Apply")]
	[Calls(Type = typeof(FreezingBuff), Member = "Apply")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(FatigueBuff), Member = "Apply")]
	[Calls(Type = typeof(WellFed), Member = "WellFedStart")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(ConditionOverTimeBuff), Member = "Apply")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_buffs_add_all()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WellFed), Member = "WellFedEnd")]
	public static void CONSOLE_buffs_lose_all()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_burns()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Burns), Member = "BurnsEnd")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_burns_cure()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
	public static void CONSOLE_burns_nofx()
	{
	}

	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricStart")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_burns_electric()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_burns_electric_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_burns_electric_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_cabinfever()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_cabinfever_cure()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_cabinfever_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_capture()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_capture_anim()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat")]
	public static void CONSOLE_capture_farclip()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_carrion_stagger()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_flaregun()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	public static void CONSOLE_capture_framerate()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_capture_mode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FrameDumper), Member = "Toggle")]
	public static void CONSOLE_capture_toggle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	public static void CONSOLE_capture_lighting()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LightingCapture), Member = "MakeNextDirectoryID")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	public static void CONSOLE_capture_lighting_all()
	{
	}

	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_challenge_complete()
	{
	}

	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static void CONSOLE_challenge_complete_all()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_character_splitstep_optimization()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_clear_force_sleep_length()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	public static void CONSOLE_close_ui()
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Container), Member = "AllFoodItemsAreNatural")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Container), Member = "GetTotalCalories")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Container), Member = "GetHoursFuel")]
	public static void CONSOLE_container_test()
	{
	}

	[CallerCount(Count = 0)]
	public static void CONSOLE_create_jump()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	public static void CONSOLE_crow_flyover_test()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_damage_multiplier()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_debug_ai()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_disable_ai()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAiManager), Member = "DisableInvalidAi")]
	public static void CONSOLE_disable_invalid_ai()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_ai_states()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_ai_spawn()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_debug_ats_verbose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void Console_debug_allow_invalid_saves()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_debug_navmesh()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_ai_closestonly()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public static void CONSOLE_debug_asset_bundles()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	public static void CONSOLE_debug_ai_lite()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_spotlights()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_steampipes()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_debug_steampipebyname()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_bearhuntredux()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_camera()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "OutputWornClothing")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_debug_clothing()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_debug_damage()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_dialogue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_elevator()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_debug_font_rendering()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void OnFontRenderingPanelLoaded(Panel_Base panel)
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_keyboard_shortcuts()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_loading_screen()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_heavy_breathing()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_panel_loading()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_debug_phone()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_player()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_debug_player_interaction()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_position()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_debug_mission()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_debug_noisemaker_radius()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_nowheretohide()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void CONSOLE_debug_npc()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_debug_projectile()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	public static void CONSOLE_debug_radial_spawning()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_roi_lods()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_raycast_jobs()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_story_hud()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_struggle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_debug_text_hide()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_debug_text_show()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_timer()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_high_resolution_timer()
	{
	}

	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_view_mode()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_debug_voice_ui()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_voice_verbose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_weather()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_debug_wolfhowl()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_decayscale()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_deferred_rendering()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "AssignCategory")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void CONSOLE_dialogue_assign()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LogChoices")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_dialogue_logchoices()
	{
	}

	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_dialogue_setanimationstate()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(int), Member = "Parse")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Animator), Member = "get_parameters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_dialogue_setanimationparameter()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_dialogue_setframing()
	{
	}

	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ShouldIgnoreMissionObject")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_hideFlags")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_hideFlags")]
	[CallsUnknownMethods(Count = 52)]
	public static void CONSOLE_dump_mission_objects()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DumpWeaponIds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_dump_weapon_ids()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_dysentery()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryEnd")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_dysentery_cure()
	{
	}

	[Calls(Type = typeof(Dysentery), Member = "DysenteryStart")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_dysentery_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingIn")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	public static void CONSOLE_fade_in()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	public static void CONSOLE_fade_out_immediate()
	{
	}

	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_fade_out()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_cinematic_fade_blackout()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_fancy()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void CONSOLE_fatigue_locked()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_farclip()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	public static void CONSOLE_feat_booksmarts()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	public static void CONSOLE_feat_coldfusion()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_feat_efficientmachine()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	public static void CONSOLE_feat_firemaster()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	public static void CONSOLE_feat_freerunner()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	public static void CONSOLE_feat_snowwalker()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	public static void CONSOLE_feat_experttrapper()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	public static void CONSOLE_feat_straighttoheart()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_feat_blizzardwalker()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	public static void CONSOLE_feat_nightwalker()
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static void CONSOLE_feat_set_enabled()
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 19)]
	public static void CONSOLE_feat_unlock_all()
	{
	}

	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningStart")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_food_poison()
	{
	}

	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	public static void CONSOLE_force_electrostatic_fog()
	{
	}

	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	public static void CONSOLE_force_aurora()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	public static void CONSOLE_force_aurora_immediate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_force_aurora_duration()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_enable_aurorafields()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_enable_auroraelectrolyzers_far_optim()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_enable_saveload()
	{
	}

	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	public static void CONSOLE_episode_complete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsInt")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(EpisodeManager), Member = "UnlockAllToEpisode")]
	public static void CONSOLE_episode_unlock()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	public static void CONSOLE_force_crouch()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_force_limp()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_force_limp_slow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_disable_procedural_instancing()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_dlc_can_use_content()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "InitializeAsync")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void CONSOLE_dlc_initialize()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private static void OnDlCInitialized()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_dlc_install_content()
	{
	}

	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[Calls(Type = typeof(OptionalContentManager), Member = "LoadOptionalContent")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_dlc_install_from_path()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyListKnownDLC")]
	[Calls(Type = typeof(string), Member = "Join")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(OptionalContentManager), Member = "GetAllConfigs")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallerCount(Count = 1)]
	public static void CONSOLE_dlc_list_known_content()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyListAvailableDLC")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(OptionalContentManager), Member = "TryFindConfig")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static void CONSOLE_dlc_list_available_content()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "OpenContentInStore")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_dlc_open_content_in_store()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_force_no_random_sprain()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_force_jam()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_force_no_jam()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_force_no_sprainwrist()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_force_walk()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_force_gear_weight()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_force_howl()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_reset_forced_gear_weight()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_reset_steam_achievements()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_force_fire_starting_success()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_force_gc()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_force_gc_verbose()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_force_skip_enabled()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_force_mobility_reduction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsInt")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Utils), Member = "TryParseTOD")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_force_sleep_length()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_fog_scale()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningEnd")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_food_poison_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_food_poison_nofx()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_forward_rendering()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_fphands()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetHandMeshState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_fphands_mesh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_framerate_cap()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(Frostbite), Member = "FrostbiteStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_frostbite()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static void CONSOLE_frostbite_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(Frostbite), Member = "FrostbiteStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_frostbite_nofx()
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static void CONSOLE_achievement_unlock()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_achievement_list()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_achievement_verbose_log()
	{
	}

	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_gear_add()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsInt")]
	public static void CONSOLE_gear_add_type()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static object CONSOLE_get_cold()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static object CONSOLE_get_condition()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static object CONSOLE_get_fatigue()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static object CONSOLE_get_hunger()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static object CONSOLE_get_thirst()
	{
		return null;
	}

	[Calls(Type = typeof(NCUtils), Member = "GetGameState")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static object CONSOLE_get_game_state()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_ghost()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_god()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(FlyMode), Member = "Enter")]
	[Calls(Type = typeof(FlyMode), Member = "Exit")]
	public static void CONSOLE_fly()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public static void CONSOLE_exception_test()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void CONSOLE_graphics_version()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_hide_testbuild_watermark()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	public static void CONSOLE_hunted2_endgame()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_hypothermia()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaEnd")]
	public static void CONSOLE_hypothermia_cure()
	{
	}

	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_hypothermia_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_invisibleentity_countdown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_invisibleentity_pause()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "Spawn")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_invisibleentity_spawn()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_invisibleentity_addspace()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetRange")]
	public static void CONSOLE_invisibleentity_near()
	{
	}

	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetRange")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_invisibleentity_far()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_invisibleentity_speed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Infection), Member = "InfectionStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_infection()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Infection), Member = "Cure")]
	public static void CONSOLE_infection_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Infection), Member = "InfectionStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_infection_nofx()
	{
	}

	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_infection_risk()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_infection_risk_constant()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InfectionRisk), Member = "Cure")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_infection_risk_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_infection_risk_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_inhibit_toxicfog_headache()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_invulnerable()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_json_net_serialization()
	{
	}

	[Calls(Type = typeof(KnowledgeManager), Member = "DumpKnowledgeToDebugLog")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_knowledge_dump()
	{
	}

	[Calls(Type = typeof(Knowledge), Member = "Unlock")]
	[Calls(Type = typeof(Knowledge), Member = "GetLocalizedKnowledgeCategoryName")]
	[Calls(Type = typeof(Knowledge), Member = "GetKnowledgeCategoryFromName")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_knowledge_unlock()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_lampinfinite()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Localization), Member = "set_Language")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	public static void CONSOLE_lang()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Utils), Member = "TryParseTOD")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_lighting_preview()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	public static void CONSOLE_list_unexplored_interiors()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_loadfadeout()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	public static void CONSOLE_loadpriority()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_lock_player()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private static void CONSOLE_lock_region()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(RegionSpecification), Member = "IsUnlocked")]
	[Calls(Type = typeof(RegionSpecification), Member = "MaybeUnlock")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private static void CONSOLE_unlock_region()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_lock_temperature()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WeatherNameToEnum")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_lock_weather()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WeatherNameToEnum")]
	public static void CONSOLE_lock_weather_instant()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_lock_wind_instant()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void CONSOLE_lod_bias()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 9)]
	public static void CONSOLE_log_all_faithful_cartographer()
	{
	}

	[Calls(Type = typeof(MapDetailManager), Member = "LogAllUnmappedLocations")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_log_faithful_cartographer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_menublur()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_makestrugglepartnerflee()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static void CONSOLE_mission_jump()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_mission_add()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionManager")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_mission_remove()
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "IsMissionActive")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static object CONSOLE_is_mission_active()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(MissionServicesManager), Member = "AddMissionObjectFilterTags")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_mission_add_filter_tags()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionObjectFilterTags")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_mission_remove_filter_tags()
	{
	}

	[Calls(Type = typeof(WeatherTransition), Member = "ForceNextWeatherStage")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_next_weather()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_next_weatherset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_neverdie()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(NPC), Member = "FindNearest")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void CONSOLE_npc_conditionupdate()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(NPC), Member = "FindNearest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	public static void CONSOLE_npc_bloodloss()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_npc_disable_conditions()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_npc_goto()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GoToAiMarker")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_NPC_GoTo_Marker()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_npc_invulnerable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	private static void CONSOLE_outdoorsceneroot_cache()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PassTime), Member = "Begin")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_pass_time()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_parasites()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntestinalParasites), Member = "AddRiskPercent")]
	public static void CONSOLE_parasites_risk()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntestinalParasites), Member = "AddRiskPercent")]
	public static void CONSOLE_parasites_risk_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_parasites_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(PlayerStunned), Member = "Begin")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_player_stunned()
	{
	}

	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public static void CONSOLE_parasites_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Phone), Member = "StartPhoneRinging")]
	public static void CONSOLE_phone_startringing()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "StopPhoneRinging")]
	public static void CONSOLE_phone_stopringing()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_physics_autosync()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	public static void CONSOLE_play_movie()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	public static void CONSOLE_play_movie_alpha()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_play_movie_alpha_ext()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayDynamicSequence")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_play_dd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneMusicManager), Member = "PlayExploreMusic")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_play_exploremusic()
	{
	}

	[Calls(Type = typeof(SoundbankLoader), Member = "DebugLoadAllEpisodeBanks")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_play_timeline()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_play_timeline_on()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_stop_timeline_on()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_play_fp_cinematic()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_play_sorrowmusic()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_play_sound()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_play_soundlogduration()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_play_unistorm_anim()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_play_voice()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_popup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_postprocess_globaloptim()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_collect_materialsets_stats()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_pulse_pain()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_pulse_stim()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_pulse_electrocution()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_random_voice()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_random_weather()
	{
	}

	[Calls(Type = typeof(FPSLogger), Member = "StartRecording")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(FPSLogger), Member = "StopRecording")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void CONSOLE_record_fps()
	{
	}

	[CallerCount(Count = 0)]
	public static void CONSOLE_rejump()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Utils), Member = "RestoreView")]
	public static void CONSOLE_restore_view()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void CONSOLE_revolver()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	public static void CONSOLE_rifle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 51)]
	public static void CONSOLE_toughclothes()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void CONSOLE_toxicfog_full()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_toxicfog_pause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ToxicFogManager), Member = "ResetTimeAccumulation")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_toxicfog_reset()
	{
	}

	[Calls(Type = typeof(ToxicFogManager), Member = "ResetTimeAccumulation")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_toxicfog_reset_all()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_toxicfog_set()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "StopVibration")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_rumble()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_safezone()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "ForceSaveGame")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	public static void CONSOLE_save()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Utils), Member = "SaveView")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_save_view()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "TurnOff")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_scene()
	{
	}

	[Calls(Type = typeof(SceneManager), Member = "AddLayer")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_scene_addlayer()
	{
	}

	[Calls(Type = typeof(SceneManager), Member = "RemoveLayer")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_scene_removelayer()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_validate_time()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_set_aurora_cine_colours()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_set_blur_level()
	{
	}

	[Calls(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_set_cinematicproperty()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_set_cold()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_set_condition()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_set_elapsed_hours()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_set_fatigue()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_fixedDeltaTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_set_hours_played()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_set_hunger()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "JoinCore")]
	public static void CONSOLE_set_hud_display_mode()
	{
	}

	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static void CONSOLE_set_image_filter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_set_jump_creation()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_set_min_airtemp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_set_nowhere_to_hide_banishment_ready()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	public static void CONSOLE_set_object_hp_percent()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_set_quality()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_set_spawn()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_set_thirst()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Utils), Member = "TryParseTOD")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_set_time()
	{
	}

	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WeatherNameToEnum")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	public static void CONSOLE_set_weather()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(ConsoleManager), Member = "SetWind")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_set_wind()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(ConsoleManager), Member = "SetWind")]
	public static void CONSOLE_set_wind_immediate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_set_slowdown_hold()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_suppress_blizzards()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_shadow_cascades()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ShaderComparison), Member = "Toggle")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_shader_toggle()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	public static void CONSOLE_shake_camera()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_show_audiobuckets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_show_calories()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_show_coords()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_show_decal_debug()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_show_location_reveal()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_show_lookat()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	public static void CONSOLE_show_days_survived()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_show_fps()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_show_placeholders()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_show_terraindebug()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_show_tod_slider()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	public static void CONSOLE_show_running_temp_bonus()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_show_temperature()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_show_unknown_timeofday()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_show_timeline_debug()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	public static void CONSOLE_skill_archery()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_skill_archery_level()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	public static void CONSOLE_skill_firestarting()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	public static void CONSOLE_skill_firestarting_level()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	public static void CONSOLE_skill_gunsmithing()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	public static void CONSOLE_skill_gunsmithing_level()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_skill_carcassharvesting()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	public static void CONSOLE_skill_carcassharvesting_level()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	public static void CONSOLE_skill_clothingrepair()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	public static void CONSOLE_skill_clothingrepair_level()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	public static void CONSOLE_skill_cooking()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_skill_cooking_level()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	public static void CONSOLE_skill_icefishing()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	public static void CONSOLE_skill_icefishing_level()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	public static void CONSOLE_skill_rifle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	public static void CONSOLE_skill_rifle_level()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_skill_toolrepair()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	public static void CONSOLE_skill_toolrepair_level()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	public static void CONSOLE_skill_revolver()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	public static void CONSOLE_skill_revolver_level()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void CONSOLE_skip_next_conversation()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_skip_fade_on_load()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_skip_delay_spawn_audio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_snowpatch()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_snowshelter()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	public static void CONSOLE_survey()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "ClearData")]
	[Calls(Type = typeof(MapDetailManager), Member = "LockAll")]
	public static void CONSOLE_survey_clear()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_leanto()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	public static void CONSOLE_spawn_aurorawolf()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	public static void CONSOLE_spawn_aurorabear()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_spawn_bear()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_spawn_bear_challenge()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_spawn_bear_old()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	public static void CONSOLE_spawn_doe()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_spawn_moose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	public static void CONSOLE_spawn_rabbit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	public static void CONSOLE_spawn_stag()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_spawn_wolf()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	public static void CONSOLE_spawn_wolf_grey()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	public static void CONSOLE_spawn_grey_wolf_aurora()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_sprain_ankle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprainedAnkle), Member = "Cure")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_sprain_ankle_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_sprain_ankle_nofx()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_sprain_ankle_nofx_unique()
	{
	}

	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_sprain_wrist()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprainedWrist), Member = "Cure")]
	public static void CONSOLE_sprain_wrist_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_sprain_wrist_nofx()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_sandbox()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private static SceneSet GetSceneSetFromLoadedScenes()
	{
		return null;
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	public static void CONSOLE_story()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_stagger_nodecanvasupdate()
	{
	}

	[Calls(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[Calls(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_suffocating()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_suppress_breath_fx()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_suppress_hypothermia()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_suppress_frostbite()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_teleport()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "ForceDisableTerrainTrees")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "ForceDisableTerrainTrees")]
	public static void CONSOLE_terrain_disabletrees()
	{
	}

	[Calls(Type = typeof(RenderObjectInstance), Member = "IsCategoryEnabled")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableCategory")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "IsCategoryEnabled")]
	public static void CONSOLE_terrain_disableinstancedtrees()
	{
	}

	[Calls(Type = typeof(QualitySettingsManager), Member = "OverrideTerrainPixelError")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_terrain_setpixelerror()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_enable_audio_use_static_check()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_audio_logbuckets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_enable_filterworldlightsforfp()
	{
	}

	[Calls(Type = typeof(RenderObjectInstance), Member = "AllEnabled")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "AllEnabled")]
	public static void CONSOLE_enable_renderobjectinstances()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "AllEnabled")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "AllEnabled")]
	public static void CONSOLE_enable_renderobjectinstances_norenderers()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_enable_renderobjectinstances_debugtext()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_enable_renderobjectinstances_frustumtest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(Utils), Member = "EnableShadows")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(Utils), Member = "EnableShadows")]
	public static void CONSOLE_enable_shadows()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_enable_specular()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_enable_ai_frustum_culling()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_texture_streaming_budget()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_texel_density()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_texture_streaming_caching()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAimBreathing")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAllAimingMotion")]
	public static void CONSOLE_disable_aim_breath()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAllAimingMotion")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAimSway")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static void CONSOLE_disable_aim_sway()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAimStamina")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAllAimingMotion")]
	public static void CONSOLE_disable_aim_stamina()
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAllAimingMotion")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAimShake")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 2)]
	public static void CONSOLE_disable_aim_shake()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "IsAmbientSwayDisabled")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAmbientSway")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAllAimingMotion")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_disable_ambient_sway()
	{
	}

	[CallerCount(Count = 0)]
	public static void CONSOLE_disable_probe_updates()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_drop_lit_item_in_hands()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	public static void CONSOLE_drop_scatter_item_in_hands()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_disable_aim_depth_of_field()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "StowItem")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_stow_item()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(TimeOfDay), Member = "AccelerateTime")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_timeaccelerate()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "SetConditionLabelDepth")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AccelTimePopup), Member = "SetActive")]
	public static void CONSOLE_timeofday_display()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_timescale()
	{
	}

	[CallerCount(Count = 0)]
	public static void CONSOLE_trialmode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_trust_add()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustManager), Member = "OutputTrustValues")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_trust_value_list()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_turbo_weather()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_ui_height()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_ui_width()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_ui_size()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_ultimatecamera_fixedstep()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_unequip_immediate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_unlimited_sprint()
	{
	}

	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetBestGearItemWithName")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_use_best_gearitem()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void CONSOLE_use_legacyloading()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "SetPlayerVoicePersona")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_voice_female()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "SetPlayerVoicePersona")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_voice_male()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_vsync()
	{
	}

	[Calls(Type = typeof(FlyMode), Member = "Warp")]
	[Calls(Type = typeof(FlyMode), Member = "TeleportPlayerAndExit")]
	[Calls(Type = typeof(FlyMode), Member = "Warp")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "JoinCore")]
	[Calls(Type = typeof(uConsole), Member = "GetAllParameters")]
	[Calls(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_warp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "SetToken")]
	[CallsUnknownMethods(Count = 1)]
	private static void SaveToken(string token)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[Calls(Type = typeof(Quaternion), Member = "set_eulerAngles")]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	private static bool TryGetWarpToPosition(out Vector3 pos, out Quaternion rot)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref pos) = null;
		System.Runtime.CompilerServices.Unsafe.As<Quaternion, @null>(ref rot) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WellFed), Member = "WellFedStart")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_well_fed()
	{
	}

	[CallsUnknownMethods(Count = 69)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	private static GameModeConfig GetGameModeConfig(string name)
	{
		return null;
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(Inventory), Member = "DestroyAllGear")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode_keep_inventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ConsoleManager), Member = "GetGameModeConfig")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_xpmode(bool resetInventory)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	public static void CONSOLE_xpmode()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_xpmode_keep_inventory()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(LoadScene), Member = "Activate")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_jump_to_loadingzone()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(LoadScene), Member = "Activate")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_jump_to_interior()
	{
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WeatherNameToEnum")]
	[CallerCount(Count = 0)]
	private static WeatherStage WeatherNameToEnum(string weatherName)
	{
		return default(WeatherStage);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_doe")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_grey_wolf_aurora")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_wolf_grey")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_wolf")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_stag")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_rabbit")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_moose")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_bear_old")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_aurorabear")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_bear")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_aurorawolf")]
	[Calls(Type = typeof(UnityEngine.AddressableAssets.AddressablesImpl), Member = "InstantiateAsync")]
	[Calls(Type = typeof(InstantiationParameters), Member = ".ctor")]
	[Calls(Type = typeof(Addressables), Member = "LoadResourceLocationsAsync")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_bear_challenge")]
	private static void spawn_common(string prefabName, float dist)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass474_0), Member = "<spawn_common>b__0")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private static void set_spawn_position(GameObject go, float dist)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearNames), Member = "GetBaseName")]
	[Calls(Type = typeof(GearNames), Member = "GetPrefixedName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 1)]
	private static void StoreAutoCompleteGearNames()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	private static string GetGearName(GearItemData asset)
	{
		return null;
	}

	[Calls(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void CONSOLE_mapmarker_add()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[CallsUnknownMethods(Count = 1)]
	private static void CONSOLE_mapmarker_remove()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	private static void CONSOLE_map_enablegps()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "RevealCurrentScene")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void CONSOLE_map_reveal()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	[CallsUnknownMethods(Count = 2)]
	private static void CONSOLE_map_unlock_region()
	{
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	private static void CONSOLE_map_screenshot()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[CallsUnknownMethods(Count = 6)]
	private static void CONSOLE_show_hands()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_firestarting")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_gunsmithing")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_carcassharvesting")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_clothingrepair")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_revolver")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_icefishing")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_rifle")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_toolrepair")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_cooking")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowLevelUp")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_archery")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowPointIncrease")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	private static void SetSkillPoints(string command, SkillType skillType, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_firestarting_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_gunsmithing_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_carcassharvesting_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_clothingrepair_level")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_icefishing_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_rifle_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_toolrepair_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_revolver_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_cooking_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_archery_level")]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowLevelUp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	private static void SetSkillLevel(string command, SkillType skillType, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_nightwalker")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_blizzardwalker")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_straighttoheart")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_experttrapper")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_snowwalker")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_freerunner")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_efficientmachine")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_firemaster")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_booksmarts")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_coldfusion")]
	private static void SetFeat(string command, FeatType featType)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_wind")]
	[Calls(Type = typeof(Wind), Member = "DirectionToAngle")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_wind_immediate")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static void SetWind(string windName, string windDir, bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsUnknownMethods(Count = 2)]
	private static void AudioCallback(object cookie, AkCallbackType type, object callbackInfo)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ConsoleManager()
	{
	}
}
