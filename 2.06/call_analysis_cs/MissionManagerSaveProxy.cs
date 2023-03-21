using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class MissionManagerSaveProxy
{
	public string m_SerializedMainBlackboard;

	public List<string> m_SerializedChildGraphs;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public MissionManagerSaveProxy()
	{
	}
}
