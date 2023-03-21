using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MechanicalClock : MonoBehaviour
{
	public GameObject m_HourHand;

	public GameObject m_MinuteHand;

	public GameObject m_Pendulum;

	public GameObject m_Weight1;

	public GameObject m_Weight2;

	public float m_ClockWindTimeDays;

	public float m_PendulumPeriod;

	public float m_PendulumHalfAngle;

	public float m_WeightMoveDistance;

	public bool m_IsActive;

	private float m_CurWindTimeSeconds;

	private float m_TimerPendulum;

	private float m_TimerLerp;

	private Vector3 m_Weight1StartPos;

	private Vector3 m_Weight2StartPos;

	private Vector3 m_Weight1EndPos;

	private Vector3 m_Weight2EndPos;

	private int m_CurDaySeconds;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(MechanicalClock), Member = "UpdateHands")]
	[Calls(Type = typeof(MechanicalClock), Member = "UpdateWeights")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdatePendulum()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(MechanicalClock), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateWeights()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(MechanicalClock), Member = "Update")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallerCount(Count = 1)]
	private void UpdateHands()
	{
	}

	[CallerCount(Count = 0)]
	public MechanicalClock()
	{
	}
}
