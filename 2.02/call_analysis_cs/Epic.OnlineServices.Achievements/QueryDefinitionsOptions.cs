using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class QueryDefinitionsOptions
{
	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private EpicAccountId _003CEpicUserId_DEPRECATED_003Ek__BackingField;

	private string[] _003CHiddenAchievementIds_DEPRECATED_003Ek__BackingField;

	public ProductUserId LocalUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public EpicAccountId EpicUserId_DEPRECATED
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
		set
		{
		}
	}

	public string[] HiddenAchievementIds_DEPRECATED
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
		set
		{
		}
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public QueryDefinitionsOptions()
	{
	}
}
