using System;
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Rope()
	{
	}
}
