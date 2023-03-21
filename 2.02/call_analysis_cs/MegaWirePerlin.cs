using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MegaWirePerlin
{
	private static MegaWirePerlin instance;

	private static int[] p;

	private static int[] permutation;

	public static MegaWirePerlin Instance
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(MegaWirePerlin), Member = ".ctor")]
		[CalledBy(Type = typeof(MegaWireWind), Member = ".ctor")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(MegaWirePerlin), Member = "get_Instance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public MegaWirePerlin()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public int Perm(int i)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MegaWirePerlin), Member = "fBm1")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MegaWirePerlin), Member = "fBm1")]
	public float Noise(float x)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	public float Noise(float x, float y)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(MegaWireWind), Member = "Update")]
	[CallsUnknownMethods(Count = 45)]
	[CalledBy(Type = typeof(MegaWireWind), Member = "Update")]
	[CalledBy(Type = typeof(MegaWireWind), Member = "Update")]
	[CalledBy(Type = typeof(MegaWireWind), Member = "Update")]
	[CalledBy(Type = typeof(MegaWireWind), Member = "RTurbulence")]
	[CalledBy(Type = typeof(MegaWirePerlin), Member = "fBm1")]
	[CalledBy(Type = typeof(MegaWirePerlin), Member = "fBm1")]
	[CalledBy(Type = typeof(MegaWirePerlin), Member = "fBm1")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(MegaWirePerlin), Member = "fBm1")]
	public float Noise(float x, float y, float z)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float fade(float t)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float lerp(float t, float a, float b)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private static float grad(int hash, float x)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float grad(int hash, float x, float y)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float grad(int hash, float x, float y, float z)
	{
		return default(float);
	}

	[Calls(Type = typeof(MegaWirePerlin), Member = "Noise")]
	[Calls(Type = typeof(MegaWirePerlin), Member = "Noise")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float fBm1(float x, float H, float lacunarity, float octaves)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MegaWirePerlin), Member = "Noise")]
	[Calls(Type = typeof(MegaWirePerlin), Member = "Noise")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float fBm1(Vector3 vertex, float H, float lacunarity, float octaves)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MegaWirePerlin), Member = "Noise")]
	[Calls(Type = typeof(MegaWirePerlin), Member = "Noise")]
	[CallsUnknownMethods(Count = 2)]
	public float fBm1(float x, float y, float z, float H, float lacunarity, float octaves)
	{
		return default(float);
	}
}
