using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EpicOnlineServicesManager : MonoBehaviour
{
	public string m_ProductName;

	public string m_ProductVersion;

	public string m_ProductId;

	public string m_SandboxId;

	public string m_DeploymentId;

	public string m_ClientId;

	public string m_ClientSecret;

	public string m_CatalogItemID;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public EpicOnlineServicesManager()
	{
	}
}
