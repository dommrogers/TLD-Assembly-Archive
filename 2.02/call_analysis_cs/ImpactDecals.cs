using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ImpactDecals : ScriptableObject
{
	public List<ProjectileImpactDecal> m_ProjectileImpactDecals;

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddSprayPaintDecal")]
	[CalledBy(Type = typeof(ImpactDecals), Member = "AddImpactDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddSprayPaintDecal")]
	[CallsUnknownMethods(Count = 6)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static MaterialEffectType MapSurfaceTagToMaterialEffectType(string tag)
	{
		return default(MaterialEffectType);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(ImpactDecals), Member = "GetImpactDecal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ImpactDecal), Member = "GetImpactDecalVariationName")]
	public DecalProjectorInstance AddSprayPaintDecal(ProjectileType shape, MaterialEffectType materialEffectType, Vector3 postion, Vector3 forward)
	{
		return null;
	}

	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[Calls(Type = typeof(ImpactDecal), Member = "GetImpactDecalVariationName")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "LookupUVRectangleIndex")]
	[Calls(Type = typeof(ImpactDecals), Member = "GetImpactDecal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
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
