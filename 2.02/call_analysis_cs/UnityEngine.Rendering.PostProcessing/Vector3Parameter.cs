using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Vector3Parameter : ParameterOverride<Vector3>
{
	[CallerCount(Count = 0)]
	public override void Interp(Vector3 from, Vector3 to, float t)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator Vector2(Vector3Parameter prop)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator Vector4(Vector3Parameter prop)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool Equals(Vector3 a, Vector3 b)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Vector3Parameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
