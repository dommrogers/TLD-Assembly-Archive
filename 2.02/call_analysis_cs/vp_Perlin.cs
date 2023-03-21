using System.Runtime.CompilerServices;
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
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private float lerp(float t, float a, float b)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private void setup(float value, out int b0, out int b1, out float r0, out float r1)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref b0) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref b1) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref r0) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref r1) = null;
	}

	[CallerCount(Count = 0)]
	private float at2(float rx, float ry, float x, float y)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float at3(float rx, float ry, float rz, float x, float y, float z)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	public float Noise(float arg)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[CalledBy(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[CalledBy(Type = typeof(vp_FractalNoise), Member = "HybridMultifractal")]
	[CalledBy(Type = typeof(vp_FractalNoise), Member = "RidgedMultifractal")]
	[CalledBy(Type = typeof(vp_FractalNoise), Member = "BrownianMotion")]
	[CalledBy(Type = typeof(vp_FractalNoise), Member = "BrownianMotion")]
	[CallsUnknownMethods(Count = 25)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(vp_FractalNoise), Member = "RidgedMultifractal")]
	public float Noise(float x, float y)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 51)]
	[CallerCount(Count = 0)]
	public float Noise(float x, float y, float z)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void normalize2(ref float x, ref float y)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void normalize3(ref float x, ref float y, ref float z)
	{
	}

	[CalledBy(Type = typeof(vp_FractalNoise), Member = ".ctor")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	public vp_Perlin()
	{
	}
}
