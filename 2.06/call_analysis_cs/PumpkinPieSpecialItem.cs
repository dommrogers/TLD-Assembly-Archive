using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PumpkinPieSpecialItem : MonoBehaviour
{
	public float m_FreezingInitialPercentDecrease;

	public float m_FreezingRateOfIncreaseScale;

	public float m_DurationHours;

	private GearItem m_GearItem;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PumpkinPieSpecialItem), Member = "Hide")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallsUnknownMethods(Count = 1)]
	public void Apply(float normalizedValue)
	{
	}

	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PumpkinPieSpecialItem), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	private void Hide(bool hide)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public PumpkinPieSpecialItem()
	{
	}
}
