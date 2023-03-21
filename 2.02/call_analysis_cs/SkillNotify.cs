using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class SkillNotify : MonoBehaviour
{
	public float m_FadeTimeSeconds;

	public float m_SkillIncreaseDisplayTimeSeconds;

	public float m_SkillLevelUpDisplayTimeSeconds;

	public string m_SkillLevelUpAudio;

	public float m_SkillLevelUpDelaySeconds;

	private float m_SkillIncreaseElapsedDisplayTimeSeconds;

	private float m_SkillIncreaseAlpha;

	private float m_SkillLevelUpElapsedDisplayTimeSeconds;

	private float m_SkillLevelUpAlpha;

	private float m_SkillLevelUpDisplayTimeGate;

	private bool m_SkillLevelUpPending;

	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Start()
	{
	}

	[Calls(Type = typeof(SkillNotify), Member = "UpdateSkillLevelUpAlpha")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(SkillNotify), Member = "ShouldHideSkillLevelUpIcon")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(SkillNotify), Member = "UpdateSkillIncreaseAlpha")]
	[Calls(Type = typeof(SkillNotify), Member = "TryToDisplaySkillLevelUp")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 9)]
	public void MaybeShowPointIncrease(string spriteName)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillPoints")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetSkillLevel")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Action_SetSkillPoints), Member = "OnExecute")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(Action_SetSkillLevel), Member = "OnExecute")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public void MaybeShowLevelUp(string spriteName, string header, string footer, int tier)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(SkillNotify), Member = "Update")]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateSkillIncreaseAlpha()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(SkillNotify), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void UpdateSkillLevelUpAlpha()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CalledBy(Type = typeof(SkillNotify), Member = "Update")]
	[CalledBy(Type = typeof(SkillNotify), Member = "TryToDisplaySkillLevelUp")]
	[CallsUnknownMethods(Count = 5)]
	private bool ShouldHideSkillLevelUpIcon()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 5)]
	private bool ShouldHideSkillIncreaseIcon()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(SkillNotify), Member = "Update")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SkillNotify), Member = "ShouldHideSkillLevelUpIcon")]
	private bool TryToDisplaySkillLevelUp()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SkillNotify()
	{
	}
}
