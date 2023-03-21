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

	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(MechanicalClock), Member = "UpdateWeights")]
	[Calls(Type = typeof(MechanicalClock), Member = "UpdateHands")]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdatePendulum()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(MechanicalClock), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void UpdateWeights()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CalledBy(Type = typeof(MechanicalClock), Member = "Update")]
	private void UpdateHands()
	{
	}

	[CallerCount(Count = 0)]
	public MechanicalClock()
	{
	}
}
