using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

public class QueryUserInfoByExternalAccountCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private string _003CExternalAccountId_003Ek__BackingField;

	private ExternalAccountType _003CAccountType_003Ek__BackingField;

	private EpicAccountId _003CTargetUserId_003Ek__BackingField;

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
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		[CompilerGenerated]
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

	public string ExternalAccountId
	{
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 12)]
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

	public ExternalAccountType AccountType
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(ExternalAccountType);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public EpicAccountId TargetUserId
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryUserInfoByExternalAccountCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(QueryUserInfoByExternalAccountCallbackInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(QueryUserInfoByExternalAccountCallbackInfoInternal), Member = "get_ExternalAccountId")]
	[Calls(Type = typeof(QueryUserInfoByExternalAccountCallbackInfoInternal), Member = "get_TargetUserId")]
	[CalledBy(Type = typeof(QueryUserInfoByExternalAccountCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 6)]
	internal void Set(QueryUserInfoByExternalAccountCallbackInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryUserInfoByExternalAccountCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public QueryUserInfoByExternalAccountCallbackInfo()
	{
	}
}
