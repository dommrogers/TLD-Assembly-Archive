using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectiveInfo : MonoBehaviour
{
	public string m_ObjectiveID;

	public string m_DescLocID;

	public string m_DescLocUnitsID;

	public string m_HudDescLocId;

	public string m_TimerID;

	public string m_CountCurrentBBName;

	public string m_CountRequiredBBName;

	public MissionObjectiveCountType m_UnitType;

	public bool m_ShowWhenCompleted;

	public bool m_ShowSubobjectivesInSummary;

	public bool m_ShowSmallKicker;

	public bool m_IgnoreInProgressionCalculation;

	public bool m_UseAsFraction;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ObjectiveInfo()
	{
	}
}
