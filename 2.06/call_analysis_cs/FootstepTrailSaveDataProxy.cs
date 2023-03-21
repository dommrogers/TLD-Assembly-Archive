using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FootstepTrailSaveDataProxy
{
	public FootstepTrailType m_TrailType;

	public SnowImprintType m_ImprintType;

	public List<string> m_FootstepGroups;

	public List<uint> m_Footsteps;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(FootstepTrail), Member = ".cctor")]
	[CallsUnknownMethods(Count = 13)]
	public FootstepTrailSaveDataProxy()
	{
	}
}
