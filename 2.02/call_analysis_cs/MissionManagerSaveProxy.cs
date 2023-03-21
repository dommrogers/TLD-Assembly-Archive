using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class MissionManagerSaveProxy
{
	public string m_SerializedMainBlackboard;

	public List<string> m_SerializedChildGraphs;

	[CalledBy(Type = typeof(MissionManagerBase), Member = ".cctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public MissionManagerSaveProxy()
	{
	}
}
