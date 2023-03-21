using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class MissionManagerSaveProxy
{
	public string m_SerializedMainBlackboard;

	public List<string> m_SerializedChildGraphs;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public MissionManagerSaveProxy()
	{
	}
}
