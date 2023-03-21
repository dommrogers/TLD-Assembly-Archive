using System.Runtime.CompilerServices;
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
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetInitialCheckHasMovedDelaySeconds()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public bool CanDespawn(float radius)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool CanTakeBearEar()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "IsDamageFatal")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "GetDamageDealt")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	public bool IsLastEncounter()
	{
		return default(bool);
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
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref position) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 38)]
	public void SetBearEarPrefab(GameObject bearEarPrefab)
	{
	}

	[CallerCount(Count = 60)]
	[DeduplicatedMethod]
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
