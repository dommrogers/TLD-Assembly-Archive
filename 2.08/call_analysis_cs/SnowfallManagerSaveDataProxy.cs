using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SnowfallManagerSaveDataProxy
{
	public List<string> m_SceneNames;

	public List<string> m_Records;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public SnowfallManagerSaveDataProxy()
	{
	}
}
