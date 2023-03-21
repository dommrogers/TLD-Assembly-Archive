using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

public class UpdateModCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	private ModIdentifier _003CMod_003Ek__BackingField;

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

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
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

	public object ClientData
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

	public ModIdentifier Mod
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Result? GetResultCode()
	{
		return null;
	}

	[Calls(Type = typeof(UpdateModCallbackInfoInternal), Member = "get_Mod")]
	[CalledBy(Type = typeof(UpdateModCallbackInfo), Member = "Set")]
	[Calls(Type = typeof(UpdateModCallbackInfoInternal), Member = "get_ClientData")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UpdateModCallbackInfoInternal), Member = "get_LocalUserId")]
	internal void Set(UpdateModCallbackInfoInternal? other)
	{
	}

	[Calls(Type = typeof(UpdateModCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public UpdateModCallbackInfo()
	{
	}
}
