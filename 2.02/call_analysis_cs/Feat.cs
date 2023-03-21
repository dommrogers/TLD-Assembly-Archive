using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Feat : MonoBehaviour
{
	public FeatType m_FeatType;

	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public LocalizedString m_LocalizedShortDescription;

	public LocalizedString m_LocalizedBonusDescription;

	public string m_BadgeIcon;

	public string m_BadgeLockedIcon;

	protected bool m_KickerPending;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Feat), Member = "TryToDisplayKicker")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "AddFeatToList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "AddFeatToList")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public BadgeInfo CreateBadgeInfo()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetDescription()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetShortDescription()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetBonusDescription()
	{
		return null;
	}

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsUnlockedAndEnabled()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual bool IsUnlocked()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual float GetNormalizedProgress()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CalledBy(Type = typeof(Feat), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	protected bool TryToDisplayKicker()
	{
		return false;
	}

	[CalledBy(Type = typeof(Feat_BlizzardWalker), Member = "IncrementHours")]
	[CalledBy(Type = typeof(Feat_BookSmarts), Member = "IncrementHours")]
	[CalledBy(Type = typeof(Feat_ColdFusion), Member = "IncrementHours")]
	[CalledBy(Type = typeof(Feat_EfficientMachine), Member = "IncrementElapsedHours")]
	[CalledBy(Type = typeof(Feat_ExpertTrapper), Member = "IncrementRabbitSnaredCount")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "IncrementFiresStarted")]
	[CalledBy(Type = typeof(Feat_FreeRunner), Member = "IncrementMeters")]
	[CalledBy(Type = typeof(Feat_SnowWalker), Member = "IncrementMeters")]
	[CalledBy(Type = typeof(Feat_StraightToHeart), Member = "IncrementItemConsumed")]
	[CalledBy(Type = typeof(Fire), Member = "FireStateSet")]
	[CalledBy(Type = typeof(ResearchItem), Member = "Read")]
	[CalledBy(Type = typeof(SnareItem), Member = "SpawnDeadRabbitOnSnare")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(GameManager), Member = "IsPlayingCustomXPGame")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected bool ShouldBlockIncrement()
	{
		return false;
	}

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void HandleOnFeatUnlocked()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Feat()
	{
	}
}
