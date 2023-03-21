using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Vector4Parameter : ParameterOverride<Vector4>
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void Interp(Vector4 from, Vector4 to, float t)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static implicit operator Vector2(Vector4Parameter prop)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator Vector3(Vector4Parameter prop)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool Equals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGradingSettings), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGradingSettings), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGradingSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(SuffocationScreenEffect), Member = ".ctor")]
	public Vector4Parameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
