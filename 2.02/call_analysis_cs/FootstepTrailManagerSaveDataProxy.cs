using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FootstepTrailManagerSaveDataProxy
{
	public List<string> m_Trails;

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(FootstepTrailManager), Member = ".cctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public FootstepTrailManagerSaveDataProxy()
	{
	}
}
