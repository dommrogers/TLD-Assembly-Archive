using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PumpkinPieSpecialItem : MonoBehaviour
{
	public float m_FreezingInitialPercentDecrease;

	public float m_FreezingRateOfIncreaseScale;

	public float m_DurationHours;

	private GearItem m_GearItem;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PumpkinPieSpecialItem), Member = "Hide")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallsUnknownMethods(Count = 4)]
	public void Apply(float normalizedValue)
	{
	}

	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[CallsUnknownMethods(Count = 35)]
	[CalledBy(Type = typeof(PumpkinPieSpecialItem), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void Hide(bool hide)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PumpkinPieSpecialItem()
	{
	}
}
