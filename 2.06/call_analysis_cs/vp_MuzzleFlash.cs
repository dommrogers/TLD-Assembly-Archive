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
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 25)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowSmoke")]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowFlash")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void Show()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowFlash")]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowSmoke")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void Shoot(Transform tr, bool hasMisfired)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "ShowMuzzleFlash")]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "Shoot")]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	private void ShowFlash()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "ShowMuzzleFlash")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "Update")]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "Shoot")]
	private void ShowSmoke()
	{
	}

	[CallerCount(Count = 0)]
	public vp_MuzzleFlash()
	{
	}
}
