using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class CopyAchievementDefinitionByIndexOptions
{
	private uint _003CAchievementIndex_003Ek__BackingField;

	public uint AchievementIndex
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(uint);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public CopyAchievementDefinitionByIndexOptions()
	{
	}
}
