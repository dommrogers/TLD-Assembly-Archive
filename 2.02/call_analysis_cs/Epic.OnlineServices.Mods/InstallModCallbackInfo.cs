using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

public class InstallModCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	private ModIdentifier _003CMod_003Ek__BackingField;

	public Result ResultCode
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
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

	public EpicAccountId LocalUserId
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

	public object ClientData
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

	public ModIdentifier Mod
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CalledBy(Type = typeof(InstallModCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InstallModCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(InstallModCallbackInfoInternal), Member = "get_Mod")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstallModCallbackInfoInternal), Member = "get_LocalUserId")]
	internal void Set(InstallModCallbackInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InstallModCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public InstallModCallbackInfo()
	{
	}
}
