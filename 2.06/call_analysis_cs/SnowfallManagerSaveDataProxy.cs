using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SnowfallManagerSaveDataProxy
{
	public List<string> m_SceneNames;

	public List<string> m_Records;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".cctor")]
	[CallsUnknownMethods(Count = 11)]
	public SnowfallManagerSaveDataProxy()
	{
	}
}
