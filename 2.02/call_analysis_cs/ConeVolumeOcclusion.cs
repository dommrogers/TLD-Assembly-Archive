using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ConeVolumeOcclusion : VolumetricObjectBase
{
	public float coneHeight;

	public float coneAngle;

	public float startOffset;

	public int occlusionTextureSize;

	private float previousConeHeight;

	private float previousConeAngle;

	private float previousStartOffset;

	private int previousOcclusionTextureSize;

	private Transform coneCameraTransform;

	private Camera coneCamera;

	private RenderTexture coneCameraRT;

	[Calls(Type = typeof(ConeVolumeOcclusion), Member = "SetupCamera")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "OnEnable")]
	protected override void OnEnable()
	{
	}

	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	protected override void CleanUp()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(ConeVolumeOcclusion), Member = "SetupCamera")]
	protected override void SetChangedValues()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Bounds), Member = "SetMinMax")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "ScaleMesh")]
	public override void UpdateVolume()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "SetupCamera")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void CreateDepthCamera()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "SetupCamera")]
	[CallerCount(Count = 1)]
	private RenderTexture ConeRenderTexture()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "OnEnable")]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "SetChangedValues")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(ConeVolumeOcclusion), Member = "CreateDepthCamera")]
	[Calls(Type = typeof(ConeVolumeOcclusion), Member = "ConeRenderTexture")]
	[CallerCount(Count = 2)]
	private void SetupCamera()
	{
	}

	[Calls(Type = typeof(VolumetricObjectBase), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public ConeVolumeOcclusion()
	{
	}
}
