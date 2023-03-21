using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FlareRandomBrightness : MonoBehaviour
{
	public float m_IntervalSeconds;

	public float m_Min;

	public float m_Max;

	private float m_CurrentTime;

	private float m_Destination;

	private float m_FlareBrightnessStart;

	private LensFlare m_LensFlare;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FlareRandomBrightness()
	{
	}
}
