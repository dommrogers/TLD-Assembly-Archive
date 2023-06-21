using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Framework;
using NodeCanvas.Tasks.Actions;
using TLD.AddressableAssets;
using TLD.Audio;
using TLD.BigCarry;
using TLD.Cooking;
using TLD.Gameplay;
using TLD.Gameplay.Condition;
using TLD.GameplayTags;
using TLD.Gear;
using TLD.OptionalContent;
using TLD.Rendering;
using TLD.SaveState;
using TLD.Scenes;
using TLD.UI.Generics;
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

		public static Comparison<MissionObjectIdentifier> _003C_003E9__129_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		internal int _003CCONSOLE_dump_mission_objects_003Eb__129_0(MissionObjectIdentifier a, MissionObjectIdentifier b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass247_0
	{
		public string regionName;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass247_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CCONSOLE_unlock_region_003Eb__0(RegionSpecification region)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass482_0
	{
		public string prefabName;

		public float dist;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass482_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Status")]
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
		[Calls(Type = typeof(ConsoleManager), Member = "set_spawn_position")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003Cspawn_common_003Eb__0(AsyncOperationHandle<GameObject> goOp)
		{
		}
	}

	public static Dictionary<string, List<string>> m_ComponentNameToGearNames;

	private static Dictionary<string, string> m_SearchStringToGearNames;

	private static bool m_Initialized;

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleManager), Member = "StoreAutoCompleteGearNames")]
	[Calls(Type = typeof(ConsoleManager), Member = "RegisterCommands")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "CreateCommandParameterSet")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Panel_Debug), Member = "PopulateTimelineOptions")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 24)]
	public static void Initialize()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommandReturn")]
	[CallsDeduplicatedMethods(Count = 484)]
	[CallsUnknownMethods(Count = 1192)]
	public static void RegisterCommands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashSet<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_add_all_gear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(BaseAiManager), Member = "UpdateCollisionMode")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningStart")]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryStart")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricStart")]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[Calls(Type = typeof(Infection), Member = "InfectionStart")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[Calls(Type = typeof(Frostbite), Member = "FrostbiteStart")]
	[Calls(Type = typeof(InsomniaManager), Member = "ApplyInsomniaAffliction")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_afflictions()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_god")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningEnd")]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryEnd")]
	[Calls(Type = typeof(SprainedAnkle), Member = "Cure")]
	[Calls(Type = typeof(SprainedWrist), Member = "Cure")]
	[Calls(Type = typeof(SprainPain), Member = "CureAffliction")]
	[Calls(Type = typeof(Burns), Member = "BurnsEnd")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaEnd")]
	[Calls(Type = typeof(BloodLoss), Member = "Cure")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	[Calls(Type = typeof(InfectionRisk), Member = "Cure")]
	[Calls(Type = typeof(Infection), Member = "Cure")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[Calls(Type = typeof(Suffocating), Member = "StopAudio")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadReplacementAtlases")]
	[CallsUnknownMethods(Count = 3)]
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
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsInt")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_autosave()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(BeachcombingManager), Member = "DebugForceBlizzard")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_beachcombing_force_blizzard()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_bearspear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_brokenrib()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(BlueprintManager), Member = "FindBlueprintsForGear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BlueprintManager), Member = "UnlockWithNotification")]
	[CallsUnknownMethods(Count = 3)]
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
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_bow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_breakdown_all()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(ConditionRestBuff), Member = "Apply")]
	[Calls(Type = typeof(FreezingBuff), Member = "Apply")]
	[Calls(Type = typeof(FatigueBuff), Member = "Apply")]
	[Calls(Type = typeof(WellFed), Member = "WellFedStart")]
	[Calls(Type = typeof(ConditionOverTimeBuff), Member = "Apply")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_cabinfever_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_carrion_stagger()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_capture_lighting()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_capture_lighting_all()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_challenge_complete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ChallengeConfig), Member = "get_UnlockedBadge")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static void CONSOLE_challenge_complete_all()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_badges_lock")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	public static void CONSOLE_badges_list()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_badges_list")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_badges_lock()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_badge_lock_all()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_character_splitstep_optimization()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(CameraGlobalRT), Member = "EnableChromaKeyMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_chroma_key_mode()
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Container), Member = "GetTotalCalories")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Container), Member = "GetHoursFuel")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(Container), Member = "AllFoodItemsAreNatural")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_container_test()
	{
	}

	[CallerCount(Count = 0)]
	public static void CONSOLE_create_jump()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 5)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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
	public static void CONSOLE_debug_radial_spawning()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(DebugViewModeManager), Member = "SetMode")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_deferred_rendering()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "AssignCategory")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_dialogue_setanimationstate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "get_parameters")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(bool), Member = "Parse")]
	[Calls(Type = typeof(int), Member = "Parse")]
	[Calls(Type = typeof(float), Member = "Parse")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_dialogue_setanimationparameter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_dialogue_setframing()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_hideFlags")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ShouldIgnoreMissionObject")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 52)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(DynamicResolutionHelper), Member = "SetForcedResolutionScale")]
	public static void CONSOLE_dynamic_resolution_set_scale()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(DynamicResolutionHelper), Member = "TrySetFramerateTarget")]
	public static void CONSOLE_dynamic_resolution_set_framerate_target()
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryStart")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	public static void CONSOLE_fade_out()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_cinematic_fade_blackout()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 24)]
	public static void CONSOLE_feat_set_enabled()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_force_aurora()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CallsUnknownMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_force_limp_slow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_disable_procedural_instancing()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_dlc_can_use_content()
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyListKnownDLC")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "LoadAllConfigs")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Join")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 25)]
	public static void CONSOLE_dlc_list_known_content()
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyListAvailableDLC")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(OptionalContentManager), Member = "TryFindConfig")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public static void CONSOLE_dlc_list_available_content()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "OpenContentInStore")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_force_skip_enabled()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_force_mobility_reduction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsInt")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Utils), Member = "TryParseTOD")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_force_sleep_length()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static void CONSOLE_gear_add()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsInt")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
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
	public static object CONSOLE_get_stamina()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaEnd")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_invisibleentity_addspace()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetRange")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Infection), Member = "Cure")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_infection_risk()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Knowledge), Member = "GetKnowledgeCategoryFromName")]
	[Calls(Type = typeof(Knowledge), Member = "GetLocalizedKnowledgeCategoryName")]
	[Calls(Type = typeof(Knowledge), Member = "Unlock")]
	public static void CONSOLE_knowledge_unlock()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_lampinfinite()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Localization), Member = "set_Language")]
	[Calls(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
	[CallsUnknownMethods(Count = 6)]
	public static void CONSOLE_lang()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Utils), Member = "TryParseTOD")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_lighting_preview()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 2)]
	private static void CONSOLE_lock_region()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetsAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(RegionSpecification), Member = "IsUnlocked")]
	[Calls(Type = typeof(RegionSpecification), Member = "MaybeUnlock")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void CONSOLE_unlock_region()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WeatherNameToEnum")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_lod_bias()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_makestrugglepartnerflee()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_mission_jump()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	public static void CONSOLE_mission_add()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionManager")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_mission_remove()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "IsMissionActive")]
	[CallsUnknownMethods(Count = 3)]
	public static object CONSOLE_is_mission_active()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "AddMissionObjectFilterTags")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_mission_add_filter_tags()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionObjectFilterTags")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_mission_remove_filter_tags()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceNextWeatherStage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(NPC), Member = "FindNearest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_npc_conditionupdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(NPC), Member = "FindNearest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_npc_bloodloss()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_npc_disable_conditions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_npc_goto()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(BaseAi), Member = "GoToAiMarker")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(PassTime), Member = "Begin")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(PlayerStunned), Member = "Begin")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_player_stunned()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_parasites_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Phone), Member = "StartPhoneRinging")]
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
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	public static void CONSOLE_play_movie_alpha_ext()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayDynamicSequence")]
	public static void CONSOLE_play_dd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneMusicManager), Member = "PlayExploreMusic")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_play_exploremusic()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SoundbankLoader), Member = "DebugLoadAllEpisodeBanks")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_play_sorrowmusic()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public static void CONSOLE_play_sound()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_play_soundlogduration()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_play_unistorm_anim()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_random_voice()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_random_weather()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(RecipeBook), Member = "UnlockRecipe")]
	[CallsUnknownMethods(Count = 5)]
	public static void CONSOLE_recipe_unlock()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RecipeBook), Member = "UnlockRecipe")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_recipe_unlock_all()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(FPSLogger), Member = "StopRecording")]
	[Calls(Type = typeof(FPSLogger), Member = "StartRecording")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_revolver()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[CallsUnknownMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ToxicFogManager), Member = "ResetTimeAccumulation")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(InputManager), Member = "StopVibration")]
	public static void CONSOLE_rumble()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_safezone()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "ForceSaveGame")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_save()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Utils), Member = "SaveView")]
	public static void CONSOLE_save_view()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(uConsole), Member = "TurnOff")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_scene()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(SceneManager), Member = "AddLayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_scene_addlayer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(SceneManager), Member = "RemoveLayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(Condition), Member = "GetMaxHPModifier")]
	[CallsUnknownMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_set_fatigue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "JoinCore")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public static void CONSOLE_set_hud_display_mode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public static void CONSOLE_set_image_filter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "WeatherNameToEnum")]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(Weather), Member = "GetCustomWeatherSet")]
	[Calls(Type = typeof(WeatherSetData), Member = "Prepare")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_set_weather()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(ConsoleManager), Member = "SetWind")]
	public static void CONSOLE_set_wind()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ShaderComparison), Member = "Toggle")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_shader_toggle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_show_decal_debug()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_show_location_reveal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_show_lookat()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	public static void CONSOLE_show_days_survived()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_show_tod_slider()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_skip_next_conversation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_survey()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "ClearData")]
	[Calls(Type = typeof(MapDetailManager), Member = "LockAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_survey_clear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	public static void CONSOLE_spawn_bear_old()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
	public static void CONSOLE_spawn_ptarmigan()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigCarrySystem), Member = "FindOrCreateBigCarryItem")]
	[Calls(Type = typeof(BigCarrySystem), Member = "AddItem")]
	[Calls(Type = typeof(BigCarrySystem), Member = "StickCarryItemGroundAtPlayersFeet")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_spawn_travois()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(ConsoleManager), Member = "spawn_common")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_sprain_wrist_nofx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameModeConfig), Member = "DestroyMissionServicesManager")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_sandbox()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static SceneSet GetSceneSetFromLoadedScenes()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void CONSOLE_story()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_suppress_breath_fx()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static void CONSOLE_teleport()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "ForceDisableTerrainTrees")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_terrain_disabletrees()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "IsCategoryEnabled")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableCategory")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "AllEnabled")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	public static void CONSOLE_enable_renderobjectinstances()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "AllEnabled")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	public static void CONSOLE_enable_renderobjectinstances_norenderers()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CONSOLE_enable_renderobjectinstances_debugtext()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_enable_renderobjectinstances_frustumtest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(Utils), Member = "EnableShadows")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_enable_shadows()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_enable_specular()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_enable_ai_frustum_culling()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_texture_streaming_budget()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsFloat")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_texel_density()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_texture_streaming_caching()
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAimBreathing")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAllAimingMotion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_disable_aim_breath()
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAimSway")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAllAimingMotion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_disable_aim_sway()
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAimStamina")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAllAimingMotion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_disable_aim_stamina()
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAimShake")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAllAimingMotion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public static void CONSOLE_disable_aim_shake()
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAmbientSway")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableAllAimingMotion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "IsAmbientSwayDisabled")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_disable_ambient_sway()
	{
	}

	[CallerCount(Count = 0)]
	public static void CONSOLE_disable_probe_updates()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CallsUnknownMethods(Count = 1)]
	public static void CONSOLE_drop_lit_item_in_hands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[Calls(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_drop_scatter_item_in_hands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetConditionLabelDepth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_timeofday_display()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public static void CONSOLE_ui_height()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetBestGearItemWithName")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 3)]
	public static void CONSOLE_use_best_gearitem()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
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
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_vsync()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "TryGetWarpToPosition")]
	[Calls(Type = typeof(uConsole), Member = "GetAllParameters")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(string), Member = "JoinCore")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(FlyMode), Member = "Warp")]
	[Calls(Type = typeof(FlyMode), Member = "Warp")]
	[Calls(Type = typeof(FlyMode), Member = "TeleportPlayerAndExit")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	public static void CONSOLE_warp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "SetToken")]
	[CallsUnknownMethods(Count = 1)]
	private static void SaveToken(string token)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "TryGetFloat")]
	[Calls(Type = typeof(Quaternion), Member = "set_eulerAngles")]
	private static bool TryGetWarpToPosition(out Vector3 pos, out Quaternion rot)
	{
		pos = default(Vector3);
		rot = default(Quaternion);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WellFed), Member = "WellFedStart")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_well_fed()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 65)]
	private static GameModeConfig GetGameModeConfig(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode_keep_inventory")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void CONSOLE_xpmode(bool resetInventory)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	public static void CONSOLE_xpmode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	public static void CONSOLE_xpmode_keep_inventory()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(LoadScene), Member = "Activate")]
	[CallsUnknownMethods(Count = 2)]
	public static void CONSOLE_jump_to_loadingzone()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
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

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_aurorawolf")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_aurorabear")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_bear")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_bear_challenge")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_bear_old")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_doe")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_moose")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_rabbit")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_stag")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_ptarmigan")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_wolf")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_wolf_grey")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_grey_wolf_aurora")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Addressables), Member = "LoadResourceLocationsAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[Calls(Type = typeof(InstantiationParameters), Member = ".ctor")]
	[Calls(TypeFullName = "UnityEngine.AddressableAssets.AddressablesImpl", Member = "InstantiateAsync")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void spawn_common(string prefabName, float dist)
	{
	}

	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass482_0), Member = "<spawn_common>b__0")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 12)]
	private static void set_spawn_position(GameObject go, float dist)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadTypedAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearNames), Member = "GetPrefixedName")]
	[Calls(Type = typeof(GearNames), Member = "GetBaseName")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 25)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[CallsUnknownMethods(Count = 1)]
	private static void CONSOLE_mapmarker_add()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "RevealCurrentScene")]
	[CallsUnknownMethods(Count = 1)]
	private static void CONSOLE_map_reveal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void CONSOLE_map_unlock_region()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_archery")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_firestarting")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_gunsmithing")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_carcassharvesting")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_clothingrepair")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_cooking")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_icefishing")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_rifle")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_toolrepair")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_revolver")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowPointIncrease")]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowLevelUp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void SetSkillPoints(string command, SkillType skillType, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_archery_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_firestarting_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_gunsmithing_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_carcassharvesting_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_clothingrepair_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_cooking_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_icefishing_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_rifle_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_toolrepair_level")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_skill_revolver_level")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SkillsManager), Member = "GetSkill")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(SkillsManager), Member = "GetTierName")]
	[Calls(Type = typeof(SkillNotify), Member = "MaybeShowLevelUp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void SetSkillLevel(string command, SkillType skillType, SkillsManager.PointAssignmentMode mode)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_booksmarts")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_coldfusion")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_efficientmachine")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_firemaster")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_freerunner")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_snowwalker")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_experttrapper")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_straighttoheart")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_blizzardwalker")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_nightwalker")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeat")]
	[Calls(Type = typeof(uConsole), Member = "GetNumParameters")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void SetFeat(string command, FeatType featType)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_wind")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_wind_immediate")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "GetRandomEnum")]
	[Calls(Type = typeof(Wind), Member = "DirectionToAngle")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CallsUnknownMethods(Count = 3)]
	public static void SetWind(string windName, string windDir, bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsUnknownMethods(Count = 2)]
	private static void AudioCallback(object cookie, AkCallbackType type, object callbackInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	private static void CONSOLE_debug_transponder()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	private static void CONSOLE_debug_transmitter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private static void CONSOLE_repair_transmitters()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ConsoleManager()
	{
	}
}
