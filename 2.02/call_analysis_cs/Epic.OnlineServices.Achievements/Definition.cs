using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class Definition : ISettable
{
	private string _003CAchievementId_003Ek__BackingField;

	private string _003CDisplayName_003Ek__BackingField;

	private string _003CDescription_003Ek__BackingField;

	private string _003CLockedDisplayName_003Ek__BackingField;

	private string _003CLockedDescription_003Ek__BackingField;

	private string _003CHiddenDescription_003Ek__BackingField;

	private string _003CCompletionDescription_003Ek__BackingField;

	private string _003CUnlockedIconId_003Ek__BackingField;

	private string _003CLockedIconId_003Ek__BackingField;

	private bool _003CIsHidden_003Ek__BackingField;

	private StatThresholds[] _003CStatThresholds_003Ek__BackingField;

	public string AchievementId
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
		set
		{
		}
	}

	public string DisplayName
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
		set
		{
		}
	}

	public string Description
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
		set
		{
		}
	}

	public string LockedDisplayName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 24)]
		set
		{
		}
	}

	public string LockedDescription
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		set
		{
		}
	}

	public string HiddenDescription
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
		[CallerCount(Count = 18)]
		set
		{
		}
	}

	public string CompletionDescription
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
		[CallerCount(Count = 46)]
		set
		{
		}
	}

	public string UnlockedIconId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 19)]
		set
		{
		}
	}

	public string LockedIconId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		set
		{
		}
	}

	public bool IsHidden
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public StatThresholds[] StatThresholds
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 40)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 37)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(Definition), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_AchievementId")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_DisplayName")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_Description")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_LockedDisplayName")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_LockedDescription")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_HiddenDescription")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_CompletionDescription")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_UnlockedIconId")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_LockedIconId")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_IsHidden")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_StatThresholds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	internal void Set(DefinitionInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Definition), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Definition()
	{
	}
}
