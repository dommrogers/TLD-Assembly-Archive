using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BoxVolume : VolumetricObjectBase
{
	public Vector3 boxSize;

	private Vector3 previousBoxSize;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "OnEnable")]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void PopulateShaderName()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "HasChanged")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool HasChanged()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "SetChangedValues")]
	protected override void SetChangedValues()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "ScaleMesh")]
	[Calls(Type = typeof(Bounds), Member = "SetMinMax")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public override void UpdateVolume()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public BoxVolume()
	{
	}
}
