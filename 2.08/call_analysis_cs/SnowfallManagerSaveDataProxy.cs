using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SnowfallManagerSaveDataProxy
{
	public List<string> m_SceneNames;

	public List<string> m_Records;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public SnowfallManagerSaveDataProxy()
	{
	}
}
