using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

[StructLayout(0, Pack = 8, Size = 4)]
internal struct GetRelayControlOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(GetRelayControlOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(P2PInterface), Member = "GetRelayControl")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
