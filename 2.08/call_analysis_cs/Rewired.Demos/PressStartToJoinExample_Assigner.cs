using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Rewired.Demos;

public class PressStartToJoinExample_Assigner : MonoBehaviour
{
	private class PlayerMap
	{
		public int rewiredPlayerId;

		public int gamePlayerId;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public PlayerMap(int rewiredPlayerId, int gamePlayerId)
		{
		}
	}

	private static PressStartToJoinExample_Assigner instance;

	public int maxPlayers;

	private List<PlayerMap> playerMap;

	private int gamePlayerIdCounter;

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PressStartToJoinExample_GamePlayer), Member = "get_player")]
	[CalledBy(Type = typeof(PressStartToJoinExample_GamePlayer), Member = "GetInput")]
	[CalledBy(Type = typeof(PressStartToJoinExample_GamePlayer), Member = "GetInput")]
	[CalledBy(Type = typeof(PressStartToJoinExample_GamePlayer), Member = "GetInput")]
	[CallsUnknownMethods(Count = 2)]
	public static Player GetRewiredPlayer(int gamePlayerId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PressStartToJoinExample_Assigner), Member = "AssignNextPlayer")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PressStartToJoinExample_Assigner), Member = "Update")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetMapsEnabled")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetMapsEnabled")]
	private void AssignNextPlayer(int rewiredPlayerId)
	{
	}

	[CallerCount(Count = 0)]
	private int GetNextGamePlayerId()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public PressStartToJoinExample_Assigner()
	{
	}
}
