using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public struct ColorHSV
{
	public float h;

	public float s;

	public float v;

	public float a;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ColorHSV(float _h, float _s, float _v, float _a)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorHSV), Member = "FromRGBA")]
	public ColorHSV(Color rgba)
	{
	}

	[CallerCount(Count = 0)]
	public void MakeCompliment()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void InvertShade()
	{
	}

	[Calls(Type = typeof(ColorHSV), Member = "FromRGBA")]
	[CallerCount(Count = 0)]
	public static implicit operator ColorHSV(Color rgba)
	{
		return default(ColorHSV);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorHSV), Member = "ToRGBA")]
	public static implicit operator Color(ColorHSV hsv)
	{
		return default(Color);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ColorHSV), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorHSV), Member = "op_Implicit")]
	private static ColorHSV FromRGBA(Color rgba)
	{
		return default(ColorHSV);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ColorHSV), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private static Color ToRGBA(ColorHSV hsv)
	{
		return default(Color);
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public static ColorHSV Lerp(ColorHSV a, ColorHSV b, float blend)
	{
		return default(ColorHSV);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 37)]
	public override string ToString()
	{
		return null;
	}
}
