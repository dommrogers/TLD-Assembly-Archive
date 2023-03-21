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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsBeingPlaced()
	{
		return default(bool);
	}

	[Calls(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[Calls(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateGrubMeshVisualCondition")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	public bool ShouldProcessInteractionInternal()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanOpenCookingInterface()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	public bool PerformInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanCookItem(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "HideItemBeingCooked")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[CallsUnknownMethods(Count = 18)]
	public void StartCooking(GearItem gearItemToCook)
	{
	}

	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[CallerCount(Count = 0)]
	public void StartMeltingSnow(float amountToMelt)
	{
	}

	[CallerCount(Count = 3)]
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
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	public void AttachToFire(Fire fire, GearPlacePoint gpp)
	{
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CallerCount(Count = 2)]
	public void DetachFromFire()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Fire GetFireBeingUsed()
	{
		return null;
	}

	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 30)]
	public bool IsDummyPot()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeReplaceGearItemForLabels")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	public bool IsCookingSomething()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GearItem), Member = "SetLocalizationOverride")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[CallsUnknownMethods(Count = 8)]
	public GearItem MaybeSpawnGearItemForInspectMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public GearItem GetGearItemForInspectMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool ShouldShowPotModelInInspect()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "ResetHeatLoss")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpWater")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpSnow")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	public void PickUpCookedItem()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Rest), Member = "Enable")]
	[Calls(Type = typeof(Panel_Rest), Member = "CheckPassTimeErrorMessage")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Rest), Member = "DoPassTime")]
	public bool DoSpecialActionFromInspectMode(float volumeAvailable)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	public float GetTotalBoilMultiplier()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ModifiedReadyTimeMinutes")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	public float GetTotalReadyMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "ResetHeatLoss")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "TurnOnParticles")]
	[Calls(Type = typeof(CookingPotItem), Member = "DetachFromFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallsUnknownMethods(Count = 2)]
	public void EnterPlaceMesh()
	{
	}

	[CallerCount(Count = 0)]
	public void RestoreCachedFire()
	{
	}

	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Cookable), Member = "IsNearFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	public void ExitPlaceMesh()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CookingState GetCookingState()
	{
		return default(CookingState);
	}

	[CalledBy(Type = typeof(BreakDown), Member = "CanStickToGround")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(GearItem), Member = "EnablePhysics")]
	[CalledBy(Type = typeof(GearItem), Member = "ApplyForce")]
	[CallerCount(Count = 4)]
	public bool IsAttachedToGearPlacePoint()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "CheckForFireBurntOut")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "CanOpenCookingInterface")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	public bool AttachedFireIsBurning()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayPutBackAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCookingSlotSwitch")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	public void PlayPutBackFromInspectAudio()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsUnknownMethods(Count = 3)]
	public void PlayStowFromInspectAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayGearItemInsidePickupAudio()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void PlayAttachToFireAudio(GearPlacePoint gpp)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Transform), Member = "set_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessage.GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(ClothingItem), Member = "PickedUp")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Inventory), Member = "GetClosestMatchStackable")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(Transform), Member = "set_localScale")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "RemoveFromSpawns")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemAdded")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void PickUpCookedGearItem(bool addToInventory)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetCookedHp")]
	[Calls(Type = typeof(GearItem), Member = "CopyHarvestedState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetCookedGearProperties(GearItem rawItem, GearItem cookedItem)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "GetCookedItemConditionPercent")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGrubMeshVisualCondition")]
	public static float GetCookedHp(float currentHp, GearItemData rawItemData, GearItemData cookedItemData)
	{
		return default(float);
	}

	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	private void FindGearItemBeingCooked(string guid)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateGrubMeshVisualCondition")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	private void UpdateGearItemBeingCooked()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Cookable), Member = "GetCookTimeMinutesForCaloriesRemaining")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalCookMultiplier")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[CallsUnknownMethods(Count = 1)]
	private float ModifiedCookTimeMinutes()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[CallsUnknownMethods(Count = 1)]
	private float ModifiedReadyTimeMinutes()
	{
		return default(float);
	}

	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	private void UpdateMeltingSnow()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateBoilingWater()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CookingPotItem), Member = "BroadcastEventWithItemName")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
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
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateParticles")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "TurnOnParticles")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "TurnOnParticles")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	private void UpdateVisuals()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
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
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "AddToPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
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
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	private void HideItemBeingCooked()
	{
	}

	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpDummyPotMeatMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private void SetUpGrubMesh()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartMeltingSnow")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Deserialize")]
	private void SetUpWaterMesh()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "BroadcastEventWithItemName")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateParticles")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	private void SetCookingState(CookingState cookingState)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	private void UpdateParticles()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void TurnOnParticles(GameObject particlesToTurnOn)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetCookedHp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	private void UpdateGrubMeshVisualCondition()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	private void DoConditionDamageToPot()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PerformInteraction")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallerCount(Count = 3)]
	private void StartInspectMode()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PassTime), Member = "End")]
	private void MaybeInterruptPassTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeFlagItemAsOpened()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[CallsUnknownMethods(Count = 1)]
	private void SetUpDummyPotMeatMesh()
	{
	}

	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void CheckForFireBurntOut()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
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
