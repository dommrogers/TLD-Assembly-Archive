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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator Vector3(Vector2Parameter prop)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(RLPRO_SRP_TVEffect_Renderer), Member = "Render")]
	[CalledBy(Type = typeof(RLProUltimateVignetteRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_Warp_Renderer), Member = "Render")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator Vector4(Vector2Parameter prop)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool Equals(Vector2 a, Vector2 b)
	{
		return false;
	}

	[CalledBy(Type = typeof(RLProAnalogTVNoise), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProBottomNoise), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProTVEffect), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProUltimateVignette), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProVHSEffect), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProWarp), Member = ".ctor")]
	[CalledBy(Type = typeof(AutoExposure), Member = ".ctor")]
	[CalledBy(Type = typeof(Vignette), Member = ".ctor")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Vector2Parameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
