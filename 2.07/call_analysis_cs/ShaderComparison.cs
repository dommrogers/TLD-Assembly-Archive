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

	[Calls(Type = typeof(TerrainData), Member = "RefreshPrototypes")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ShaderComparison), Member = "Toggle")]
	[CalledBy(Type = typeof(ShaderComparison), Member = "Toggle")]
	[CalledBy(Type = typeof(ShaderComparison), Member = "SelectShader")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	public void SetShaderForMaterials(Shader shader)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ShaderComparison), Member = "SetShaderForMaterials")]
	[Calls(Type = typeof(ShaderComparison), Member = "SetShaderForMaterials")]
	[CalledBy(Type = typeof(ShaderToggle), Member = "Toggle")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shader_toggle")]
	public void Toggle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ShaderComparison()
	{
	}
}
