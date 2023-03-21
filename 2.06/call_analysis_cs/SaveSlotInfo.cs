using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
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

	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsLoadable()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SaveSlotInfo()
	{
	}
}
