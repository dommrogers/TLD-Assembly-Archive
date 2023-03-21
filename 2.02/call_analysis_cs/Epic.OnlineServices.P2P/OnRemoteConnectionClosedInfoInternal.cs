using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct OnRemoteConnectionClosedInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private IntPtr m_RemoteUserId;

	private IntPtr m_SocketId;

	private ConnectionClosedReason m_Reason;

	public object ClientData
	{
		[CalledBy(Type = typeof(OnRemoteConnectionClosedInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public IntPtr ClientDataAddress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return (IntPtr)0;
		}
	}

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(OnRemoteConnectionClosedInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public ProductUserId RemoteUserId
	{
		[CalledBy(Type = typeof(OnRemoteConnectionClosedInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public SocketId SocketId
	{
		[CalledBy(Type = typeof(OnRemoteConnectionClosedInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public ConnectionClosedReason Reason
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(ConnectionClosedReason);
		}
	}
}
