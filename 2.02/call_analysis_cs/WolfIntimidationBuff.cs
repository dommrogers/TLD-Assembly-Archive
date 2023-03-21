using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WolfIntimidationBuff : MonoBehaviour
{
	public float m_IncreaseFleePercentagePoints;

	public float m_DecreaseAttackChancePercentagePoints;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Apply()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Remove()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WolfIntimidationBuff()
	{
	}
}
