using Cpp2ILInjected.CallAnalysis;

internal struct ColorCIELab
{
	public float l;

	public float a;

	public float b;

	public float alpha;

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public ColorCIELab(float _l, float _a, float _b, float _alpha)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static implicit operator ColorCIELab(ColorXYZ xyz)
	{
		return default(ColorCIELab);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static implicit operator ColorCIELab(ColorCIELCh lch)
	{
		return default(ColorCIELab);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static ColorCIELab FromXYZ(ColorXYZ xyz)
	{
		return default(ColorCIELab);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ColorCIELab FromCIELCh(ColorCIELCh lch)
	{
		return default(ColorCIELab);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 37)]
	public override string ToString()
	{
		return null;
	}
}
