using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Cooking;
using TLD.Gear;
using TLD.PDID;
using TLD.SaveState;
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
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsBeingPlaced()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[Calls(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateGrubMeshVisualCondition")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[CallsUnknownMethods(Count = 1)]
	public bool ShouldProcessInteractionInternal()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanOpenCookingInterface()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool PerformInteraction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "HideItemBeingCooked")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 18)]
	public void StartCooking(GearItem gearItemToCook)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	public void StartMeltingSnow(float amountToMelt)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoil")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpWaterMesh")]
	[CallsUnknownMethods(Count = 2)]
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
	[CallerCount(Count = 0)]
	public Fire GetFireBeingUsed()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 5)]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 30)]
	public bool IsDummyPot()
	{
		return false;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeReplaceGearItemForLabels")]
	[CallerCount(Count = 10)]
	public bool IsCookingSomething()
	{
		return false;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(GearItem), Member = "SetLocalizationOverride")]
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
		return false;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CookingPotItem), Member = "ResetHeatLoss")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpWater")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpSnow")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void PickUpCookedItem()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Rest), Member = "CheckPassTimeErrorMessage")]
	[Calls(Type = typeof(Panel_Rest), Member = "Enable")]
	[Calls(Type = typeof(Panel_Rest), Member = "DoPassTime")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public bool DoSpecialActionFromInspectMode(float volumeAvailable)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void InspectModeCallback()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetTotalCookMultiplier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetTotalBoilMultiplier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ModifiedReadyTimeMinutes")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Cookable), Member = "IsNearFire")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
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
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(BreakDown), Member = "CanStickToGround")]
	[CallerCount(Count = 4)]
	public bool IsAttachedToGearPlacePoint()
	{
		return false;
	}

	[CalledBy(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "CanOpenCookingInterface")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeInterruptPassTime")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "CheckForFireBurntOut")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	public bool AttachedFireIsBurning()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlayPutBackAudio")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCookingSlotSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void PlayPutBackFromInspectAudio()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayAttachToFireAudio(GearPlacePoint gpp)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(GearMessage.GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(ClothingItem), Member = "PickedUp")]
	[Calls(Type = typeof(Inventory), Member = "GetClosestMatchStackable")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemAdded")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "RemoveFromSpawns")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_localScale")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "set_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "set_rotation")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "AddLiquidToInventory")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 21)]
	private void PickUpCookedGearItem(bool addToInventory)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(GearItem), Member = "CopyHarvestedState")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetCookedHp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetCookedGearProperties(GearItem rawItem, GearItem cookedItem)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGrubMeshVisualCondition")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "GetCookedItemConditionPercent")]
	[CallerCount(Count = 4)]
	public static float GetCookedHp(float currentHp, GearItemData rawItemData, GearItemData cookedItemData)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 12)]
	private void FindGearItemBeingCooked(string guid)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "ModifiedCookTimeMinutes")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateGrubMeshVisualCondition")]
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
	[CallsUnknownMethods(Count = 1)]
	private void UpdateMeltingSnow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalBoilMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalReadyMultiplier")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateBoilingWater()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateBoilingWater")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CookingPotItem), Member = "BroadcastEventWithItemName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateCookingTimeAndState(float cookTimeMinutes, float readyTimeMinutes)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(CookingPotItem), Member = "TurnOnParticles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateParticles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateVisuals()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PassTime), Member = "Begin")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 7)]
	private void PickUpSnow()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Inventory), Member = "AddToPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallsUnknownMethods(Count = 8)]
	private void PickUpWater()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[CallsUnknownMethods(Count = 2)]
	private void HideItemBeingCooked()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpDummyPotMeatMesh")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CookingPotItem), Member = "BroadcastEventWithItemName")]
	[Calls(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "UpdateParticles")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	private void TurnOnParticles(GameObject particlesToTurnOn)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGearItemBeingCooked")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetCookedHp")]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateGrubMeshVisualCondition()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CallsUnknownMethods(Count = 1)]
	private void DoConditionDamageToPot()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void SetRuinedFoodMaterial()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAudio()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	private void StartInspectMode()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateMeltingSnow")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeInterruptPassTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeFlagItemAsOpened()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "SetUpGrubMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void SetUpDummyPotMeatMesh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CallsUnknownMethods(Count = 1)]
	private void CheckForFireBurntOut()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateCookingTimeAndState")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 3)]
	private bool BroadcastEventWithItemName(string eventName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsItemBeingCookedHot()
	{
		return false;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void ResetHeatLoss()
	{
	}

	[CallerCount(Count = 0)]
	public CookingPotItem()
	{
	}
}
