using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct ReceivePacketOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private uint m_MaxDataSizeBytes;

	private IntPtr m_RequestedChannel;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(ReceivePacketOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ReceivePacketOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint MaxDataSizeBytes
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public byte? RequestedChannel
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(ReceivePacketOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(ReceivePacketOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReceivePacketOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(ReceivePacketOptionsInternal), Member = "set_RequestedChannel")]
	public void Set(ReceivePacketOptions other)
	{
	}

	[CalledBy(Type = typeof(P2PInterface), Member = "ReceivePacket")]
	[Calls(Type = typeof(ReceivePacketOptionsInternal), Member = "set_RequestedChannel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReceivePacketOptionsInternal), Member = "set_LocalUserId")]
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
