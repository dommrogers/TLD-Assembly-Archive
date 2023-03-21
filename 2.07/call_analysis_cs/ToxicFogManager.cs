using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay.Challenges.DarkWalker;
using TLD.Scenes;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class ToxicFogManager : MonoBehaviour
{
	[Serializable]
	public struct ToxicFogGlobalDataProxy
	{
		public List<uint> m_TimeAccumulationKeys;

		public List<string> m_SceneKeys;

		public List<float> m_TimeAccumulationValues;

		public bool m_HasUsedDispelFogGlyph;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<BaseAi> _003C_003E9__42_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CMaybeKillAllWildlife_003Eb__42_0(BaseAi ai)
		{
			return default(bool);
		}
	}

	private PanelReference<Panel_Loading> m_Loading;

	private PanelReference<Panel_SprayPaint> m_SprayPaint;

	private ToxicFogConfig m_Config;

	public static bool s_IsPaused;

	private readonly Dictionary<SceneSet, float> m_AccumulatedTimeSeconds;

	private SceneSet m_CurrentSceneSet;

	private bool m_DetermineRegion;

	private bool m_HasAffliction;

	private readonly List<GearItem> m_FoodItemsToRuin;

	private readonly List<BaseAi> m_OnBaseAiToKill;

	private readonly List<GearItem> m_WornOut;

	private readonly List<string> m_SceneKeys;

	private readonly List<float> m_TimeValues;

	private bool m_HasUsedDispelFogGlyph;

	private const uint INVALID_REGION = uint.MaxValue;

	private static readonly Dictionary<string, uint> s_RegionCodes;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAiManager), Member = "add_m_OnBaseAiRemoved")]
	[Calls(Type = typeof(BaseAiManager), Member = "add_m_OnBaseAiAdded")]
	[Calls(Type = typeof(GearManager), Member = "add_m_OnGearItemRemoved")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearManager), Member = "add_m_OnGearItemAdded")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[CallsUnknownMethods(Count = 1)]
	public float DetermineScaleForPlayerCondition()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_reset_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_reset")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void ResetTimeAccumulation(bool allregions)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_full")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_set")]
	public void SetAccumulationPercent(float pct)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateNowhereToHide")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSceneOverrideTunable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	public float GetFogProgressForRegion(string regionName)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasPlacedDispelFogGlyph()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	public void PlaceGlyph(DecalProjectorInstance instance)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MigrateSaveData")]
	[Calls(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	public void Deserialize(string serialized)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(ToxicFogManager), Member = "InitCurrentRegion")]
	[CallsUnknownMethods(Count = 1)]
	public void StartFogWeatherTransition()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeKillAllWildlife")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetRemainingTimeToFullFogSeconds")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "UpdateToxicFogIndicatorLabel")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "DetermineScaleForPlayerCondition")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSceneOverrideTunable")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	private float GetTimeSecondsToFillUpCurrentScene()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSceneOverrideTunable")]
	private float GetTimeSecondsToFillUpScene(SceneSet sceneSet)
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpScene")]
	[CallsUnknownMethods(Count = 5)]
	private ToxicFogConfig.SceneSetTunables GetSceneOverrideTunable(SceneSet sceneSet)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	private float GetPercentInCurrentRegion()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	public float GetRemainingTimeToFullFogSeconds()
	{
		return default(float);
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetToxicFogDensity")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetClearNightFogDensity")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeKillAllWildlife")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "InitCurrentRegion")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	private bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsCurrentRegionValid()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetToxicFogDensity")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetClearNightFogDensity")]
	private void SetFogDensity(float fogScale)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void OnGearItemAddedToWorld(GearItem gearItem)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnGearItemRemovedFromWorld(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnBaseAiAddedToWorld(BaseAi baseAi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnBaseAiRemovedFromWorld(BaseAi baseAi)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GearItem), Member = "WearOut")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybeRuinFood()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeKillAllWildlife()
	{
	}

	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[Calls(Type = typeof(PlayerCough), Member = "MaybeStart")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerCough), Member = "Stop")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	private void MaybeReducePlayerCondition()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void AddSecondsInCurrentRegion(float seconds)
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "PlaceGlyph")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeKillAllWildlife")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetRemainingTimeToFullFogSeconds")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "UpdateToxicFogIndicatorLabel")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "DetermineScaleForPlayerCondition")]
	[CallsUnknownMethods(Count = 2)]
	private float GetSecondsInCurrentRegion()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "StartFogWeatherTransition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	private void InitCurrentRegion()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "ResetTimeAccumulation")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "PlaceGlyph")]
	[CallsUnknownMethods(Count = 1)]
	private void SetSecondsInCurrentRegion(float seconds)
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	private static KeyValuePair<string, uint> MakeRegionCodeEntry(GameRegion region)
	{
		return default(KeyValuePair<string, uint>);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetHashLookupTable")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private uint GetRegionHashName(string regionName)
	{
		return default(uint);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionHashName")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MigrateSaveData")]
	[CallsUnknownMethods(Count = 10)]
	private Dictionary<uint, SceneSet> GetHashLookupTable()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetHashLookupTable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MigrateSaveData(List<uint> keys, List<float> values)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public ToxicFogManager()
	{
	}
}
