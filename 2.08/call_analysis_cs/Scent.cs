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

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeInvestigateMeatWhenStalking")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestDecoy")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestDecoy")]
	[CallAnalysisFailed]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeInvestigateMeatWhenStalking")]
	public float GetRange()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Scent()
	{
	}
}
