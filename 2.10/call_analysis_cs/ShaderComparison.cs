using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class ShaderComparison
{
	public enum EnabledShader
	{
		ShaderA,
		ShaderB
	}

	public string m_Name;

	private EnabledShader m_EnabledShader;

	private Shader m_ShaderA;

	private Shader m_ShaderB;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShaderComparison), Member = "SetShaderForMaterials")]
	private void SelectShader(EnabledShader shader)
	{
	}

	[CalledBy(Type = typeof(ShaderComparison), Member = "SelectShader")]
	[CalledBy(Type = typeof(ShaderComparison), Member = "Toggle")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[Calls(Type = typeof(TerrainData), Member = "RefreshPrototypes")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void SetShaderForMaterials(Shader shader)
	{
	}

	[CalledBy(Type = typeof(ShaderToggle), Member = "Toggle")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shader_toggle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ShaderComparison), Member = "SetShaderForMaterials")]
	public void Toggle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ShaderComparison()
	{
	}
}
