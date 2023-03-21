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

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "IsActive")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateIntensityNeedle")]
	[CalledBy(Type = typeof(HandheldShortwaveItem), Member = "Update")]
	public bool IsActive()
	{
		return default(bool);
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

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public HandheldShortwaveItem()
	{
	}
}
