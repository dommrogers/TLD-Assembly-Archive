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
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsUnknownMethods(Count = 4)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOn")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	public void TriggerStage(FireState curState, bool shouldPlay, bool stopOtherStages = false)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	public void TriggerFlareupLarge()
	{
	}

	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	public void StopAllFX()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 19)]
	public void DeactivateAllFX()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerFlareupLarge")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Awake")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Start")]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "DeactivateAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerFlareupLarge")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	private void LocalPrint(string text)
	{
	}

	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void TriggerParticleSystems(List<ParticleSystem> particleSystems, bool shouldPlay)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public EffectsControllerFire()
	{
	}
}
