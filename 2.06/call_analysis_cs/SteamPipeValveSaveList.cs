using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SteamPipeValveSaveList
{
	public List<SteamPipeSaveData> m_SerializedSteamPipeValves;

	public List<SteamPipeSaveData> m_SerializedSteamPipeValveSockets;

	[CalledBy(Type = typeof(SteamPipeValveManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public SteamPipeValveSaveList()
	{
	}
}
