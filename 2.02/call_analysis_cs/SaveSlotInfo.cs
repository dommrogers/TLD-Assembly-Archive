using System;
using Cpp2ILInjected.CallAnalysis;

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

	public string m_LocationOverride;

	public string m_SandboxManagerSerialized;

	public string m_StoryManagerSerialized;

	public bool m_Incompatible;

	public bool m_Corrupt;

	public string m_ActiveMissionLocId;

	public string m_ActiveMissionId;

	public bool m_EpisodeCompleted;

	public float m_EpisodeProgress;

	public ScreenshotSaveGameFormat m_ScreenshotData;

	public int m_SaveChangelistVersion;

	public string m_SceneManagerSerialized;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public SaveSlotInfo()
	{
	}
}
