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
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ReInput), Member = "get_players")]
		[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomControllerDemo_Player), Member = "get_player")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public CustomControllerDemo_Player()
	{
	}
}
