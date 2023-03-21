using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ScreenEffectTest : MonoBehaviour
{
	private Mesh m_Mesh;

	public Material m_Material;

	public Vector2 m_AnimRate;

	public Vector2 m_MaxDisplacement;

	private Material m_CustomMaterial;

	[CallsUnknownMethods(Count = 81)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow")]
	private void OnRenderObject()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ScreenEffectTest()
	{
	}
}
