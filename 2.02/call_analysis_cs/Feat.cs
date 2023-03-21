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
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Feat), Member = "TryToDisplayKicker")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "AddFeatToList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "AddFeatToList")]
	[CallsUnknownMethods(Count = 9)]
	public BadgeInfo CreateBadgeInfo()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public virtual string GetBonusDescription()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 25)]
	public bool IsUnlockedAndEnabled()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual bool IsUnlocked()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual float GetNormalizedProgress()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CalledBy(Type = typeof(Feat), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	protected bool TryToDisplayKicker()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SnareItem), Member = "SpawnDeadRabbitOnSnare")]
	[CalledBy(Type = typeof(ResearchItem), Member = "Read")]
	[CalledBy(Type = typeof(Fire), Member = "FireStateSet")]
	[CalledBy(Type = typeof(Feat_StraightToHeart), Member = "IncrementItemConsumed")]
	[CalledBy(Type = typeof(Feat_SnowWalker), Member = "IncrementMeters")]
	[CalledBy(Type = typeof(Feat_FreeRunner), Member = "IncrementMeters")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "IncrementFiresStarted")]
	[CalledBy(Type = typeof(Feat_EfficientMachine), Member = "IncrementElapsedHours")]
	[CalledBy(Type = typeof(Feat_ColdFusion), Member = "IncrementHours")]
	[CalledBy(Type = typeof(Feat_BookSmarts), Member = "IncrementHours")]
	[CalledBy(Type = typeof(Feat_BlizzardWalker), Member = "IncrementHours")]
	[Calls(Type = typeof(GameManager), Member = "IsPlayingCustomXPGame")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Feat_ExpertTrapper), Member = "IncrementRabbitSnaredCount")]
	protected bool ShouldBlockIncrement()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void HandleOnFeatUnlocked()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Feat()
	{
	}
}
