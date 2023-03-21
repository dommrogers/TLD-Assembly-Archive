using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class UnregisterPlayersCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	public Result ResultCode
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(Result);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnregisterPlayersCallbackInfoInternal), Member = "get_ClientData")]
	internal void Set(UnregisterPlayersCallbackInfoInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnregisterPlayersCallbackInfoInternal), Member = "get_ClientData")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public UnregisterPlayersCallbackInfo()
	{
	}
}
