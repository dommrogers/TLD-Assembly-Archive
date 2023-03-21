using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

public class LoginStatusChangedCallbackInfo : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private LoginStatus _003CPrevStatus_003Ek__BackingField;

	private LoginStatus _003CCurrentStatus_003Ek__BackingField;

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

	public EpicAccountId LocalUserId
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

	public LoginStatus PrevStatus
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		get
		{
			return default(LoginStatus);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public LoginStatus CurrentStatus
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(LoginStatus);
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(LoginStatusChangedCallbackInfo), Member = "Set")]
	[Calls(Type = typeof(LoginStatusChangedCallbackInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(LoginStatusChangedCallbackInfoInternal), Member = "get_ClientData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	internal void Set(LoginStatusChangedCallbackInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LoginStatusChangedCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LoginStatusChangedCallbackInfo()
	{
	}
}
