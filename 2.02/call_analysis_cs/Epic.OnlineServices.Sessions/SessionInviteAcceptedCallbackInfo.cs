using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class SessionInviteAcceptedCallbackInfo : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private string _003CSessionId_003Ek__BackingField;

	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private ProductUserId _003CTargetUserId_003Ek__BackingField;

	private string _003CInviteId_003Ek__BackingField;

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

	public string SessionId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public ProductUserId LocalUserId
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

	public ProductUserId TargetUserId
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

	public string InviteId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
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
	[Calls(Type = typeof(SessionInviteAcceptedCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(SessionInviteAcceptedCallbackInfoInternal), Member = "get_SessionId")]
	[Calls(Type = typeof(SessionInviteAcceptedCallbackInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(SessionInviteAcceptedCallbackInfoInternal), Member = "get_TargetUserId")]
	[Calls(Type = typeof(SessionInviteAcceptedCallbackInfoInternal), Member = "get_InviteId")]
	[CalledBy(Type = typeof(SessionInviteAcceptedCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 5)]
	internal void Set(SessionInviteAcceptedCallbackInfoInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SessionInviteAcceptedCallbackInfo), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SessionInviteAcceptedCallbackInfo()
	{
	}
}
