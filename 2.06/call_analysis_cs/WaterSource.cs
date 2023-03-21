using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class WaterSource : MonoBehaviour
{
	public float m_MinStartingLiters;

	public float m_MaxStartingLiters;

	public float m_CapacityLiters;

	public float m_ChanceContaminated;

	public string m_OpenAudio;

	public string m_TakeAudio;

	public float m_SpawnChance;

	private PanelReference<Panel_PickWater> m_PickWater;

	private float m_CurrentLiters;

	private LiquidQuality m_CurrentLiquidQuality;

	private bool m_RolledSpawnChance;

	private bool m_StartHasBeenCalled;

	private static WaterSourceSaveDataProxy m_WaterSourceSaveDataProxy;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	private void Start()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetVolumeLiters()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LiquidQuality GetQuality()
	{
		return default(LiquidQuality);
	}

	[CallerCount(Count = 0)]
	public float RemoveLiters(float liters)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_PickWater), Member = "SetWaterSourceForTaking")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(WaterSourceManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(WaterSourceManager), Member = "Deserialize")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallerCount(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public WaterSource()
	{
	}
}
