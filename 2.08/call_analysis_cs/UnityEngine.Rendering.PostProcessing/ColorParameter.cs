using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class ColorParameter : ParameterOverride<Color>
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void Interp(Color from, Color to, float t)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator Vector4(ColorParameter prop)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 0)]
	public override bool Equals(Color a, Color b)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ColorParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
