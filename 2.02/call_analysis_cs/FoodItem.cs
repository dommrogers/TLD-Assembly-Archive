using Cpp2ILInjected.CallAnalysis;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(FoodItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateHeatPercent(float gameMinutes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsPreventHeatLossEnabled()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetPreventHeatLoss(bool shouldPrevent)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(FoodItem), Member = "UpdateHeatPercent")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsHot()
	{
		return false;
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetTemperatureTextForInspectMode()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetTemperatureTextPostfix()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void MarkAsHarvested()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool WasHarvested()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void CopyHarvestedState(FoodItem fi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDailyHPDecay()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void DoGearHarvestAfterFinishEating()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FoodItem()
	{
	}
}
