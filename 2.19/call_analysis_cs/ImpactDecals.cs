using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ImpactDecals : ScriptableObject
{
	public List<ProjectileImpactDecal> m_ProjectileImpactDecals;

	[CalledBy(Type = typeof(ImpactDecals), Member = "AddSprayPaintDecal")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddSprayPaintDecal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 6)]
	private ImpactDecal GetImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	public static MaterialEffectType MapSurfaceTagToMaterialEffectType(string tag)
	{
		return default(MaterialEffectType);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ImpactDecals), Member = "GetImpactDecal")]
	[Calls(Type = typeof(ImpactDecal), Member = "GetImpactDecalVariationName")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CallsUnknownMethods(Count = 3)]
	public DecalProjectorInstance AddSprayPaintDecal(ProjectileType shape, MaterialEffectType materialEffectType, Vector3 postion, Vector3 forward)
	{
		return null;
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ImpactDecals), Member = "GetImpactDecal")]
	[Calls(Type = typeof(ImpactDecal), Member = "GetImpactDecalVariationName")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "LookupUVRectangleIndex")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CallsUnknownMethods(Count = 6)]
	public DecalProjectorInstance AddImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, DecalProjectorType projectorType, Vector3 postion, Vector3 forward, float yaw)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ImpactDecals()
	{
	}
}
