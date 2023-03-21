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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleAuroraMaterials")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnableAuroraMaterials")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetAuroraMaterialsOnFlee")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	public void SwitchToNormalMaterials()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnableAuroraMaterials")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetAuroraMaterialsOnFlee")]
	[CallsUnknownMethods(Count = 4)]
	public void SwitchToAuroraMaterials()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AuroraObjectMaterials()
	{
	}
}
