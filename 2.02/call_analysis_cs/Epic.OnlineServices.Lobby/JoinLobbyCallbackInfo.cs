using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class JoinLobbyCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	private string _003CLobbyId_003Ek__BackingField;

	public Result ResultCode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		get
		{
			return default(Result);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
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
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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
	[Calls(Type = typeof(JoinLobbyCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(JoinLobbyCallbackInfoInternal), Member = "get_LobbyId")]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(JoinLobbyCallbackInfoInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(JoinLobbyCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(JoinLobbyCallbackInfoInternal), Member = "get_LobbyId")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public JoinLobbyCallbackInfo()
	{
	}
}
