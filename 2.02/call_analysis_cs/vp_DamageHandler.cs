using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class vp_DamageHandler : MonoBehaviour
{
	public float Health;

	public GameObject DeathEffect;

	public float MinDeathDelay;

	public float MaxDeathDelay;

	protected float m_CurrentHealth;

	public bool Respawns;

	public float MinRespawnTime;

	public float MaxRespawnTime;

	public float RespawnCheckRadius;

	public AudioClip RespawnSound;

	protected Vector3 m_StartPosition;

	protected Quaternion m_StartRotation;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	public void Damage(float damage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_DamageHandler), Member = "RemoveBulletHoles")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 17)]
	public void Die()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Physics), Member = "CheckSphere")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 20)]
	protected void Respawn()
	{
	}

	[CalledBy(Type = typeof(vp_DamageHandler), Member = "Die")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	protected void RemoveBulletHoles()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public vp_DamageHandler()
	{
	}
}
