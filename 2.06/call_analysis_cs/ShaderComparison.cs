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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[CalledBy(Type = typeof(ShaderComparison), Member = "Toggle")]
	[CalledBy(Type = typeof(ShaderComparison), Member = "Toggle")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[CalledBy(Type = typeof(ShaderComparison), Member = "SelectShader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TerrainData), Member = "RefreshPrototypes")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TerrainData), Member = "get_treePrototypes")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	public void SetShaderForMaterials(Shader shader)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shader_toggle")]
	[CalledBy(Type = typeof(ShaderToggle), Member = "Toggle")]
	[Calls(Type = typeof(ShaderComparison), Member = "SetShaderForMaterials")]
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
