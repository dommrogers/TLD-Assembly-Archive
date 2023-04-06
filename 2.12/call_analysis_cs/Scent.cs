using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Scent : MonoBehaviour
{
	public ScentRangeCategory m_ScentCategory;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeInvestigateMeatWhenStalking")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestDecoy")]
	[CallerCount(Count = 4)]
	public float GetRange()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Scent()
	{
	}
}
