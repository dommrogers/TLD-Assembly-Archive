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

	[CalledBy(Type = typeof(SnowPatchManager), Member = "AddPatch")]
	[CallerCount(Count = 1)]
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
		return false;
	}

	[CalledBy(Type = typeof(SnowPatchManager), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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
		deviationWeight = default(float);
	}

	[CalledBy(Type = typeof(SnowPatch), Member = "AddImprint")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	private float GetPatchHeightAtPosition(Vector3 pos)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	private float GetPatchHeightTangentAtPosition(Vector3 pos)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(SnowPatchManager), Member = "AddImprint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowImprint), Member = "get_Position")]
	[Calls(Type = typeof(SnowPatch), Member = "GetPatchHeightAtPosition")]
	[Calls(Type = typeof(SnowImprintExpanded), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CallsUnknownMethods(Count = 3)]
	public int AddImprint(ref SnowImprint imprint, Bounds imprintBounds, int typeMask = -1)
	{
		return 0;
	}
}
