using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class BodyHarvest : MonoBehaviour
{
	private struct FastForwardState
	{
		public float m_PercentFrozen;

		public float m_HoursRemaining;

		public float m_HoursRemainingNextToFire;

		public float m_PercentDecay;
	}

	private struct FrozenDecayCalculator
	{
		private readonly float m_ThawedDecayRate;

		private readonly float m_FrozenDecayRate;

		private readonly float m_HoursToThaw;

		private readonly float m_HoursToFreeze;

		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		public FrozenDecayCalculator(float thawedConditionLossPerHour, float frozenConditionLossPerHour, float hoursToThawCarcass, float hoursToFreezeCarcass)
		{
		}

		[CalledBy(Type = typeof(BodyHarvest), Member = "FastForwardTime")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "IntegrateDecay")]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "HandleFreezeOrThawChanges")]
		public FastForwardState FastForwardTime(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "IntegrateDecay")]
		private FastForwardState HandleThawingNextToFire(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "IntegrateDecay")]
		private FastForwardState HandleFullyThawedNextToFire(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "FastForwardTime")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "IntegrateDecay")]
		[CallsUnknownMethods(Count = 2)]
		private FastForwardState HandleFreezeOrThawChanges(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "IntegrateDecay")]
		private FastForwardState HandleSteadyStateAfterFreezeOrThaw(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "FastForwardTime")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleThawingNextToFire")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleFullyThawedNextToFire")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleFreezeOrThawChanges")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleSteadyStateAfterFreezeOrThaw")]
		[CallerCount(Count = 7)]
		private float IntegrateDecay(float hoursInLinearSection, float startPercentFrozen, float endPercentFrozen)
		{
			return 0f;
		}

		[CallerCount(Count = 0)]
		private float GetDecayRate(float percentFrozen)
		{
			return 0f;
		}
	}

	public LocalizedString m_LocalizedDisplayName;

	public GameObject m_MeatPrefab;

	public GameObject m_HidePrefab;

	public GameObject m_GutPrefab;

	public string m_HarvestAudio;

	public float m_MeatAvailableMinKG;

	public float m_MeatAvailableMaxKG;

	public int m_HideAvailableUnits;

	public int m_GutAvailableUnits;

	public float m_SpawnChance;

	public float m_StartConditionMin;

	public float m_StartConditionMax;

	public float m_DecayConditionPerHour;

	public bool m_StartFrozen;

	public bool m_StartRavaged;

	public bool m_HideIsAvailable;

	public bool m_GutIsAvailable;

	public bool m_CanCarry;

	public bool m_IsBigCarry;

	public bool m_CanQuarter;

	public GameObject m_QuarterObjectPrefab;

	public GameObject m_CarcassSitePrefab;

	public GameObject m_CarcassSiteLocation;

	public string m_QuarterAudio;

	public float m_QuarterDurationMinutes;

	public float m_QuarterBagMeatCapacityKG;

	public float m_QuarterBagWasteMultiplier;

	public float m_QuarterPrefabSpawnRadius;

	public float m_QuarterPrefabSpawnAngle;

	public GameObject m_LargeObjectCollidersRoot;

	private PanelReference<Panel_BodyHarvest> m_BodyHarvestPanel;

	public bool m_Frozen;

	public bool m_Ravaged;

	public float m_MeatAvailableKG;

	public bool m_DestroyPending;

	public string m_MissionIdSerialized;

	public BearHuntAiRedux m_BearHuntAiRedux;

	private float m_Condition;

	private bool m_RolledSpawnChance;

	private bool m_AllowDecay;

	private bool m_AllowFreezing;

	private float m_PercentFrozen;

	private GearItem m_GearItem;

	private BaseAi.DamageSide m_DamageSide;

	private static BodyHarvestSaveDataProxy m_BodyHarvestSaveDataProxy;

	private string m_FrozenDisplayNameId;

	private CarcassSite m_CarcassSite;

	private bool m_HasHarvested;

	private float m_LastHarvestTimeHours;

	private float m_GutWeightKgPerUnit;

	private float m_HideWeightKgPerUnit;

	private bool m_HasUpdatedColliders;

	private GameObject m_NonInteractiveCollidersRoot;

	private bool m_HasInitialized;

	private const float MINDIST_UPDATE_DESTROY = 200f;

	private const float MINDIST_LOAD_ONSCREEN_DESTROY = 70f;

	private const float MINDIST_LOAD_OFFSCREEN_DESTROY = 30f;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BodyHarvest), Member = "RefreshInternalReferences")]
	[Calls(Type = typeof(BodyHarvest), Member = "InitializeResourcesAndConditions")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BodyHarvest), Member = "IsGearItem")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeFreeze")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateBodyHarvest(float todHours)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[Calls(Type = typeof(GameManager), Member = "IsFrameValidToUpdate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BodyHarvest), Member = "UpdateColliders")]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public void OnHarvestActionSuccess()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(BodyHarvest), Member = "IsNearFire")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(AiUtils), Member = "GetAiFeedingOnCarcass")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BodyHarvest), Member = "InitializeResourcesAndConditions")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(BodyHarvest), Member = "FastForwardTime")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text, bool isSceneLoad)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FrozenDecayCalculator), Member = "FastForwardTime")]
	[CallsUnknownMethods(Count = 1)]
	private void FastForwardTime(float elapsedHours, float percentFrozen, float hoursRemainingOnCloseFire)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDecay")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	[CallerCount(Count = 4)]
	public bool IsGearItem()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BaseAi.DamageSide GetDamageSide()
	{
		return default(BaseAi.DamageSide);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCondition()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetGearItemCondition()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void SetAllowDecay(bool allow)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetPercentFrozen()
	{
		return 0;
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybePerformCompletionAction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Action_ShowPanel), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_ShowPanel), Member = "MaybeShowBodyHarvest")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void InteractWithBodyHarvest(bool playBookEndAnimation)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetFrozenDisplayName()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetDisplayName()
	{
		return null;
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "DestroyIfFarAway")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BodyHarvest), Member = "IsGearItem")]
	[Calls(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void BodyHarvestDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public void MaybeRoundMeatAvailableToZero()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[CalledBy(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "CanExamine")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "AreResourcesAvailable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeDropDepletedItem")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool NoMoreResources()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public float GetGutsAvailableWeightKg()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetHideAvailableWeightKg()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[CalledBy(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "AreResourcesAvailable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeDropDepletedItem")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[CallerCount(Count = 9)]
	public bool ConditionReachedZero()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public bool CanSpawnCarcassSite()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	public bool AreResourcesAvailable()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BodyHarvest), Member = "HasSpawnedCarcassSite")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "Refresh")]
	[CallsUnknownMethods(Count = 3)]
	public void MaybeSpawnOrRefreshCarcassSite()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void MaybeRestoreCarcassSite()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnOrRefreshCarcassSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BodyHarvest), Member = "HasSpawnedCarcassSite")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(CarcassSite.Manager), Member = "TryInstanciateCarcassSite")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(CarcassSite), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void MaybeSpawnCarcassSite(float timeHours)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnOrRefreshCarcassSite")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[CallerCount(Count = 4)]
	public bool HasSpawnedCarcassSite()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeSpawnQuarteringMess()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BaseAi), Member = "SpawnCarcassPickup")]
	[CallerCount(Count = 1)]
	public static void Copy(BodyHarvest from, BodyHarvest to)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshInternalReferences()
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeFreeze")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsNearFire()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void DestroyIfFarAway()
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 24)]
	private void MaybeDestroyAfterDeserialize(bool useTeleportTransformAfterSceneLoad)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BodyHarvest), Member = "IsGearItem")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeDecay(float hours)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BodyHarvest), Member = "IsNearFire")]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeFreeze(float hours)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "Awake")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void InitializeResourcesAndConditions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshCarcassSite(float hoursAtRefresh)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateColliders")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private Transform[] UnparentArrows(ArrowItem[] arrows)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ReparentArrows(ArrowItem[] arrows, Transform[] parentArrows)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(BodyHarvest), Member = "UnparentArrows")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateColliders()
	{
	}

	[CallerCount(Count = 0)]
	public BodyHarvest()
	{
	}
}
