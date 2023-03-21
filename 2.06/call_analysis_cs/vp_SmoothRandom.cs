using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class vp_SmoothRandom
{
	private static vp_FractalNoise s_Noise;

	[Calls(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[Calls(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[CallsUnknownMethods(Count = 1)]
	public static Vector3 GetVector3Slow(float time, float speed)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[Calls(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[Calls(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[Calls(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[Calls(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateShakes")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateEarthQuake")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
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
		return default(float);
	}

	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetSlow")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3Slow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3Slow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3Slow")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(vp_FractalNoise), Member = ".ctor")]
	private static vp_FractalNoise Get()
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public vp_SmoothRandom()
	{
	}
}
