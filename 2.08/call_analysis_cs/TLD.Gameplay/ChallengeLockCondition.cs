using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

public abstract class ChallengeLockCondition : ScriptableObject
{
	public AssetReferenceTexture2D m_AltChallengeTexture;

	public string m_AltSpriteName;

	public LocalizedString m_AltHeader;

	public LocalizedString m_AltDescription;

	public LocalizedString m_AltInstructions;

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	public abstract bool IsLocked();

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected ChallengeLockCondition()
	{
	}
}
