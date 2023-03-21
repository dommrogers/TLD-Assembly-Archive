using Cpp2ILInjected.CallAnalysis;
using EasyRoads3Dv3;
using UnityEngine;

public class ERVegetationStudio : ScriptableObject
{
	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public static bool VegetationStudio()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public static bool VegetationStudioPro()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CreateVegetationMaskLine(GameObject go, float grassPerimeter, float plantPerimeter, float treePerimeter, float objectPerimeter, float largeObjectPerimeter)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void UpdateVegetationMaskLine(GameObject go, ERVSData[] vsData, float grassPerimeter, float plantPerimeter, float treePerimeter, float objectPerimeter, float largeObjectPerimeter)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void UpdateHeightmap(Bounds bounds)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void RemoveVegetationMaskLine(GameObject go)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CreateBiomeArea(GameObject go, float distance, float blendDistance, float noise)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void UpdateBiomeArea(GameObject go, ERVSData[] vsData, float distance, float blendDistance, float noise)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void RemoveBiomeArea(GameObject go)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ERVegetationStudio()
	{
	}
}
