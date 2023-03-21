using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LinkParticlesToPanel : MonoBehaviour
{
	public Panel_MainMenu m_Panel;

	private Material m_Material;

	private Color m_Color;

	private float m_Alpha;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public LinkParticlesToPanel()
	{
	}
}
