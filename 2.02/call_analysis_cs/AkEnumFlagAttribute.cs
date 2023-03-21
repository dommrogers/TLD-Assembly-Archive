using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkEnumFlagAttribute : PropertyAttribute
{
	public Type Type;

	[DeduplicatedMethod]
	[CallerCount(Count = 77)]
	public AkEnumFlagAttribute(Type type)
	{
	}
}
