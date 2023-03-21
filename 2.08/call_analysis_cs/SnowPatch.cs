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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnRenderCapture(int captureTick, Camera cam)
	{
	}

	[CallerCount(Count = 0)]
	public void Hide()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[CallerCount(Count = 0)]
	public static void GeneratePatchCoefficients(Vector3 minPos, Vector3 maxPos, ref Vector3[] hermiteCoefficients, out float deviationWeight)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref deviationWeight) = null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(SnowPatch), Member = "AddImprint")]
	[CalledBy(Type = typeof(SnowPatch), Member = "AddImprint")]
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
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "AddImprint")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowPatch), Member = "GetPatchHeightAtPosition")]
	[Calls(Type = typeof(SnowImprintExpanded), Member = ".ctor")]
	[Calls(Type = typeof(SnowPatch), Member = "GetPatchHeightAtPosition")]
	[Calls(Type = typeof(SnowImprint), Member = "get_Position")]
	[Calls(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	public int AddImprint(ref SnowImprint imprint, Bounds imprintBounds, int typeMask = -1)
	{
		return default(int);
	}
}
