using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct OnAchievementsUnlockedCallbackV2InfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_UserId;

	private IntPtr m_AchievementId;

	private long m_UnlockTime;

	public object ClientData
	{
		[CalledBy(Type = typeof(OnAchievementsUnlockedCallbackV2Info), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
	}

	public IntPtr ClientDataAddress
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(IntPtr);
		}
	}

	public ProductUserId UserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(OnAchievementsUnlockedCallbackV2Info), Member = "Set")]
		get
		{
			return null;
		}
	}

	public string AchievementId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(OnAchievementsUnlockedCallbackV2Info), Member = "Set")]
		get
		{
			return null;
		}
	}

	public DateTimeOffset? UnlockTime
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
	}
}
