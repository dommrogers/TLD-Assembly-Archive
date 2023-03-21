using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class ActivatedMaterialProperties : ScriptableObject
{
	public abstract string ActivationKeyword { get; }

	[CalledBy(Type = typeof(ElectrostaticMaterialProperties), Member = "UpdateMaterial")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "DisableKeyword")]
	[Calls(Type = typeof(Material), Member = "EnableKeyword")]
	[CallsDeduplicatedMethods(Count = 4)]
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
