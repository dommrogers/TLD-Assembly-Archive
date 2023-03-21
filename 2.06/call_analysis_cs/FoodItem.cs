using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class FoodItem : MonoBehaviour
{
	public float m_DailyHPDecayInside;

	public float m_DailyHPDecayOutside;

	public float m_CaloriesRemaining;

	public float m_CaloriesTotal;

	public bool m_MustConsumeAll;

	public float m_TimeToEatSeconds;

	public float m_TimeToOpenAndEatSeconds;

	public float m_ChanceFoodPoisoning;

	public float m_ChanceFoodPoisoningLowCondition;

	public float m_ChanceFoodPoisoningRuined;

	public float[] m_ParasiteRiskPercentIncrease;

	public string m_EatingAudio;

	public string m_OpenAndEatingAudio;

	public bool m_IsDrink;

	public bool m_IsMeat;

	public bool m_IsFish;

	public bool m_IsRawMeat;

	public bool m_IsNatural;

	public bool m_StayHeatedUntilInteraction;

	public bool m_HeatedWhenCooked;

	public float m_PercentHeatLossPerMinuteIndoors;

	public float m_PercentHeatLossPerMinuteOutdoors;

	public float m_ReduceThirst;

	public bool m_Packaged;

	public GameObject m_GearPrefabHarvestAfterFinishEatingNormal;

	public GameObject m_GearPrefabHarvestAfterFinishEatingSmashed;

	public bool m_Opened;

	public bool m_GearRequiredToOpen;

	public bool m_OpenedWithCanOpener;

	public bool m_OpenedWithKnife;

	public bool m_OpenedWithHatchet;

	public float m_HeatPercent;

	public bool m_ReturnToCookingAfterOpen;

	public int m_NumTimesHeatedUp;

	public GearMeatTypeEnum m_MeatType;

	private bool m_HarvestedByPlayer;

	private GearItem m_GearItem;

	private bool m_PreventHeatLoss;

	private static FoodItemSaveDataProxy m_FoodItemSaveDataProxy;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(FoodItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateHeatPercent(float gameMinutes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsPreventHeatLossEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void SetPreventHeatLoss(bool shouldPrevent)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FoodItem), Member = "UpdateHeatPercent")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public bool IsHot()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	public string GetTemperatureTextForInspectMode()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[CalledBy(Type = typeof(GearItem), Member = "GetHoverStateText")]
	public string GetTemperatureTextPostfix()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void MarkAsHarvested()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool WasHarvested()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public void CopyHarvestedState(FoodItem fi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public float GetDailyHPDecay()
	{
		return default(float);
	}

	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void DoGearHarvestAfterFinishEating()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FoodItem()
	{
	}
}
