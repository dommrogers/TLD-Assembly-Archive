using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class RegisterPlayersCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

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
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 71)]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RegisterPlayersCallbackInfoInternal), Member = "get_ClientData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal void Set(RegisterPlayersCallbackInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(RegisterPlayersCallbackInfoInternal), Member = "get_ClientData")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public RegisterPlayersCallbackInfo()
	{
	}
}
