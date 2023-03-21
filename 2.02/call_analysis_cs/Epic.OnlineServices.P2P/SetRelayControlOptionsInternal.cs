using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct SetRelayControlOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private RelayControl m_RelayControl;

	public RelayControl RelayControl
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(SetRelayControlOptions other)
	{
	}

	[CalledBy(Type = typeof(P2PInterface), Member = "SetRelayControl")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
