using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WaterSource : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public float m_MinStartingLiters;

	public float m_MaxStartingLiters;

	public float m_CapacityLiters;

	public float m_ChanceContaminated;

	public string m_OpenAudio;

	public string m_TakeAudio;

	public float m_SpawnChance;

	public bool m_DestroyPending;

	private float m_CurrentLiters;

	private LiquidQuality m_CurrentLiquidQuality;

	private bool m_RolledSpawnChance;

	private bool m_StartHasBeenCalled;

	private static WaterSourceSaveDataProxy m_WaterSourceSaveDataProxy;

	public string m_DisplayName
	{
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
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
	[CallsDeduplicatedMethods(Count = 1)]
	public float RemoveLiters(float liters)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(WaterSourceManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WaterSourceManager), Member = "Deserialize")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WaterSource()
	{
	}
}
