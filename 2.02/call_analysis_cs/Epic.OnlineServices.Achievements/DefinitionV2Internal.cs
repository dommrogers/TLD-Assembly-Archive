using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 88)]
internal struct DefinitionV2Internal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_AchievementId;

	private IntPtr m_UnlockedDisplayName;

	private IntPtr m_UnlockedDescription;

	private IntPtr m_LockedDisplayName;

	private IntPtr m_LockedDescription;

	private IntPtr m_FlavorText;

	private IntPtr m_UnlockedIconURL;

	private IntPtr m_LockedIconURL;

	private int m_IsHidden;

	private uint m_StatThresholdsCount;

	private IntPtr m_StatThresholds;

	public string AchievementId
	{
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string UnlockedDisplayName
	{
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string UnlockedDescription
	{
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string LockedDisplayName
	{
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string LockedDescription
	{
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string FlavorText
	{
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string UnlockedIconURL
	{
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string LockedIconURL
	{
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool IsHidden
	{
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return false;
		}
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public StatThresholds[] StatThresholds
	{
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_AchievementId")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_UnlockedDisplayName")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_UnlockedDescription")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_LockedDisplayName")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_LockedDescription")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_FlavorText")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_UnlockedIconURL")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_LockedIconURL")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_IsHidden")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_StatThresholds")]
	public void Set(DefinitionV2 other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "Set")]
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
