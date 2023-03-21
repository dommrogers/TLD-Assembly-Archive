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
		[CallerCount(Count = 52)]
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

	public string UnlockedDisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		[CompilerGenerated]
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

	public string UnlockedDescription
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
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

	public string LockedDisplayName
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	public string LockedDescription
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
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

	public string FlavorText
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string UnlockedIconURL
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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

	public string LockedIconURL
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[CallerCount(Count = 17)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public bool IsHidden
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public StatThresholds[] StatThresholds
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
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

	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_FlavorText")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_StatThresholds")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_IsHidden")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_LockedIconURL")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_UnlockedIconURL")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_LockedDisplayName")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_UnlockedDescription")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_UnlockedDisplayName")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_AchievementId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "get_LockedDescription")]
	internal void Set(DefinitionV2Internal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DefinitionV2), Member = "Set")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public DefinitionV2()
	{
	}
}
