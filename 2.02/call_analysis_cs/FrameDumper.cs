using System;
using System.Globalization;
using System.IO;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FrameDumper : MonoBehaviour
{
	public Material m_CopyImageMaterial;

	public Material m_CopyDepthMaterial;

	public Material m_CopyNormalsMaterial;

	public static int m_CaptureMode;

	public static FrameDumper m_Instance;

	public static string m_AnimToCaptureNext;

	private static string m_ShotDirectory;

	private static bool m_Dumping;

	private static int m_CurrentImageIndex;

	private static int m_CaptureFramerate;

	private static float m_CaptureFarClip;

	private static FrameDumpHelper m_CaptureHelper;

	private static ThreadedImageWriter m_ImageWriter;

	private static Camera m_WeaponCamera;

	private static CameraClearFlags m_WeaponCameraClearFlags;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(FrameDumper), Member = "CreateHelpers")]
	[Calls(Type = typeof(Directory), Member = "Delete")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[Calls(Type = typeof(Time), Member = "set_captureFramerate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void StartDumpingToDirectory(string directoryName)
	{
	}

	[Calls(Type = typeof(FrameDumper), Member = "CreateHelpers")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_toggle")]
	[Calls(Type = typeof(FrameDumper), Member = "DestroyHelpers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[Calls(Type = typeof(Time), Member = "set_captureFramerate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	public static void Toggle()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Thread), Member = "Sleep")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(FrameDumper), Member = "MaybeStartDumpingAnimation")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FrameDumper), Member = "GetImageFilename")]
	private void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	[CallerCount(Count = 0)]
	public static void SetCaptureFramerate(int fps)
	{
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetCaptureFarClip(float farClip)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	public static void SetCaptureMode(int mode)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(FrameDumper), Member = "StartDumpingToDirectory")]
	[CalledBy(Type = typeof(FrameDumper), Member = "Toggle")]
	[CallsUnknownMethods(Count = 14)]
	private void CreateHelpers()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags")]
	[CalledBy(Type = typeof(FrameDumper), Member = "Toggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void DestroyHelpers()
	{
	}

	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ImageConversion), Member = "EncodeToPNG")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(ThreadedImageWriter), Member = "AddWriteRequest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(FrameDumpHelper), Member = "OnRenderImage")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(ThreadedImageWriter), Member = "AddWriteRequest")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(FrameDumper), Member = "GetImageFilename")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(ThreadedImageWriter), Member = "AddWriteRequest")]
	public void DumpFrame(RenderTexture image, RenderTexture depth, RenderTexture norm)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FrameDumper), Member = "GetImageFilename")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	private void DumpFrameSimple()
	{
	}

	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrameSimple")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(FrameDumper), Member = "Update")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private static string GetImageFilename()
	{
		return null;
	}

	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private static string GetShotDirectory()
	{
		return null;
	}

	[CalledBy(Type = typeof(FrameDumper), Member = "Update")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AnimatorClipInfo), Member = "get_clip")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Time), Member = "set_captureFramerate")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AnimatorClipInfo), Member = "get_clip")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorClipInfo")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	private static void MaybeStartDumpingAnimation()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FrameDumper()
	{
	}
}
