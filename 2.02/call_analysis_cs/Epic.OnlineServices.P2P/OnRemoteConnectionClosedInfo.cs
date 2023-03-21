using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

public class OnRemoteConnectionClosedInfo : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private ProductUserId _003CRemoteUserId_003Ek__BackingField;

	private SocketId _003CSocketId_003Ek__BackingField;

	private ConnectionClosedReason _003CReason_003Ek__BackingField;

	public object ClientData
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		private set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		private set
		{
		}
	}

	public ProductUserId RemoteUserId
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		private set
		{
		}
	}

	public SocketId SocketId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		private set
		{
		}
	}

	public ConnectionClosedReason Reason
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(ConnectionClosedReason);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(OnRemoteConnectionClosedInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(OnRemoteConnectionClosedInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(OnRemoteConnectionClosedInfoInternal), Member = "get_RemoteUserId")]
	[Calls(Type = typeof(OnRemoteConnectionClosedInfoInternal), Member = "get_SocketId")]
	[CalledBy(Type = typeof(OnRemoteConnectionClosedInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 5)]
	internal void Set(OnRemoteConnectionClosedInfoInternal? other)
	{
	}

	[Calls(Type = typeof(OnRemoteConnectionClosedInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public OnRemoteConnectionClosedInfo()
	{
	}
}
