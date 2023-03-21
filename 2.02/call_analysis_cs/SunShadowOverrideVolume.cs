using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SunShadowOverrideVolume : MonoBehaviour
{
	private BoxCollider m_InnerCollider;

	private BoxCollider m_OuterCollider;

	private int m_Priority;

	private float m_ShadowStrength;

	private const string PLAYER_TRIGGER_TAG = "Player";

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public int GetPriority()
	{
		return 0;
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateShadowStrength")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "IsValid")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	public void BlendShadowStrength(ref float sunShadow, ref float moonShadow)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "IsValid")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "RegisterSunShadowOverrideVolume")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UnregisterSunShadowOverrideVolume")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UnregisterSunShadowOverrideVolume")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "BlendShadowStrength")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsValid()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SunShadowOverrideVolume()
	{
	}
}
