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
	[CallsUnknownMethods(Count = 5)]
	public float SelectCps(float t, bool isLooping)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CatmullRomSpline), Member = "Evaluate")]
	[CalledBy(Type = typeof(CatmullRomSpline), Member = "EvaluateWithTangent")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private Vector3 CalcPoint(float t)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(CatmullRomSpline), Member = "EvaluateTangent")]
	[CalledBy(Type = typeof(CatmullRomSpline), Member = "EvaluateWithTangent")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private Vector3 CalcTangent(float t)
	{
		return default(Vector3);
	}
}
