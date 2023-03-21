using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SimpleSway : MonoBehaviour
{
	public float m_SwayPeriod;

	public float m_SwayHalfAngle;

	public float m_SwayDirection;

	public float m_SwayMultiplier;

	public MinMax m_RandomTimeOffset;

	private float m_SwayRate;

	private float m_SwayTimer;

	private float m_CurDegrees;

	private float m_CurTimeOffset;

	private float m_RadDirection;

	private Vector3 m_Direction;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSwingMultiplier(float newMultiplier = 1f)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SimpleSway()
	{
	}
}
