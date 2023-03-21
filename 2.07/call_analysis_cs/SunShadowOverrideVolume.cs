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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "IsValid")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "RegisterSunShadowOverrideVolume")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UnregisterSunShadowOverrideVolume")]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerExit(Collider other)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "UnregisterSunShadowOverrideVolume")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "Start")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "GetBlendFactor")]
	private bool IsValid()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateShadowStrength")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "BlendTODState")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "BlendShadowStrength")]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "IsValid")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
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
