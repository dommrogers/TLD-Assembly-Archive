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

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	public void Damage(float damage)
	{
	}

	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(vp_DamageHandler), Member = "RemoveBulletHoles")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsUnknownMethods(Count = 8)]
	public void Die()
	{
	}

	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Physics), Member = "CheckSphere")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	protected void Respawn()
	{
	}

	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(vp_DamageHandler), Member = "Die")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	protected void RemoveBulletHoles()
	{
	}

	[CallerCount(Count = 0)]
	public vp_DamageHandler()
	{
	}
}
