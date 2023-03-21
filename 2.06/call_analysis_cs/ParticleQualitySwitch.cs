using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ParticleQualitySwitch : MonoBehaviour
{
	public enum FxComponentQuality
	{
		Off,
		Low,
		Medium,
		High
	}

	public GameObject m_ParticleParent;

	public bool m_UseModuleState;

	public FxComponentQuality m_LowCollideQuality;

	public FxComponentQuality m_LowNoiseQuality;

	public bool m_LowDisabled;

	public FxComponentQuality m_MediumCollideQuality;

	public FxComponentQuality m_MediumNoiseQuality;

	public bool m_MediumDisabled;

	public FxComponentQuality m_HighCollideQuality;

	public FxComponentQuality m_HighNoiseQuality;

	public bool m_HighDisabled;

	public FxComponentQuality m_UltraCollideQuality;

	public FxComponentQuality m_UltraNoiseQuality;

	public bool m_UltraDisabled;

	public FxComponentQuality m_ConsoleLowCollideQuality;

	public FxComponentQuality m_ConsoleLowNoiseQuality;

	public bool m_ConsoleLowDisabled;

	public FxComponentQuality m_ConsoleCollideQuality;

	public FxComponentQuality m_ConsoleNoiseQuality;

	public bool m_ConsoleDisabled;

	private QualityLodBias m_CachedQuality;

	private List<ParticleSystem> m_FxList;

	private List<bool> m_FxCollideState;

	private List<bool> m_FxNoiseState;

	private bool m_IsInitialized;

	[Calls(Type = typeof(ParticleQualitySwitch), Member = "Initialize")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleQualitySwitch), Member = "RefreshLocalQuality")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ParticleQualitySwitch), Member = "Start")]
	[CallsUnknownMethods(Count = 25)]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(ParticleQualitySwitch), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ParticleQualitySwitch), Member = "SetLocalQuality")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallerCount(Count = 1)]
	private void RefreshLocalQuality()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(ParticleQualitySwitch), Member = "RefreshLocalQuality")]
	[CallsUnknownMethods(Count = 17)]
	private void SetLocalQuality(ParticleSystem curFX, bool cEnabled, bool nEnabled, bool isDisabled, FxComponentQuality cQual, FxComponentQuality nQual)
	{
	}

	[CallerCount(Count = 0)]
	public ParticleQualitySwitch()
	{
	}
}
