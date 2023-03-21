using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.UI.Generics;
using UnityEngine;

public class SkillNotify : MonoBehaviour
{
	public float m_FadeTimeSeconds;

	public float m_SkillIncreaseDisplayTimeSeconds;

	public float m_SkillLevelUpDisplayTimeSeconds;

	public string m_SkillLevelUpAudio;

	public float m_SkillLevelUpDelaySeconds;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_PauseMenu> m_PauseMenu;

	private float m_SkillIncreaseElapsedDisplayTimeSeconds;

	private float m_SkillIncreaseAlpha;

	private float m_SkillLevelUpElapsedDisplayTimeSeconds;

	private float m_SkillLevelUpAlpha;

	private float m_SkillLevelUpDisplayTimeGate;

	private bool m_SkillLevelUpPending;

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[Calls(Type = typeof(SkillNotify), Member = "ShouldHideSkillLevelUpIcon")]
	[Calls(Type = typeof(SkillNotify), Member = "UpdateSkillIncreaseAlpha")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(SkillNotify), Member = "UpdateSkillLevelUpAlpha")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(SkillNotify), Member = "ShouldHideSkillLevelUpIcon")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void MaybeShowPointIncrease(string spriteName)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_SetSkillLevel), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public void MaybeShowLevelUp(string spriteName, string header, string footer, int tier)
	{
	}

	[CalledBy(Type = typeof(SkillNotify), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateSkillIncreaseAlpha(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(SkillNotify), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateSkillLevelUpAlpha(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(SkillNotify), Member = "TryToDisplaySkillLevelUp")]
	[CalledBy(Type = typeof(SkillNotify), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SkillNotify), Member = "Update")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	private bool ShouldHideSkillLevelUpIcon()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldHideSkillIncreaseIcon()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SkillNotify), Member = "ShouldHideSkillLevelUpIcon")]
	private bool TryToDisplaySkillLevelUp(Panel_HUD hud)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SkillNotify()
	{
	}
}
