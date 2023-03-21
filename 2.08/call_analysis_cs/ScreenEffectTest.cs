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

	[Calls(Type = typeof(Array), Member = "get_Length")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel")]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel")]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow")]
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
