using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

public class CreateUserCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	private ProductUserId _003CLocalUserId_003Ek__BackingField;

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
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public ProductUserId LocalUserId
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Result? GetResultCode()
	{
		return null;
	}

	[Calls(Type = typeof(CreateUserCallbackInfoInternal), Member = "get_LocalUserId")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CreateUserCallbackInfoInternal), Member = "get_ClientData")]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(CreateUserCallbackInfoInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CreateUserCallbackInfoInternal), Member = "get_LocalUserId")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(CreateUserCallbackInfoInternal), Member = "get_ClientData")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CreateUserCallbackInfo()
	{
	}
}
