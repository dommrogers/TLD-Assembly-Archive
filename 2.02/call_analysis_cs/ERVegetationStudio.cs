using Cpp2ILInjected.CallAnalysis;
using EasyRoads3Dv3;
using UnityEngine;

public class ERVegetationStudio : ScriptableObject
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool VegetationStudio()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void CreateVegetationMaskLine(GameObject go, float grassPerimeter, float plantPerimeter, float treePerimeter, float objectPerimeter, float largeObjectPerimeter)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void UpdateVegetationMaskLine(GameObject go, ERVSData[] vsData, float grassPerimeter, float plantPerimeter, float treePerimeter, float objectPerimeter, float largeObjectPerimeter)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
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
