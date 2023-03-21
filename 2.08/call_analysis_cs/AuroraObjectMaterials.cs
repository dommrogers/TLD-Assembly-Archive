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
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnableAuroraMaterials")]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleAuroraMaterials")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetAuroraMaterialsOnFlee")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SwitchToNormalMaterials()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnableAuroraMaterials")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetAuroraMaterialsOnFlee")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SwitchToAuroraMaterials()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AuroraObjectMaterials()
	{
	}
}
