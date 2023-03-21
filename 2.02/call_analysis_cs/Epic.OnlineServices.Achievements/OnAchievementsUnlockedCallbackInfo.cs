using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class OnAchievementsUnlockedCallbackInfo : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private ProductUserId _003CUserId_003Ek__BackingField;

	private string[] _003CAchievementIds_003Ek__BackingField;

	public object ClientData
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		private set
		{
		}
	}

	public ProductUserId UserId
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

	public string[] AchievementIds
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(OnAchievementsUnlockedCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(OnAchievementsUnlockedCallbackInfoInternal), Member = "get_UserId")]
	[Calls(Type = typeof(OnAchievementsUnlockedCallbackInfoInternal), Member = "get_AchievementIds")]
	[CalledBy(Type = typeof(OnAchievementsUnlockedCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(OnAchievementsUnlockedCallbackInfoInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(OnAchievementsUnlockedCallbackInfo), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public OnAchievementsUnlockedCallbackInfo()
	{
	}
}
