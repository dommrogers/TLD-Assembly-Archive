using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct GetNextReceivedPacketSizeOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_RequestedChannel;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public byte? RequestedChannel
	{
		[CalledBy(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "set_RequestedChannel")]
	public void Set(GetNextReceivedPacketSizeOptions other)
	{
	}

	[CalledBy(Type = typeof(P2PInterface), Member = "GetNextReceivedPacketSize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "set_RequestedChannel")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
