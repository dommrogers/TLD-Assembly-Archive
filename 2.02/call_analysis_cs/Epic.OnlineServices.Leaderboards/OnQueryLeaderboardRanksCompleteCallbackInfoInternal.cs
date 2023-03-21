using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct OnQueryLeaderboardRanksCompleteCallbackInfoInternal : ICallbackInfoInternal
{
	private Result m_ResultCode;

	private IntPtr m_ClientData;

	public Result ResultCode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Result);
		}
	}

	public object ClientData
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(OnQueryLeaderboardRanksCompleteCallbackInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(OnQueryLeaderboardRanksCompleteCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public IntPtr ClientDataAddress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(IntPtr);
		}
	}
}
