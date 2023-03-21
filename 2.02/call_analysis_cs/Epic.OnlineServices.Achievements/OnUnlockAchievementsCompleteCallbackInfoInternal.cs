using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct OnUnlockAchievementsCompleteCallbackInfoInternal : ICallbackInfoInternal
{
	private Result m_ResultCode;

	private IntPtr m_ClientData;

	private IntPtr m_UserId;

	private uint m_AchievementsCount;

	public Result ResultCode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Result);
		}
	}

	public object ClientData
	{
		[CalledBy(Type = typeof(OnUnlockAchievementsCompleteCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(OnUnlockAchievementsCompleteCallbackInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return (IntPtr)0;
		}
	}

	public ProductUserId UserId
	{
		[CalledBy(Type = typeof(OnUnlockAchievementsCompleteCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(OnUnlockAchievementsCompleteCallbackInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public uint AchievementsCount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return 0u;
		}
	}
}
