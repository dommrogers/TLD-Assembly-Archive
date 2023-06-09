using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace DataPlatform;

public class Achievement : IWrappedObject, IDisposable
{
	private IntPtr m_Self;

	private AchievementTimeWindow m_Available;

	private string m_DeepLink;

	private string m_Id;

	private string m_LockedDescription;

	private AchievementMediaAssetList m_MediaAssets;

	private string m_Name;

	private PlatformsAvailableOnList m_PlatformsAvailableOn;

	private string m_ProductId;

	private AchievementProgression m_Progression;

	private AchievementRewardList m_Rewards;

	private string m_ServiceConfigurationId;

	private AchievementTitleAssociationList m_TitleAssociations;

	private string m_UnlockedDescription;

	public AchievementType GetAchievementType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(AchievementType);
		}
	}

	public AchievementTimeWindow Available
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	public string DeepLink
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public long EstimatedUnlockTime
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0L;
		}
	}

	public string Id
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public bool IsRevoked
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public bool IsSecret
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public string LockedDescription
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public AchievementMediaAssetList MediaAssets
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	public string Name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public AchievementParticipationType ParticipationType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(AchievementParticipationType);
		}
	}

	public PlatformsAvailableOnList PlatformsAvailableOn
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	public string ProductId
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public AchievementProgression Progression
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	public AchievementProgressState ProgressState
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(AchievementProgressState);
		}
	}

	public AchievementRewardList Rewards
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	public string ServiceConfigurationId
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public AchievementTitleAssociationList TitleAssociations
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	public string UnlockedDescription
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Achievement(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Achievement()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 59)]
	public IntPtr GetNativePtr()
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	~Achievement()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}
}
