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
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public string DisplayName
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

	public string Description
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
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
		[CallerCount(Count = 20)]
		set
		{
		}
	}

	public string LockedDescription
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string HiddenDescription
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
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
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	public string UnlockedIconId
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		set
		{
		}
	}

	public string LockedIconId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 14)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public bool IsHidden
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
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
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 20)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 12)]
		set
		{
		}
	}

	[Calls(Type = typeof(DefinitionInternal), Member = "get_IsHidden")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_StatThresholds")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_LockedIconId")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_UnlockedIconId")]
	[CalledBy(Type = typeof(Definition), Member = "Set")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_HiddenDescription")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_CompletionDescription")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_LockedDescription")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_LockedDisplayName")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_Description")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_DisplayName")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_AchievementId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	internal void Set(DefinitionInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Definition), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Definition()
	{
	}
}
