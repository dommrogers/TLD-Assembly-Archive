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

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract bool IsLocked();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected ChallengeLockCondition()
	{
	}
}
