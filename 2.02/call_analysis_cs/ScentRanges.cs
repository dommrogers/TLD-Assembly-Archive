using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ScentRanges : MonoBehaviour
{
	public float m_DistanceToPlayerIgnoreScent;

	public int m_RawMeatScentRange;

	public int m_RawFishScentRange;

	public int m_CookedMeatScentRange;

	public int m_CookedFishScentRange;

	public int m_GutsScentRange;

	public int m_QuarterScentRange;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public float GetScentRange(ScentRangeCategory cat)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ScentRanges()
	{
	}
}
