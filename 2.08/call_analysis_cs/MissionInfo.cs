using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class MissionInfo : MonoBehaviour
{
	public const string Label = "MissionInfo";

	public bool m_IsSideMission;

	public string m_MissionID;

	public string m_NameLocID;

	public string m_DescLocID;

	public string m_TextureName;

	public string m_TimerID;

	public string m_NPC_ID;

	public float m_TrustDecayGracePeriodHours;

	public string m_ChapterLocID;

	public bool m_ShowWhenCompleted;

	public string m_Icon;

	private static AsyncOperationHandle<IList<GameObject>> s_handles;

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "LoadMissionDataFromResources")]
	[CalledBy(Type = typeof(Utils), Member = "MaybePopulateMissionIds")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	public static IList<MissionInfo> GetAllMissionInfos()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "LoadMissionDataFromResources")]
	[CalledBy(Type = typeof(Utils), Member = "MaybePopulateMissionIds")]
	public static void ReleaseAllMissionInfos()
	{
	}

	[CallerCount(Count = 0)]
	public MissionInfo()
	{
	}
}
