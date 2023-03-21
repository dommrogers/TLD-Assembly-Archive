using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimatedCookie : MonoBehaviour
{
	public float m_FPS;

	public bool m_RandomStartFrame;

	public Texture2D[] m_Frames;

	private int m_CurrentFrame;

	private float m_CurrentAnimationTime;

	private Light m_Light;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void NextFrame()
	{
	}

	[CallerCount(Count = 0)]
	public AnimatedCookie()
	{
	}
}
