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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddSprayPaintDecal")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddSprayPaintDecal")]
	[CallsUnknownMethods(Count = 3)]
	public string GetImpactDecalVariationName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public ImpactDecal()
	{
	}
}
