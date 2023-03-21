using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraBand : MonoBehaviour
{
	public float m_AnimSpeed;

	public float m_AnimStart;

	public Vector2 m_MainTexScrollRate;

	public Vector2 m_AlphaTexScrollRate;

	public float m_SpeedPercentage;

	private Color m_CurColour;

	private Vector2 uvOffsetMain;

	private Vector2 uvOffsetMask;

	private Renderer m_Renderer;

	private Material m_Material;

	private Animation m_Animation;

	private float m_LastAlpha;

	private float curLerp;

	private bool m_IsTriggeredColour;

	private Color m_TriggeredColour;

	private float m_TriggeredColourTime;

	private float m_TriggeredColourLerp;

	[Calls(Type = typeof(DownsampleAurora), Member = "RegisterAurora")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AuroraBand), Member = "SetAlpha")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 23)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(AuroraBand), Member = "SetAlpha")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	[Calls(Type = typeof(AuroraBand), Member = "UpdateUV")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	private void UpdateColour()
	{
	}

	[CalledBy(Type = typeof(AuroraBand), Member = "Update")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	private void UpdateUV()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CalledBy(Type = typeof(AuroraBand), Member = "Start")]
	[CalledBy(Type = typeof(AuroraBand), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public void SetAlpha(float alpha)
	{
	}

	[CallerCount(Count = 0)]
	public void TriggerColour(Color newColour, float lerpTime)
	{
	}

	[CallerCount(Count = 0)]
	public void ReturnColour(float lerpTime)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	public AuroraBand()
	{
	}
}
