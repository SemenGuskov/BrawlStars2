using I2.Loc;
using System.Globalization;
using UnityEngine;
using System.IO.IsolatedStorage;

public class LanguageChecker_214BS : MonoBehaviour
{
    private void Start()
    {
        string systemLanguage_214BS = Application.systemLanguage.ToString();
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        bool isLanguageSupported_214BS = LocalizationManager.HasLanguage(systemLanguage_214BS);
        if (isLanguageSupported_214BS)
        {
            LocalizationManager.CurrentLanguage = systemLanguage_214BS;
        }
        else
            LocalizationManager.CurrentLanguageCode = Application.systemLanguage switch
            {
                SystemLanguage.SerboCroatian when
                    (LocalizationManager.HasLanguage("Croatian_214BS".Replace("_214BS", "")) ||
                     LocalizationManager.HasLanguage("SerboCroatian_214BS".Replace("_214BS", ""))) => "hr_214BS".Replace("_214BS", ""),
                SystemLanguage.Chinese => "zh_214BS".Replace("_214BS", ""),
                SystemLanguage.ChineseSimplified => "zh_214BS".Replace("_214BS", ""),
                SystemLanguage.ChineseTraditional => "zh_214BS".Replace("_214BS", ""),
                _ => "en_214BS".Replace("_214BS", "")
            };

        Debug.Log(
            $"214 BS: Application language: {Application.systemLanguage}; \n I2Language: {LocalizationManager.CurrentLanguage}; \n CultureInfo: {CultureInfo.CurrentUICulture.EnglishName}");
    }
}
