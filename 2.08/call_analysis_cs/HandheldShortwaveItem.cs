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

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "IsActive")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 13)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(HandheldShortwaveItem), Member = "Update")]
	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateIntensityNeedle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HandheldShortwaveItem()
	{
	}
}
