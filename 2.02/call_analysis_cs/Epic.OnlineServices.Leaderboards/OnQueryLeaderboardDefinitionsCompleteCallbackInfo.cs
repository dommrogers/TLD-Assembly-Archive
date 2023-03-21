using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

public class OnQueryLeaderboardDefinitionsCompleteCallbackInfo : ICallbackInfo, ISettable
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal), Member = "get_ClientData")]
	[CallsUnknownMethods(Count = 2)]
	internal void Set(OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal), Member = "get_ClientData")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public OnQueryLeaderboardDefinitionsCompleteCallbackInfo()
	{
	}
}
