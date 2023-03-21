using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gameplay.Challenges.DarkWalker;
using TLD.Scenes;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

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
			return false;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "Reset")]
	[Calls(Type = typeof(GearManager), Member = "add_m_OnGearItemAdded")]
	[Calls(Type = typeof(GearManager), Member = "add_m_OnGearItemRemoved")]
	[Calls(Type = typeof(BaseAiManager), Member = "add_m_OnBaseAiAdded")]
	[Calls(Type = typeof(BaseAiManager), Member = "add_m_OnBaseAiRemoved")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[CallsUnknownMethods(Count = 1)]
	public float DetermineScaleForPlayerCondition()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[CallsUnknownMethods(Count = 2)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_reset")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_reset_all")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetTimeAccumulation(bool allregions)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_full")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_set")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	public void SetAccumulationPercent(float pct)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateNowhereToHide")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSceneOverrideTunable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetFogProgressForRegion(string regionName)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasPlacedDispelFogGlyph()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[CallsUnknownMethods(Count = 1)]
	public void PlaceGlyph(DecalProjectorInstance instance)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MigrateSaveData")]
	[Calls(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string serialized)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
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

	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "UpdateToxicFogIndicatorLabel")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "DetermineScaleForPlayerCondition")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetRemainingTimeToFullFogSeconds")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeKillAllWildlife")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSceneOverrideTunable")]
	[CallsUnknownMethods(Count = 1)]
	private float GetTimeSecondsToFillUpCurrentScene()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSceneOverrideTunable")]
	[CallsUnknownMethods(Count = 1)]
	private float GetTimeSecondsToFillUpScene(SceneSet sceneSet)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpScene")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	private ToxicFogConfig.SceneSetTunables GetSceneOverrideTunable(SceneSet sceneSet)
	{
		return null;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	private float GetPercentInCurrentRegion()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[CallsUnknownMethods(Count = 1)]
	public float GetRemainingTimeToFullFogSeconds()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(ToxicFogManager), Member = "InitCurrentRegion")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetClearNightFogDensity")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetToxicFogDensity")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeKillAllWildlife")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	private bool IsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsCurrentRegionValid()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetClearNightFogDensity")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetToxicFogDensity")]
	[CallsUnknownMethods(Count = 1)]
	private void SetFogDensity(float fogScale)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void OnGearItemAddedToWorld(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnGearItemRemovedFromWorld(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnBaseAiAddedToWorld(BaseAi baseAi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnBaseAiRemovedFromWorld(BaseAi baseAi)
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "WearOut")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeRuinFood()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(List<>), Member = "RemoveAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeKillAllWildlife()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(PlayerCough), Member = "Stop")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerCough), Member = "MaybeStart")]
	[CallsUnknownMethods(Count = 7)]
	private void MaybeReducePlayerCondition()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void AddSecondsInCurrentRegion(float seconds)
	{
	}

	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "UpdateToxicFogIndicatorLabel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "DetermineScaleForPlayerCondition")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "PlaceGlyph")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetRemainingTimeToFullFogSeconds")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeKillAllWildlife")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float GetSecondsInCurrentRegion()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "StartFogWeatherTransition")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void InitCurrentRegion()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "ResetTimeAccumulation")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "PlaceGlyph")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetSecondsInCurrentRegion(float seconds)
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = ".cctor")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	private static KeyValuePair<string, uint> MakeRegionCodeEntry(GameRegion region)
	{
		return default(KeyValuePair<string, uint>);
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetHashLookupTable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private uint GetRegionHashName(string regionName)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "MigrateSaveData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetHelper), Member = "FindAllAssetsLocations")]
	[Calls(Type = typeof(Addressables), Member = "LoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionHashName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private Dictionary<uint, SceneSet> GetHashLookupTable()
	{
		return null;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetHashLookupTable")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
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
