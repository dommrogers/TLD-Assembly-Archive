using System;
using System.Collections.Generic;
using System.Linq;
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
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOn")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[CallsUnknownMethods(Count = 1)]
	public void TriggerStage(FireState curState, bool shouldPlay, bool stopOtherStages = false)
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	public void TriggerFlareupLarge()
	{
	}

	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[CallerCount(Count = 0)]
	public void StopAllStageFX()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Fire), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOff")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	public void StopAllFX()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 19)]
	public void DeactivateAllFX()
	{
	}

	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerFlareupLarge")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Start")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Awake")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerFlareupLarge")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "DeactivateAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	private void LocalPrint(string text)
	{
	}

	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsUnknownMethods(Count = 6)]
	private void TriggerParticleSystems(List<ParticleSystem> particleSystems, bool shouldPlay)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public EffectsControllerFire()
	{
	}
}
