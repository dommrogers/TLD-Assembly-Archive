using System;
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

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public FrozenDecayCalculator(float thawedConditionLossPerHour, float frozenConditionLossPerHour, float hoursToThawCarcass, float hoursToFreezeCarcass)
		{
		}

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "IntegrateDecay")]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "IntegrateDecay")]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "HandleFreezeOrThawChanges")]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "IntegrateDecay")]
		[CalledBy(Type = typeof(BodyHarvest), Member = "FastForwardTime")]
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

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "IntegrateDecay")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "FastForwardTime")]
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

		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleFreezeOrThawChanges")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleSteadyStateAfterFreezeOrThaw")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleFullyThawedNextToFire")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleThawingNextToFire")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "FastForwardTime")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "FastForwardTime")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "FastForwardTime")]
		[CallerCount(Count = 7)]
		private float IntegrateDecay(float hoursInLinearSection, float startPercentFrozen, float endPercentFrozen)
		{
			return default(float);
		}

		[CallerCount(Count = 0)]
		private float GetDecayRate(float percentFrozen)
		{
			return default(float);
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(BodyHarvest), Member = "InitializeResourcesAndConditions")]
	[Calls(Type = typeof(BodyHarvest), Member = "RefreshInternalReferences")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Update")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[Calls(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeFreeze")]
	[Calls(Type = typeof(BodyHarvest), Member = "IsGearItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	public void UpdateBodyHarvest(float todHours)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsFrameValidToUpdate")]
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

	[Calls(Type = typeof(BearHuntAiRedux), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Serialize")]
	[Calls(Type = typeof(AiUtils), Member = "GetAiFeedingOnCarcass")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(BodyHarvest), Member = "IsNearFire")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "InitializeResourcesAndConditions")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(BodyHarvest), Member = "FastForwardTime")]
	public void Deserialize(string text, bool isSceneLoad)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(FrozenDecayCalculator), Member = "FastForwardTime")]
	[CallerCount(Count = 1)]
	private void FastForwardTime(float elapsedHours, float percentFrozen, float hoursRemainingOnCloseFire)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDecay")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	public bool IsGearItem()
	{
		return default(bool);
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
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetGearItemCondition()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void SetAllowDecay(bool allow)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public int GetPercentFrozen()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Action_ShowPanel), Member = "OnExecute")]
	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "PerformInteraction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoBodyHarvest")]
	[CalledBy(Type = typeof(Action_ShowPanel), Member = "MaybeShowBodyHarvest")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybePerformCompletionAction")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "DestroyIfFarAway")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[Calls(Type = typeof(BodyHarvest), Member = "IsGearItem")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[CallsUnknownMethods(Count = 6)]
	public void BodyHarvestDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public void MaybeRoundMeatAvailableToZero()
	{
	}

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[CalledBy(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "AreResourcesAvailable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeDropDepletedItem")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsUnknownMethods(Count = 1)]
	public bool NoMoreResources()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public float GetGutsAvailableWeightKg()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetHideAvailableWeightKg()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeDropDepletedItem")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "AreResourcesAvailable")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[CalledBy(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	public bool ConditionReachedZero()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool CanSpawnCarcassSite()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	public bool AreResourcesAvailable()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CarcassSite), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "HasSpawnedCarcassSite")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	public void MaybeSpawnOrRefreshCarcassSite()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void MaybeRestoreCarcassSite()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnOrRefreshCarcassSite")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[Calls(Type = typeof(CarcassSite), Member = "Initialize")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(CarcassSite.Manager), Member = "TryInstanciateCarcassSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "HasSpawnedCarcassSite")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void MaybeSpawnCarcassSite(float timeHours)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnOrRefreshCarcassSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	public bool HasSpawnedCarcassSite()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeSpawnQuarteringMess()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "SpawnCarcassPickup")]
	public static void Copy(BodyHarvest from, BodyHarvest to)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Awake")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void RefreshInternalReferences()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeFreeze")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsNearFire()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	private void DestroyIfFarAway()
	{
	}

	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void MaybeDestroyAfterDeserialize(bool useTeleportTransformAfterSceneLoad)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BodyHarvest), Member = "IsGearItem")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeDecay(float hours)
	{
	}

	[Calls(Type = typeof(BodyHarvest), Member = "IsNearFire")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	private void MaybeFreeze(float hours)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	private void InitializeResourcesAndConditions()
	{
	}

	[Calls(Type = typeof(CarcassSite), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void RefreshCarcassSite(float hoursAtRefresh)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateColliders")]
	[CallsUnknownMethods(Count = 9)]
	private Transform[] UnparentArrows(ArrowItem[] arrows)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 3)]
	private void ReparentArrows(ArrowItem[] arrows, Transform[] parentArrows)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "LateUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BodyHarvest), Member = "UnparentArrows")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void UpdateColliders()
	{
	}

	[CallerCount(Count = 0)]
	public BodyHarvest()
	{
	}
}
