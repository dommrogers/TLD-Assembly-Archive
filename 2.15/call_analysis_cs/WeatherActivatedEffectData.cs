using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;

[Serializable]
public class WeatherActivatedEffectData : ScriptableObject
{
	public WeatherStage m_WeatherStage;

	public AssetReferenceWithComponent<WeatherActivatedEffect> m_EffectAsset;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public WeatherActivatedEffectData()
	{
	}
}
