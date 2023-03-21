using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Rewired.Demos;

public class CustomControllersTiltDemo : MonoBehaviour
{
	public Transform target;

	public float speed;

	private CustomController controller;

	private Player player;

	[Calls(Type = typeof(Player.ControllerHelper.BnvLPSemkwrCfKYYABiuIneeJhx), Member = "eFsFDEPBoBwkCtkCNRQkVwhlOQ")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "add_InputSourceUpdateEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CustomController), Member = "SetAxisValue")]
	[Calls(Type = typeof(CustomController), Member = "SetAxisValue")]
	[Calls(Type = typeof(CustomController), Member = "SetAxisValue")]
	[CallsUnknownMethods(Count = 2)]
	private void OnInputUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CustomControllersTiltDemo()
	{
	}
}
