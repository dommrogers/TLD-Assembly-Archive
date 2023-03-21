using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FootstepTrailManagerSaveDataProxy
{
	public List<string> m_Trails;

	[CalledBy(Type = typeof(FootstepTrailManager), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public FootstepTrailManagerSaveDataProxy()
	{
	}
}
