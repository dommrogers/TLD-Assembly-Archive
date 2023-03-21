using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Placeholder : MonoBehaviour
{
	private enum VisualizationMode
	{
		Box,
		Mesh,
		LineOnly
	}

	private string m_Label;

	private Color m_LabelColor;

	private Vector3 m_LabelOffset;

	private VisualizationMode m_VisualizationMode;

	private Color m_VisualizationColor;

	private Mesh m_Mesh;

	public static bool s_ShouldRender;

	private GUIStyle m_LabelStyle;

	private const int MIN_FONT_SIZE = 2;

	private const int MAX_FONT_SIZE = 11;

	private const float LABEL_WIDTH = 200f;

	private const float MIN_LABEL_HEIGHT = 20f;

	private const float MAX_LABEL_HEIGHT = 50f;

	private const float MAX_LABEL_DISTANCE = 30f;

	private const float MAX_SQR_LABEL_DISTANCE = 900f;

	private const string MESH_NAME = "Placeholder Mesh";

	private const string MESH_SHADER_NAME = "Shader Forge/TLD_Simple";

	private const string LINE_SHADER_NAME = "Hidden/Internal-Colored";

	[Calls(Type = typeof(Gizmos), Member = "DrawMesh")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private void OnDrawGizmos()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(GUIStyle), Member = "get_normal")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private GUIStyle GetLabelStyle(Color textColor, float normalizedDistance)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Placeholder()
	{
	}
}
