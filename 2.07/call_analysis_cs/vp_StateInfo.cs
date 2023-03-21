using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class vp_StateInfo
{
	public string TypeName;

	public string Name;

	public TextAsset TextAsset;

	public vp_ComponentPreset Preset;

	public bool Enabled;

	public bool Allowed;

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	public vp_StateInfo(string typeName, string name = "New State", string path = null, TextAsset asset = null)
	{
	}
}
