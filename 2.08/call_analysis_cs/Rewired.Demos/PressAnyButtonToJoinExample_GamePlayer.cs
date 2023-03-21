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
		[CalledBy(Type = typeof(PressAnyButtonToJoinExample_GamePlayer), Member = "GetInput")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(PressAnyButtonToJoinExample_GamePlayer), Member = "GetInput")]
		[CalledBy(Type = typeof(PressAnyButtonToJoinExample_GamePlayer), Member = "GetInput")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[CallerCount(Count = 3)]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(PressAnyButtonToJoinExample_GamePlayer), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(PressAnyButtonToJoinExample_GamePlayer), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(PressAnyButtonToJoinExample_GamePlayer), Member = "get_player")]
	[CallerCount(Count = 0)]
	private void GetInput()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	private void ProcessInput()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PressAnyButtonToJoinExample_GamePlayer()
	{
	}
}
