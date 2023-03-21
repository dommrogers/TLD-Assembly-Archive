using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Rewired.Demos;

public class CustomControllersTiltDemo : MonoBehaviour
{
	public Transform target;

	public float speed;

	private CustomController controller;

	private Player player;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "add_InputSourceUpdateEvent")]
	[Calls(Type = typeof(Player.ControllerHelper.BnvLPSemkwrCfKYYABiuIneeJhx), Member = "eFsFDEPBoBwkCtkCNRQkVwhlOQ")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallsUnknownMethods(Count = 10)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
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
