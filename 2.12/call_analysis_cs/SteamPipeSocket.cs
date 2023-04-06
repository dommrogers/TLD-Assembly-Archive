using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class SteamPipeSocket
{
	public SteamPipe m_Socket;

	public float m_MaxFlowPercent;

	[CallerCount(Count = 0)]
	public SteamPipeSocket()
	{
	}
}
