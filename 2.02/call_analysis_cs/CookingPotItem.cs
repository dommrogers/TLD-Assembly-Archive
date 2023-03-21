using Cpp2ILInjected.CallAnalysis;
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

	private static CookingPotItemSaveDataProxy m_CookingPotItemSaveDataProxy;

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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsBeingPlaced()
	{
		return default(bool);
	}

	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 8)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(CookingPotItem), Member = "CanOpenCookingInterface")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallerCount(Count = 1)]
	public bool ShouldProcessInteractionInternal()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanOpenCookingInterface()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[Calls(Type = typeof(CookingPotItem), Member = "CanOpenCookingInterface")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public bool CanCookItem(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 77)]
	[Calls(Type = typeof(ObjectGuid), Member = "Generate")]
	[Calls(Type = typeof(ObjectGuid), Member = "Register")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(CookingPotItem), Member = "HideItemBeingCooked")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void StartCooking(GearItem gearItemToCook)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	public void StartMeltingSnow(float amountToMelt)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoil")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	public void StartBoilingWater(float amountToBoil, bool doWaterRemoval = true)
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	public void AttachToFire(Fire fire, GearPlacePoint gpp)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	public void DetachFromFire()
	{
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public Fire GetFireBeingUsed()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 29)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public bool IsDummyPot()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeReplaceGearItemForLabels")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	public bool IsCookingSomething()
	{
		return default(bool);
	}

	[Calls(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public GearItem MaybeSpawnGearItemForInspectMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public GearItem GetGearItemForInspectMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool ShouldShowPotModelInInspect()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[Calls(Type = typeof(CookingPotItem), Member = "DoConditionDamageToPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpSnow")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpWater")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "ResetHeatLoss")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	public void PickUpCookedItem()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Rest), Member = "DoPassTime")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(Panel_Rest), Member = "CheckPassTimeErrorMessage")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Rest), Member = "Enable")]
	public bool DoSpecialActionFromInspectMode(float volumeAvailable)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public void InspectModeCallback()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(Skill_Cooking), Member = "GetCookingTimeScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public float GetTotalCookMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Skill_Cooking), Member = "GetCookingTimeScale")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CallsUnknownMethods(Count = 3)]
	public float GetTotalBoilMultiplier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ModifiedReadyTimeMinutes")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	public float GetTotalReadyMultiplier()
	{
		return default(float);
	}

	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "DetachFromFire")]
	[Calls(Type = typeof(CookingPotItem), Member = "TurnOnParticles")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "ResetHeatLoss")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	public void EnterPlaceMesh()
	{
	}

	[CallerCount(Count = 0)]
	public void RestoreCachedFire()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(GearItem), Member = "ApplyForce")]
	[CalledBy(Type = typeof(GearItem), Member = "EnablePhysics")]
	[CalledBy(Type = typeof(BreakDown), Member = "CanStickToGround")]
	public bool IsAttachedToGearPlacePoint()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "CheckForFireBurntOut")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "CanOpenCookingInterface")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	public bool AttachedFireIsBurning()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayPutBackAudio")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCookingSlotSwitch")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	public void PlayPutBackFromInspectAudio()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public void PlayStowFromInspectAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayGearItemInsidePickupAudio()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	public void PlayAttachToFireAudio(GearPlacePoint gpp)
	{
	}

	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CallsUnknownMethods(Count = 83)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private void PickUpCookedGearItem(bool addToInventory)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "CopyHarvestedState")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void SetCookedGearProperties(GearItem rawItem, GearItem cookedItem)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "HideItemBeingCooked")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallsUnknownMethods(Count = 22)]
	private void FindGearItemBeingCooked(string guid)
	{
	}

	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	private float ModifiedReadyTimeMinutes()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateMeltingSnow()
	{
	}

	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	private void UpdateBoilingWater()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CookingPotItem), Member = "BroadcastEventWithItemName")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CookingPotItem), Member = "SetShaderBlendAmt")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void UpdateCookingTimeAndState(float cookTimeMinutes, float readyTimeMinutes)
	{
	}

	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateParticles")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "TurnOnParticles")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "TurnOnParticles")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	private void UpdateVisuals()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
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
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "AddToPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	private void PickUpWater()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	private void HideItemBeingCooked()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpDummyPotMeatMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void SetUpGrubMesh()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartMeltingSnow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Deserialize")]
	[CallerCount(Count = 4)]
	private void SetUpWaterMesh()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateParticles")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "BroadcastEventWithItemName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
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

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void TurnOnParticles(GameObject particlesToTurnOn)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void SetShaderBlendAmt(float blendAmt)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsUnknownMethods(Count = 4)]
	private void DoConditionDamageToPot()
	{
	}

	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void SetRuinedFoodMaterial()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	private void UpdateAudio()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ProcessInteraction")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	private void StartInspectMode()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PassTime), Member = "End")]
	private void MaybeInterruptPassTime()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void MaybeFlagItemAsOpened()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[CallsUnknownMethods(Count = 2)]
	private void SetUpDummyPotMeatMesh()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	private void CheckForFireBurntOut()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private bool BroadcastEventWithItemName(string eventName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsItemBeingCookedHot()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void ResetHeatLoss()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CookingPotItem()
	{
	}
}
