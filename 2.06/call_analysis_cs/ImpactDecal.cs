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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddSprayPaintDecal")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddSprayPaintDecal")]
	public string GetImpactDecalVariationName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public ImpactDecal()
	{
	}
}
