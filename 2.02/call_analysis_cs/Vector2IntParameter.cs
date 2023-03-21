using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Vector2IntParameter : ParameterOverride<Vector2Int>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Vector2IntParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
