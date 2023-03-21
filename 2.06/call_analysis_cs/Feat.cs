using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
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

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	protected bool m_KickerPending;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "AddFeatToList")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "AddFeatToList")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public BadgeInfo CreateBadgeInfo()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetDescription()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetShortDescription()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetBonusDescription()
	{
		return null;
	}

	[CallerCount(Count = 25)]
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
	[CallerCount(Count = 6)]
	public virtual void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateTimeStats")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	protected bool ShouldBlockIncrement()
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
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateTimeStats")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	protected void HandleOnFeatUnlocked()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Feat()
	{
	}
}
