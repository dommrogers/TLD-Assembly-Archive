using Cpp2ILInjected.CallAnalysis;
using UnityEngine.AddressableAssets;

public class BadgeInfo
{
	public AssetReferenceTexture2D m_Sprite;

	public string m_NameLocID;

	public string m_Desc;

	public bool m_Unlocked;

	public float m_NormalizedProgress;

	public string m_Benefit;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BadgeInfo()
	{
	}
}
