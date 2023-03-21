using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Rewired.Demos;

public class CustomControllerDemo_Player : MonoBehaviour
{
	public int playerId;

	public float speed;

	public float bulletSpeed;

	public GameObject bulletPrefab;

	private Player _player;

	private CharacterController cc;

	private Player player
	{
		[CalledBy(Type = typeof(CustomControllerDemo_Player), Member = "Update")]
		[CalledBy(Type = typeof(CustomControllerDemo_Player), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(CustomControllerDemo_Player), Member = "Update")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[CalledBy(Type = typeof(CustomControllerDemo_Player), Member = "Update")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(CustomControllerDemo_Player), Member = "get_player")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(CustomControllerDemo_Player), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(CustomControllerDemo_Player), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(CustomControllerDemo_Player), Member = "get_player")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public CustomControllerDemo_Player()
	{
	}
}
