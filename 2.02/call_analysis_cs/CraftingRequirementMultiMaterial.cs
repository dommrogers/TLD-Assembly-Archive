using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CraftingRequirementMultiMaterial : MonoBehaviour
{
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public CraftingRequirementMultiMaterial()
	{
	}
}
