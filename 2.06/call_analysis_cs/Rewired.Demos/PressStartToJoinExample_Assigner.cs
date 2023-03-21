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

	[CalledBy(Type = typeof(PressStartToJoinExample_GamePlayer), Member = "get_player")]
	[CalledBy(Type = typeof(PressStartToJoinExample_GamePlayer), Member = "GetInput")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static Player GetRewiredPlayer(int gamePlayerId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(TypeFullName = "Rewired.Logger", Member = "LogError")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(PressStartToJoinExample_Assigner), Member = "AssignNextPlayer")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(PressStartToJoinExample_Assigner), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetMapsEnabled")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void AssignNextPlayer(int rewiredPlayerId)
	{
	}

	[CallerCount(Count = 0)]
	private int GetNextGamePlayerId()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public PressStartToJoinExample_Assigner()
	{
	}
}
