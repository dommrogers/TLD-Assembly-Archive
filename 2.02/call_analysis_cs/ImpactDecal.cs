using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class ImpactDecal
{
	public MaterialEffectType m_EffectType;

	public List<string> m_ImpactDecalName;

	public Vector3 m_Scale;

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddSprayPaintDecal")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddSprayPaintDecal")]
	public string GetImpactDecalVariationName()
	{
		return null;
	}

	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ImpactDecal()
	{
	}
}
