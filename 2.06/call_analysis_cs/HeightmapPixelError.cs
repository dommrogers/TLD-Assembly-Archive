using System;
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
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public float GetPixelError(QualityTerrainLod quality)
	{
		return default(float);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	public static float GetDefaultPixelError(QualityTerrainLod quality)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public HeightmapPixelError()
	{
	}
}
