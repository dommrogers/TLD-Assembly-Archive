using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Rewired.Demos;

public class PressStartToJoinExample_GamePlayer : MonoBehaviour
{
	public int gamePlayerId;

	public float moveSpeed;

	public float bulletSpeed;

	public GameObject bulletPrefab;

	private CharacterController cc;

	private Vector3 moveVector;

	private bool fire;

	private Player player
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PressStartToJoinExample_Assigner), Member = "GetRewiredPlayer")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PressStartToJoinExample_Assigner), Member = "GetRewiredPlayer")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(PressStartToJoinExample_Assigner), Member = "GetRewiredPlayer")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(PressStartToJoinExample_Assigner), Member = "GetRewiredPlayer")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[CallsUnknownMethods(Count = 1)]
	private void GetInput()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	private void ProcessInput()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PressStartToJoinExample_GamePlayer()
	{
	}
}
