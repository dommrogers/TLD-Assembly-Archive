using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;
using UnityEngine;

public class FeatNotify : MonoBehaviour
{
	public float m_FeatUnlockDisplayTimeSeconds;

	public float m_FadeTimeSeconds;

	public string m_FeatUnlockAudio;

	private float m_FeatUnlockedElapsedDisplayTimeSeconds;

	private float m_FeatUnlockedAlpha;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(FeatNotify), Member = "UpdateFeatUnlockedAlpha")]
	public void Update()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(Feat), Member = "TryToDisplayKicker")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "UnlockBadge")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Mark4DONCurrentDayComplete")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "EatingComplete")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "CheckSaveSlotForMissedBadges")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Mark4DONCurrentDayComplete")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(Utils), Member = "GetBadgeIcon")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	public void ShowFeatUnlockedKicker(string textureName, string footer)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(FeatNotify), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateFeatUnlockedAlpha()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 0)]
	private bool ShouldHideFeatUnlockedIcon()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FeatNotify()
	{
	}
}
