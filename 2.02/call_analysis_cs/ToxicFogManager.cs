using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;
using UnityEngine;

public class ToxicFogManager : MonoBehaviour
{
	[Serializable]
	public struct ToxicFogGlobalDataProxy
	{
		public List<uint> m_TimeAccumulationKeys;

		public List<float> m_TimeAccumulationValues;

		public bool m_HasUsedDispelFogGlyph;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<BaseAi> _003C_003E9__56_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CMaybeKillAllWildlife_003Eb__56_0(BaseAi ai)
		{
			return false;
		}
	}

	public float m_TimeToFillUpToMaximumMinutes;

	public float m_TimePassingScalar;

	public List<ToxicFogRegionTunables> m_ToxicFogRegionTunables;

	public List<ToxicFogSceneOverrideTunables> m_ToxicFogSceneOverrideTunables;

	public float m_FogScaleToRuinFood;

	public float m_FogScaleToKillAllWildlife;

	public float m_FogScaleToReduceCondition;

	public float m_FogReductionOnDispelFogGlyph;

	public float m_MinimumFogScale;

	public float m_MaximumFogScale;

	public ToxicFogIndicatorTunables m_ToxicFogIndicatorTunables;

	public static bool s_IsPaused;

	private Dictionary<uint, float> m_TimeAccumulationSeconds;

	private uint m_CurrentRegion;

	private bool m_DetermineRegion;

	private uint m_CurrentSceneHash;

	private bool m_IsSceneOverrideAvailable;

	private bool m_HasAffliction;

	private List<GearItem> m_FoodItemsToRuin;

	private List<BaseAi> m_OnBaseAiToKill;

	private bool m_HasUsedDispelFogGlyph;

	private const uint INVALID_REGION = uint.MaxValue;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "Reset")]
	[Calls(Type = typeof(GearManager), Member = "RegisterForOnGearItemAdded")]
	[Calls(Type = typeof(GearManager), Member = "RegisterForOnGearItemRemoved")]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterForBaseAiAdded")]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterForBaseAiRemoved")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionHashName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 31)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float DetermineScaleForPlayerCondition()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_reset_all")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsActive")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void ResetTimeAccumulation(bool allregions)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_full")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_set")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsActive")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetAccumulationPercent(float pct)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateNowhereToHide")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsActive")]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionHash")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpRegion")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
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
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PlaceGlyph(DecalProjectorInstance instance)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsActive")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void Deserialize(string serialized)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsActive")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(ToxicFogManager), Member = "DetermineCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "InitCurrentRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StartFogWeatherTransition()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionHashName")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsSceneOverrideAvailableForCurrentScene()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "StartFogWeatherTransition")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 3)]
	private uint DetermineCurrentRegion()
	{
		return 0u;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private uint GetRegionHashFromName(string regionName, out GameRegion region)
	{
		region = default(GameRegion);
		return 0u;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionHashName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private uint GetRegionHash(GameRegion region, string fallback)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private GameRegion GetCurrentGameRegion()
	{
		return default(GameRegion);
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "UpdateToxicFogIndicatorLabel")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetRemainingTimeToFullFogSeconds")]
	[CallerCount(Count = 4)]
	private float GetTimeSecondsToFillUpCurrentRegion()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSceneOverrideTunable")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionTunables")]
	private float GetTimeSecondsToFillUpRegion(GameRegion region, uint sceneHash)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpRegion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private ToxicFogRegionTunables GetRegionTunables(GameRegion region)
	{
		return null;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpRegion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private ToxicFogSceneOverrideTunables GetSceneOverrideTunable(uint sceneHash)
	{
		return null;
	}

	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "DetermineScaleForPlayerCondition")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeKillAllWildlife")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetPercentInCurrentRegion()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetRemainingTimeToFullFogSeconds()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(ToxicFogManager), Member = "DetermineCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionHashName")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsSceneOverrideAvailableForCurrentScene")]
	[Calls(Type = typeof(ToxicFogManager), Member = "InitCurrentRegion")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[Calls(Type = typeof(ToxicFogManager), Member = "AddSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetFogDensity")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeKillAllWildlife")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "IsSceneOverrideAvailableForCurrentScene")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetRegionHash")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private uint GetRegionHashName(string regionName)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_reset")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "ResetTimeAccumulation")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Serialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsCurrentRegionValid()
	{
		return false;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetToxicFogDensity")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void SetFogDensity(float fogScale)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnGearItemAddedToWorld(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnGearItemRemovedFromWorld(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnBaseAiAddedToWorld(BaseAi baseAi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnBaseAiRemovedFromWorld(BaseAi baseAi)
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(GearItem), Member = "WearOut")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	private void MaybeRuinFood()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(List<>), Member = "RemoveAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void MaybeKillAllWildlife()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(PlayerCough), Member = "Stop")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "HeadachePulse")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerCough), Member = "MaybeStart")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private void MaybeReducePlayerCondition()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void AddSecondsInCurrentRegion(float seconds)
	{
	}

	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "UpdateToxicFogIndicatorLabel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "PlaceGlyph")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetRemainingTimeToFullFogSeconds")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private float GetSecondsInCurrentRegion()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private uint GetCurrentRegionKey()
	{
		return 0u;
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "StartFogWeatherTransition")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void InitCurrentRegion()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_reset")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "ResetTimeAccumulation")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "PlaceGlyph")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void SetSecondsInCurrentRegion(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	public ToxicFogManager()
	{
	}
}
