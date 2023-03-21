using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeightFogVolume : MonoBehaviour
{
	public bool m_IsGlobal;

	public float m_Falloff;

	public HeightFogSettings m_Settings;

	private SphereCollider m_Collider;

	[CalledBy(Type = typeof(HeightFogManager), Member = "Update")]
	[Calls(Type = typeof(SphereCollider), Member = "get_radius")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public float GetBlendAmount()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnValidate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HeightFogVolume()
	{
	}
}
