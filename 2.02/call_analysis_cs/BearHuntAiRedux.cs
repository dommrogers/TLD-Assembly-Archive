using System.Runtime.CompilerServices;
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
	[CallsDeduplicatedMethods(Count = 2)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Serialize")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetInitialCheckHasMovedDelaySeconds()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public bool CanDespawn(float radius)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	public GameObject GetBearEarPrefab()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool CanTakeBearEar()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public GameObject TakeBearEar()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetPostStruggleBehavior(BearEncounter.PostStruggleBehavior postStruggleBehavior)
	{
	}

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public BearEncounter.PostStruggleBehavior GetPostStruggleBehavior()
	{
		return default(BearEncounter.PostStruggleBehavior);
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "IsDamageFatal")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "GetDamageDealt")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsLastEncounter()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void ForceBearFleePosition(Vector3 position)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ClearForceBearFleePosition()
	{
	}

	[CallerCount(Count = 0)]
	public bool TryGetForcedBearFleePosition(out Vector3 position)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref position) = null;
		return default(bool);
	}

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public void SetBearEarPrefab(GameObject bearEarPrefab)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 41)]
	public void SetCurrentEncounterOwner(BearEncounter bearEncounter)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BearEncounter GetCurrentBearEncounterOwner()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public BearHuntAiRedux()
	{
	}
}
