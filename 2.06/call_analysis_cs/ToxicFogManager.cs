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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "Reset")]
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

	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_reset")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_reset_all")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetTimeAccumulation(bool allregions)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_set")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_full")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	public void SetAccumulationPercent(float pct)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSceneOverrideTunable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateNowhereToHide")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[CallsUnknownMethods(Count = 1)]
	public void PlaceGlyph(DecalProjectorInstance instance)
	{
	}

	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[Calls(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MigrateSaveData")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public void Deserialize(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
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

	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeKillAllWildlife")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetRemainingTimeToFullFogSeconds")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "DetermineScaleForPlayerCondition")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "UpdateToxicFogIndicatorLabel")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSceneOverrideTunable")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	private float GetTimeSecondsToFillUpCurrentScene()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSceneOverrideTunable")]
	[CallsUnknownMethods(Count = 1)]
	private float GetTimeSecondsToFillUpScene(SceneSet sceneSet)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpScene")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	private ToxicFogConfig.SceneSetTunables GetSceneOverrideTunable(SceneSet sceneSet)
	{
		return null;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	private float GetPercentInCurrentRegion()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[CallerCount(Count = 0)]
	public float GetRemainingTimeToFullFogSeconds()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeKillAllWildlife")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetToxicFogDensity")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetClearNightFogDensity")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ToxicFogManager), Member = "InitCurrentRegion")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[DeduplicatedMethod]
	private bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public bool IsCurrentRegionValid()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetToxicFogDensity")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetClearNightFogDensity")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void SetFogDensity(float fogScale)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void OnGearItemAddedToWorld(GearItem gearItem)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnGearItemRemovedFromWorld(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "WearOut")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallsUnknownMethods(Count = 15)]
	private void MaybeRuinFood()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void MaybeKillAllWildlife()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[Calls(Type = typeof(PlayerCough), Member = "MaybeStart")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerCough), Member = "Stop")]
	private void MaybeReducePlayerCondition()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void AddSecondsInCurrentRegion(float seconds)
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetRemainingTimeToFullFogSeconds")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeKillAllWildlife")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "PlaceGlyph")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "DetermineScaleForPlayerCondition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "UpdateToxicFogIndicatorLabel")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	private float GetSecondsInCurrentRegion()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "StartFogWeatherTransition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	private void InitCurrentRegion()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "PlaceGlyph")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "ResetTimeAccumulation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
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
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	private static KeyValuePair<string, uint> MakeRegionCodeEntry(GameRegion region)
	{
		return default(KeyValuePair<string, uint>);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetHashLookupTable")]
	[CallsUnknownMethods(Count = 3)]
	private uint GetRegionHashName(string regionName)
	{
		return default(uint);
	}

	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionHashName")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MigrateSaveData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 18)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private Dictionary<uint, SceneSet> GetHashLookupTable()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetHashLookupTable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	private void MigrateSaveData(List<uint> keys, List<float> values)
	{
	}

	[CallsUnknownMethods(Count = 33)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public ToxicFogManager()
	{
	}
}
