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
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		set
		{
		}
	}

	public string DisplayName
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		set
		{
		}
	}

	public string Description
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		set
		{
		}
	}

	public string LockedDisplayName
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public string LockedDescription
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		set
		{
		}
	}

	public string HiddenDescription
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public string CompletionDescription
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		set
		{
		}
	}

	public string UnlockedIconId
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		set
		{
		}
	}

	public string LockedIconId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
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
			return default(bool);
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		set
		{
		}
	}

	public StatThresholds[] StatThresholds
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[Calls(Type = typeof(DefinitionInternal), Member = "set_UnlockedIconId")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_LockedIconId")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_StatThresholds")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_CompletionDescription")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_IsHidden")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_HiddenDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_LockedDisplayName")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_Description")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_DisplayName")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_AchievementId")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_LockedDescription")]
	[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
	public void Set(Definition other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefinitionInternal), Member = "Set")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
