using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class IconAttribute : Attribute
{
	public readonly string iconName;

	public readonly bool fixedColor;

	public readonly string runtimeIconTypeCallback;

	public readonly Type fromType;

	[CallerCount(Count = 0)]
	public IconAttribute(string iconName = "", bool fixedColor = false, string runtimeIconTypeCallback = "")
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 20)]
	public IconAttribute(Type fromType)
	{
	}
}
