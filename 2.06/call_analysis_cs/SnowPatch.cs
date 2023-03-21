using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowPatch
{
	public int m_Id;

	public Bounds m_Bounds;

	public Bounds m_BoundsQ0;

	public Bounds m_BoundsQ1;

	public Bounds m_BoundsQ2;

	public Bounds m_BoundsQ3;

	public Vector3[] m_HermiteCoefficients;

	public SnowImprintExpanded[] m_Imprints;

	public int m_NumImprints;

	public int m_MaxImprints;

	public int m_NextImprint;

	public int m_RefCount;

	public int m_QuadrantUsage;

	public int m_CaptureTick;

	public float m_CaptureWeight;

	public float m_DeviationWeight;

	private static int m_NextPatchId;

	public static int m_MaxImprintsPerPatch;

	[CallerCount(Count = 0)]
	public SnowPatch()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "AddPatch")]
	public void Initialize(Vector3 centrePos, float boundsSize)
	{
	}

	[CallerCount(Count = 0)]
	public void AddReference()
	{
	}

	[CallerCount(Count = 0)]
	public bool RemoveReference()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 2)]
	public void OnRenderCapture(int captureTick, Camera cam)
	{
	}

	[CallerCount(Count = 0)]
	public void Hide()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	public static void GeneratePatchCoefficients(Vector3 minPos, Vector3 maxPos, ref Vector3[] hermiteCoefficients, out float deviationWeight)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref deviationWeight) = null;
	}

	[CalledBy(Type = typeof(SnowPatch), Member = "AddImprint")]
	[CalledBy(Type = typeof(SnowPatch), Member = "AddImprint")]
	[Calls(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CallerCount(Count = 2)]
	private float GetPatchHeightAtPosition(Vector3 pos)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	private float GetPatchHeightTangentAtPosition(Vector3 pos)
	{
		return default(float);
	}

	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "AddImprint")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[Calls(Type = typeof(SnowPatch), Member = "GetPatchHeightAtPosition")]
	[Calls(Type = typeof(SnowImprintExpanded), Member = ".ctor")]
	[Calls(Type = typeof(SnowPatch), Member = "GetPatchHeightAtPosition")]
	[Calls(Type = typeof(SnowImprint), Member = "get_Position")]
	[CallerCount(Count = 1)]
	public int AddImprint(ref SnowImprint imprint, Bounds imprintBounds, int typeMask = -1)
	{
		return default(int);
	}
}
