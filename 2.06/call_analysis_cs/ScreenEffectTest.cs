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
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsUnknownMethods(Count = 30)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 15)]
	private void OnRenderObject()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ScreenEffectTest()
	{
	}
}
