using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class SendInviteCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	private string _003CLobbyId_003Ek__BackingField;

	public Result ResultCode
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(Result);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public object ClientData
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

	public string LobbyId
	{
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SendInviteCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(SendInviteCallbackInfoInternal), Member = "get_LobbyId")]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(SendInviteCallbackInfoInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SendInviteCallbackInfoInternal), Member = "get_LobbyId")]
	[Calls(Type = typeof(SendInviteCallbackInfoInternal), Member = "get_ClientData")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SendInviteCallbackInfo()
	{
	}
}
