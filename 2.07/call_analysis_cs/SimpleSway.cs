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
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSwingMultiplier(float newMultiplier = 1f)
	{
	}

	[CallerCount(Count = 0)]
	public SimpleSway()
	{
	}
}
