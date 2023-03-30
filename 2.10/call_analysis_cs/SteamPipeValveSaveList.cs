using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SteamPipeValveSaveList
{
	public List<SteamPipeSaveData> m_SerializedSteamPipeValves;

	public List<SteamPipeSaveData> m_SerializedSteamPipeValveSockets;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public SteamPipeValveSaveList()
	{
	}
}
