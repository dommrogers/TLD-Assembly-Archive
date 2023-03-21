using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EffectsControllerFire : MonoBehaviour
{
	public Transform stage00_Embers;

	public Transform stage01_Small;

	public Transform stage02_Medium;

	public Transform stage03_Large;

	public Transform stage04_Full;

	public Transform accelrant;

	public Transform otherFX;

	public Transform flareupSmallFX;

	public Transform flareupLargeFX;

	public Transform lighting;

	private List<ParticleSystem> l_StartingEmbers;

	private List<ParticleSystem> l_StartingSmall;

	private List<ParticleSystem> l_StartingMedium;

	private List<ParticleSystem> l_StartingLarge;

	private List<ParticleSystem> l_Fullburn;

	private List<ParticleSystem> l_Accelerant;

	private List<ParticleSystem> l_OtherFX;

	private List<ParticleSystem> l_FlareupSmallFX;

	private List<ParticleSystem> l_FlareupLargeFX;

	private List<Light> l_Lighting;

	private bool isInitialized;

	private bool usePrint;

	private Dictionary<ParticleSystem, bool> m_ParticlePlayStates;

	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOn")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CallerCount(Count = 9)]
	[CallAnalysisFailed]
	public void TriggerStage(FireState curState, bool shouldPlay, bool stopOtherStages = false)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void TriggerFlareupLarge()
	{
	}

	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	public void StopAllStageFX()
	{
	}

	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Fire), Member = "TurnOffImmediate")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOff")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	public void StopAllFX()
	{
	}

	[CallsUnknownMethods(Count = 40)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	public void DeactivateAllFX()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerFlareupLarge")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Awake")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Start")]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(EffectsControllerFire), Member = "DeactivateAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerFlareupLarge")]
	private void LocalPrint(string text)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerFlareupLarge")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	private void TriggerParticleSystems(List<ParticleSystem> particleSystems, bool shouldPlay)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public EffectsControllerFire()
	{
	}
}
