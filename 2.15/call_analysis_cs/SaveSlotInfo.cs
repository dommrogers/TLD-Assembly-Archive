using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gameplay;
using TLD.OptionalContent;
using UnityEngine;

public class SaveSlotInfo
{
	public string m_SaveSlotName;

	public SaveSlotType m_GameMode;

	public uint m_GameId;

	public Episode m_Episode;

	public DateTime m_Timestamp;

	public string m_Region;

	public string m_Location;

	public float m_HoursSurvived;

	public VoicePersona m_Persona;

	public float m_Condition;

	public string m_UserDefinedName;

	public float m_WorldExplored;

	public ExperienceModeType m_XPMode;

	public GameModeConfig m_GameModeConfig;

	public string m_LocationOverride;

	public string m_SandboxManagerSerialized;

	public string m_StoryManagerSerialized;

	public bool m_Corrupt;

	public string m_ActiveMissionLocId;

	public string m_ActiveMissionId;

	public bool m_EpisodeCompleted;

	public float m_EpisodeProgress;

	public ScreenshotSaveGameFormat m_ScreenshotData;

	public int m_SaveChangelistVersion;

	public string m_SceneManagerSerialized;

	public readonly List<string> m_InstalledOptionalContent;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsMissingOptionalContent")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsLoadable")]
	public bool ShowInLoadScreen()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool CanBeLoaded()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnLoadSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnLoadSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[CalledBy(Type = typeof(SaveSlotInfo), Member = "ShowInLoadScreen")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AssetHelper), Member = "ValidateKey")]
	private bool IsLoadable()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnLoadSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnLoadSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[CalledBy(Type = typeof(SaveSlotInfo), Member = "ShowInLoadScreen")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "TryFindConfigFromName")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[CallsUnknownMethods(Count = 5)]
	public bool IsMissingOptionalContent(List<string> missingContent = null)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SaveSlotInfo()
	{
	}
}
