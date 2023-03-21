using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TimeWidget : MonoBehaviour
{
	public UISprite m_ArrowSprite;

	public UISprite m_MoonSprite;

	public UISprite m_SunSprite;

	private float m_SunRadius;

	private float m_MoonRadius;

	private bool m_Initialized;

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(TimeWidget), Member = "UpdateIconFill")]
	[Calls(Type = typeof(TimeWidget), Member = "UpdateIconPositions")]
	[Calls(Type = typeof(TimeWidget), Member = "UpdateIconFill")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(TimeWidget), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(TimeWidget), Member = "GetPositionOnCircle")]
	[Calls(Type = typeof(TimeWidget), Member = "GetPositionOnCircle")]
	[CallsUnknownMethods(Count = 20)]
	private void UpdateIconPositions(float angleDegrees)
	{
	}

	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void UpdateIconFill(UISprite sprite, Vector3 pos, float angleDegrees)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TimeWidget), Member = "UpdateIconPositions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(TimeWidget), Member = "UpdateIconPositions")]
	private Vector3 GetPositionOnCircle(float radius, float angleDegrees)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TimeWidget()
	{
	}
}
