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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public byte? RequestedChannel
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "set_RequestedChannel")]
	[Calls(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	public void Set(GetNextReceivedPacketSizeOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "set_RequestedChannel")]
	[CalledBy(Type = typeof(P2PInterface), Member = "GetNextReceivedPacketSize")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
