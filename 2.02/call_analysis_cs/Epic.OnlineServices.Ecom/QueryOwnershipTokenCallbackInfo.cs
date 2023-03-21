using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class QueryOwnershipTokenCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private string _003COwnershipToken_003Ek__BackingField;

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
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		private set
		{
		}
	}

	public EpicAccountId LocalUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		private set
		{
		}
	}

	public string OwnershipToken
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
		[CallerCount(Count = 24)]
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

	[CalledBy(Type = typeof(QueryOwnershipTokenCallbackInfo), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryOwnershipTokenCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(QueryOwnershipTokenCallbackInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(QueryOwnershipTokenCallbackInfoInternal), Member = "get_OwnershipToken")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void Set(QueryOwnershipTokenCallbackInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryOwnershipTokenCallbackInfo), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public QueryOwnershipTokenCallbackInfo()
	{
	}
}
