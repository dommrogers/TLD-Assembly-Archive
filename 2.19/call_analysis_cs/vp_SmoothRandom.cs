using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class vp_SmoothRandom
{
	private static vp_FractalNoise s_Noise;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[Calls(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[CallsUnknownMethods(Count = 1)]
	public static Vector3 GetVector3Slow(float time, float speed)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateShakes")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateEarthQuake")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[Calls(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[CallsUnknownMethods(Count = 1)]
	public static Vector3 GetVector3CenteredSlow(float time, float speed)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[Calls(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetSlow(float time, float speed)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3Slow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetSlow")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(vp_FractalNoise), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	private static vp_FractalNoise Get()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public vp_SmoothRandom()
	{
	}
}
