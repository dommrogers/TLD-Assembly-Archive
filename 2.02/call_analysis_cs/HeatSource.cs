using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeatSource : MonoBehaviour
{
	public float m_MaxTempIncrease;

	public float m_MaxTempIncreaseInnerRadius;

	public float m_MaxTempIncreaseOuterRadius;

	public float m_TimeToReachMaxTempMinutes;

	public float m_StartingTemp;

	public bool m_StartOn;

	public bool m_MaskTempIncrease;

	private float m_TempIncrease;

	private bool m_TurnedOn;

	private static HeatSourceSaveDataProxy m_HeatSourceSaveDataProxy;

	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	public void Start()
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(HeatSourceManager), Member = "GetTemperatureIncrease")]
	[CalledBy(Type = typeof(HeatSourceManager), Member = "GetBestHeatSourceInRange")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	public float GetTempIncrease(Vector3 pos)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsTurnedOn()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(TorchItem), Member = "Extinguish")]
	[CalledBy(Type = typeof(TorchItem), Member = "DestroyHeatSource")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "DestroyHeatSource")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[CalledBy(Type = typeof(FlareItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(FlareItem), Member = "DestroyHeatSource")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[Calls(Type = typeof(HeatSourceManager), Member = "RemoveHeatSource")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "DestroyHeatSource")]
	public void TurnOffImmediate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCurrentTempIncrease()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(FlareItem), Member = "Ignite")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[CalledBy(Type = typeof(HeatSource), Member = "Deserialize")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOn")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(HeatSource), Member = "Start")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "TurnOnEffects")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 13)]
	public void TurnOn()
	{
	}

	[CallerCount(Count = 0)]
	public void TurnOff()
	{
	}

	[Calls(Type = typeof(HeatSourceManager), Member = "RemoveHeatSource")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HeatSource()
	{
	}
}
