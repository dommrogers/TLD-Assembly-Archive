using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

public class SetPresenceCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	public Result ResultCode
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(Result);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SetPresenceCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(SetPresenceCallbackInfoInternal), Member = "get_LocalUserId")]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(SetPresenceCallbackInfoInternal? other)
	{
	}

	[Calls(Type = typeof(SetPresenceCallbackInfoInternal), Member = "get_ClientData")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SetPresenceCallbackInfoInternal), Member = "get_LocalUserId")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SetPresenceCallbackInfo()
	{
	}
}
