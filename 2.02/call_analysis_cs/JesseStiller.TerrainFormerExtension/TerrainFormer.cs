using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace JesseStiller.TerrainFormerExtension;

public class TerrainFormer : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TerrainFormer()
	{
	}
}
