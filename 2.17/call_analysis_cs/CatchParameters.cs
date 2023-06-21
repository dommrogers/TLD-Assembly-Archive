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

	[CallerCount(Count = 0)]
	public CatchParameters()
	{
	}
}
