using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CatmullRomSpline
{
	public Vector3[] m_Waypoints;

	private Vector3[] cps;

	private float MaxT
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CatmullRomSpline(Vector3[] waypoints)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CatmullRomSpline), Member = "SelectCps")]
	[Calls(Type = typeof(CatmullRomSpline), Member = "CalcPoint")]
	public Vector3 Evaluate(float t, bool isLooping)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CatmullRomSpline), Member = "SelectCps")]
	[Calls(Type = typeof(CatmullRomSpline), Member = "CalcTangent")]
	public Vector3 EvaluateTangent(float t, bool isLooping)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CatmullRomSpline), Member = "SelectCps")]
	[Calls(Type = typeof(CatmullRomSpline), Member = "CalcTangent")]
	[Calls(Type = typeof(CatmullRomSpline), Member = "CalcPoint")]
	public Vector3 EvaluateWithTangent(float t, bool isLooping, out Vector3 tangent)
	{
		tangent = default(Vector3);
		return default(Vector3);
	}

	[CalledBy(Type = typeof(CatmullRomSpline), Member = "Evaluate")]
	[CalledBy(Type = typeof(CatmullRomSpline), Member = "EvaluateTangent")]
	[CalledBy(Type = typeof(CatmullRomSpline), Member = "EvaluateWithTangent")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 49)]
	public float SelectCps(float t, bool isLooping)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CatmullRomSpline), Member = "Evaluate")]
	[CalledBy(Type = typeof(CatmullRomSpline), Member = "EvaluateWithTangent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private Vector3 CalcPoint(float t)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(CatmullRomSpline), Member = "EvaluateTangent")]
	[CalledBy(Type = typeof(CatmullRomSpline), Member = "EvaluateWithTangent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private Vector3 CalcTangent(float t)
	{
		return default(Vector3);
	}
}
