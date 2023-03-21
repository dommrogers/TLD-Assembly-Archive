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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public void Awake()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CallsUnknownMethods(Count = 4)]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetAuroraMaterialsOnFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnableAuroraMaterials")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleAuroraMaterials")]
	public void SwitchToNormalMaterials()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnableAuroraMaterials")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetAuroraMaterialsOnFlee")]
	[CallsUnknownMethods(Count = 4)]
	public void SwitchToAuroraMaterials()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AuroraObjectMaterials()
	{
	}
}
