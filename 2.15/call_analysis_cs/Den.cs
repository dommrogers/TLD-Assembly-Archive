using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Den : MonoBehaviour
{
	public float m_MinSleepHoursDay;

	public float m_MaxSleepHoursDay;

	public float m_MinSleepHoursNight;

	public float m_MaxSleepHoursNight;

	public float m_ChanceSleepAfterWaypointsLoopDay;

	public float m_ChanceSleepAfterWaypointsLoopNight;

	[CallerCount(Count = 0)]
	public Den()
	{
	}
}
