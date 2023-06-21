using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
using TLD.UI.Generics;

public class Feat_NightWalker : Feat
{
	public const BadgeInfoType BADGE = BadgeInfoType.Badge_NowhereToHide2020Badge1;

	public float m_FatigueScaleDayMultiplier;

	public float m_FatigueScaleNightMultiplier;

	private bool m_Unlocked;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected override void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[CallsUnknownMethods(Count = 2)]
	public float GetFatigueScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsUnlocked()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CallerCount(Count = 0)]
	public Feat_NightWalker()
	{
	}
}
