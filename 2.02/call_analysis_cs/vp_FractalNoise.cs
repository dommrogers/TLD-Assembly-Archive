using Cpp2ILInjected.CallAnalysis;

public class vp_FractalNoise
{
	private vp_Perlin m_Noise;

	private float[] m_Exponent;

	private int m_IntOctaves;

	private float m_Octaves;

	private float m_Lacunarity;

	[Calls(Type = typeof(vp_FractalNoise), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public vp_FractalNoise(float inH, float inLacunarity, float inOctaves)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Perlin), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "Get")]
	[CalledBy(Type = typeof(vp_FractalNoise), Member = ".ctor")]
	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 2)]
	public vp_FractalNoise(float inH, float inLacunarity, float inOctaves, vp_Perlin noise)
	{
	}

	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3Slow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3Slow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3CenteredSlow")]
	[CalledBy(Type = typeof(vp_SmoothRandom), Member = "GetVector3Slow")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(vp_Perlin), Member = "Noise")]
	[Calls(Type = typeof(vp_Perlin), Member = "Noise")]
	[Calls(Type = typeof(vp_Perlin), Member = "Noise")]
	public float HybridMultifractal(float x, float y, float offset)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Perlin), Member = "Noise")]
	[Calls(Type = typeof(vp_Perlin), Member = "Noise")]
	public float RidgedMultifractal(float x, float y, float offset, float gain)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(vp_Perlin), Member = "Noise")]
	[Calls(Type = typeof(vp_Perlin), Member = "Noise")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float BrownianMotion(float x, float y)
	{
		return default(float);
	}
}
