using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct SocketIdInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private byte[] m_SocketName;

	public string SocketName
	{
		[CalledBy(Type = typeof(SocketId), Member = "Set")]
		[CalledBy(Type = typeof(SocketId), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryConvert")]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(SocketIdInternal), Member = "Set")]
		[CalledBy(Type = typeof(SocketIdInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryConvert")]
		[CallsDeduplicatedMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketIdInternal), Member = "set_SocketName")]
	public void Set(SocketId other)
	{
	}

	[CalledBy(Type = typeof(AcceptConnectionOptionsInternal), Member = "set_SocketId")]
	[CalledBy(Type = typeof(AddNotifyPeerConnectionClosedOptionsInternal), Member = "set_SocketId")]
	[CalledBy(Type = typeof(AddNotifyPeerConnectionRequestOptionsInternal), Member = "set_SocketId")]
	[CalledBy(Type = typeof(CloseConnectionOptionsInternal), Member = "set_SocketId")]
	[CalledBy(Type = typeof(CloseConnectionsOptionsInternal), Member = "set_SocketId")]
	[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "set_SocketId")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SocketIdInternal), Member = "set_SocketName")]
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
