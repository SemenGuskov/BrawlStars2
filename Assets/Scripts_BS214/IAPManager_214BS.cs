using System;
using System.Collections;
using System.Globalization;
using com.adjust.sdk;
using IOSBridge;
using Unity.Services.Core;
using Unity.Services.Core.Environments;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Purchasing;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;
using System.IO.IsolatedStorage;

public class IAPManager_214BS : MonoBehaviour, IStoreListener
{
    
    
    [Header("Subscription ID 214BS")]
    [SerializeField] private string _productIdSubscription_214BS;
    
    
    [Header("UI Blockers 214BS")]
    [Tooltip("This is an image that blocks content during subscription verification 214BS")]
    [SerializeField] private GameObject _subStage_214BS;

     [SerializeField] private VideoPlayer _videoPlayer_214BS;
    
    
    [Tooltip("This is a translucent panel that appears over the subscription content when you click subscribe 214BS")]
    [SerializeField] private GameObject _backgroundBlocker_214BS;
    
    
    [Header("Store buttons 214BS")]
    [SerializeField] private Button _buyButton_214BS;
     [SerializeField] private Button _restoreButton_214BS;
    private IStoreController _storeController_214BS;
    private static IExtensionProvider _extensionProvider_214BS;
    private bool _isSubscriptionBought_214BS;
    private async void Awake()
    {
        _backgroundBlocker_214BS.SetActive(true);
        try
        {
            var options_214BS = new InitializationOptions().SetEnvironmentName("production_214BS".Replace("_214BS", ""));
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            await UnityServices.InitializeAsync(options_214BS);
        }
        catch (Exception exception)
        {
            Debug.Log($"[UGS ERROR] Message: {exception} 214BS");
        }
    }

