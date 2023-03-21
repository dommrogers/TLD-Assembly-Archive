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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(MechanicalClock), Member = "UpdatePendulum")]
	[Calls(Type = typeof(MechanicalClock), Member = "UpdateWeights")]
	[Calls(Type = typeof(MechanicalClock), Member = "UpdateHands")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(MechanicalClock), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdatePendulum()
	{
	}

	[CalledBy(Type = typeof(MechanicalClock), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateWeights()
	{
	}

	[CalledBy(Type = typeof(MechanicalClock), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 17)]
	private void UpdateHands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MechanicalClock()
	{
	}
}
