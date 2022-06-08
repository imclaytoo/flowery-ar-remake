using System;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsManager : MonoBehaviour
{
    #region Instance
    private static UnityAdsManager instance;
    public static UnityAdsManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<UnityAdsManager>();
                if(instance == null)
                {
                    instance = new GameObject("Spawned UnityAdsManager", typeof(UnityAdsManager)).GetComponent<UnityAdsManager>();
                }
            }

            return instance;
        }
        set
        {
            instance = value;
        }
    }
    #endregion

    [Header("Config")]
    [SerializeField] private string gameID = "";
    [SerializeField] private bool testMode;
    [SerializeField] private string rewardedVideoPlacementId;
    [SerializeField] private string regularPlacementId;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        Advertisement.Initialize(gameID, testMode);
    }

    public void ShowRegularAd(Action<ShowResult> callback)
    {
        if (Advertisement.IsReady(regularPlacementId))
        {
            ShowOptions so = new ShowOptions();
            so.resultCallback = callback;
            Advertisement.Show(regularPlacementId, so);
        }
        else
            Debug.Log("Ads not ready, consider waiting a bit more.. or going online");
    }

    public void ShowRewardedAd(Action<ShowResult> callback)
    {
        if (Advertisement.IsReady(regularPlacementId))
        {
            ShowOptions so = new ShowOptions();
            so.resultCallback = callback;
            Advertisement.Show(regularPlacementId, so);
        }
        else
            Debug.Log("Ads not ready, consider waiting a bit more.. or going online");
    }
}
