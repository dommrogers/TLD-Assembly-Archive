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
		return default(int);
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

	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "IsValid")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "RegisterSunShadowOverrideVolume")]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UnregisterSunShadowOverrideVolume")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UnregisterSunShadowOverrideVolume")]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "GetBlendFactor")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "Start")]
	private bool IsValid()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "BlendTODState")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateShadowStrength")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "BlendShadowStrength")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "IsValid")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private float GetBlendFactor()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public SunShadowOverrideVolume()
	{
	}
}
