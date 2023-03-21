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

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Random), Member = "Range")]
	public void Damage(float damage)
	{
	}

	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(vp_DamageHandler), Member = "RemoveBulletHoles")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsUnknownMethods(Count = 13)]
	public void Die()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Physics), Member = "CheckSphere")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Random), Member = "Range")]
	protected void Respawn()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CalledBy(Type = typeof(vp_DamageHandler), Member = "Die")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	protected void RemoveBulletHoles()
	{
	}

	[CallerCount(Count = 0)]
	public vp_DamageHandler()
	{
	}
}
