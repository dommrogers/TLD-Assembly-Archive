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
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[Calls(Type = typeof(AnimationState), Member = "set_speed")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 6)]
	public void SetAlpha(float alpha)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private Color SetColor()
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraBand_OneOff()
	{
	}
}