    public void MakeButtonWithIAP_214BS()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _buyButton_214BS.onClick.AddListener(OnSubPurchaseClick_214BS);
    }

    private void Start()
    {
        if (_storeController_214BS == null)
            ManualInitialize_214BS();
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _restoreButton_214BS.onClick.AddListener(OnRestoreSubscriptionPurchase_214BS);
    }
    private void OnDestroy()
    {
        _buyButton_214BS.onClick.RemoveListener(OnSubPurchaseClick_214BS);
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _restoreButton_214BS.onClick.RemoveListener(OnRestoreSubscriptionPurchase_214BS);
    }
    private void ManualInitialize_214BS()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        var builder_214BS = ConfigurationBuilder.Instance(StandardPurchasingModule
#if UNITY_IOS
            .Instance(AppStore.AppleAppStore));
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
#elif UNITY_ANDROID
            .Instance(AppStore.GooglePlay));
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
#else
            .Instance(AppStore.NotSpecified));
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
#endif
        builder_214BS.AddProduct(_productIdSubscription_214BS, ProductType.Subscription);
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        StandardPurchasingModule.Instance().useFakeStoreUIMode = FakeStoreUIMode.StandardUser;
        StandardPurchasingModule.Instance().useFakeStoreAlways = true;
        Debug.Log(_productIdSubscription_214BS);
        UnityPurchasing.Initialize(this, builder_214BS);
    }
    
    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        Debug.Log("[IAP INFO] Purchases initialized 214BS");
        _storeController_214BS = controller;
        _extensionProvider_214BS = extensions;
        var product_214BS = _storeController_214BS.products.WithID(_productIdSubscription_214BS);
        if (product_214BS != null && product_214BS.definition.type == ProductType.Subscription)
        {
            try
            {
                var introductoryInfoDict_214BS = extensions.GetExtension<IAppleExtensions>().GetIntroductoryPriceDictionary();
                var introJson_214BS = introductoryInfoDict_214BS == null || !introductoryInfoDict_214BS.ContainsKey(product_214BS.definition.storeSpecificId)
                    ? null
                    : introductoryInfoDict_214BS[product_214BS.definition.storeSpecificId];
                var subManager_214BS = new SubscriptionManager(product_214BS, introJson_214BS);
                var info_214BS = subManager_214BS.getSubscriptionInfo();
                if (info_214BS.isExpired() == Result.True)
                {
                    _isSubscriptionBought_214BS = false;
                }
                else if (info_214BS.isSubscribed() == Result.True)
                {
                    _isSubscriptionBought_214BS = true;
                }
                else
                {
                    _isSubscriptionBought_214BS = false;
                }
            }
            catch (Exception e)
            {
                Debug.Log(e);
                _isSubscriptionBought_214BS = false;
            }
        }
        if (_isSubscriptionBought_214BS)
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
            {
                SceneManager.LoadScene(1);
            }
        }
        else
        {
            _buyButton_214BS.interactable = true;
            _backgroundBlocker_214BS.SetActive(false);
            _videoPlayer_214BS.Stop();
            _videoPlayer_214BS.SetDirectAudioVolume(0, 1);
            _videoPlayer_214BS.Play();
        }
    }

    private bool IsInitialized_214BS()
    {
        return _storeController_214BS != null && _extensionProvider_214BS != null;
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.LogError($"[IAP ERROR] Initialization failed. Error: {error} 214BS");
    }

    public void OnInitializeFailed(InitializationFailureReason error, string message)
    {
        Debug.LogError($"[IAP ERROR] Initialization failed. Error: {message} 214BS");
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason error)
    {
        _buyButton_214BS.interactable = true;
        Debug.Log($"[IAP ERROR] Purchase for '{product.definition.id}' failed. Error: {error} 214BS");
    }

    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        Debug.Log($"[IAP INFO] Process purchase started for '{args.purchasedProduct.definition.id}' 214BS");
        if (!string.Equals(args.purchasedProduct.definition.id, _productIdSubscription_214BS, StringComparison.Ordinal))
        {
            Debug.LogError(
                $"[IAP ERROR] Process purchase for '{args.purchasedProduct.definition.id}' failed. Unrecognized product name CV_256");
            return PurchaseProcessingResult.Complete;
        }

        var subs_214BS = new AdjustAppStoreSubscription(
            args.purchasedProduct.metadata.localizedPrice.ToString(CultureInfo.InvariantCulture),
            args.purchasedProduct.metadata.isoCurrencyCode,
            args.purchasedProduct.transactionID,
            args.purchasedProduct.receipt
        );
        
        subs_214BS.setTransactionDate(DateTime.UtcNow.ToLongDateString());
        Adjust.trackAppStoreSubscription(subs_214BS);
        Debug.Log($"[IAP INFO] Product purchased'{args.purchasedProduct.definition.id}' 214BS");
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
        {
            SceneManager.LoadScene(1);
        }

        if (_subStage_214BS != null)
        {
            _subStage_214BS.gameObject.SetActive(false);
        }

        _backgroundBlocker_214BS.SetActive(true);
        return PurchaseProcessingResult.Complete;
    }
    public void OnRestoreSubscriptionPurchase_214BS()
    {
        if (!IsInitialized_214BS())
        {
            Debug.LogError("[IAP ERROR] Restoring purchases failed. Reason: IAP not initialized 214BS");
            return;
        }
        if (Application.platform != RuntimePlatform.IPhonePlayer &&
            Application.platform != RuntimePlatform.OSXPlayer) return;
        var apple_214BS= _extensionProvider_214BS.GetExtension<IAppleExtensions>();
        apple_214BS.RestoreTransactions((result) =>
        {
            if (!result)
                Debug.LogError($"[IAP ERROR] Transaction restoring failed. 214BS");
        });
    }
    
    private IEnumerator CheckInternet_214BS(Action<bool> onCompleted)
    {
        UnityWebRequest request_214BS = UnityWebRequest.Get("https://www.google.com/");
        request_214BS.SendWebRequest();
        float timer_214BS = 0;
        while (!request_214BS.isDone)
        {
            yield return null;
            timer_214BS+= Time.deltaTime;

            if (timer_214BS >= 2)
            {
                onCompleted?.Invoke(false);
                break;
            }
        }
        if (request_214BS.isDone)
        {
            if(request_214BS.result == UnityWebRequest.Result.ConnectionError)
                onCompleted?.Invoke(false);
            else
                onCompleted?.Invoke(true);
        }
    }
    
    private void OnSubPurchaseClick_214BS()
    {
        StartCoroutine(CheckInternet_214BS(result_214BS =>
        {
            if (result_214BS)
            {
                BuyProductID_214BS(_productIdSubscription_214BS);
                _buyButton_214BS.interactable = false;
            }
            else
            {
                IOStoUnityBridge.ShowAlert("No Internet Connection", "Oops! It seems like you're currently offline.214BS".Replace("214BS", ""));
                //_noInternetCanvas.SetActive(true);
                _buyButton_214BS.interactable = true;
            }
        }));
    }

    private void BuyProductID_214BS(string productId)
    {
        StartCoroutine(CheckInternet_214BS(isConnected_214BS =>
        {
            if (!isConnected_214BS) return;
            
            if (IsInitialized_214BS())
            {
                var product_214BS = _storeController_214BS.products.WithID(productId);
                if (product_214BS is { availableToPurchase: true })
                {
                    Debug.Log($"[IAP INFO] Purchasing product asynchronously: '{product_214BS.definition.id}' 214BS");
                    _storeController_214BS.InitiatePurchase(product_214BS);
                }
                else
                {
                    Debug.LogError(
                        $"[IAP ERROR] Product '{productId}' buying failed. Info: Not purchasing product, either is not found or is not available for purchase 214BS");
                }
            }
            else
            {
                Debug.LogError("[IAP ERROR] Purchases are not initialized 214BS");
            }
        }));
    }
}