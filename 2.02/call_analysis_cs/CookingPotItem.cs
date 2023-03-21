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
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsBeingPlaced()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[Calls(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "CanOpenCookingInterface")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	public bool ShouldProcessInteractionInternal()
	{
		return false;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ProcessInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanOpenCookingInterface()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(CookingPotItem), Member = "CanOpenCookingInterface")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetFireContainer")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public bool ProcessInteraction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool CanCookItem(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "HideItemBeingCooked")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(ObjectGuid), Member = "Generate")]
	[Calls(Type = typeof(ObjectGuid), Member = "Register")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 77)]
	public void StartCooking(GearItem gearItemToCook)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void StartMeltingSnow(float amountToMelt)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoil")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void StartBoilingWater(float amountToBoil, bool doWaterRemoval = true)
	{
	}

	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[CallerCount(Count = 3)]
	public void AttachToFire(Fire fire, GearPlacePoint gpp)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[CallerCount(Count = 2)]
	public void DetachFromFire()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Fire GetFireBeingUsed()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 33)]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 29)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsDummyPot()
	{
		return false;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeReplaceGearItemForLabels")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsCookingSomething()
	{
		return false;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	public GearItem MaybeSpawnGearItemForInspectMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetGearItemForInspectMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool ShouldShowPotModelInInspect()
	{
		return false;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CookingPotItem), Member = "ResetHeatLoss")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpWater")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpSnow")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "DoConditionDamageToPot")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void PickUpCookedItem()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(Panel_Rest), Member = "CheckPassTimeErrorMessage")]
	[Calls(Type = typeof(Panel_Rest), Member = "Enable")]
	[Calls(Type = typeof(Panel_Rest), Member = "DoPassTime")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public bool DoSpecialActionFromInspectMode(float volumeAvailable)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void InspectModeCallback()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Skill_Cooking), Member = "GetCookingTimeScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float GetTotalCookMultiplier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Skill_Cooking), Member = "GetCookingTimeScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float GetTotalBoilMultiplier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ModifiedReadyTimeMinutes")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public float GetTotalReadyMultiplier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "ResetHeatLoss")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "TurnOnParticles")]
	[Calls(Type = typeof(CookingPotItem), Member = "DetachFromFire")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void EnterPlaceMesh()
	{
	}

	[CallerCount(Count = 0)]
	public void RestoreCachedFire()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Cookable), Member = "IsNearFire")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	public void ExitPlaceMesh()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CookingState GetCookingState()
	{
		return default(CookingState);
	}

	[CalledBy(Type = typeof(GearItem), Member = "ApplyForce")]
	[CalledBy(Type = typeof(GearItem), Member = "EnablePhysics")]
	[CalledBy(Type = typeof(BreakDown), Member = "CanStickToGround")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsAttachedToGearPlacePoint()
	{
		return false;
	}

	[CalledBy(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "CanOpenCookingInterface")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "CheckForFireBurntOut")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool AttachedFireIsBurning()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlayPutBackAudio")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCookingSlotSwitch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void PlayPutBackFromInspectAudio()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void PlayStowFromInspectAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void PlayGearItemInsidePickupAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PlayAttachToFireAudio(GearPlacePoint gpp)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 83)]
	private void PickUpCookedGearItem(bool addToInventory)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GearItem), Member = "CopyHarvestedState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	private void SetCookedGearProperties(GearItem rawItem, GearItem cookedItem)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "HideItemBeingCooked")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 22)]
	private void FindGearItemBeingCooked(string guid)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateGearItemBeingCooked()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Cookable), Member = "GetCookTimeMinutesForCaloriesRemaining")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalCookMultiplier")]
	[CallsUnknownMethods(Count = 1)]
	private float ModifiedCookTimeMinutes()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[CallsUnknownMethods(Count = 1)]
	private float ModifiedReadyTimeMinutes()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateMeltingSnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateBoilingWater()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetShaderBlendAmt")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CookingPotItem), Member = "BroadcastEventWithItemName")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	private void UpdateCookingTimeAndState(float cookTimeMinutes, float readyTimeMinutes)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(CookingPotItem), Member = "TurnOnParticles")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateParticles")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateVisuals()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PassTime), Member = "Begin")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	private void PickUpSnow()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Inventory), Member = "AddToPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	private void PickUpWater()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void HideItemBeingCooked()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpDummyPotMeatMesh")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 41)]
	private void SetUpGrubMesh()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnow")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetUpWaterMesh()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CookingPotItem), Member = "BroadcastEventWithItemName")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateParticles")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetCookingState(CookingState cookingState)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CallerCount(Count = 2)]
	private void UpdateParticles()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void TurnOnParticles(GameObject particlesToTurnOn)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetShaderBlendAmt(float blendAmt)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void DoConditionDamageToPot()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 31)]
	private void SetRuinedFoodMaterial()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateAudio()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void StartInspectMode()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeInterruptPassTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeFlagItemAsOpened()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void SetUpDummyPotMeatMesh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void CheckForFireBurntOut()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private bool BroadcastEventWithItemName(string eventName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsItemBeingCookedHot()
	{
		return false;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ResetHeatLoss()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CookingPotItem()
	{
	}
}
