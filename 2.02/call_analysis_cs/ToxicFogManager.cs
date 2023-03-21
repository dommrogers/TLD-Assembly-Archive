using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CMaybeKillAllWildlife_003Eb__56_0(BaseAi ai)
		{
			return default(bool);
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

	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionHashName")]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterForBaseAiRemoved")]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterForBaseAiAdded")]
	[Calls(Type = typeof(ToxicFogManager), Member = "Reset")]
	[Calls(Type = typeof(GearManager), Member = "RegisterForOnGearItemAdded")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearManager), Member = "RegisterForOnGearItemRemoved")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	public float DetermineScaleForPlayerCondition()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[Calls(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_reset_all")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsActive")]
	public void ResetTimeAccumulation(bool allregions)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsActive")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_full")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_set")]
	public void SetAccumulationPercent(float pct)
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateNowhereToHide")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpRegion")]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionHash")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void PlaceGlyph(DecalProjectorInstance instance)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(Weather), Member = "MaybeCreateToxicFogSporeFx")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	public void Deserialize(string serialized)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 18)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsActive")]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(ToxicFogManager), Member = "DetermineCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "InitCurrentRegion")]
	[CallsUnknownMethods(Count = 2)]
	public void StartFogWeatherTransition()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionHashName")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsSceneOverrideAvailableForCurrentScene()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "StartFogWeatherTransition")]
	[CallerCount(Count = 3)]
	[CallAnalysisFailed]
	private uint DetermineCurrentRegion()
	{
		return default(uint);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private uint GetRegionHashFromName(string regionName, out GameRegion region)
	{
		System.Runtime.CompilerServices.Unsafe.As<GameRegion, @null>(ref region) = null;
		return default(uint);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionHashName")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[CallsUnknownMethods(Count = 2)]
	private uint GetRegionHash(GameRegion region, string fallback)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private GameRegion GetCurrentGameRegion()
	{
		return default(GameRegion);
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetRemainingTimeToFullFogSeconds")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "UpdateToxicFogIndicatorLabel")]
	[CallAnalysisFailed]
	[CallerCount(Count = 4)]
	private float GetTimeSecondsToFillUpCurrentRegion()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSceneOverrideTunable")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionTunables")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	private float GetTimeSecondsToFillUpRegion(GameRegion region, uint sceneHash)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpRegion")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private ToxicFogRegionTunables GetRegionTunables(GameRegion region)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpRegion")]
	[CallsUnknownMethods(Count = 3)]
	private ToxicFogSceneOverrideTunables GetSceneOverrideTunable(uint sceneHash)
	{
		return null;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeKillAllWildlife")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "DetermineScaleForPlayerCondition")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	private float GetPercentInCurrentRegion()
	{
		return default(float);
	}

	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetRemainingTimeToFullFogSeconds()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeKillAllWildlife")]
	[Calls(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetFogDensity")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "AddSecondsInCurrentRegion")]
	[Calls(Type = typeof(Weather), Member = "SetToxicFogParameters")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(ToxicFogManager), Member = "InitCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsSceneOverrideAvailableForCurrentScene")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetRegionHashName")]
	[Calls(Type = typeof(ToxicFogManager), Member = "DetermineCurrentRegion")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(ToxicFogManager), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetRegionHash")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "IsSceneOverrideAvailableForCurrentScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
	private uint GetRegionHashName(string regionName)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Serialize")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_reset")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "ResetTimeAccumulation")]
	private bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsCurrentRegionValid()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetToxicFogDensity")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	private void SetFogDensity(float fogScale)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnGearItemAddedToWorld(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void OnGearItemRemovedFromWorld(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnBaseAiAddedToWorld(BaseAi baseAi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnBaseAiRemovedFromWorld(BaseAi baseAi)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[Calls(Type = typeof(GearItem), Member = "WearOut")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	private void MaybeRuinFood()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	private void MaybeKillAllWildlife()
	{
	}

	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[Calls(Type = typeof(PlayerCough), Member = "MaybeStart")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "HeadachePulse")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerCough), Member = "Stop")]
	private void MaybeReducePlayerCondition()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	private void AddSecondsInCurrentRegion(float seconds)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetRemainingTimeToFullFogSeconds")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "PlaceGlyph")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "UpdateToxicFogIndicatorLabel")]
	private float GetSecondsInCurrentRegion()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private uint GetCurrentRegionKey()
	{
		return default(uint);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "StartFogWeatherTransition")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void InitCurrentRegion()
	{
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "SetAccumulationPercent")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "PlaceGlyph")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "ResetTimeAccumulation")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toxicfog_reset")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetSecondsInCurrentRegion(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 22)]
	public ToxicFogManager()
	{
	}
}
