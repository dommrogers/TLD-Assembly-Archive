using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

public class OnIncomingConnectionRequestInfo : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private ProductUserId _003CRemoteUserId_003Ek__BackingField;

	private SocketId _003CSocketId_003Ek__BackingField;

	public object ClientData
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		[CompilerGenerated]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 41)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public SocketId SocketId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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
	[Calls(Type = typeof(OnIncomingConnectionRequestInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(OnIncomingConnectionRequestInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(OnIncomingConnectionRequestInfoInternal), Member = "get_RemoteUserId")]
	[Calls(Type = typeof(OnIncomingConnectionRequestInfoInternal), Member = "get_SocketId")]
	[CalledBy(Type = typeof(OnIncomingConnectionRequestInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 4)]
	internal void Set(OnIncomingConnectionRequestInfoInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(OnIncomingConnectionRequestInfo), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public OnIncomingConnectionRequestInfo()
	{
	}
}
