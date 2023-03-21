using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
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
		[CallerCount(Count = 7)]
		public FrozenDecayCalculator(float thawedConditionLossPerHour, float frozenConditionLossPerHour, float hoursToThawCarcass, float hoursToFreezeCarcass)
		{
		}

		[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "HandleFreezeOrThawChanges")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "HandleThawingNextToFire")]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "HandleFullyThawedNextToFire")]
		public FastForwardState FastForwardTime(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
		[CalledBy(Type = typeof(BodyHarvest), Member = "FastForwardTime")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "FastForwardTime")]
		private FastForwardState HandleThawingNextToFire(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "FastForwardTime")]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
		[CalledBy(Type = typeof(BodyHarvest), Member = "FastForwardTime")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
		[CallerCount(Count = 2)]
		private FastForwardState HandleFullyThawedNextToFire(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
		[CalledBy(Type = typeof(BodyHarvest), Member = "FastForwardTime")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "FastForwardTime")]
		[CallsUnknownMethods(Count = 2)]
		private FastForwardState HandleFreezeOrThawChanges(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
		[CallerCount(Count = 0)]
		private FastForwardState HandleSteadyStateAfterFreezeOrThaw(FastForwardState inState)
		{
			return default(FastForwardState);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
		[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
		private float IntegrateDecay(float hoursInLinearSection, float startPercentFrozen, float endPercentFrozen)
		{
			return default(float);
		}

		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "IntegrateDecay")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleSteadyStateAfterFreezeOrThaw")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "IntegrateDecay")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleFreezeOrThawChanges")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleFreezeOrThawChanges")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleFullyThawedNextToFire")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleFullyThawedNextToFire")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleThawingNextToFire")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleSteadyStateAfterFreezeOrThaw")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "FastForwardTime")]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "FastForwardTime")]
		[CalledBy(Type = typeof(BodyHarvest), Member = "FastForwardTime")]
		[CalledBy(Type = typeof(BodyHarvest), Member = "FastForwardTime")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 14)]
		[CalledBy(Type = typeof(FrozenDecayCalculator), Member = "HandleThawingNextToFire")]
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

	public string m_DisplayName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(BodyHarvest), Member = "InitializeResourcesAndConditions")]
	[Calls(Type = typeof(BodyHarvest), Member = "RefreshInternalReferences")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Update")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[Calls(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeFreeze")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(BodyHarvest), Member = "IsGearItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	public void UpdateBodyHarvest(float todHours)
	{
	}

	[Calls(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsFrameValidToUpdate")]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Serialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetAiFeedingOnCarcass")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(BodyHarvest), Member = "IsNearFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvest), Member = "FastForwardTime")]
	[Calls(Type = typeof(BodyHarvest), Member = "InitializeResourcesAndConditions")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	public void Deserialize(string text, bool isSceneLoad)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
	[Calls(Type = typeof(FrozenDecayCalculator), Member = "GetDecayRate")]
	[Calls(Type = typeof(FrozenDecayCalculator), Member = "HandleFullyThawedNextToFire")]
	[Calls(Type = typeof(FrozenDecayCalculator), Member = "HandleThawingNextToFire")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FrozenDecayCalculator), Member = "HandleFreezeOrThawChanges")]
	private void FastForwardTime(float elapsedHours, float percentFrozen, float hoursRemainingOnCloseFire)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDecay")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	public bool IsGearItem()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BaseAi.DamageSide GetDamageSide()
	{
		return default(BaseAi.DamageSide);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetCondition()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	[CallsUnknownMethods(Count = 1)]
	public float GetGearItemCondition()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void SetAllowDecay(bool allow)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "IsCarcassTooFrozenToQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshTitle")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "GetHoverText")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "GetHoverText")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	public int GetPercentFrozen()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(BodyHarvest), Member = "GetPercentFrozen")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BodyHarvest), Member = "GetPercentFrozen")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string GetFrozenDisplayName()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 1)]
	public string GetDisplayName()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "DestroyIfFarAway")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(BodyHarvest), Member = "IsGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MapDetail), Member = "ShowOnMap")]
	public void BodyHarvestDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public void MaybeRoundMeatAvailableToZero()
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeDropDepletedItem")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "AreResourcesAvailable")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
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

	[CalledBy(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeDropDepletedItem")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "AreResourcesAvailable")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	public bool ConditionReachedZero()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void MaybeSpawnOrRefreshCarcassSite()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void MaybeRestoreCarcassSite()
	{
	}

	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[Calls(Type = typeof(CarcassSite), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BodyHarvest), Member = "HasSpawnedCarcassSite")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BodyHarvest), Member = "CanSpawnCarcassSite")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CarcassSite.Manager), Member = "TryInstanciateCarcassSite")]
	public void MaybeSpawnCarcassSite(float timeHours)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool HasSpawnedCarcassSite()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeSpawnQuarteringMess()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SpawnCarcassPickup")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	public static void Copy(BodyHarvest from, BodyHarvest to)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Awake")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void RefreshInternalReferences()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeFreeze")]
	[CallsUnknownMethods(Count = 7)]
	private bool IsNearFire()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	private void DestroyIfFarAway()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsUnknownMethods(Count = 39)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeDestroyAfterDeserialize(bool useTeleportTransformAfterSceneLoad)
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BodyHarvest), Member = "IsGearItem")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeDecay(float hours)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BodyHarvest), Member = "IsNearFire")]
	[CallerCount(Count = 1)]
	private void MaybeFreeze(float hours)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Awake")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	private void InitializeResourcesAndConditions()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CarcassSite), Member = "AddPostHarvestMessFx")]
	[Calls(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CarcassSite), Member = "ResetBodyHarvestOnSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	private void RefreshCarcassSite(float hoursAtRefresh)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateColliders")]
	[CallsUnknownMethods(Count = 18)]
	private Transform[] UnparentArrows(ArrowItem[] arrows)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 6)]
	private void ReparentArrows(ArrowItem[] arrows, Transform[] parentArrows)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "LateUpdate")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BodyHarvest), Member = "UnparentArrows")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void UpdateColliders()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BodyHarvest()
	{
	}
}
