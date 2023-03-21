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
		[CalledBy(Type = typeof(CloseConnectionsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public SocketId SocketId
	{
		[CalledBy(Type = typeof(CloseConnectionsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CloseConnectionsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SocketIdInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CloseConnectionsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CloseConnectionsOptionsInternal), Member = "set_SocketId")]
	public void Set(CloseConnectionsOptions other)
	{
	}

	[CalledBy(Type = typeof(P2PInterface), Member = "CloseConnections")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CloseConnectionsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CloseConnectionsOptionsInternal), Member = "set_SocketId")]
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
