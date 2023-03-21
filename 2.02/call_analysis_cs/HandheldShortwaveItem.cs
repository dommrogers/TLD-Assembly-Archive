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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "IsActive")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 13)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(HandheldShortwaveItem), Member = "Update")]
	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateIntensityNeedle")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HandheldShortwaveItem()
	{
	}
}
