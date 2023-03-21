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
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CalledBy(Type = typeof(Chimney), Member = "Update")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	public void SetAlpha(float fadePercent)
	{
	}

	[Calls(Type = typeof(SmokeTrail), Member = "SetAlpha")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdate")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "WarmUpSmokeTrails")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "WarmUpEffect")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "set_mainTextureOffset")]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
	[Calls(Type = typeof(SmokeTrail), Member = "UpdateInternal")]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	private void FixedUpdateInternal(float deltaTime)
	{
	}

	[Calls(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void FixedUpdate()
	{
	}

	[CalledBy(Type = typeof(SmokeTrail), Member = "Start")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "Start")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "Reset")]
	[CalledBy(Type = typeof(GunItem), Member = "ResetEffects")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "ShowSmoke")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "StartSmoke")]
	[CalledBy(Type = typeof(vp_MuzzleFlash), Member = "OnDisable")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Fire), Member = "SetSmokeTrail")]
	[Calls(Type = typeof(SmokeTrail), Member = "getSmokeVec")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	private void InitEffect(bool resetEffect = false)
	{
	}

	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(SmokeTrail), Member = "getSmokeVec")]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
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

	[Calls(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CallerCount(Count = 0)]
	public void WarmUpEffect()
	{
	}

	[CallerCount(Count = 0)]
	public SmokeTrail()
	{
	}
}
