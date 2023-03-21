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
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOn")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CallerCount(Count = 9)]
	public void TriggerStage(FireState curState, bool shouldPlay, bool stopOtherStages = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void TriggerFlareupLarge()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void StopAllFX()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 40)]
	public void DeactivateAllFX()
	{
	}

	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Awake")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Start")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerFlareupLarge")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Enumerable), Member = "ToList")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 10)]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerFlareupLarge")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "DeactivateAllFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CallerCount(Count = 6)]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void LocalPrint(string text)
	{
	}

	[CalledBy(Type = typeof(EffectsControllerFire), Member = "TriggerFlareupLarge")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllStageFX")]
	[CalledBy(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void TriggerParticleSystems(List<ParticleSystem> particleSystems, bool shouldPlay)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public EffectsControllerFire()
	{
	}
}
