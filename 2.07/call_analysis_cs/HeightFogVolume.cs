using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeightFogVolume : MonoBehaviour
{
	public bool m_IsGlobal;

	public float m_Falloff;

	public HeightFogSettings m_Settings;

	private SphereCollider m_Collider;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(SphereCollider), Member = "get_radius")]
	[CalledBy(Type = typeof(HeightFogManager), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	public float GetBlendAmount()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HeightFogVolume()
	{
	}
}
