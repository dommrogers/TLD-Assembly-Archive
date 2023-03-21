using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class LobbyMemberStatusReceivedCallbackInfo : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private string _003CLobbyId_003Ek__BackingField;

	private ProductUserId _003CTargetUserId_003Ek__BackingField;

	private LobbyMemberStatus _003CCurrentStatus_003Ek__BackingField;

	public object ClientData
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	public string LobbyId
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

	public ProductUserId TargetUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
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

	public LobbyMemberStatus CurrentStatus
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(LobbyMemberStatus);
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LobbyMemberStatusReceivedCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(LobbyMemberStatusReceivedCallbackInfoInternal), Member = "get_LobbyId")]
	[Calls(Type = typeof(LobbyMemberStatusReceivedCallbackInfoInternal), Member = "get_TargetUserId")]
	[CalledBy(Type = typeof(LobbyMemberStatusReceivedCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 4)]
	internal void Set(LobbyMemberStatusReceivedCallbackInfoInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(LobbyMemberStatusReceivedCallbackInfo), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LobbyMemberStatusReceivedCallbackInfo()
	{
	}
}
