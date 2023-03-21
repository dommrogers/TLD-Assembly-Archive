using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class ActivatedMaterialProperties : ScriptableObject
{
	public abstract string ActivationKeyword
	{
		[CallerCount(Count = 101261)]
		[DeduplicatedMethod]
		get;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "DisableKeyword")]
	[Calls(Type = typeof(Material), Member = "EnableKeyword")]
	[CalledBy(Type = typeof(ElectrostaticMaterialProperties), Member = "UpdateMaterial")]
	public virtual void UpdateMaterial(Material mat, bool isActive)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	protected ActivatedMaterialProperties()
	{
	}
}
