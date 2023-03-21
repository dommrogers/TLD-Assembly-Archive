using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class PackGroup
{
	public int m_FormationCount;

	public List<PackAnimal> m_Members;

	public float m_TargetAwarenessTime;

	public float m_AttackCooldownTime;

	public float m_PackMoraleModifier;

	public bool m_GroupEventProcessed;

	[CallerCount(Count = 0)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public PackGroup()
	{
	}
}
