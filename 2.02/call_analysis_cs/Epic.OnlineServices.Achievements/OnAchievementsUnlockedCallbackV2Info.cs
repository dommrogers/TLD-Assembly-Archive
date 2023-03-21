using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class OnAchievementsUnlockedCallbackV2Info : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private ProductUserId _003CUserId_003Ek__BackingField;

	private string _003CAchievementId_003Ek__BackingField;

	private DateTimeOffset? _003CUnlockTime_003Ek__BackingField;

	public object ClientData
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		private set
		{
		}
	}

	public ProductUserId UserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		private set
		{
		}
	}

	public string AchievementId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		private set
		{
		}
	}

	public DateTimeOffset? UnlockTime
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CalledBy(Type = typeof(OnAchievementsUnlockedCallbackV2Info), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OnAchievementsUnlockedCallbackV2InfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(OnAchievementsUnlockedCallbackV2InfoInternal), Member = "get_UserId")]
	[Calls(Type = typeof(OnAchievementsUnlockedCallbackV2InfoInternal), Member = "get_AchievementId")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal void Set(OnAchievementsUnlockedCallbackV2InfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OnAchievementsUnlockedCallbackV2Info), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public OnAchievementsUnlockedCallbackV2Info()
	{
	}
}
