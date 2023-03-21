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
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(Chimney), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	public void SetAlpha(float fadePercent)
	{
	}

	[Calls(Type = typeof(SmokeTrail), Member = "SetAlpha")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "WarmUpSmokeTrails")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "WarmUpEffect")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdate")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[Calls(Type = typeof(SmokeTrail), Member = "UpdateInternal")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
	[Calls(Type = typeof(Material), Member = "set_mainTextureOffset")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
	private void FixedUpdateInternal(float deltaTime)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void FixedUpdate()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SmokeTrail), Member = "Start")]
	[CalledBy(Type = typeof(GunItem), Member = "ResetEffects")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "Reset")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "StartSmoke")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "Start")]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "ShowSmoke")]
	[Calls(Type = typeof(Fire), Member = "SetSmokeTrail")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(SmokeTrail), Member = "getSmokeVec")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "OnDisable")]
	private void InitEffect(bool resetEffect = false)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(SmokeTrail), Member = "getSmokeVec")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SmokeTrail), Member = "getSmokeVec")]
	private void UpdateInternal(float deltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
	[Calls(Type = typeof(Material), Member = "set_mainTextureOffset")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateMaterial()
	{
	}

	[CalledBy(Type = typeof(SmokeTrail), Member = "UpdateInternal")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SmokeTrail), Member = "UpdateInternal")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
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
		return default(bool);
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
	public SmokeTrail()
	{
	}
}
