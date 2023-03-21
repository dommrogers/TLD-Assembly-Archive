using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SteamPipeSaveList
{
	public List<SteamPipeSaveData> m_SerializedSteamPipes;

	[CalledBy(Type = typeof(SteamPipeManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public SteamPipeSaveList()
	{
	}
}
