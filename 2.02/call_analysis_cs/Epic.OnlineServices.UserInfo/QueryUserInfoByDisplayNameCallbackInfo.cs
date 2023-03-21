using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

public class QueryUserInfoByDisplayNameCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private EpicAccountId _003CTargetUserId_003Ek__BackingField;

	private string _003CDisplayName_003Ek__BackingField;

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

	public EpicAccountId LocalUserId
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

	public EpicAccountId TargetUserId
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

	public string DisplayName
	{
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 20)]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(QueryUserInfoByDisplayNameCallbackInfo), Member = "Set")]
	[Calls(Type = typeof(QueryUserInfoByDisplayNameCallbackInfoInternal), Member = "get_DisplayName")]
	[Calls(Type = typeof(QueryUserInfoByDisplayNameCallbackInfoInternal), Member = "get_TargetUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryUserInfoByDisplayNameCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(QueryUserInfoByDisplayNameCallbackInfoInternal), Member = "get_LocalUserId")]
	[CallerCount(Count = 1)]
	internal void Set(QueryUserInfoByDisplayNameCallbackInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryUserInfoByDisplayNameCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public QueryUserInfoByDisplayNameCallbackInfo()
	{
	}
}
