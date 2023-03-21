using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraObjectMaterials : MonoBehaviour
{
	private enum TypeMaterialActive
	{
		None,
		TypeMaterialAurora,
		TypeMaterialNormal
	}

	public List<AuroraObjectMaterialInfo> m_AuroraObjectMaterialInfoList;

	private TypeMaterialActive m_TypeMaterialActive;

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetAuroraMaterialsOnFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleAuroraMaterials")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnableAuroraMaterials")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void SwitchToNormalMaterials()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnableAuroraMaterials")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetAuroraMaterialsOnFlee")]
	[CallsUnknownMethods(Count = 5)]
	public void SwitchToAuroraMaterials()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AuroraObjectMaterials()
	{
	}
}
