using Cpp2ILInjected.CallAnalysis;
using UnityEngine.AddressableAssets;

public class CatchParameters
{
	public float m_MinutesToNextCatch;

	public bool m_SnapLine;

	public AssetReference m_FishReference;

	public float m_FishMinWeightModifier;

	public float m_FishWeightScale;

	public float m_FishHealthRoll;

	public float m_FishWeightRoll;

	[CalledBy(Type = typeof(IceFishingHole), Member = "Awake")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CollectFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[CallerCount(Count = 3)]
	public void ResetParameters()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void CopyParameters(CatchParameters parameters)
	{
	}

	[CallerCount(Count = 0)]
	public CatchParameters()
	{
	}
}
