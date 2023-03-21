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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
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
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOn")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public void TriggerStage(FireState curState, bool shouldPlay, bool stopOtherStages = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void TriggerFlareupLarge()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	public void StopAllStageFX()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "TurnOff")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOffImmediate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void StopAllFX()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 21)]
	public void DeactivateAllFX()
	{
	}

	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Awake")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Start")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerFlareupLarge")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Enumerable), Member = "ToList")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerFlareupLarge")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "DeactivateAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CallerCount(Count = 16)]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	private void LocalPrint(string text)
	{
	}

	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerFlareupLarge")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
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
