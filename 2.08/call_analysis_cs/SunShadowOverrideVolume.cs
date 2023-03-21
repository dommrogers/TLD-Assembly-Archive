using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SunShadowOverrideVolume : MonoBehaviour
{
	private BoxCollider m_InnerCollider;

	private BoxCollider m_OuterCollider;

	private int m_Priority;

	private float m_ShadowStrength;

	private TODStateData m_TODStateData;

	private const string PLAYER_TRIGGER_TAG = "Player";

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetPriority()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "GetBlendFactor")]
	public void BlendShadowStrength(ref float sunShadow, ref float moonShadow)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "GetBlendFactor")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	public void BlendTODState(TODStateData sourceStateData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "IsValid")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "RegisterSunShadowOverrideVolume")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UnregisterSunShadowOverrideVolume")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UnregisterSunShadowOverrideVolume")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "Start")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "GetBlendFactor")]
	[CallerCount(Count = 2)]
	private bool IsValid()
	{
		return false;
	}

	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "BlendShadowStrength")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "BlendTODState")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateShadowStrength")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "IsValid")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private float GetBlendFactor()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public SunShadowOverrideVolume()
	{
	}
}
