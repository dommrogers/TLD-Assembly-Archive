using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Transmitters.UI;

[Serializable]
public class LocalizedString
{
	public string m_LocalizationID;

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "TryPerformInteraction")]
	[CalledBy(Type = typeof(LockedInteraction), Member = "PerformLockInteraction")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(RockCache), Member = "Awake")]
	[CalledBy(Type = typeof(GridUI), Member = "RefreshGridItem")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSpeakerNameDuringPhoneCalls")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "GetSpeakerName")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ShowError")]
	[CalledBy(Type = typeof(TransmitterSiteListItem), Member = "SetTransmitter")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string Text()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSet()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LocalizedString()
	{
	}
}
