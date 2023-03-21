using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct CloseConnectionOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_RemoteUserId;

	private IntPtr m_SocketId;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CloseConnectionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CloseConnectionOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ProductUserId RemoteUserId
	{
		[CalledBy(Type = typeof(CloseConnectionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CloseConnectionOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public SocketId SocketId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(SocketIdInternal), Member = "Set")]
		[CalledBy(Type = typeof(CloseConnectionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CloseConnectionOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CloseConnectionOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CloseConnectionOptionsInternal), Member = "set_RemoteUserId")]
	[Calls(Type = typeof(CloseConnectionOptionsInternal), Member = "set_SocketId")]
	public void Set(CloseConnectionOptions other)
	{
	}

	[CalledBy(Type = typeof(P2PInterface), Member = "CloseConnection")]
	[Calls(Type = typeof(CloseConnectionOptionsInternal), Member = "set_SocketId")]
	[Calls(Type = typeof(CloseConnectionOptionsInternal), Member = "set_RemoteUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CloseConnectionOptionsInternal), Member = "set_LocalUserId")]
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
