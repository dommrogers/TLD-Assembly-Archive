using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public struct ColorHSV
{
	public float h;

	public float s;

	public float v;

	public float a;

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public ColorHSV(float _h, float _s, float _v, float _a)
	{
	}

	[CallerCount(Count = 0)]
	public ColorHSV(Color rgba)
	{
	}

	[CallerCount(Count = 0)]
	public void MakeCompliment()
	{
	}

	[CallerCount(Count = 0)]
	public void InvertShade()
	{
	}

	[CallerCount(Count = 0)]
	public static implicit operator ColorHSV(Color rgba)
	{
		return default(ColorHSV);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static implicit operator Color(ColorHSV hsv)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	private static ColorHSV FromRGBA(Color rgba)
	{
		return default(ColorHSV);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static Color ToRGBA(ColorHSV hsv)
	{
		return default(Color);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static ColorHSV Lerp(ColorHSV a, ColorHSV b, float blend)
	{
		return default(ColorHSV);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 41)]
	public override string ToString()
	{
		return null;
	}
}
