using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SceneTransitionData
{
	public bool m_TeleportPlayerSaveGamePosition;

	public string m_SpawnPointName;

	public string m_SpawnPointAudio;

	public string m_ForceSceneOnNextNavMapLoad;

	public string m_ForceNextSceneLoadTriggerScene;

	public Vector3 m_PosBeforeInteriorLoad;

	public string m_SceneSaveFilenameCurrent;

	public string m_SceneSaveFilenameNextLoad;

	public string m_SceneLocationLocIDToShow;

	public int m_GameRandomSeed;

	public string m_Location;

	public string m_LastOutdoorScene;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public SceneTransitionData()
	{
	}
}
