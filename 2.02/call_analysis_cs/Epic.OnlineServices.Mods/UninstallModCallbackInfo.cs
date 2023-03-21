using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

public class UninstallModCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	private ModIdentifier _003CMod_003Ek__BackingField;

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
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		[CompilerGenerated]
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

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UninstallModCallbackInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(UninstallModCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(UninstallModCallbackInfoInternal), Member = "get_Mod")]
	[CalledBy(Type = typeof(UninstallModCallbackInfo), Member = "Set")]
	internal void Set(UninstallModCallbackInfoInternal? other)
	{
	}

	[Calls(Type = typeof(UninstallModCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public UninstallModCallbackInfo()
	{
	}
}
