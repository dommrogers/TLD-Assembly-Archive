using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MuzzleFlash : MonoBehaviour
{
	public float m_AlphaOnFire;

	private Color m_DefaultColor;

	private float m_CurrentAlpha;

	private Renderer m_Renderer;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 10)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MuzzleFlash()
	{
	}
}
