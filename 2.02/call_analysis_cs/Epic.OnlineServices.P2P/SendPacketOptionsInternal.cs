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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ProductUserId RemoteUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public SocketId SocketId
	{
		[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(SocketIdInternal), Member = "Set")]
		[CallerCount(Count = 1)]
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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool AllowDelayedDelivery
	{
		[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public PacketReliability Reliability
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SendPacketOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(SendPacketOptionsInternal), Member = "set_RemoteUserId")]
	[Calls(Type = typeof(SendPacketOptionsInternal), Member = "set_SocketId")]
	[Calls(Type = typeof(SendPacketOptionsInternal), Member = "set_Data")]
	[Calls(Type = typeof(SendPacketOptionsInternal), Member = "set_AllowDelayedDelivery")]
	[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
	public void Set(SendPacketOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
	[CalledBy(Type = typeof(P2PInterface), Member = "SendPacket")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
