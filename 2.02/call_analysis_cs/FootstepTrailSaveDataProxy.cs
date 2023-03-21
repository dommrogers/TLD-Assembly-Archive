using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FootstepTrailSaveDataProxy
{
	public FootstepTrailType m_TrailType;

	public SnowImprintType m_ImprintType;

	public List<string> m_FootstepGroups;

	public List<uint> m_Footsteps;

	[CalledBy(Type = typeof(FootstepTrail), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	public FootstepTrailSaveDataProxy()
	{
	}
}
