using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CraftingRequirementMultiMaterial : MonoBehaviour
{
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public CraftingRequirementMultiMaterial()
	{
	}
}
