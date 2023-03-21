using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Rewired.Demos;

public class EightPlayersExample_Player : MonoBehaviour
{
	public int playerId;

	public float moveSpeed;

	public float bulletSpeed;

	public GameObject bulletPrefab;

	private Player player;

	private CharacterController cc;

	private Vector3 moveVector;

	private bool fire;

	[NonSerialized]
	private bool initialized;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[CallsUnknownMethods(Count = 1)]
	private void Initialize()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[CallsUnknownMethods(Count = 1)]
	private void GetInput()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsUnknownMethods(Count = 11)]
	private void ProcessInput()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public EightPlayersExample_Player()
	{
	}
}
