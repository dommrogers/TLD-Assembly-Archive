using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Vector2Parameter : ParameterOverride<Vector2>
{
	[CallerCount(Count = 0)]
	public override void Interp(Vector2 from, Vector2 to, float t)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator Vector3(Vector2Parameter prop)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator Vector4(Vector2Parameter prop)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 0)]
	public override bool Equals(Vector2 a, Vector2 b)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Vector2Parameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
