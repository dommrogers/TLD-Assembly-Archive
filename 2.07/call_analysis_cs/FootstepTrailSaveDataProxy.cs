using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FootstepTrailSaveDataProxy
{
	public FootstepTrailType m_TrailType;

	public SnowImprintType m_ImprintType;

	public List<string> m_FootstepGroups;

	public List<uint> m_Footsteps;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public FootstepTrailSaveDataProxy()
	{
	}
}
