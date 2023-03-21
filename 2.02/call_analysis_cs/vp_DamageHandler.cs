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

	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	public void Damage(float damage)
	{
	}

	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(vp_DamageHandler), Member = "RemoveBulletHoles")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void Die()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Physics), Member = "CheckSphere")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 20)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	protected void Respawn()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(vp_DamageHandler), Member = "Die")]
	protected void RemoveBulletHoles()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public vp_DamageHandler()
	{
	}
}
