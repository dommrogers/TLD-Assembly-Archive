using Cpp2ILInjected.CallAnalysis;
using SuperSplines;
using UnityEngine;

public class Rope : MonoBehaviour
{
	public Spline m_Spline;

	public float m_UnusedLengthAtTop;

	public float m_UnusedLengthAtBottom;

	public float m_TopDistanceToEdge;

	public float m_BreakRopeThreshold;

	public float m_BreakRopePlayerDamagePercent;

	public float m_DeployDurationMinutes;

	public float m_RetreiveDurationMinutes;

	private float m_SplineParameter;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Rope()
	{
	}
}
