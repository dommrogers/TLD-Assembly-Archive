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
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		private set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		private set
		{
		}
	}

	public ProductUserId RemoteUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
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
		[CallerCount(Count = 24)]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(OnRemoteConnectionClosedInfo), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OnRemoteConnectionClosedInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(OnRemoteConnectionClosedInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(OnRemoteConnectionClosedInfoInternal), Member = "get_RemoteUserId")]
	[Calls(Type = typeof(OnRemoteConnectionClosedInfoInternal), Member = "get_SocketId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void Set(OnRemoteConnectionClosedInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OnRemoteConnectionClosedInfo), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public OnRemoteConnectionClosedInfo()
	{
	}
}
