using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Cooking;
using TLD.Gear;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class CookingPotItem : MonoBehaviour
{
	public enum CookingState
	{
		Cooking,
		Ready,
		Ruined
	}

	public enum GrubMeshType
	{
		Pot,
		Can,
		FryingPan
	}

	private CookSettings m_CookSettings;

	public bool m_CanCookMeat;

	public bool m_CanCookGrub;

	public bool m_CanCookLiquid;

	public bool m_CanOnlyWarmUpFood;

	public float m_WaterCapacityLiters;

	public float m_ConditionPercentDamageFromBurningFood;

	public float m_ConditionPercentDamageFromBoilingDry;

	public float m_CookingTimeMultiplier;

	public float m_ReadyTimeMultiplier;

	public float m_BoilingTimeMultiplier;

	public float m_LampOilMultiplier;

	public float m_CookedCalorieMultiplier;

	public float m_NearFireWarmUpCookingTimeMultiplier;

	public float m_NearFireWarmUpReadyTimeMultiplier;

	public float m_WarningMinutesBeforeCooked;

	public float m_WarningMinutesBeforeRuined;

	public GrubMeshType m_GrubMeshType;

	public MeshFilter m_GrubMeshFilter;

	public MeshRenderer m_GrubMeshRenderer;

	public Material[] m_RuinedFoodMaterialsList;

	public Material[] m_MeltSnowMaterialsList;

	public Material[] m_BoilWaterPotMaterialsList;

	public Material[] m_BoilWaterReadyMaterialsList;

	public Mesh m_SnowMesh;

	public Mesh m_WaterMesh;

	public GameObject m_ParticlesItemCooking;

	public GameObject m_ParticlesItemReady;

	public GameObject m_ParticlesItemRuined;

	public GameObject m_ParticlesSnowMelting;

	public GameObject m_ParticlesWaterBoiling;

	public GameObject m_ParticlesWaterReady;

	public GameObject m_ParticlesWaterRuined;

	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	private PanelReference<Panel_CanOpening> m_CanOpening;

	private PanelReference<Panel_Rest> m_Rest;

	private GearItem m_GearItem;

	private Fire m_FireBeingUsed;

	private GearPlacePoint m_GearPlacePointAttachedTo;

	private GearItem m_GearItemBeingCooked;

	private GearItem m_GearItemSpawnedForInspectMode;

	private GearItem m_GearItemToEatDrinkFromInspectMode;

	private float m_CookingElapsedHours;

	private float m_GracePeriodElapsedHours;

	private string m_GearItemGUIDFromDeserialize;

	private float m_LitersSnowBeingMelted;

	private float m_LitersWaterBeingBoiled;

	private CookingState m_CookingState;

	private float m_PercentCooked;

	private float m_PercentRuined;

	private float m_MinutesUntilCooked;

	private float m_MinutesUntilRuined;

	private bool m_ForceParticleUpdate;

	private GameObject m_ParticlesCurrentlyEnabled;

	private bool m_IsBeingInspected;

	private bool m_IsBeingPlaced;

	private Fire m_CachedFireBeingUsed;

	private GearPlacePoint m_CachedGearPlacePoint;

	private uint m_CookingAudioId;

	private bool m_ShouldInterruptPassTime;

	private bool m_HasDoneReattachCheck;

	private float m_CookingStateEventCooldown;

	private static CookingPotItemSaveDataProxy m_CookingPotItemSaveDataProxy;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsBeingPlaced()
	{
		return default(bool);
	}

	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateGrubMeshVisualCondition")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	private void Update()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	public bool ShouldProcessInteractionInternal()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanOpenCookingInterface()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	public bool PerformInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	public bool CanCookItem(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "HideItemBeingCooked")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void StartCooking(GearItem gearItemToCook)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void StartMeltingSnow(float amountToMelt)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoil")]
	[CallsUnknownMethods(Count = 2)]
	public void StartBoilingWater(float amountToBoil, bool doWaterRemoval = true)
	{
	}

	[CalledBy(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CallerCount(Count = 3)]
	public void AttachToFire(Fire fire, GearPlacePoint gpp)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	public void DetachFromFire()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public Fire GetFireBeingUsed()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 29)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public bool IsDummyPot()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeReplaceGearItemForLabels")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	public bool IsCookingSomething()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(GearItem), Member = "SetLocalizationOverride")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	public GearItem MaybeSpawnGearItemForInspectMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public GearItem GetGearItemForInspectMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool ShouldShowPotModelInInspect()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpWater")]
	[Calls(Type = typeof(CookingPotItem), Member = "ResetHeatLoss")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpSnow")]
	public void PickUpCookedItem()
	{
	}

	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Rest), Member = "DoPassTime")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Rest), Member = "CheckPassTimeErrorMessage")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Rest), Member = "Enable")]
	public bool DoSpecialActionFromInspectMode(float volumeAvailable)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	public void InspectModeCallback()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CallsUnknownMethods(Count = 1)]
	public float GetTotalCookMultiplier()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	public float GetTotalBoilMultiplier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ModifiedReadyTimeMinutes")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	public float GetTotalReadyMultiplier()
	{
		return default(float);
	}

	[Calls(Type = typeof(CookingPotItem), Member = "TurnOnParticles")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "DetachFromFire")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "ResetHeatLoss")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	public void EnterPlaceMesh()
	{
	}

	[CallerCount(Count = 0)]
	public void RestoreCachedFire()
	{
	}

	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Cookable), Member = "IsNearFire")]
	public void ExitPlaceMesh()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CookingState GetCookingState()
	{
		return default(CookingState);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(GearItem), Member = "ApplyForce")]
	[CalledBy(Type = typeof(GearItem), Member = "EnablePhysics")]
	[CalledBy(Type = typeof(BreakDown), Member = "CanStickToGround")]
	public bool IsAttachedToGearPlacePoint()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "CheckForFireBurntOut")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "CanOpenCookingInterface")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	public bool AttachedFireIsBurning()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayPutBackAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCookingSlotSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	public void PlayPutBackFromInspectAudio()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void PlayStowFromInspectAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayGearItemInsidePickupAudio()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	public void PlayAttachToFireAudio(GearPlacePoint gpp)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(string), Member = "Substring")]
	private void PickUpCookedGearItem(bool addToInventory)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "CopyHarvestedState")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetCookedHp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetCookedGearProperties(GearItem rawItem, GearItem cookedItem)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "GetCookedItemConditionPercent")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGrubMeshVisualCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[CallerCount(Count = 4)]
	public static float GetCookedHp(float currentHp, GearItemData rawItemData, GearItemData cookedItemData)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "HideItemBeingCooked")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallsUnknownMethods(Count = 11)]
	private void FindGearItemBeingCooked(string guid)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateGrubMeshVisualCondition")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	private void UpdateGearItemBeingCooked()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Cookable), Member = "GetCookTimeMinutesForCaloriesRemaining")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalCookMultiplier")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	private float ModifiedCookTimeMinutes()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[CallerCount(Count = 0)]
	private float ModifiedReadyTimeMinutes()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateMeltingSnow()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	private void UpdateBoilingWater()
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "BroadcastEventWithItemName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateCookingTimeAndState(float cookTimeMinutes, float readyTimeMinutes)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateParticles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "TurnOnParticles")]
	[Calls(Type = typeof(CookingPotItem), Member = "TurnOnParticles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	private void UpdateVisuals()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(PassTime), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void PickUpSnow()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Inventory), Member = "AddToPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	private void PickUpWater()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	private void HideItemBeingCooked()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpDummyPotMeatMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	private void SetUpGrubMesh()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartMeltingSnow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Deserialize")]
	private void SetUpWaterMesh()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateParticles")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "BroadcastEventWithItemName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	private void SetCookingState(CookingState cookingState)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	private void UpdateParticles()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void TurnOnParticles(GameObject particlesToTurnOn)
	{
	}

	[Calls(Type = typeof(CookingPotItem), Member = "GetCookedHp")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void UpdateGrubMeshVisualCondition()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private void DoConditionDamageToPot()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetRuinedFoodMaterial()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	private void UpdateAudio()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PerformInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	private void StartInspectMode()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PassTime), Member = "End")]
	private void MaybeInterruptPassTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeFlagItemAsOpened()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetUpDummyPotMeatMesh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CallsUnknownMethods(Count = 1)]
	private void CheckForFireBurntOut()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool BroadcastEventWithItemName(string eventName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsItemBeingCookedHot()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ResetHeatLoss()
	{
	}

	[CallerCount(Count = 0)]
	public CookingPotItem()
	{
	}
}
