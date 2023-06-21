using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MuzzleFlash : MonoBehaviour
{
	public float m_AlphaOnFire;

	private Color m_DefaultColor;

	private float m_CurrentAlpha;

	private Renderer m_Renderer;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 4)]
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
