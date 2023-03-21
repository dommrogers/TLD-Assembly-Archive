using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FireManager : MonoBehaviour
{
	public float m_WindSpeedThatMakeStartingFireImpossible;

	public float m_WindSpeedThatBlowsOutFires;

	public float m_SkillIncreaseChanceOnSuccess;

	public float m_SkillIncreaseChanceOnFailure;

	public float m_StartFireTimeSeconds;

	public float m_StartFireTimeSecondsWet;

	public float m_TODMinutesFadeOutFireAudio;

	public float m_MinimumNormalizedFadeOutVolume;

	public float m_MinAirTempFromFireOutdoors;

	public float m_MinAirTempFromFireIndoors;

	public float m_MaxHeatIncreaseOfFireInForge;

	public float m_MaxHeatIncreaseOfFire;

	public float m_MaxDurationHoursOfFire;

	public float m_FireOuterRadiusScaleIndoors;

	public float m_TempBeginBurnRateAdjustment;

	public float m_TempEndBurnRateAdjustment;

	public float m_MaxBurnRateAdjustment;

	public float m_TakeTorchReduceBurnMinutes;

	public float m_KeroseneLitersAccelerant;

	public GameObject m_KeroseneAccelerantPrefab;

	public GameObject m_CampFirePrefab;

	public float m_GunpowderKilogramsAccelerant;

	public GameObject m_GunpowderAccelerantPrefab;

	public static List<Fire> m_Fires;

	public static List<string> m_DestroyedFireGuids;

	private static List<WoodStove> m_WoodStoves;

	private static List<Campfire> m_Campfires;

	private GearItem m_FireStarterToDestroy;

	private bool m_ForceFireStartingSuccess;

	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Fire), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(FireSaveList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(ObjectGuidManager), Member = "UnRegisterGuid")]
	[Calls(Type = typeof(ObjectGuid), Member = "Set")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Fire), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FireManager), Member = "InstantiateFireGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FireManager), Member = "FindFireByPosition")]
	[Calls(Type = typeof(FireManager), Member = "FindFireByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FireManager), Member = "FindFireByGuid")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ChimneySaveList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static string SerializeChimneyData()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataPostSceneRestore")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Chimney), Member = "GetClosestChimney")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Chimney), Member = "FindByGuid")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	public static void DeserializeChimneyData(string text)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void AddWoodStove(WoodStove ws)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ObjectGuid), Member = "Generate")]
	[Calls(Type = typeof(ObjectGuid), Member = "Register")]
	[CalledBy(Type = typeof(Campfire), Member = "Start")]
	[CallsUnknownMethods(Count = 5)]
	public static void AddCampfire(Campfire cf)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCancel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void DestroyFireObject(Fire f)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Campfire), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(FireManager), Member = "SpawnPlayerFire")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(FireManager), Member = "PlayerCalculateFireStartTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public bool PlayerStartFire(Campfire campfire, FireStarterItem starter, FuelSourceItem tinder, FuelSourceItem fuel, FireStarterItem accelerant, float percentChanceSuccess)
	{
		return default(bool);
	}

	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void UpdateSkillAfterFireCreationAttempt(bool success)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float CalclateFireStartSuccess(FireStarterItem starter, FuelSourceItem fuel, FireStarterItem accelerant)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void AddFire(Fire f)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Fire), Member = "OnDestroy")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public static void RemoveFire(Fire f)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(Panel_FireStart), Member = "FilterItem")]
	[Calls(Type = typeof(Panel_FireStart), Member = "FilterItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FireStart), Member = "FilterItem")]
	public void GetMissingMaterials(out bool hasStarter, out bool hasTinder, out bool hasFuel)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref hasStarter) = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref hasTinder) = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref hasFuel) = null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteStartFireAction")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoCampfireMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(FireManager), Member = "GetMissingMaterials")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	public string GetMissingMaterialsString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "IsNearFire")]
	[CalledBy(Type = typeof(Cookable), Member = "IsNearFire")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeInvestigateMeatWhenStalking")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	public float GetDistanceToClosestFire(Vector3 pos)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForHappySuccess")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Serialize")]
	[CalledBy(Type = typeof(Rest), Member = "GetNearbyBuringFire")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	public Fire GetClosestFire(Vector3 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Weather), Member = "GetMinAirTemp")]
	[CalledBy(Type = typeof(StatusBar), Member = "ShouldBeHidden")]
	[CalledBy(Type = typeof(Freezing), Member = "MaybeAdjustFreezingDueToNearbyFire")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public bool PointInRadiusOfBurningFire(Vector3 pos)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Freezing), Member = "UpdateHoursWithinRangeOfFire")]
	[CallsUnknownMethods(Count = 5)]
	public bool PointInRadiusOfFullyBurningFire(Vector3 pos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(TorchItem), Member = "MaybeAdjustHeatSource")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	public bool PointInInnerRadiusOfBurningFire(Vector3 pos)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[CallsUnknownMethods(Count = 1)]
	public void ExitFireStarting()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool PlayerRollFireStartSuccess(float percentChanceSuccess)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool GetForceFireStartingSuccess()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetForceFireStartingSuccess(bool forceFireStartingSuccess)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CallsUnknownMethods(Count = 7)]
	private bool PlayerCalculateFireStartTime(out float duration, FireStarterItem starter, FuelSourceItem fuel, FireStarterItem accelerant)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref duration) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerHasMaterialsToStartFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private FireStarterItem PlayerGetFirestarterChoice()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerHasMaterialsToStartFire")]
	[CallsUnknownMethods(Count = 13)]
	private FuelSourceItem PlayerGetTinderChoice()
	{
		return null;
	}

	[CalledBy(Type = typeof(FireManager), Member = "PlayerHasMaterialsToStartFire")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private FuelSourceItem PlayerGetFuelChoice()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerHasMaterialsToStartFire")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private FireStarterItem PlayerGetAccelerantChoice()
	{
		return null;
	}

	[Calls(Type = typeof(FireManager), Member = "PlayerGetFuelChoice")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(FireManager), Member = "PlayerGetAccelerantChoice")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(FireManager), Member = "PlayerGetTinderChoice")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(FireManager), Member = "PlayerGetFirestarterChoice")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	private bool PlayerHasMaterialsToStartFire(out FireStarterItem starter, out FuelSourceItem tinder, out FuelSourceItem fuel, out FireStarterItem accelerant)
	{
		starter = null;
		tinder = null;
		fuel = null;
		accelerant = null;
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[Calls(Type = typeof(Fire), Member = "OnFuelBurnt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private bool SpawnPlayerFire(Campfire campfire, bool startFireAfterCountdown, float tinderIgniteTimeSeconds, float startTimeSeconds, FireStarterItem starter, FuelSourceItem fuel, FireStarterItem accelerant)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool RollForSkillIncrease(bool success)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private static Fire GetFireComponent(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	private static Fire FindFireByPosition(FireSaveData fsd)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	private static Fire FindFireByGuid(string guid)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private static Fire InstantiateFireGameObject(FireSaveData fsd)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FireManager()
	{
	}
}
