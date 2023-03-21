using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ScreenEffectTest : MonoBehaviour
{
	private Mesh m_Mesh;

	public Material m_Material;

	public Vector2 m_AnimRate;

	public Vector2 m_MaxDisplacement;

	private Material m_CustomMaterial;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 18)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void OnRenderObject()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ScreenEffectTest()
	{
	}
}
