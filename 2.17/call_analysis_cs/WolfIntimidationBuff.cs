using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WolfIntimidationBuff : MonoBehaviour
{
	public float m_IncreaseFleePercentagePoints;

	public float m_DecreaseAttackChancePercentagePoints;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Apply()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Remove()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WolfIntimidationBuff()
	{
	}
}
