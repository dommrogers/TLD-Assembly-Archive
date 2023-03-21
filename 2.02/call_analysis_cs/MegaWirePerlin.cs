using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MegaWirePerlin
{
	private static MegaWirePerlin instance;

	private static int[] p;

	private static int[] permutation;

	public static MegaWirePerlin Instance
	{
		[CalledBy(Type = typeof(MegaWireWind), Member = ".ctor")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MegaWirePerlin), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(MegaWirePerlin), Member = "get_Instance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public MegaWirePerlin()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public int Perm(int i)
	{
		return 0;
	}

	[CalledBy(Type = typeof(MegaWirePerlin), Member = "fBm1")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public float Noise(float x)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	public float Noise(float x, float y)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(MegaWirePerlin), Member = "fBm1")]
	[CalledBy(Type = typeof(MegaWirePerlin), Member = "fBm1")]
	[CalledBy(Type = typeof(MegaWireWind), Member = "RTurbulence")]
	[CalledBy(Type = typeof(MegaWireWind), Member = "Update")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 45)]
	public float Noise(float x, float y, float z)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float fade(float t)
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
	private static float grad(int hash, float x)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float grad(int hash, float x, float y)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float grad(int hash, float x, float y, float z)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MegaWirePerlin), Member = "Noise")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float fBm1(float x, float H, float lacunarity, float octaves)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MegaWirePerlin), Member = "Noise")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float fBm1(Vector3 vertex, float H, float lacunarity, float octaves)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MegaWirePerlin), Member = "Noise")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float fBm1(float x, float y, float z, float H, float lacunarity, float octaves)
	{
		return 0f;
	}
}
