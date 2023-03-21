using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PumpkinPieSpecialItem : MonoBehaviour
{
	public float m_FreezingInitialPercentDecrease;

	public float m_FreezingRateOfIncreaseScale;

	public float m_DurationHours;

	private GearItem m_GearItem;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PumpkinPieSpecialItem), Member = "Hide")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void Apply(float normalizedValue)
	{
	}

	[CalledBy(Type = typeof(PumpkinPieSpecialItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 35)]
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
