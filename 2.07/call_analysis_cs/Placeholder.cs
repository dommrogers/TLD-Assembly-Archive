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
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void OnDrawGizmos()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(GUIStyle), Member = "get_normal")]
	[CallsUnknownMethods(Count = 11)]
	private GUIStyle GetLabelStyle(Color textColor, float normalizedDistance)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public Placeholder()
	{
	}
}
