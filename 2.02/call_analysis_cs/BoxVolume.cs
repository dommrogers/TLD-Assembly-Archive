using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BoxVolume : VolumetricObjectBase
{
	public Vector3 boxSize;

	private Vector3 previousBoxSize;

	[Calls(Type = typeof(VolumetricObjectBase), Member = "OnEnable")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void PopulateShaderName()
	{
	}

	[Calls(Type = typeof(VolumetricObjectBase), Member = "HasChanged")]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override bool HasChanged()
	{
		return default(bool);
	}

	[Calls(Type = typeof(VolumetricObjectBase), Member = "SetChangedValues")]
	[CallerCount(Count = 0)]
	protected override void SetChangedValues()
	{
	}

	[Calls(Type = typeof(Material), Member = "SetVector")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bounds), Member = "SetMinMax")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "ScaleMesh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 8)]
	public override void UpdateVolume()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	public BoxVolume()
	{
	}
}
