using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class LobbyMemberUpdateReceivedCallbackInfo : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private string _003CLobbyId_003Ek__BackingField;

	private ProductUserId _003CTargetUserId_003Ek__BackingField;

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

	public string LobbyId
	{
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(LobbyMemberUpdateReceivedCallbackInfoInternal), Member = "get_TargetUserId")]
	[Calls(Type = typeof(LobbyMemberUpdateReceivedCallbackInfoInternal), Member = "get_LobbyId")]
	[CalledBy(Type = typeof(LobbyMemberUpdateReceivedCallbackInfo), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LobbyMemberUpdateReceivedCallbackInfoInternal), Member = "get_ClientData")]
	[CallerCount(Count = 1)]
	internal void Set(LobbyMemberUpdateReceivedCallbackInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LobbyMemberUpdateReceivedCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public LobbyMemberUpdateReceivedCallbackInfo()
	{
	}
}
