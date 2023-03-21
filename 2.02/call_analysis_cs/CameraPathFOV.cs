using Cpp2ILInjected.CallAnalysis;

public class CameraPathFOV : CameraPathPoint
{
	public float FOV;

	public float Size;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPoint), Member = ".ctor")]
	public CameraPathFOV()
	{
	}
}
