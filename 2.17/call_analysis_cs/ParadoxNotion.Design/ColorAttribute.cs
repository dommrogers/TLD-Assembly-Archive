using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class ColorAttribute : Attribute
{
	public readonly string hexColor;

	[DeduplicatedMethod]
	[CallerCount(Count = 283)]
	public ColorAttribute(string hexColor)
	{
	}
}
