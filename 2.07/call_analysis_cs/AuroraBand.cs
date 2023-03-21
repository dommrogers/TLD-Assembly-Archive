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

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(AuroraBand), Member = "SetAlpha")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(DownsampleAurora), Member = "RegisterAurora")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DownsampleAurora), Member = "UnRegisterAurora")]
	[CallsUnknownMethods(Count = 3)]
	public void OnDestroy()
	{
	}

	[Calls(Type = typeof(AuroraBand), Member = "SetAlpha")]
	[Calls(Type = typeof(AuroraBand), Member = "UpdateColour")]
	[Calls(Type = typeof(AuroraBand), Member = "UpdateUV")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 12)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraBand), Member = "Update")]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallerCount(Count = 1)]
	private void UpdateColour()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[CalledBy(Type = typeof(AuroraBand), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateUV()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraBand), Member = "Update")]
	[CalledBy(Type = typeof(AuroraBand), Member = "Start")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallerCount(Count = 2)]
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

	[CallerCount(Count = 0)]
	public AuroraBand()
	{
	}
}
