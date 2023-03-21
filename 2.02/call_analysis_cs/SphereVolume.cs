using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SphereVolume : VolumetricObjectBase
{
	public float radius;

	private float previousRadius;

	[Calls(Type = typeof(VolumetricObjectBase), Member = "OnEnable")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void PopulateShaderName()
	{
	}

	[Calls(Type = typeof(VolumetricObjectBase), Member = "HasChanged")]
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

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "ScaleMesh")]
	[Calls(Type = typeof(Bounds), Member = "SetMinMax")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	public override void UpdateVolume()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricObjectBase), Member = ".ctor")]
	public SphereVolume()
	{
	}
}
