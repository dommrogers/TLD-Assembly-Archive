using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SnowfallManagerSaveDataProxy
{
	public List<string> m_SceneNames;

	public List<string> m_Records;

	[CalledBy(Type = typeof(SnowfallManager), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public SnowfallManagerSaveDataProxy()
	{
	}
}
