#if UNITY_IOS
using System.IO;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;


    public static class FrameworkAdderPostProcessingBuild
    {
        [PostProcessBuild]
        public static void AddFrameworksToXcode(BuildTarget buildTarget, string pathToProject)
        {
            if(buildTarget != BuildTarget.iOS) return;

            PBXProject project = new PBXProject();
            string sPath = PBXProject.GetPBXProjectPath(pathToProject);
            project.ReadFromFile(sPath);
            string frameworkTargetGuid = project.GetUnityFrameworkTargetGuid();
            
            //In this place you can write all frameworks which you want to add in the UnityFrameworks
            project.AddFrameworkToProject(frameworkTargetGuid, "AdSupport.framework", false);
            project.AddFrameworkToProject(frameworkTargetGuid, "iAd.framework", false);
            project.AddFrameworkToProject(frameworkTargetGuid, "AdServices.framework", false);
            project.AddFrameworkToProject(frameworkTargetGuid, "StoreKit.framework", false);
            project.AddFrameworkToProject(frameworkTargetGuid, "WebKit.framework", false);
            project.AddFrameworkToProject(frameworkTargetGuid, "AppTrackingTransparency.framework", false);
            project.SetBuildProperty(frameworkTargetGuid, "ENABLE_BITCODE", "false");

            string target = project.GetUnityMainTargetGuid();
            project.SetBuildProperty(target, "ENABLE_BITCODE", "false");

            File.WriteAllText(sPath, project.WriteToString());
        }
    }

#endif
