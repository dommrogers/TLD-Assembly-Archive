using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CloseConnectionsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_SocketId;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(CloseConnectionsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CloseConnectionsOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public SocketId SocketId
	{
		[Calls(Type = typeof(SocketIdInternal), Member = "Set")]
		[CalledBy(Type = typeof(CloseConnectionsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CalledBy(Type = typeof(CloseConnectionsOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(CloseConnectionsOptionsInternal), Member = "set_SocketId")]
	[Calls(Type = typeof(CloseConnectionsOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	public void Set(CloseConnectionsOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CloseConnectionsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CloseConnectionsOptionsInternal), Member = "set_SocketId")]
	[CalledBy(Type = typeof(P2PInterface), Member = "CloseConnections")]
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
