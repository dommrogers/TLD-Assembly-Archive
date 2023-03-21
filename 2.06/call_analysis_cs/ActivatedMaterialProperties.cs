using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class ActivatedMaterialProperties : ScriptableObject
{
	public abstract string ActivationKeyword
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	[CalledBy(Type = typeof(ElectrostaticMaterialProperties), Member = "UpdateMaterial")]
	[Calls(Type = typeof(Material), Member = "EnableKeyword")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "DisableKeyword")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public virtual void UpdateMaterial(Material mat, bool isActive)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected ActivatedMaterialProperties()
	{
	}
}
