﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class BaseConfiguration {
    
    private BaseConfigurationPage pageField;
    
    private BaseConfigurationPaths pathsField;
    
    private BaseConfigurationApplicationContainer applicationContainerField;
    
    private BaseConfigurationDBConnSource dBConnSourceField;
    
    private BaseConfigurationModuleTemplate moduleTemplateField;
    
    private BaseConfigurationMiniModuleServers miniModuleServersField;
    
    private BaseConfigurationMiniModule[] requiredMiniModulesField;
    
    private BaseConfigurationGIS gISField;
    
    private BaseConfigurationMailServerSettings mailServerSettingsField;
    
    private BaseConfigurationItem[] initital_SettingsField;
    
    private string fileFormat_ReleaseDateField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public BaseConfigurationPage Page {
        get {
            return this.pageField;
        }
        set {
            this.pageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public BaseConfigurationPaths Paths {
        get {
            return this.pathsField;
        }
        set {
            this.pathsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public BaseConfigurationApplicationContainer ApplicationContainer {
        get {
            return this.applicationContainerField;
        }
        set {
            this.applicationContainerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public BaseConfigurationDBConnSource DBConnSource {
        get {
            return this.dBConnSourceField;
        }
        set {
            this.dBConnSourceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public BaseConfigurationModuleTemplate ModuleTemplate {
        get {
            return this.moduleTemplateField;
        }
        set {
            this.moduleTemplateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public BaseConfigurationMiniModuleServers MiniModuleServers {
        get {
            return this.miniModuleServersField;
        }
        set {
            this.miniModuleServersField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("MiniModule", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public BaseConfigurationMiniModule[] RequiredMiniModules {
        get {
            return this.requiredMiniModulesField;
        }
        set {
            this.requiredMiniModulesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public BaseConfigurationGIS GIS {
        get {
            return this.gISField;
        }
        set {
            this.gISField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public BaseConfigurationMailServerSettings MailServerSettings {
        get {
            return this.mailServerSettingsField;
        }
        set {
            this.mailServerSettingsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public BaseConfigurationItem[] Initital_Settings {
        get {
            return this.initital_SettingsField;
        }
        set {
            this.initital_SettingsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FileFormat_ReleaseDate {
        get {
            return this.fileFormat_ReleaseDateField;
        }
        set {
            this.fileFormat_ReleaseDateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class BaseConfigurationPage {
    
    private string titleField;
    
    private string backgroundColorField;
    
    private string debugModeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string BackgroundColor {
        get {
            return this.backgroundColorField;
        }
        set {
            this.backgroundColorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DebugMode {
        get {
            return this.debugModeField;
        }
        set {
            this.debugModeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class BaseConfigurationPaths {
    
    private string applicationRoot_PhysicalField;
    
    private string applicationroot_AppServerSelfReferenceField;
    
    private string webServicesFolder_RelativeToApplicationRootField;
    
    private string ressourcesFolder_RelativeToApplicationRootField;
    
    private string ressourcesFolder_UseWebAccessField;
    
    private string moduleInfoFolder_RelativeToApplicationRootField;
    
    private string moduleInfoFolder_UseWebAccessField;
    
    private string cachingFolder_RelativeToApplicationRootField;
    
    private string enableCachingField;
    
    private string cacheRenewalIntervall_in_MinutesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ApplicationRoot_Physical {
        get {
            return this.applicationRoot_PhysicalField;
        }
        set {
            this.applicationRoot_PhysicalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Applicationroot_AppServerSelfReference {
        get {
            return this.applicationroot_AppServerSelfReferenceField;
        }
        set {
            this.applicationroot_AppServerSelfReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string WebServicesFolder_RelativeToApplicationRoot {
        get {
            return this.webServicesFolder_RelativeToApplicationRootField;
        }
        set {
            this.webServicesFolder_RelativeToApplicationRootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RessourcesFolder_RelativeToApplicationRoot {
        get {
            return this.ressourcesFolder_RelativeToApplicationRootField;
        }
        set {
            this.ressourcesFolder_RelativeToApplicationRootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RessourcesFolder_UseWebAccess {
        get {
            return this.ressourcesFolder_UseWebAccessField;
        }
        set {
            this.ressourcesFolder_UseWebAccessField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ModuleInfoFolder_RelativeToApplicationRoot {
        get {
            return this.moduleInfoFolder_RelativeToApplicationRootField;
        }
        set {
            this.moduleInfoFolder_RelativeToApplicationRootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ModuleInfoFolder_UseWebAccess {
        get {
            return this.moduleInfoFolder_UseWebAccessField;
        }
        set {
            this.moduleInfoFolder_UseWebAccessField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CachingFolder_RelativeToApplicationRoot {
        get {
            return this.cachingFolder_RelativeToApplicationRootField;
        }
        set {
            this.cachingFolder_RelativeToApplicationRootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string EnableCaching {
        get {
            return this.enableCachingField;
        }
        set {
            this.enableCachingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CacheRenewalIntervall_in_Minutes {
        get {
            return this.cacheRenewalIntervall_in_MinutesField;
        }
        set {
            this.cacheRenewalIntervall_in_MinutesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class BaseConfigurationApplicationContainer {
    
    private string flashRecognition_MinimumVersion_MajorField;
    
    private string flashRecognition_MinimumVersion_MinorField;
    
    private string flashRecognition_MinimumVersion_RevisionField;
    
    private string preloader_PathField;
    
    private string preloader_ExeField;
    
    private string preloader_ShowZugSeilLogoField;
    
    private string preloader_BackgroundColorField;
    
    private string mainApp_PathField;
    
    private string mainApp_AppExeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FlashRecognition_MinimumVersion_Major {
        get {
            return this.flashRecognition_MinimumVersion_MajorField;
        }
        set {
            this.flashRecognition_MinimumVersion_MajorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FlashRecognition_MinimumVersion_Minor {
        get {
            return this.flashRecognition_MinimumVersion_MinorField;
        }
        set {
            this.flashRecognition_MinimumVersion_MinorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FlashRecognition_MinimumVersion_Revision {
        get {
            return this.flashRecognition_MinimumVersion_RevisionField;
        }
        set {
            this.flashRecognition_MinimumVersion_RevisionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Preloader_Path {
        get {
            return this.preloader_PathField;
        }
        set {
            this.preloader_PathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Preloader_Exe {
        get {
            return this.preloader_ExeField;
        }
        set {
            this.preloader_ExeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Preloader_ShowZugSeilLogo {
        get {
            return this.preloader_ShowZugSeilLogoField;
        }
        set {
            this.preloader_ShowZugSeilLogoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Preloader_BackgroundColor {
        get {
            return this.preloader_BackgroundColorField;
        }
        set {
            this.preloader_BackgroundColorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MainApp_Path {
        get {
            return this.mainApp_PathField;
        }
        set {
            this.mainApp_PathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MainApp_AppExe {
        get {
            return this.mainApp_AppExeField;
        }
        set {
            this.mainApp_AppExeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class BaseConfigurationDBConnSource {
    
    private string useWebAccessField;
    
    private string nonStdWebLocationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UseWebAccess {
        get {
            return this.useWebAccessField;
        }
        set {
            this.useWebAccessField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NonStdWebLocation {
        get {
            return this.nonStdWebLocationField;
        }
        set {
            this.nonStdWebLocationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class BaseConfigurationModuleTemplate {
    
    private string useTemplateField;
    
    private string checkIntegrityField;
    
    private string sendMailField;
    
    private string writeFileField;
    
    private string updateModuleSettingsField;
    
    private string integrityMailRecipientField;
    
    private string systemMarkerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UseTemplate {
        get {
            return this.useTemplateField;
        }
        set {
            this.useTemplateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CheckIntegrity {
        get {
            return this.checkIntegrityField;
        }
        set {
            this.checkIntegrityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SendMail {
        get {
            return this.sendMailField;
        }
        set {
            this.sendMailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string WriteFile {
        get {
            return this.writeFileField;
        }
        set {
            this.writeFileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UpdateModuleSettings {
        get {
            return this.updateModuleSettingsField;
        }
        set {
            this.updateModuleSettingsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IntegrityMailRecipient {
        get {
            return this.integrityMailRecipientField;
        }
        set {
            this.integrityMailRecipientField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SystemMarker {
        get {
            return this.systemMarkerField;
        }
        set {
            this.systemMarkerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class BaseConfigurationMiniModuleServers {
    
    private BaseConfigurationMiniModuleServersMMServer mMServerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public BaseConfigurationMiniModuleServersMMServer MMServer {
        get {
            return this.mMServerField;
        }
        set {
            this.mMServerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class BaseConfigurationMiniModuleServersMMServer {
    
    private string isActiveField;
    
    private string publiclyreachable_ServerRootField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IsActive {
        get {
            return this.isActiveField;
        }
        set {
            this.isActiveField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Publiclyreachable_ServerRoot {
        get {
            return this.publiclyreachable_ServerRootField;
        }
        set {
            this.publiclyreachable_ServerRootField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class BaseConfigurationMiniModule {
    
    private BaseConfigurationMiniModuleInstances[] instancesField;
    
    private string nameField;
    
    private string commentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Instances", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public BaseConfigurationMiniModuleInstances[] Instances {
        get {
            return this.instancesField;
        }
        set {
            this.instancesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Comment {
        get {
            return this.commentField;
        }
        set {
            this.commentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class BaseConfigurationMiniModuleInstances {
    
    private BaseConfigurationMiniModuleInstancesInstance instanceField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public BaseConfigurationMiniModuleInstancesInstance Instance {
        get {
            return this.instanceField;
        }
        set {
            this.instanceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class BaseConfigurationMiniModuleInstancesInstance {
    
    private string instance_AliasField;
    
    private string instance_VersionField;
    
    private string directLink_PathField;
    
    private string directLink_FileNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Instance_Alias {
        get {
            return this.instance_AliasField;
        }
        set {
            this.instance_AliasField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Instance_Version {
        get {
            return this.instance_VersionField;
        }
        set {
            this.instance_VersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DirectLink_Path {
        get {
            return this.directLink_PathField;
        }
        set {
            this.directLink_PathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DirectLink_FileName {
        get {
            return this.directLink_FileNameField;
        }
        set {
            this.directLink_FileNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class BaseConfigurationGIS {
    
    private string documentRootField;
    
    private string documentRoot_RelativeToApplicationRootField;
    
    private string uploadScript_RelativeToApplicationRootField;
    
    private string downloadScript_RelativeToApplicationRootField;
    
    private string maxGISItemsPerFolderField;
    
    private string userImpersonationField;
    
    private string impersonate_UserNameField;
    
    private string impersonate_PasswordField;
    
    private string impersonate_DomainField;
    
    private string relayModeField;
    
    private string relay_MasterGISServer_DocumentRootField;
    
    private string relay_MasterGISServer_UploadScriptField;
    
    private string relay_MasterGISServer_DownloadScriptField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DocumentRoot {
        get {
            return this.documentRootField;
        }
        set {
            this.documentRootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DocumentRoot_RelativeToApplicationRoot {
        get {
            return this.documentRoot_RelativeToApplicationRootField;
        }
        set {
            this.documentRoot_RelativeToApplicationRootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UploadScript_RelativeToApplicationRoot {
        get {
            return this.uploadScript_RelativeToApplicationRootField;
        }
        set {
            this.uploadScript_RelativeToApplicationRootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DownloadScript_RelativeToApplicationRoot {
        get {
            return this.downloadScript_RelativeToApplicationRootField;
        }
        set {
            this.downloadScript_RelativeToApplicationRootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MaxGISItemsPerFolder {
        get {
            return this.maxGISItemsPerFolderField;
        }
        set {
            this.maxGISItemsPerFolderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UserImpersonation {
        get {
            return this.userImpersonationField;
        }
        set {
            this.userImpersonationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Impersonate_UserName {
        get {
            return this.impersonate_UserNameField;
        }
        set {
            this.impersonate_UserNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Impersonate_Password {
        get {
            return this.impersonate_PasswordField;
        }
        set {
            this.impersonate_PasswordField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Impersonate_Domain {
        get {
            return this.impersonate_DomainField;
        }
        set {
            this.impersonate_DomainField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RelayMode {
        get {
            return this.relayModeField;
        }
        set {
            this.relayModeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Relay_MasterGISServer_DocumentRoot {
        get {
            return this.relay_MasterGISServer_DocumentRootField;
        }
        set {
            this.relay_MasterGISServer_DocumentRootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Relay_MasterGISServer_UploadScript {
        get {
            return this.relay_MasterGISServer_UploadScriptField;
        }
        set {
            this.relay_MasterGISServer_UploadScriptField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Relay_MasterGISServer_DownloadScript {
        get {
            return this.relay_MasterGISServer_DownloadScriptField;
        }
        set {
            this.relay_MasterGISServer_DownloadScriptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class BaseConfigurationMailServerSettings {
    
    private string ipField;
    
    private string portField;
    
    private string useSMTPAuthField;
    
    private string sMTP_UsernameField;
    
    private string sMTP_PasswordField;
    
    private string defaultSenderField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IP {
        get {
            return this.ipField;
        }
        set {
            this.ipField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Port {
        get {
            return this.portField;
        }
        set {
            this.portField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UseSMTPAuth {
        get {
            return this.useSMTPAuthField;
        }
        set {
            this.useSMTPAuthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SMTP_Username {
        get {
            return this.sMTP_UsernameField;
        }
        set {
            this.sMTP_UsernameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SMTP_Password {
        get {
            return this.sMTP_PasswordField;
        }
        set {
            this.sMTP_PasswordField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DefaultSender {
        get {
            return this.defaultSenderField;
        }
        set {
            this.defaultSenderField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class BaseConfigurationItem {
    
    private string valueField;
    
    private string isActiveField;
    
    private string typeField;
    
    private string varNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IsActive {
        get {
            return this.isActiveField;
        }
        set {
            this.isActiveField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string VarName {
        get {
            return this.varNameField;
        }
        set {
            this.varNameField = value;
        }
    }
}
