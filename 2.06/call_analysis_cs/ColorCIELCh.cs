using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

internal struct ColorCIELCh
{
	public float l;

	public float c;

	public float h;

	public float a;

	[DeduplicatedMethod]
	[CallerCount(Count = 19)]
	public ColorCIELCh(float _l, float _c, float _h, float _a)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorCIELCh), Member = "FromRGBA")]
	public static implicit operator ColorCIELCh(Color rgba)
	{
		return default(ColorCIELCh);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static implicit operator ColorCIELCh(ColorCIELab lab)
	{
		return default(ColorCIELCh);
	}

	[Calls(Type = typeof(ColorCIELCh), Member = "ToRGBA")]
	[CallerCount(Count = 0)]
	public static implicit operator Color(ColorCIELCh lch)
	{
		return default(Color);
	}

	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ColorCIELCh), Member = "op_Implicit")]
	private static ColorCIELCh FromRGBA(Color rgba)
	{
		return default(ColorCIELCh);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private static ColorCIELCh FromLAB(ColorCIELab lab)
	{
		return default(ColorCIELCh);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ColorCIELCh), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	private static Color ToRGBA(ColorCIELCh lch)
	{
		return default(Color);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static ColorCIELCh Lerp(ColorCIELCh a, ColorCIELCh b, float blend)
	{
		return default(ColorCIELCh);
	}

	[CallsUnknownMethods(Count = 41)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public override string ToString()
	{
		return null;
	}
}
