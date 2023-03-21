using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Vector2IntParameter : ParameterOverride<Vector2Int>
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Vector2IntParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
