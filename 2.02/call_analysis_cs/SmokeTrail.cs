using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SmokeTrail : MonoBehaviour
{
	public int numberOfPoints;

	public float updateSpeed;

	public float riseSpeed;

	public float spread;

	public bool applySpeedAndDir;

	public float windForceDivider;

	public bool affectRiseSpeed;

	public float riseRateDivider;

	public bool affectSpread;

	public float spreadDivider;

	public bool useFadeout;

	public float duration;

	public float fadeDuration;

	public bool playOnAwake;

	public bool autoDestroy;

	public Fire m_SourceFire;

	public float m_SourceFireFadeStart;

	public int m_ParentLevels;

	private LineRenderer line;

	private Transform tr;

	private Vector3[] positions;

	private Vector3[] directions;

	private int i;

	private float timeSinceUpdate;

	private Material lineMaterial;

	private float lineSegment;

	private int currentNumberOfPoints;

	private bool allPointsAdded;

	private Color startColour;

	private Vector3 tempVec;

	private float windSpeed;

	private Vector3 windDir;

	private bool isSmoking;

	private float smokeTimer;

	private float smokeFadeStep;

	private bool m_ForceFadeOut;

	private float m_ForceFadeOutSeconds;

	private bool m_Warmed;

	private Color m_currentColor;

	private bool m_IsReset;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(Chimney), Member = "Update")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetAlpha(float fadePercent)
	{
	}

	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "WarmUpEffect")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "WarmUpSmokeTrails")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[Calls(Type = typeof(SmokeTrail), Member = "UpdateInternal")]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
	[Calls(Type = typeof(Material), Member = "set_mainTextureOffset")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(SmokeTrail), Member = "SetAlpha")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	private void FixedUpdateInternal(float deltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void FixedUpdate()
	{
	}

	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "OnDisable")]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "ShowSmoke")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "Start")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "StartSmoke")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "Reset")]
	[CalledBy(Type = typeof(GunItem), Member = "ResetEffects")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(SmokeTrail), Member = "getSmokeVec")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Fire), Member = "SetSmokeTrail")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 29)]
	private void InitEffect(bool resetEffect = false)
	{
	}

	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LineRenderer), Member = "set_positionCount")]
	[Calls(Type = typeof(SmokeTrail), Member = "getSmokeVec")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 60)]
	private void UpdateInternal(float deltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
	[Calls(Type = typeof(Material), Member = "set_mainTextureOffset")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateMaterial()
	{
	}

	[CalledBy(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "UpdateInternal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private Vector3 getSmokeVec()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	public void StartSmoke()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	public void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool GetSmokeStatus()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void ForceOff(bool force)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	public void WarmUpEffect()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SmokeTrail()
	{
	}
}
