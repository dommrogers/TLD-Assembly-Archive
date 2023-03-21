using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SnowfallManagerSaveDataProxy
{
	public List<string> m_SceneNames;

	public List<string> m_Records;

	[CalledBy(Type = typeof(SnowfallManager), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public SnowfallManagerSaveDataProxy()
	{
	}
}
