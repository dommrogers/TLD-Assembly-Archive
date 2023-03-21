using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MuzzleFlash : MonoBehaviour
{
	public float m_AlphaOnFire;

	private Color m_DefaultColor;

	private float m_CurrentAlpha;

	private Renderer m_Renderer;

	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MuzzleFlash()
	{
	}
}
