using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Rewired.Demos;

public class PressAnyButtonToJoinExample_GamePlayer : MonoBehaviour
{
	public int playerId;

	public float moveSpeed;

	public float bulletSpeed;

	public GameObject bulletPrefab;

	private CharacterController cc;

	private Vector3 moveVector;

	private bool fire;

	private Player player
	{
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[CalledBy(Type = typeof(PressAnyButtonToJoinExample_GamePlayer), Member = "GetInput")]
		[CalledBy(Type = typeof(PressAnyButtonToJoinExample_GamePlayer), Member = "GetInput")]
		[CalledBy(Type = typeof(PressAnyButtonToJoinExample_GamePlayer), Member = "GetInput")]
		[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(PressAnyButtonToJoinExample_GamePlayer), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(PressAnyButtonToJoinExample_GamePlayer), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(PressAnyButtonToJoinExample_GamePlayer), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[CallsUnknownMethods(Count = 1)]
	private void GetInput()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	private void ProcessInput()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PressAnyButtonToJoinExample_GamePlayer()
	{
	}
}
