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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(OnRemoteConnectionClosedInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public IntPtr ClientDataAddress
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(IntPtr);
		}
	}

	public ProductUserId LocalUserId
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(OnRemoteConnectionClosedInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	public ProductUserId RemoteUserId
	{
		[CalledBy(Type = typeof(OnRemoteConnectionClosedInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public SocketId SocketId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(OnRemoteConnectionClosedInfo), Member = "Set")]
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
