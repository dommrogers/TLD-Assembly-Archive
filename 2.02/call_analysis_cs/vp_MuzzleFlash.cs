using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class vp_MuzzleFlash : MonoBehaviour
{
	public ParticleSystem muzzleFlashFX;

	public ParticleSystem muzzleSmokeFX;

	public ParticleSystem breachPuffFX;

	public ParticleSystem m_MisfireFX;

	public float m_FlashDelay;

	public float m_SmokeDelay;

	protected float m_FadeSpeed;

	protected bool m_ForceShow;

	protected Color m_Color;

	private Transform m_RenderTransform;

	private ParticleSystem inst_MuzzleFlash;

	private ParticleSystem inst_MuzzleSmoke;

	private ParticleSystem inst_BreachPuff;

	private ParticleSystem m_MisfireFXInstance;

	private Material m_FlashMaterial;

	private float m_FlashDelayBeforeShow;

	private float m_SmokeDelayBeforeShow;

	private bool m_HasMisfired;

	private const float DEFAULT_FLASH_ALPHA = 0.5f;

	private static readonly int s_TintColorShaderID;

	private SmokeTrail m_SmokeTrail;

	public float FadeSpeed
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool ForceShow
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 52)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowFlash")]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowSmoke")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 28)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void Show()
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "ShowMuzzleFlash")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowFlash")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowSmoke")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Shoot(Transform tr, bool hasMisfired)
	{
	}

	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "Update")]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "Shoot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	private void ShowFlash()
	{
	}

	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "Update")]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "Shoot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ShowSmoke()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public vp_MuzzleFlash()
	{
	}
}
