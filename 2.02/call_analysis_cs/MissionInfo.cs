using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionInfo : MonoBehaviour
{
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public MissionInfo()
	{
	}
}
