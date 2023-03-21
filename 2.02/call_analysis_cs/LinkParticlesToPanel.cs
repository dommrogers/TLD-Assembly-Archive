using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LinkParticlesToPanel : MonoBehaviour
{
	public Panel_MainMenu m_Panel;

	private Material m_Material;

	private Color m_Color;

	private float m_Alpha;

	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public LinkParticlesToPanel()
	{
	}
}
