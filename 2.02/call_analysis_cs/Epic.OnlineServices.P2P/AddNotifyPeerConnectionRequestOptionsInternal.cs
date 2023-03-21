using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct AddNotifyPeerConnectionRequestOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_SocketId;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(AddNotifyPeerConnectionRequestOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(AddNotifyPeerConnectionRequestOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public SocketId SocketId
	{
		[CalledBy(Type = typeof(AddNotifyPeerConnectionRequestOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(AddNotifyPeerConnectionRequestOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(SocketIdInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AddNotifyPeerConnectionRequestOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(AddNotifyPeerConnectionRequestOptionsInternal), Member = "set_SocketId")]
	public void Set(AddNotifyPeerConnectionRequestOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AddNotifyPeerConnectionRequestOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(AddNotifyPeerConnectionRequestOptionsInternal), Member = "set_SocketId")]
	[CalledBy(Type = typeof(P2PInterface), Member = "AddNotifyPeerConnectionRequest")]
	public void Set(object other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
