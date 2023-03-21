using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SunShadowOverrideVolume : MonoBehaviour
{
	private BoxCollider m_InnerCollider;

	private BoxCollider m_OuterCollider;

	private int m_Priority;

	private float m_ShadowStrength;

	private const string PLAYER_TRIGGER_TAG = "Player";

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetPriority()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "IsValid")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateShadowStrength")]
	[CallsUnknownMethods(Count = 13)]
	public void BlendShadowStrength(ref float sunShadow, ref float moonShadow)
	{
	}

	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "IsValid")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "RegisterSunShadowOverrideVolume")]
	[CallsUnknownMethods(Count = 5)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UnregisterSunShadowOverrideVolume")]
	[CallsUnknownMethods(Count = 5)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UnregisterSunShadowOverrideVolume")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "BlendShadowStrength")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "Start")]
	private bool IsValid()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SunShadowOverrideVolume()
	{
	}
}
