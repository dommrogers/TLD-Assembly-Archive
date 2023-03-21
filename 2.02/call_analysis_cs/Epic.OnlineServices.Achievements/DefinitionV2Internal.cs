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
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		set
		{
		}
	}

	public string UnlockedDisplayName
	{
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public string UnlockedDescription
	{
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string LockedDisplayName
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public string LockedDescription
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		set
		{
		}
	}

	public string FlavorText
	{
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		set
		{
		}
	}

	public string UnlockedIconURL
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		set
		{
		}
	}

	public string LockedIconURL
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
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
			return default(bool);
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
		set
		{
		}
	}

	public StatThresholds[] StatThresholds
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(DefinitionV2), Member = "Set")]
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

	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_IsHidden")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_StatThresholds")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_UnlockedIconURL")]
	[CalledBy(Type = typeof(DefinitionV2Internal), Member = "Set")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_FlavorText")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_LockedIconURL")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_LockedDisplayName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_AchievementId")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_LockedDescription")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_UnlockedDescription")]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "set_UnlockedDisplayName")]
	public void Set(DefinitionV2 other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DefinitionV2Internal), Member = "Set")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
