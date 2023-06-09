using Cpp2ILInjected.CallAnalysis;

internal struct ColorCIELab
{
	public float l;

	public float a;

	public float b;

	public float alpha;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ColorCIELab(float _l, float _a, float _b, float _alpha)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorCIELab), Member = "FromXYZ")]
	public static implicit operator ColorCIELab(ColorXYZ xyz)
	{
		return default(ColorCIELab);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static implicit operator ColorCIELab(ColorCIELCh lch)
	{
		return default(ColorCIELab);
	}

	[CalledBy(Type = typeof(ColorCIELab), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ColorCIELCh), Member = "FromRGBA")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static ColorCIELab FromXYZ(ColorXYZ xyz)
	{
		return default(ColorCIELab);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static ColorCIELab FromCIELCh(ColorCIELCh lch)
	{
		return default(ColorCIELab);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 37)]
	public override string ToString()
	{
		return null;
	}
}
