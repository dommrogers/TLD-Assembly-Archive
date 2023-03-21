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

	[CalledBy(Type = typeof(ImpactDecals), Member = "AddSprayPaintDecal")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddSprayPaintDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
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
