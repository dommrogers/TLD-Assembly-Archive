using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct AddNotifyPeerConnectionClosedOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_SocketId;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(AddNotifyPeerConnectionClosedOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(AddNotifyPeerConnectionClosedOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public SocketId SocketId
	{
		[CalledBy(Type = typeof(AddNotifyPeerConnectionClosedOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(SocketIdInternal), Member = "Set")]
		[CalledBy(Type = typeof(AddNotifyPeerConnectionClosedOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	[Calls(Type = typeof(AddNotifyPeerConnectionClosedOptionsInternal), Member = "set_SocketId")]
	[Calls(Type = typeof(AddNotifyPeerConnectionClosedOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	public void Set(AddNotifyPeerConnectionClosedOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AddNotifyPeerConnectionClosedOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(AddNotifyPeerConnectionClosedOptionsInternal), Member = "set_SocketId")]
	[CalledBy(Type = typeof(P2PInterface), Member = "AddNotifyPeerConnectionClosed")]
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
