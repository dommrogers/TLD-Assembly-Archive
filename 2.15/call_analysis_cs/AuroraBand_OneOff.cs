using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraBand_OneOff : MonoBehaviour
{
	public float animSpeed;

	public float animStart;

	public Vector2 mainTexSpinRate;

	public Vector2 alphaTexSpinRate;

	public Vector3 rgbMin;

	public Vector3 rgbMax;

	public Vector3 cycleRGBTime;

	public float speedPercentage;

	private Vector2 uvOffsetMain;

	private Vector2 uvOffsetMask;

	private Vector3 colorTimers;

	private Renderer m_Renderer;

	private Animation m_Animation;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "set_speed")]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetAlpha(float alpha)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private Color SetColor()
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	public AuroraBand_OneOff()
	{
	}
}
