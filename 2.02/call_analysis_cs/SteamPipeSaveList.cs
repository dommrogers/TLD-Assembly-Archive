using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SteamPipeSaveList
{
	public List<SteamPipeSaveData> m_SerializedSteamPipes;

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SteamPipeManager), Member = "SerializeAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public SteamPipeSaveList()
	{
	}
}
