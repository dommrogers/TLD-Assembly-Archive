using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 96)]
internal struct DefinitionInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_AchievementId;

	private IntPtr m_DisplayName;

	private IntPtr m_Description;

	private IntPtr m_LockedDisplayName;

	private IntPtr m_LockedDescription;

	private IntPtr m_HiddenDescription;

	private IntPtr m_CompletionDescription;

	private IntPtr m_UnlockedIconId;

	private IntPtr m_LockedIconId;

	private int m_IsHidden;

	private int m_StatThresholdsCount;

	private IntPtr m_StatThresholds;

	public string AchievementId
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string DisplayName
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Description
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string LockedDisplayName
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string LockedDescription
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string HiddenDescription
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string CompletionDescription
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string UnlockedIconId
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string LockedIconId
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool IsHidden
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return false;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public StatThresholds[] StatThresholds
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_AchievementId")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_DisplayName")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_Description")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_LockedDisplayName")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_LockedDescription")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_HiddenDescription")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_CompletionDescription")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_UnlockedIconId")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_LockedIconId")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_IsHidden")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_StatThresholds")]
	public void Set(Definition other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefinitionInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
