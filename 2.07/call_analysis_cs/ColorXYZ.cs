using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

internal struct ColorXYZ
{
	public float x;

	public float y;

	public float z;

	public float a;

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public ColorXYZ(float _x, float _y, float _z, float _a)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static implicit operator ColorXYZ(Color rgba)
	{
		return default(ColorXYZ);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static implicit operator ColorXYZ(ColorCIELab lab)
	{
		return default(ColorXYZ);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static implicit operator Color(ColorXYZ xyz)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static ColorXYZ FromRGBA(Color rgba)
	{
		return default(ColorXYZ);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static ColorXYZ FromLAB(ColorCIELab lab)
	{
		return default(ColorXYZ);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private static Color ToRGBA(ColorXYZ xyz)
	{
		return default(Color);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 41)]
	[CallerCount(Count = 0)]
	public override string ToString()
	{
		return null;
	}
}
