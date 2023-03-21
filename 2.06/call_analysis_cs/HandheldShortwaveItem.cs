using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HandheldShortwaveItem : MonoBehaviour
{
	public enum Range
	{
		OutOfRange,
		Near,
		Mid,
		Far
	}

	public static bool s_ShowDebugInfo;

	public float m_MaximumRange;

	public float m_IntermediateRange;

	public float m_MinimumRange;

	public Range m_NearestRange;

	public float m_NearestDistance;

	public float m_Intensity;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "IsActive")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 15)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateIntensityNeedle")]
	[CalledBy(Type = typeof(HandheldShortwaveItem), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static string GetDebugText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public HandheldShortwaveItem()
	{
	}
}
