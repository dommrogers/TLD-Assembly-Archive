using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

public class LoginCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private PinGrantInfo _003CPinGrantInfo_003Ek__BackingField;

	private ContinuanceToken _003CContinuanceToken_003Ek__BackingField;

	private AccountFeatureRestrictedInfo _003CAccountFeatureRestrictedInfo_003Ek__BackingField;

	public Result ResultCode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		[CompilerGenerated]
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

	public EpicAccountId LocalUserId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
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

	public PinGrantInfo PinGrantInfo
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

	public ContinuanceToken ContinuanceToken
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
		[CallerCount(Count = 20)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public AccountFeatureRestrictedInfo AccountFeatureRestrictedInfo
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
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

	[CalledBy(Type = typeof(LoginCallbackInfo), Member = "Set")]
	[Calls(Type = typeof(LoginCallbackInfoInternal), Member = "get_AccountFeatureRestrictedInfo")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(LoginCallbackInfoInternal), Member = "get_PinGrantInfo")]
	[Calls(Type = typeof(LoginCallbackInfoInternal), Member = "get_ContinuanceToken")]
	[Calls(Type = typeof(LoginCallbackInfoInternal), Member = "get_ClientData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoginCallbackInfoInternal), Member = "get_LocalUserId")]
	internal void Set(LoginCallbackInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LoginCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LoginCallbackInfo()
	{
	}
}
