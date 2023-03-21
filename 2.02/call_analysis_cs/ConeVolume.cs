using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ConeVolume : VolumetricObjectBase
{
	public float coneHeight;

	public float coneAngle;

	public float startOffset;

	private float previousConeHeight;

	private float previousConeAngle;

	private float previousStartOffset;

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "OnEnable")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "HasChanged")]
	public override bool HasChanged()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "SetChangedValues")]
	protected override void SetChangedValues()
	{
	}

	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "ScaleMesh")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bounds), Member = "SetMinMax")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public override void UpdateVolume()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricObjectBase), Member = ".ctor")]
	public ConeVolume()
	{
	}
}
