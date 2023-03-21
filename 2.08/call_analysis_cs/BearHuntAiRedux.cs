using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class BearHuntAiRedux : MonoBehaviour
{
	public delegate void OnBearSpearOutcomeAction(bool success);

	private bool m_BearEarGiven;

	private static BearHuntAiReduxSaveData m_BearHuntAiReduxSaveData;

	private float m_InitialCheckHasMovedDelaySeconds;

	private BaseAi m_BearBaseAi;

	public bool m_UseForceBearFleePosition;

	private Vector3 m_ForceBearFleePosition;

	public GameObject m_BearEarPrefab;

	private BearEncounter m_CurrentBearEncounter;

	private BearEncounter.PostStruggleBehavior m_PostStruggleBehavior;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Serialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetInitialCheckHasMovedDelaySeconds()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public bool CanDespawn(float radius)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool CanTakeBearEar()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public GearItem TakeBearEar()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetPostStruggleBehavior(BearEncounter.PostStruggleBehavior postStruggleBehavior)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	public BearEncounter.PostStruggleBehavior GetPostStruggleBehavior()
	{
		return default(BearEncounter.PostStruggleBehavior);
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "GetDamageDealt")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "IsDamageFatal")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLastEncounter()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void ForceBearFleePosition(Vector3 position)
	{
	}

	[CallerCount(Count = 0)]
	public void ClearForceBearFleePosition()
	{
	}

	[CallerCount(Count = 0)]
	public bool TryGetForcedBearFleePosition(out Vector3 position)
	{
		position = default(Vector3);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 43)]
	public void SetBearEarPrefab(GameObject bearEarPrefab)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 69)]
	public void SetCurrentEncounterOwner(BearEncounter bearEncounter)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public BearEncounter GetCurrentBearEncounterOwner()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public BearHuntAiRedux()
	{
	}
}
