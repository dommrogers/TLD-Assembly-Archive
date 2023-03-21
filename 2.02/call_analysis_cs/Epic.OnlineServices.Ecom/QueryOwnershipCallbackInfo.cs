using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class QueryOwnershipCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private ItemOwnership[] _003CItemOwnership_003Ek__BackingField;

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

	public ItemOwnership[] ItemOwnership
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryOwnershipCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(QueryOwnershipCallbackInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(QueryOwnershipCallbackInfoInternal), Member = "get_ItemOwnership")]
	[CalledBy(Type = typeof(QueryOwnershipCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 4)]
	internal void Set(QueryOwnershipCallbackInfoInternal? other)
	{
	}

	[Calls(Type = typeof(QueryOwnershipCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public QueryOwnershipCallbackInfo()
	{
	}
}
