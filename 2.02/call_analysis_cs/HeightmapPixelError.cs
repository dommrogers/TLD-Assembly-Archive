using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeightmapPixelError : MonoBehaviour
{
	public static float DEFAULT_HEIGHTMAP_PIXEL_ERROR_ULTRA;

	public static float DEFAULT_HEIGHTMAP_PIXEL_ERROR_HIGH;

	public static float DEFAULT_HEIGHTMAP_PIXEL_ERROR_MEDIUM;

	public static float DEFAULT_HEIGHTMAP_PIXEL_ERROR_LOW;

	public float m_Ultra;

	public float m_High;

	public float m_Medium;

	public float m_Low;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	public float GetPixelError(QualityTerrainLod quality)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "GetHeightmapPixelError")]
	public static float GetDefaultPixelError(QualityTerrainLod quality)
	{
		return default(float);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public HeightmapPixelError()
	{
	}
}
