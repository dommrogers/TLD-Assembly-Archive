using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.PDID;
using TLD.Serialization;
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

	public AssetReferenceWithComponent<Campfire> m_CampFireReference;

	public float m_GunpowderKilogramsAccelerant;

	public GameObject m_GunpowderAccelerantPrefab;

	public static List<Fire> m_Fires;

	private static readonly HashSet<string> m_DestroyedFireGuids;

	private static readonly List<WoodStove> m_WoodStoves;

	private static readonly List<Campfire> m_Campfires;

	private GearItem m_FireStarterToDestroy;

	private bool m_ForceFireStartingSuccess;

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Fire), Member = "Serialize")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	public static string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(Fire), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "FindFireByPosition")]
	[Calls(Type = typeof(FireManager), Member = "FindFireByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Fire), Member = "CanBreakdownFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FireManager), Member = "FindFireByGuid")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(FireManager), Member = "InstantiateFireFromAddress")]
	public static void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	public static string SerializeChimneyData()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataPostSceneRestore")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Chimney), Member = "GetClosestChimney")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Chimney), Member = "FindByGuid")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	public static void DeserializeChimneyData(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void AddWoodStove(WoodStove ws)
	{
	}

	[CalledBy(Type = typeof(Campfire), Member = "Start")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void AddCampfire(Campfire cf)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnDoneStartingFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCancel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallsUnknownMethods(Count = 2)]
	public static void DestroyFireObject(Fire f)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[Calls(Type = typeof(Fire), Member = "OnFuelBurnt")]
	[Calls(Type = typeof(FireManager), Member = "CalculateFireStartSuccess")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(FireManager), Member = "PlayerCalculateFireStartTime")]
	public void PlayerStartFire(Fire fire, FireStarterItem starter, FuelSourceItem tinder, FuelSourceItem fuel, FireStarterItem accelerant, Action<bool> onDoneStartingFire)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void UpdateSkillAfterFireCreationAttempt(bool success)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshChanceOfSuccessLabel")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	public float CalculateFireStartSuccess(FireStarterItem starter, FuelSourceItem fuel, FireStarterItem accelerant)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void AddFire(Fire f)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void RemoveFire(Fire f)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CalledBy(Type = typeof(Fire), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCompleteCallback")]
	public static void RemoveFire(Fire f, bool permanent)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_FireStart), Member = "FilterItem")]
	[Calls(Type = typeof(Panel_FireStart), Member = "FilterItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FireStart), Member = "FilterItem")]
	public void GetMissingMaterials(out bool hasStarter, out bool hasTinder, out bool hasFuel)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref hasStarter) = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref hasTinder) = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref hasFuel) = null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoCampfireMessage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteStartFireAction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(FireManager), Member = "GetMissingMaterials")]
	[CallerCount(Count = 3)]
	public string GetMissingMaterialsString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "IsNearFire")]
	[CalledBy(Type = typeof(Cookable), Member = "IsNearFire")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeInvestigateMeatWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
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
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	public Fire GetClosestFire(Vector3 pos)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CalledBy(Type = typeof(StatusBar), Member = "ShouldBeHidden")]
	[CalledBy(Type = typeof(Weather), Member = "GetMinAirTemp")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Freezing), Member = "MaybeAdjustFreezingDueToNearbyFire")]
	public bool PointInRadiusOfBurningFire(Vector3 pos)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public bool PointInRadiusOfFullyBurningFire(Vector3 pos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool PointInInnerRadiusOfBurningFire(Vector3 pos)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool GetForceFireStartingSuccess()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetForceFireStartingSuccess(bool forceFireStartingSuccess)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	private float PlayerCalculateFireStartTime(FireStarterItem starter, FuelSourceItem fuel, FireStarterItem accelerant)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(FireManager), Member = "PlayerHasMaterialsToStartFire")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private FireStarterItem PlayerGetFirestarterChoice()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerHasMaterialsToStartFire")]
	[CallsUnknownMethods(Count = 6)]
	private FuelSourceItem PlayerGetTinderChoice()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerHasMaterialsToStartFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private FuelSourceItem PlayerGetFuelChoice()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerHasMaterialsToStartFire")]
	[CallsUnknownMethods(Count = 4)]
	private FireStarterItem PlayerGetAccelerantChoice()
	{
		return null;
	}

	[Calls(Type = typeof(FireManager), Member = "PlayerGetAccelerantChoice")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(FireManager), Member = "PlayerGetFuelChoice")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(FireManager), Member = "PlayerGetTinderChoice")]
	[Calls(Type = typeof(Skill_Firestarting), Member = "TinderRequired")]
	[Calls(Type = typeof(FireManager), Member = "PlayerGetFirestarterChoice")]
	[CallerCount(Count = 0)]
	private bool PlayerHasMaterialsToStartFire(out FireStarterItem starter, out FuelSourceItem tinder, out FuelSourceItem fuel, out FireStarterItem accelerant)
	{
		starter = null;
		tinder = null;
		fuel = null;
		accelerant = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool RollForSkillIncrease(bool success)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private static Fire FindFireByPosition(FireSaveData fsd)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	private static Fire FindFireByGuid(string guid)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseFireStarterInventoryItem")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteStartFireAction")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	public Fire InstantiateCampFire()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	private static Fire InstantiateFireFromAddress(string address)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FireManager()
	{
	}
}
