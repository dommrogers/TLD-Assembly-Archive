using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FootstepTrailSaveDataProxy
{
	public FootstepTrailType m_TrailType;

	public SnowImprintType m_ImprintType;

	public List<string> m_FootstepGroups;

	public List<uint> m_Footsteps;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public FootstepTrailSaveDataProxy()
	{
	}
}
