using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class ProjectileImpactDecal
{
	public ProjectileType m_ProjectileType;

	public List<ImpactDecal> m_ImpactDecals;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ProjectileImpactDecal()
	{
	}
}
