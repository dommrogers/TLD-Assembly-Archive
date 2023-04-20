using System;
using Cpp2ILInjected.CallAnalysis;

public class vp_FractalNoise
{
	private vp_Perlin m_Noise;

	private float[] m_Exponent;

	private int m_IntOctaves;

	private float m_Octaves;

	private float m_Lacunarity;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FractalNoise), Member = ".ctor")]
	public vp_FractalNoise(float inH, float inLacunarity, float inOctaves)
	{
	}

	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[CalledBy(Type = typeof(vp_FractalNoise), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Pow")]
	[Calls(Type = typeof(vp_Perlin), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public vp_FractalNoise(float inH, float inLacunarity, float inOctaves, vp_Perlin noise)
	{
	}

	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3Slow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetSlow")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(vp_Perlin), Member = "Noise")]
	[CallsUnknownMethods(Count = 2)]
	public float HybridMultifractal(float x, float y, float offset)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Perlin), Member = "Noise")]
	[CallsUnknownMethods(Count = 2)]
	public float RidgedMultifractal(float x, float y, float offset, float gain)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Perlin), Member = "Noise")]
	[CallsUnknownMethods(Count = 2)]
	public float BrownianMotion(float x, float y)
	{
		return 0f;
	}
}
