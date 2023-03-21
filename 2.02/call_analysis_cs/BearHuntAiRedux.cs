using Cpp2ILInjected.CallAnalysis;
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
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Serialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public bool CanDespawn(float radius)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	public GameObject GetBearEarPrefab()
	{
		return null;
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public GameObject TakeBearEar()
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
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 18)]
	public void SetBearEarPrefab(GameObject bearEarPrefab)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 46)]
	public void SetCurrentEncounterOwner(BearEncounter bearEncounter)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BearEncounter GetCurrentBearEncounterOwner()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public BearHuntAiRedux()
	{
	}
}
