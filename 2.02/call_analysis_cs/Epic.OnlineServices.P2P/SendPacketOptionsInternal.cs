using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

[StructLayout(0, Pack = 8, Size = 56)]
internal struct SendPacketOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_RemoteUserId;

	private IntPtr m_SocketId;

	private byte m_Channel;

	private uint m_DataLengthBytes;

	private IntPtr m_Data;

	private int m_AllowDelayedDelivery;

	private PacketReliability m_Reliability;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId RemoteUserId
	{
		[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public SocketId SocketId
	{
		[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SocketIdInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	public byte Channel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public byte[] Data
	{
		[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool AllowDelayedDelivery
	{
		[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public PacketReliability Reliability
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SendPacketOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(SendPacketOptionsInternal), Member = "set_RemoteUserId")]
	[Calls(Type = typeof(SendPacketOptionsInternal), Member = "set_SocketId")]
	[Calls(Type = typeof(SendPacketOptionsInternal), Member = "set_Data")]
	[Calls(Type = typeof(SendPacketOptionsInternal), Member = "set_AllowDelayedDelivery")]
	public void Set(SendPacketOptions other)
	{
	}

	[CalledBy(Type = typeof(P2PInterface), Member = "SendPacket")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
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
