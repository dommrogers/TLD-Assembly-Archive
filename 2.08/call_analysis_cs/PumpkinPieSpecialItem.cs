using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PumpkinPieSpecialItem : MonoBehaviour
{
	public float m_FreezingInitialPercentDecrease;

	public float m_FreezingRateOfIncreaseScale;

	public float m_DurationHours;

	private GearItem m_GearItem;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(PumpkinPieSpecialItem), Member = "Hide")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallsUnknownMethods(Count = 1)]
	public void Apply(float normalizedValue)
	{
	}

	[CalledBy(Type = typeof(PumpkinPieSpecialItem), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void Hide(bool hide)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PumpkinPieSpecialItem()
	{
	}
}
