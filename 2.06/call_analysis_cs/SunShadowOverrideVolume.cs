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

	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "GetBlendFactor")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
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
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "Start")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "GetBlendFactor")]
	private bool IsValid()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "BlendTODState")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "UpdateShadowStrength")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "BlendShadowStrength")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SunShadowOverrideVolume), Member = "IsValid")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 7)]
	private float GetBlendFactor()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public SunShadowOverrideVolume()
	{
	}
}
