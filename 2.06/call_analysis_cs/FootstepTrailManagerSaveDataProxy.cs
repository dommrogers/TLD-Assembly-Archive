using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FootstepTrailManagerSaveDataProxy
{
	public List<string> m_Trails;

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public FootstepTrailManagerSaveDataProxy()
	{
	}
}
