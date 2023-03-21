using System;
using Cpp2ILInjected.CallAnalysis;

public class vp_Perlin
{
	private const int B = 256;

	private const int BM = 255;

	private const int N = 4096;

	private int[] p;

	private float[,] g3;

	private float[,] g2;

	private float[] g1;

	[CallerCount(Count = 0)]
	private float s_curve(float t)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float lerp(float t, float a, float b)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private void setup(float value, out int b0, out int b1, out float r0, out float r1)
	{
		b0 = default(int);
		b1 = default(int);
		r0 = default(float);
		r1 = default(float);
	}

	[CallerCount(Count = 0)]
	private float at2(float rx, float ry, float x, float y)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float at3(float rx, float ry, float rz, float x, float y, float z)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	public float Noise(float arg)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[CalledBy(Type = typeof(vp_FractalNoise), Member = "RidgedMultifractal")]
	[CalledBy(Type = typeof(vp_FractalNoise), Member = "BrownianMotion")]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 25)]
	public float Noise(float x, float y)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 51)]
	public float Noise(float x, float y, float z)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_Perlin), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void normalize2(ref float x, ref float y)
	{
	}

	[CalledBy(Type = typeof(vp_Perlin), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void normalize3(ref float x, ref float y, ref float z)
	{
	}

	[CalledBy(Type = typeof(vp_FractalNoise), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Random), Member = ".ctor")]
	[Calls(Type = typeof(vp_Perlin), Member = "normalize2")]
	[Calls(Type = typeof(vp_Perlin), Member = "normalize3")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 60)]
	public vp_Perlin()
	{
	}
}
