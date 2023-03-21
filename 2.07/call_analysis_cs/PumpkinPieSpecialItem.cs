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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[CalledBy(Type = typeof(PumpkinPieSpecialItem), Member = "Update")]
	[CallsUnknownMethods(Count = 9)]
	private void Hide(bool hide)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PumpkinPieSpecialItem()
	{
	}
}
