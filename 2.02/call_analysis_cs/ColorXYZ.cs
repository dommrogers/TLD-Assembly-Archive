using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

internal struct ColorXYZ
{
	public float x;

	public float y;

	public float z;

	public float a;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ColorXYZ(float _x, float _y, float _z, float _a)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorXYZ), Member = "FromRGBA")]
	public static implicit operator ColorXYZ(Color rgba)
	{
		return default(ColorXYZ);
	}

	[Calls(Type = typeof(ColorXYZ), Member = "FromLAB")]
	[CallerCount(Count = 0)]
	public static implicit operator ColorXYZ(ColorCIELab lab)
	{
		return default(ColorXYZ);
	}

	[Calls(Type = typeof(ColorXYZ), Member = "ToRGBA")]
	[CallerCount(Count = 0)]
	public static implicit operator Color(ColorXYZ xyz)
	{
		return default(Color);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ColorXYZ), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ColorCIELCh), Member = "FromRGBA")]
	[CallsUnknownMethods(Count = 3)]
	private static ColorXYZ FromRGBA(Color rgba)
	{
		return default(ColorXYZ);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ColorXYZ), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ColorCIELCh), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ColorCIELCh), Member = "ToRGBA")]
	[CallsUnknownMethods(Count = 3)]
	private static ColorXYZ FromLAB(ColorCIELab lab)
	{
		return default(ColorXYZ);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ColorCIELCh), Member = "ToRGBA")]
	[CalledBy(Type = typeof(ColorCIELCh), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(ColorXYZ), Member = "op_Implicit")]
	private static Color ToRGBA(ColorXYZ xyz)
	{
		return default(Color);
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
