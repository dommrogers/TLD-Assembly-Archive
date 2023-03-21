using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SteamPipeSaveList
{
	public List<SteamPipeSaveData> m_SerializedSteamPipes;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public SteamPipeSaveList()
	{
	}
}
