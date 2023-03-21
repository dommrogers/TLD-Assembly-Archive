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
			return default(float);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public bool ForceShow
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 52)]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 29)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowSmoke")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowFlash")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void Show()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowFlash")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowSmoke")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "ShowMuzzleFlash")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void Shoot(Transform tr, bool hasMisfired)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "Update")]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "Shoot")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 9)]
	private void ShowFlash()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "Shoot")]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "Update")]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void ShowSmoke()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public vp_MuzzleFlash()
	{
	}
}
