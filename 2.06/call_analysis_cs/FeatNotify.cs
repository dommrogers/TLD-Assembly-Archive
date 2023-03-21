using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class FeatNotify : MonoBehaviour
{
	public float m_FeatUnlockDisplayTimeSeconds;

	public float m_FadeTimeSeconds;

	public string m_FeatUnlockAudio;

	private PanelReference<Panel_HUD> m_HUD;

	private float m_FeatUnlockedElapsedDisplayTimeSeconds;

	private float m_FeatUnlockedAlpha;

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(FeatNotify), Member = "UpdateFeatUnlockedAlpha")]
	[CallsUnknownMethods(Count = 5)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "UnlockBadge")]
	[CalledBy(Type = typeof(Feat), Member = "TryToDisplayKicker")]
	[CalledBy(Type = typeof(Feat), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	public void ShowFeatUnlockedKicker(string textureName, string footer)
	{
	}

	[CalledBy(Type = typeof(FeatNotify), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private void UpdateFeatUnlockedAlpha(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldHideFeatUnlockedIcon()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FeatNotify()
	{
	}
}
