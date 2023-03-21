using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FootstepTrailManagerSaveDataProxy
{
	public List<string> m_Trails;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public FootstepTrailManagerSaveDataProxy()
	{
	}
}
