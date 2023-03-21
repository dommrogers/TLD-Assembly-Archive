using Cpp2ILInjected.CallAnalysis;
using EasyRoads3Dv3;
using UnityEngine;

public class ERVegetationStudio : ScriptableObject
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool VegetationStudio()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void CreateVegetationMaskLine(GameObject go, float grassPerimeter, float plantPerimeter, float treePerimeter, float objectPerimeter, float largeObjectPerimeter)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static void UpdateVegetationMaskLine(GameObject go, ERVSData[] vsData, float grassPerimeter, float plantPerimeter, float treePerimeter, float objectPerimeter, float largeObjectPerimeter)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static void UpdateHeightmap(Bounds bounds)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ERVegetationStudio()
	{
	}
}
