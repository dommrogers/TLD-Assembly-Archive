using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct SetPortRangeOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private ushort m_Port;

	private ushort m_MaxAdditionalPortsToTry;

	public ushort Port
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public ushort MaxAdditionalPortsToTry
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	public void Set(SetPortRangeOptions other)
	{
	}

	[CalledBy(Type = typeof(P2PInterface), Member = "SetPortRange")]
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
