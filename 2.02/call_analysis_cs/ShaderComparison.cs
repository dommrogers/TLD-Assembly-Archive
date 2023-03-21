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
	[Calls(Type = typeof(TerrainData), Member = "RefreshPrototypes")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	[CalledBy(Type = typeof(ShaderComparison), Member = "Toggle")]
	[CalledBy(Type = typeof(ShaderComparison), Member = "Toggle")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[CalledBy(Type = typeof(ShaderComparison), Member = "SelectShader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(TerrainData), Member = "get_treePrototypes")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	public void SetShaderForMaterials(Shader shader)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ShaderComparison), Member = "SetShaderForMaterials")]
	[Calls(Type = typeof(ShaderComparison), Member = "SetShaderForMaterials")]
	[CalledBy(Type = typeof(ShaderToggle), Member = "Toggle")]
	public void Toggle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ShaderComparison()
	{
	}
}
