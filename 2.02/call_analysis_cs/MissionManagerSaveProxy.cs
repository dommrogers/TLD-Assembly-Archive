using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class MissionManagerSaveProxy
{
	public string m_SerializedMainBlackboard;

	public List<string> m_SerializedChildGraphs;

	[CalledBy(Type = typeof(MissionManagerBase), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public MissionManagerSaveProxy()
	{
	}
}
