using System;
using System.Collections.Generic;
using System.Globalization;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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
	}

	private sealed class _003C_003Ec__DisplayClass241_0
	{
		public string regionName;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass241_0()
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

	private sealed class _003C_003Ec__DisplayClass472_0
	{
		public string prefabName;

		public float dist;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass472_0()
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
	[CallsUnknownMethods(Count = 1109)]
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
	[CallsDeduplicatedMethods(Count = 470)]
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
	public static void RegisterCommands()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void CONSOLE_add_all_gear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_ai_feeding_test()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_ai_batchgroundraycast()
	{
	}

	[Calls(Type = typeof(BaseAiManager), Member = "UpdateCollisionMode")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_ai_continuouscollision()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_weather_usejobsystem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_audiospline_usejobsystem()
	{
	}

	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InsomniaManager), Member = "ApplyInsomniaAffliction")]
	[Calls(Type = typeof(Frostbite), Member = "FrostbiteStart")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[Calls(Type = typeof(Infection), Member = "InfectionStart")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricStart")]
	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryStart")]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningStart")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	public static void CONSOLE_afflictions()
	{
	}

	[Calls(Type = typeof(Infection), Member = "Cure")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[Calls(Type = typeof(Suffocating), Member = "StopAudio")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_god")]
	[Calls(Type = typeof(InfectionRisk), Member = "Cure")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	[Calls(Type = typeof(Burns), Member = "BurnsEnd")]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaEnd")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[Calls(Type = typeof(SprainPain), Member = "CureAffliction")]
	[Calls(Type = typeof(SprainedWrist), Member = "Cure")]
	[Calls(Type = typeof(SprainedAnkle), Member = "Cure")]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryEnd")]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningEnd")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BloodLoss), Member = "Cure")]
	public static void CONSOLE_afflictions_cure()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_afflictions_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_almanac_debug()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadReplacementAtlases")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadReplacementAtlases")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_atlas_sd()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_aurora()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsInt")]
	public static void CONSOLE_autosave()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	public static void CONSOLE_bearhuntredux_encounter_activate()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(BearHuntRedux), Member = "SetLastEncounter")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_bearhuntredux_encounter_last()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(BearHuntRedux), Member = "SetPostStruggleBehavior")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 7)]
	public static void CONSOLE_bearhuntredux_encounter_poststrugglemode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "Begin")]
	[Calls(Type = typeof(BearHuntRedux), Member = "End")]
	public static void CONSOLE_bear_hunt_redux()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	public static void CONSOLE_bearspear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 17)]
	public static void CONSOLE_blood_loss()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BloodLoss), Member = "Cure")]
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

	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	public static void CONSOLE_blood_loss_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "ApplyInsomniaAffliction")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_insomnia()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	public static void CONSOLE_insomnia_risk()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	public static void CONSOLE_brokenrib()
	{
	}

	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_brokenrib_cure()
	{
	}

	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(BlueprintManager), Member = "FindBlueprintsForGear")]
	[Calls(Type = typeof(BlueprintManager), Member = "UnlockWithNotification")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_blueprint_unlock()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_breakdown_all()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(WellFed), Member = "WellFedStart")]
	[Calls(Type = typeof(ConditionOverTimeBuff), Member = "Apply")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(FatigueBuff), Member = "Apply")]
	[Calls(Type = typeof(ConditionRestBuff), Member = "Apply")]
	[Calls(Type = typeof(FreezingBuff), Member = "Apply")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	public static void CONSOLE_buffs_add_all()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WellFed), Member = "WellFedEnd")]
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_burns_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_burns_electric()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_burns_electric_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_burns_electric_nofx()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public static void CONSOLE_cabinfever()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_cabinfever_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_cabinfever_nofx()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_carrion_stagger()
	{
	}

	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	public static void CONSOLE_capture_mode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FrameDumper), Member = "Toggle")]
	public static void CONSOLE_capture_toggle()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_capture_lighting()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LightingCapture), Member = "MakeNextDirectoryID")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_capture_lighting_all()
	{
	}

	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_challenge_complete()
	{
	}

	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_challenge_complete_all()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_character_splitstep_optimization()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_clear_force_sleep_length()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static void CONSOLE_close_ui()
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Container), Member = "AllFoodItemsAreNatural")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	public static void CONSOLE_crow_flyover_test()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_damage_multiplier()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_ai()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_disable_ai()
	{
	}

	[Calls(Type = typeof(BaseAiManager), Member = "DisableInvalidAi")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_disable_invalid_ai()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_ai_states()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_ai_spawn()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_ai_closestonly()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public static void CONSOLE_debug_asset_bundles()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_ai_lite()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_spotlights()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_steampipes()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_steampipebyname()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_bearhuntredux()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_camera()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "OutputWornClothing")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_debug_clothing()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_damage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_dialogue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_elevator()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void CONSOLE_debug_font_rendering()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void OnFontRenderingPanelLoaded(Panel_Base panel)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_keyboard_shortcuts()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_debug_loading_screen()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_debug_heavy_breathing()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_panel_loading()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_phone()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_debug_player()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void CONSOLE_debug_player_interaction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_debug_position()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_debug_mission()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void CONSOLE_debug_noisemaker_radius()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_debug_nowheretohide()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
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

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_debug_high_resolution_timer()
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsUnknownMethods(Count = 7)]
	public static void CONSOLE_debug_view_mode()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void CONSOLE_debug_voice_ui()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_deferred_rendering()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "AssignCategory")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	public static void CONSOLE_dialogue_setanimationstate()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(int), Member = "Parse")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Animator), Member = "get_parameters")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_dialogue_setanimationparameter()
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	public static void CONSOLE_dialogue_setframing()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ShouldIgnoreMissionObject")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 52)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_hideFlags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_hideFlags")]
	public static void CONSOLE_dump_mission_objects()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DumpWeaponIds")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_dump_weapon_ids()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryStart")]
	public static void CONSOLE_dysentery()
	{
	}

	[Calls(Type = typeof(Dysentery), Member = "DysenteryEnd")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_dysentery_cure()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryStart")]
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

	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_fade_out()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_cinematic_fade_blackout()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_fancy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
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

	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_feat_booksmarts()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	public static void CONSOLE_feat_coldfusion()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
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

	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_feat_snowwalker()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_feat_experttrapper()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
	public static void CONSOLE_feat_straighttoheart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetFeat")]
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
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	public static void CONSOLE_feat_set_enabled()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	public static void CONSOLE_feat_unlock_all()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_food_poison()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_force_electrostatic_fog()
	{
	}

	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_force_aurora()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_force_aurora_immediate()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_force_aurora_duration()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_enable_aurorafields()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_enable_auroraelectrolyzers_far_optim()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_enable_saveload()
	{
	}

	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
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
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_force_crouch()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_force_limp()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_force_limp_slow()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_disable_procedural_instancing()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_dlc_can_use_content()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "InitializeAsync")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	public static void CONSOLE_dlc_initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private static void OnDlCInitialized()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyListKnownDLC")]
	[Calls(Type = typeof(string), Member = "Join")]
	[Calls(Type = typeof(OptionalContentManager), Member = "GetAllConfigs")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static void CONSOLE_dlc_list_known_content()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "TryFindConfig")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyListAvailableDLC")]
	[CallsUnknownMethods(Count = 10)]
	public static void CONSOLE_dlc_list_available_content()
	{
	}

	[Calls(Type = typeof(OptionalContentManager), Member = "OpenContentInStore")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_dlc_open_content_in_store()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_force_no_random_sprain()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_force_jam()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_force_no_jam()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_force_no_sprainwrist()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_force_walk()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_force_gear_weight()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_fog_scale()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningEnd")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_food_poison_cure()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningStart")]
	public static void CONSOLE_food_poison_nofx()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_forward_rendering()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_fphands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetHandMeshState")]
	[CallsUnknownMethods(Count = 2)]
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

	[Calls(Type = typeof(Frostbite), Member = "FrostbiteStart")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	public static void CONSOLE_frostbite()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_frostbite_cure()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Frostbite), Member = "FrostbiteStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	public static void CONSOLE_frostbite_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 19)]
	public static void CONSOLE_achievement_unlock()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_achievement_list()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_achievement_verbose_log()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_gear_add()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsInt")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static object CONSOLE_get_thirst()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 6)]
	public static object CONSOLE_get_game_state()
	{
		return null;
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_ghost()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CallsUnknownMethods(Count = 13)]
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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void CONSOLE_exception_test()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
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
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void CONSOLE_hunted2_endgame()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	public static void CONSOLE_hypothermia()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaEnd")]
	public static void CONSOLE_hypothermia_cure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_invisibleentity_pause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "Spawn")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_invisibleentity_spawn()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public static void CONSOLE_invisibleentity_addspace()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetRange")]
	public static void CONSOLE_invisibleentity_near()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetRange")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(Infection), Member = "InfectionStart")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_infection_nofx()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_infection_risk()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_infection_risk_constant()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InfectionRisk), Member = "Cure")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_infection_risk_cure()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_invulnerable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_json_net_serialization()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KnowledgeManager), Member = "DumpKnowledgeToDebugLog")]
	public static void CONSOLE_knowledge_dump()
	{
	}

	[Calls(Type = typeof(Knowledge), Member = "Unlock")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Knowledge), Member = "GetKnowledgeCategoryFromName")]
	[Calls(Type = typeof(Knowledge), Member = "GetLocalizedKnowledgeCategoryName")]
	public static void CONSOLE_knowledge_unlock()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_lampinfinite()
	{
	}

	[Calls(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "set_Language")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	public static void CONSOLE_lang()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Utils), Member = "TryParseTOD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	public static void CONSOLE_lighting_preview()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static void CONSOLE_list_unexplored_interiors()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_loadfadeout()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_loadpriority()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_lock_player()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CallsUnknownMethods(Count = 3)]
	private static void CONSOLE_lock_region()
	{
	}

	[Calls(Type = typeof(RegionSpecification), Member = "IsUnlocked")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RegionSpecification), Member = "MaybeUnlock")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	private static void CONSOLE_unlock_region()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_lock_temperature()
	{
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WeatherNameToEnum")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_lock_weather()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WeatherNameToEnum")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_lock_weather_instant()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_lock_wind_instant()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_lod_bias()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static void CONSOLE_log_all_faithful_cartographer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetailManager), Member = "LogAllUnmappedLocations")]
	public static void CONSOLE_log_faithful_cartographer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_menublur()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void CONSOLE_makestrugglepartnerflee()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_mission_jump()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsUnknownMethods(Count = 4)]
	public static object CONSOLE_is_mission_active()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "AddMissionObjectFilterTags")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_mission_add_filter_tags()
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionObjectFilterTags")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_mission_remove_filter_tags()
	{
	}

	[Calls(Type = typeof(WeatherTransition), Member = "ForceNextWeatherStage")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[Calls(Type = typeof(NPC), Member = "FindNearest")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_npc_conditionupdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(NPC), Member = "FindNearest")]
	public static void CONSOLE_npc_bloodloss()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_npc_disable_conditions()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_npc_goto()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GoToAiMarker")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
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

	[Calls(Type = typeof(PassTime), Member = "Begin")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_pass_time()
	{
	}

	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	public static void CONSOLE_parasites()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntestinalParasites), Member = "AddRiskPercent")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_parasites_risk()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntestinalParasites), Member = "AddRiskPercent")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_parasites_risk_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_parasites_cure()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerStunned), Member = "Begin")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_player_stunned()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	public static void CONSOLE_parasites_nofx()
	{
	}

	[Calls(Type = typeof(Phone), Member = "StartPhoneRinging")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_phone_startringing()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Phone), Member = "StopPhoneRinging")]
	public static void CONSOLE_phone_stopringing()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 4)]
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

	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayDynamicSequence")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_play_dd()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneMusicManager), Member = "PlayExploreMusic")]
	public static void CONSOLE_play_exploremusic()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SoundbankLoader), Member = "DebugLoadAllEpisodeBanks")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_play_timeline()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_play_timeline_on()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void CONSOLE_stop_timeline_on()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_play_fp_cinematic()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_play_sorrowmusic()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void CONSOLE_play_sound()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_play_soundlogduration()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static void CONSOLE_play_unistorm_anim()
	{
	}

	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_play_voice()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void CONSOLE_popup()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_postprocess_globaloptim()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_collect_materialsets_stats()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_pulse_pain()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(FPSLogger), Member = "StopRecording")]
	[Calls(Type = typeof(FPSLogger), Member = "StartRecording")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_record_fps()
	{
	}

	[CallerCount(Count = 0)]
	public static void CONSOLE_rejump()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "RestoreView")]
	public static void CONSOLE_restore_view()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_revolver()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	public static void CONSOLE_toxicfog_full()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ToxicFogManager), Member = "ResetTimeAccumulation")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_toxicfog_reset_all()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void CONSOLE_toxicfog_set()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(InputManager), Member = "StopVibration")]
	public static void CONSOLE_rumble()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_safezone()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "ForceSaveGame")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void CONSOLE_save()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Utils), Member = "SaveView")]
	public static void CONSOLE_save_view()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[Calls(Type = typeof(uConsole), Member = "TurnOff")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_scene()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(SceneManager), Member = "AddLayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_scene_addlayer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(SceneManager), Member = "RemoveLayer")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_scene_removelayer()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_validate_time()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
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

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
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
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_set_fatigue()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_fixedDeltaTime()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
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

	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "JoinCore")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void CONSOLE_set_hud_display_mode()
	{
	}

	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CallsUnknownMethods(Count = 9)]
	public static void CONSOLE_set_image_filter()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_set_jump_creation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_set_min_airtemp()
	{
	}

	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_set_nowhere_to_hide_banishment_ready()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_set_object_hp_percent()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static void CONSOLE_set_quality()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_set_spawn()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_set_thirst()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "TryParseTOD")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_set_time()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[Calls(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WeatherNameToEnum")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	public static void CONSOLE_set_weather()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(ConsoleManager), Member = "SetWind")]
	public static void CONSOLE_set_wind()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(ConsoleManager), Member = "SetWind")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_set_wind_immediate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_set_slowdown_hold()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ShaderComparison), Member = "Toggle")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void CONSOLE_shader_toggle()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_show_coords()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	public static void CONSOLE_skill_carcassharvesting()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	public static void CONSOLE_skill_cooking_level()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	public static void CONSOLE_skill_toolrepair()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_skip_next_conversation()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_skip_fade_on_load()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_leanto()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_spawn_bear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	public static void CONSOLE_spawn_bear_challenge()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_spawn_bear_old()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_spawn_doe()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	public static void CONSOLE_spawn_moose()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_spawn_rabbit()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_spawn_stag()
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_spawn_wolf()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	public static void CONSOLE_spawn_wolf_grey()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_spawn_grey_wolf_aurora()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_sprain_ankle_nofx_unique()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_sprain_wrist()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprainedWrist), Member = "Cure")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_sprain_wrist_cure()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_sprain_wrist_nofx()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_sandbox()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	private static SceneSet GetSceneSetFromLoadedScenes()
	{
		return null;
	}

	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	public static void CONSOLE_story()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_stagger_nodecanvasupdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(Suffocating), Member = "MaybeStopSuffocating")]
	[Calls(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_suffocating()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_suppress_frostbite()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static void CONSOLE_teleport()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "ForceDisableTerrainTrees")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "ForceDisableTerrainTrees")]
	public static void CONSOLE_terrain_disabletrees()
	{
	}

	[Calls(Type = typeof(RenderObjectInstance), Member = "IsCategoryEnabled")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableCategory")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "IsCategoryEnabled")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_terrain_disableinstancedtrees()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "OverrideTerrainPixelError")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_terrain_setpixelerror()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
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

	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "AllEnabled")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
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

	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAimSway")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAllAimingMotion")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_disable_aim_sway()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAimStamina")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAllAimingMotion")]
	public static void CONSOLE_disable_aim_stamina()
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAllAimingMotion")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAimShake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void CONSOLE_timescale()
	{
	}

	[CallerCount(Count = 0)]
	public static void CONSOLE_trialmode()
	{
	}

	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
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

	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	public static void CONSOLE_ui_height()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_ui_width()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_ui_size()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_ultimatecamera_fixedstep()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_unequip_immediate()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	public static void CONSOLE_unlimited_sprint()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetBestGearItemWithName")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_use_best_gearitem()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void CONSOLE_use_legacyloading()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "SetPlayerVoicePersona")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(FlyMode), Member = "TeleportPlayerAndExit")]
	[Calls(Type = typeof(FlyMode), Member = "Warp")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(FlyMode), Member = "Warp")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "JoinCore")]
	[Calls(Type = typeof(uConsole), Member = "GetAllParameters")]
	[Calls(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void CONSOLE_warp()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "SetToken")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	private static void SaveToken(string token)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[Calls(Type = typeof(Quaternion), Member = "set_eulerAngles")]
	private static bool TryGetWarpToPosition(out Vector3 pos, out Quaternion rot)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref pos) = null;
		System.Runtime.CompilerServices.Unsafe.As<Quaternion, @null>(ref rot) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(WellFed), Member = "WellFedStart")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_well_fed()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 69)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	private static GameModeConfig GetGameModeConfig(string name)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(ConsoleManager), Member = "GetGameModeConfig")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(Inventory), Member = "DestroyAllGear")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode_keep_inventory")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_xpmode(bool resetInventory)
	{
	}

	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CallerCount(Count = 0)]
	public static void CONSOLE_xpmode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	public static void CONSOLE_xpmode_keep_inventory()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(LoadScene), Member = "Activate")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WeatherNameToEnum")]
	private static WeatherStage WeatherNameToEnum(string weatherName)
	{
		return default(WeatherStage);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_rabbit")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_moose")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_stag")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_doe")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_wolf_grey")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_grey_wolf_aurora")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_wolf")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_bear_old")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_aurorawolf")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_bear")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_aurorabear")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_bear_challenge")]
	[Calls(Type = typeof(UnityEngine.AddressableAssets.AddressablesImpl), Member = "InstantiateAsync")]
	[Calls(Type = typeof(InstantiationParameters), Member = ".ctor")]
	[Calls(Type = typeof(Addressables), Member = "LoadResourceLocationsAsync")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 12)]
	private static void spawn_common(string prefabName, float dist)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass472_0), Member = "<spawn_common>b__0")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void set_spawn_position(GameObject go, float dist)
	{
	}

	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearNames), Member = "GetBaseName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearNames), Member = "GetPrefixedName")]
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
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
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
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_rifle")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_toolrepair")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_revolver")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_archery")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_cooking")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowLevelUp")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_icefishing")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowPointIncrease")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	private static void SetSkillPoints(string command, SkillType skillType, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_firestarting_level")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_revolver_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_toolrepair_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_rifle_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_icefishing_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_cooking_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_clothingrepair_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_carcassharvesting_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_gunsmithing_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_archery_level")]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowLevelUp")]
	[CallerCount(Count = 10)]
	private static void SetSkillLevel(string command, SkillType skillType, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_freerunner")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_snowwalker")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_experttrapper")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_firemaster")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_blizzardwalker")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_straighttoheart")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_efficientmachine")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_nightwalker")]
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
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_wind")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_wind_immediate")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Wind), Member = "DirectionToAngle")]
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
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static void SetWind(string windName, string windDir, bool immediate)
	{
	}

	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private static void AudioCallback(object cookie, AkCallbackType type, object callbackInfo)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ConsoleManager()
	{
	}
}
