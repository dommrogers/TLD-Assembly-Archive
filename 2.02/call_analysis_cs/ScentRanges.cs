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

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 1)]
	public float GetScentRange(ScentRangeCategory cat)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ScentRanges()
	{
	}
}
