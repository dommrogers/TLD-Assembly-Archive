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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Rope()
	{
	}
}
