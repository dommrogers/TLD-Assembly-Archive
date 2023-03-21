using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

internal struct ColorCIELCh
{
	public float l;

	public float c;

	public float h;

	public float a;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ColorCIELCh(float _l, float _c, float _h, float _a)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorCIELCh), Member = "FromRGBA")]
	public static implicit operator ColorCIELCh(Color rgba)
	{
		return default(ColorCIELCh);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static implicit operator ColorCIELCh(ColorCIELab lab)
	{
		return default(ColorCIELCh);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ColorXYZ), Member = "FromLAB")]
	[Calls(Type = typeof(ColorXYZ), Member = "ToRGBA")]
	[CallsUnknownMethods(Count = 2)]
	public static implicit operator Color(ColorCIELCh lch)
	{
		return default(Color);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ColorXYZ), Member = "FromRGBA")]
	[Calls(Type = typeof(ColorCIELab), Member = "FromXYZ")]
	[CalledBy(Type = typeof(ColorCIELCh), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	private static ColorCIELCh FromRGBA(Color rgba)
	{
		return default(ColorCIELCh);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static ColorCIELCh FromLAB(ColorCIELab lab)
	{
		return default(ColorCIELCh);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ColorXYZ), Member = "FromLAB")]
	[Calls(Type = typeof(ColorXYZ), Member = "ToRGBA")]
	[CallsUnknownMethods(Count = 2)]
	private static Color ToRGBA(ColorCIELCh lch)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public static ColorCIELCh Lerp(ColorCIELCh a, ColorCIELCh b, float blend)
	{
		return default(ColorCIELCh);
	}

	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override string ToString()
	{
		return null;
	}
}
