using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace JesseStiller.TerrainFormerExtension;

public class TerrainFormer : MonoBehaviour
{
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
