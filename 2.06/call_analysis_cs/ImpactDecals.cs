using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ImpactDecals : ScriptableObject
{
	public List<ProjectileImpactDecal> m_ProjectileImpactDecals;

	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddSprayPaintDecal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddSprayPaintDecal")]
	private ImpactDecal GetImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(ArrowItem), Member = "OnCollisionStay")]
	public static MaterialEffectType MapArrowImpactEffectTypeToMaterialEffectType(ArrowImpactEffectType et)
	{
		return default(MaterialEffectType);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static MaterialEffectType MapBulletImpactEffectTypeToMaterialEffectType(BulletImpactEffectType et)
	{
		return default(MaterialEffectType);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static MaterialEffectType MapScorchImpactEffectTypeToMaterialEffectType(ScorchImpactEffectType et)
	{
		return default(MaterialEffectType);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static MaterialEffectType MapHeavyFootstepEffectTypeToMaterialEffectType(HeavyFootstepEffectType et)
	{
		return default(MaterialEffectType);
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	public static MaterialEffectType MapSurfaceTagToMaterialEffectType(string tag)
	{
		return default(MaterialEffectType);
	}

	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(ImpactDecals), Member = "GetImpactDecal")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ImpactDecal), Member = "GetImpactDecalVariationName")]
	public DecalProjectorInstance AddSprayPaintDecal(ProjectileType shape, MaterialEffectType materialEffectType, Vector3 postion, Vector3 forward)
	{
		return null;
	}

	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ImpactDecals), Member = "GetImpactDecal")]
	[Calls(Type = typeof(ImpactDecal), Member = "GetImpactDecalVariationName")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "LookupUVRectangleIndex")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[CallsUnknownMethods(Count = 6)]
	public DecalProjectorInstance AddImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, DecalProjectorType projectorType, Vector3 postion, Vector3 forward, float yaw)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	public ImpactDecals()
	{
	}
}
