using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

public class LoginStatusChangedCallbackInfo : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private LoginStatus _003CPreviousStatus_003Ek__BackingField;

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

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	public LoginStatus PreviousStatus
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LoginStatusChangedCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(LoginStatusChangedCallbackInfoInternal), Member = "get_LocalUserId")]
	[CalledBy(Type = typeof(LoginStatusChangedCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 4)]
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
