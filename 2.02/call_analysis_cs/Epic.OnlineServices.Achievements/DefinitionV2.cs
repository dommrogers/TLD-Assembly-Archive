using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class DefinitionV2 : ISettable
{
	private string _003CAchievementId_003Ek__BackingField;

	private string _003CUnlockedDisplayName_003Ek__BackingField;

	private string _003CUnlockedDescription_003Ek__BackingField;

	private string _003CLockedDisplayName_003Ek__BackingField;

	private string _003CLockedDescription_003Ek__BackingField;

	private string _003CFlavorText_003Ek__BackingField;

	private string _003CUnlockedIconURL_003Ek__BackingField;

	private string _003CLockedIconURL_003Ek__BackingField;

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

	public string UnlockedDisplayName
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

	public string UnlockedDescription
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

	public string FlavorText
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

	public string UnlockedIconURL
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

	public string LockedIconURL
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
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_AchievementId")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_UnlockedDisplayName")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_UnlockedDescription")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_LockedDisplayName")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_LockedDescription")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_FlavorText")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_UnlockedIconURL")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_LockedIconURL")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_IsHidden")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_StatThresholds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	internal void Set(DefinitionV2Internal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefinitionV2), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public DefinitionV2()
	{
	}
}
