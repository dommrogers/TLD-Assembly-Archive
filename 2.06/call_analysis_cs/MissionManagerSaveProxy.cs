using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class MissionManagerSaveProxy
{
	public string m_SerializedMainBlackboard;

	public List<string> m_SerializedChildGraphs;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public MissionManagerSaveProxy()
	{
	}
}
